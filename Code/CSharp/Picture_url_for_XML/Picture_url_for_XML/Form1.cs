using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Windows.Forms;
using System.IO;

namespace Picture_url_for_XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument doc = new XmlDocument();
        string filename;
        string filename2;
        private XDocument LoadXmlDocument(string url)
        {
            //Hầm load một file xml vào đối tượng XDocument
            try
            {
                return XDocument.Load(url);
            }
            catch
            {
                return null;
            }
        }

        public void loadcombo()
        {
            try
            {
                XDocument doc = LoadXmlDocument("data.xml");
                DataTable dtb = new DataTable();
                comboBox1.Items.Clear();
                //dtb.Columns.Add("Thành Phố");

                foreach (XElement p in doc.Descendants("Picture"))
                {
                    comboBox1.Items.Add(p.Attribute("id").Value.ToString());
                    comboBox1.Text = p.Attribute("id").Value.ToString();
                }
            }
            catch { }
        }
        public void loadimage()
        {
            try
            {
                XDocument xmlDoc = XDocument.Load("data.xml");
                //string str= xmlDoc.XPathSelectElement("//Picture[@id='" + comboBox1.Text + "']/Name").Value;
                foreach (XElement p in xmlDoc.Descendants("Picture"))
                {
                    if (p.Attribute("id").Value == comboBox1.Text)
                    {
                        string val = p.Element("Name").Value;

                        byte[] bytes = Convert.FromBase64String(val);
                        MemoryStream mem = new MemoryStream(bytes);
                        Bitmap bmp2 = new Bitmap(mem);
                        MemoryStream memoryStream = new MemoryStream();
                        bmp2.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        //MemoryStream ms = new MemoryStream();
                        //bmp2.Save(ms, ImageFormat.Bmp);
                        //pictureBox1.Image = (System.Drawing.Image)bmp2;
                        //this.pictureBox2.Image = Image.FromStream(stream);

                        //objBitmap.Dispose();

                        pictureBox1.Image = Image.FromStream(memoryStream);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi roi"+ex);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            loadcombo();
            loadimage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "All File (*.*)|*.*|JPG Files(*.JPG)|*.JPG | GIF Files(*.GIF)|*.GIF";
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    pictureBox1.ImageLocation = dlg.FileName;
                    filename = dlg.FileName;
                    textBox1.Text = filename.Split('\\').Last();
                    filename2 = textBox1.Text;
                    
                    
                }
                dlg.Dispose();
                
            }
            catch { MessageBox.Show("loi roi"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //File.Delete(textBox1.Text);
            //File.Create("D:\\fdsfsdfsdf.txt");
            //File.Copy(filename,fbPath,true);
            try
            {
                //string fbPath = Application.StartupPath + "\\" + filename2;
                
                
                Bitmap bmp = new Bitmap(filename);
                TypeConverter convert = TypeDescriptor.GetConverter(typeof(Bitmap));
                
                //XElement img = new XElement("Name",Convert.ToBase64String((byte[])convert.ConvertTo(bmp, typeof(byte[]))));
                
                XDocument xmlDoc = XDocument.Load("data.xml");
                //MessageBox.Show(Convert.ToBase64String((byte[])convert.ConvertTo(bmp, typeof(byte[]))));
                xmlDoc.Element("Pictures").Add(new XElement("Picture", new XAttribute("id", textBox1.Text), 
                    new XElement("Name", Convert.ToBase64String((byte[])convert.ConvertTo(bmp, typeof(byte[]))))));



                xmlDoc.Save("data.xml");
                //comboBox1.Items.Clear();
                loadcombo();
                loadimage();
                MessageBox.Show("Save!");
            }
            catch(Exception ex) 
            { MessageBox.Show("loi roi"+ex); }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadimage();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                XDocument xmldoc = XDocument.Load("data.xml");
                xmldoc.XPathSelectElement("//Picture[@id='" + comboBox1.Text + "']").Remove();
                xmldoc.Save("data.xml");
                loadcombo();
                loadimage();
                MessageBox.Show("Delete Thanh Cong");
            }
            catch { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadimage();
        }
    }
}
