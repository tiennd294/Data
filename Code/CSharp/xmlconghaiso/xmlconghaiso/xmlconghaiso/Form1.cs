using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
namespace xmlconghaiso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_cong_Click(object sender, EventArgs e)
        {
            try
            {
                int so1 = Convert.ToInt32(txt_so1.Text.ToString());
                int so2 = Convert.ToInt32(txt_so2.Text.ToString());
                int tong = so1 + so2;
                lb_ketqua.Text = tong.ToString();
                if (!File.Exists("conghaiso.xml"))
                {
                    XmlTextWriter xml = new XmlTextWriter("conghaiso.xml", null);
                    xml.WriteStartDocument();
                    xml.WriteStartElement("Adds");
                    xml.WriteEndDocument();
                    xml.Flush();
                }
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load("conghaiso.xml");
                //XmlElement xe=null;
                //XmlText xt=null;
                XmlElement subcong = xdoc.CreateElement("add");
                // add tong vao la khoa chinh
                XmlAttribute tongxml = xdoc.CreateAttribute("tonghaiso");
                subcong.SetAttributeNode(tongxml);
                tongxml.Value = lb_ketqua.Text.ToString();
                //add so thu 1 vao
                XmlElement xe1 = xdoc.CreateElement("so1");
                XmlText xt1 = xdoc.CreateTextNode(so1.ToString());
                xe1.AppendChild(xt1);
                subcong.AppendChild(xe1);
                //add so thu 2 vao
                XmlElement xe = xdoc.CreateElement("so2");
                XmlText xt = xdoc.CreateTextNode(so2.ToString());
                xe.AppendChild(xt);
                subcong.AppendChild(xe);
                //day tat ca vao file xml va ket thuc
                xdoc.DocumentElement.AppendChild(subcong);
                xdoc.Save("conghaiso.xml");
                MessageBox.Show("Xuat Thanh Cong", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ie)
            {
                MessageBox.Show("Error System " + ie);
            }
        }
    }
}
