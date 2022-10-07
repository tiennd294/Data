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
    public partial class Form1 : Form
    {
        XmlDocument doc = new XmlDocument();
        public Form1()
        {
            InitializeComponent();
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

        private void LoadData()
        {
            try
            {
                
                XDocument xmldoc = XDocument.Load("data.xml");
                var items = (from i in xmldoc.Descendants("Language")
                             select new { English = i.Attribute("English").Value, Vietnamese = i.Element("Vietnamese").Value }).ToList();
                //Administrator
                listBox2.DataSource = items;
                listBox2.DisplayMember = "English";
                listBox1.ValueMember = "Language";
                comboBox2.DataSource = items;
                comboBox2.DisplayMember = "English";
                richTextBox2.DataBindings.Add("text", items, "Vietnamese");
                

            }
            catch { }
        }

        private void LoadData2()
        {
            try
            {

                XDocument xmldoc = XDocument.Load("data.xml");
                var items = (from i in xmldoc.Descendants("Language")
                             select new { English = i.Attribute("English").Value, Vietnamese = i.Element("Vietnamese").Value }).ToList();
                
                //guest
                listBox1.DataSource = items;
                listBox1.DisplayMember = "English";
                listBox1.ValueMember = "Language";
                comboBox1.DataSource = items;
                comboBox1.DisplayMember = "English";
                richTextBox1.DataBindings.Add("text", items, "Vietnamese");

            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadData2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                              
               XDocument xmldoc = XDocument.Load("data.xml");
               richTextBox1.Text =xmldoc.XPathSelectElement("//Language[@English='" + comboBox1.Text + "']").Value;
               
            }
            catch 
            {
                richTextBox1.Text = "chua co trong tu dien";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Text = "Add New";
            frm.ShowDialog();
            LoadData();
            LoadData2();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Text = "Edit";
            frm.ShowDialog();
            LoadData();
            LoadData2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                
                XDocument xmldoc = XDocument.Load("data.xml");
                xmldoc.XPathSelectElement("//Language[@English='" + comboBox2.Text + "']").Remove();
                xmldoc.Save("data.xml");
                LoadData();
                LoadData2();
            }
            catch { }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                XDocument xmldoc = XDocument.Load("data.xml");
                richTextBox2.Text = xmldoc.XPathSelectElement("//Language[@English='" + listBox2.Text + "']").Value;
               
            }
            catch
            {}
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                XDocument xmldoc = XDocument.Load("data.xml");
                richTextBox1.Text = xmldoc.XPathSelectElement("//Language[@English='" + listBox1.Text + "']").Value;

            }
            catch
            { }
        }
    }
}
