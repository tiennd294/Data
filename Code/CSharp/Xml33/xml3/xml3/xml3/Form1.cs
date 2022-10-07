using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Xml.XPath;

namespace xml3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XmlDocument doc = new XmlDocument();
        private XDocument LoadXmlDocument(string url)// doan nay dung de lam j vay? load data vao xdocument a uj ma uj ??
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
            XDocument doc = LoadXmlDocument("conghaiso.xml");
            DataTable dtb = new DataTable();
            dtb.Columns.Add("Tong");
            dtb.Columns.Add("So A");
            dtb.Columns.Add("So B");

            foreach (XElement p in doc.Descendants("add"))// day la j Descendants? cai nay e k hiu nua ok no add data vao datatable roi add 
            {
                DataRow row = dtb.NewRow();
                row[0] = p.Attribute("tonghaiso").Value;
                row[1] = p.Element("so1").Value;
                row[2] = p.Element("so2").Value;
                dtb.Rows.Add(row); 
            }

            dataGridView1.DataSource = dtb;
        }

        private void bt_kq_Click(object sender, EventArgs e)
        {
            try
            {
                int so1 = Convert.ToInt32(txt_so1.Text.ToString());
                int so2 = Convert.ToInt32(txt_so2.Text.ToString());
                int tong = so1 + so2;
                lb_ketqua.Text = tong.ToString();
                #region "xuat xml file"
                if(!File.Exists("conghaiso.xml"))
                {
                    XmlTextWriter xml = new XmlTextWriter("conghaiso.xml", null);
                    xml.WriteStartDocument();
                    xml.WriteStartElement("CongS");
                    xml.WriteEndDocument();
                    xml.Flush();
                }
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load("conghaiso.xml");
                //add khoa chinh vao
                XmlElement subcong = xdoc.CreateElement("add");
                XmlAttribute attri = xdoc.CreateAttribute("tonghaiso");
                subcong.SetAttributeNode(attri);
                attri.Value = tong.ToString();
                //add so thu 1 vao
                XmlElement xe;// e goi soure qua cho a di a sua xong roi a dua e e goi media a nha ok co setup gmail k cho goi a ah
                XmlText xt;
                xe = xdoc.CreateElement("so1");
                xt = xdoc.CreateTextNode(txt_so1.Text.ToString());
                xe.AppendChild(xt);
                subcong.AppendChild(xe);
                //add so thu 2 vao
                xe = xdoc.CreateElement("so2");
                xt = xdoc.CreateTextNode(txt_so2.Text.ToString());
                xe.AppendChild(xt);
                subcong.AppendChild(xe);
                //day vao file xml
                xdoc.DocumentElement.AppendChild(subcong);
                xdoc.Save("conghaiso.xml");
                //MessageBox.Show("Xuat Thanh Cong", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
              #endregion
                LoadData();
            }
            catch (Exception ie)
            {
                MessageBox.Show("Loi " + ie);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                string str = dataGridView1.Rows[r].Cells[0].Value.ToString();
                //MessageBox.Show(str);
                //XmlNode node = doc.SelectSingleNode("//add[@tonghaiso='" + str + "']");

                // XmlNode nodee = doc.SelectSingleNode("//add[@tonghaiso='" + str + "']");//a oi no loi nang lam roi
                //XmlNode nodee = doc.SelectSingleNode("//add[@tonghaiso='" + str + "']");
                //nodee.ParentNode.RemoveChild(nodee);
                /*if (nodee != null)
                {
                    doc.DocumentElement.RemoveChild(nodee);//e coi ng ta lam dc ma doi wa day k tai nao no chay
                    doc.Save("conghaiso.xml");
                }*/
                //nodee.ParentNode.RemoveChild(nodee);

                XDocument xmldoc = XDocument.Load("conghaiso.xml");

                xmldoc.XPathSelectElement("//add[@tonghaiso='" + str + "']").Remove();
                
                xmldoc.Save("conghaiso.xml");



                LoadData();
            }
            catch { }
        }
    }
}
