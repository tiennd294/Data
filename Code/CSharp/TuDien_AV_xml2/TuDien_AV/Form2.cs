using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace TuDien_AV
{
    public partial class Form2 : Form 
    {
        

        public Form2()
        {
            InitializeComponent();
        
        }
        //setget
        public TextBox TextBox1_Form2
        {
            get
            {
                return textBox1;
            }
            set
            {
                textBox1 = value;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
             
            textBox2.Focus();
                        
        }
        private XDocument LoadXmlDocument(string url)
        {
            try
            {
                return XDocument.Load(url);
            }
            catch
            {
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" )
                {
                    //Load xml document
                    XDocument doc = LoadXmlDocument("data.xml");
                    if (doc.Descendants("Language").Where(x => x.Attribute("English").Value.Equals(textBox1.Text)).Count() == 1)
                    {
                        //Nếu đã tồn tại sản phẩm có ID này rồi thì thực hiện cập nhật
                        
                        XElement ele = doc.Descendants("Language").Where(x => x.Attribute("English").Value.Equals(textBox1.Text)).First();
                        ele.Element("Vietnamese").Value = textBox2.Text;
                        doc.Save("data.xml");
                        MessageBox.Show("Edit thanh cong");
                        this.Close();
                    }
                    else
                    {
                                                                   
                        XDocument xmlDoc = XDocument.Load("data.xml");

                        xmlDoc.Element("DataAV").Add(new XElement("Language", new XAttribute("English", textBox1.Text),
                                                                               new XElement("Vietnamese", textBox2.Text)));

                        xmlDoc.Save("data.xml");
                        //MessageBox.Show("Add thanh cong");
                        this.Close();
                        
                    }
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
