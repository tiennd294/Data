using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using PhanSo.DTO;
using System.Xml.XPath;
using System.Xml.Linq;
using System.IO;

namespace PhanSo.DataAccess
{
    class PhanSoDAO
    {

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

        //public PhanSoDTO docdulieu(string strpath)
        //{
        //    PhanSoDTO Phanso = new PhanSoDTO();
        //    XDocument doc = LoadXmlDocument(strpath);
        //    foreach (XElement p in doc.Descendants("PhanSo"))
        //    {
        //        if (doc != null)
        //        {
        //            int Tuso = int.Parse(p.Attribute("TuSo").ToString());
        //            int Mauso = int.Parse(p.Element("MauSo").Value.ToString());
        //            Phanso.Tuso = Tuso;
        //            Phanso.Mauso = Mauso;
        //        }
        //        return Phanso;
        //    }
            
            
        //}

        public void Ghidulieu(PhanSoDTO phanso, string strpath)
        {
            XDocument doc = LoadXmlDocument(strpath);
            doc.Element("PhanSos").Add(new XElement("PhanSo", new XAttribute("TuSo", phanso.Tuso.ToString()),
                                                              new XElement("MauSo",phanso.Mauso.ToString())));
            doc.Save(strpath);
            
        }
    }
}

// public void loadcombo()
//        {
//            try
//            {
//                XDocument doc = LoadXmlDocument("data.xml");
//                DataTable dtb = new DataTable();
//                comboBox1.Items.Clear();
//                dtb.Columns.Add("Thành Phố");

//                foreach (XElement p in doc.Descendants("Picture"))
//                {
//                    comboBox1.Items.Add(p.Attribute("id").Value.ToString());
//                    comboBox1.Text = p.Attribute("id").Value.ToString();
//                }
//            }
//            catch { }
//        }

// XDocument xmlDoc = XDocument.Load("data.xml");

//                xmlDoc.Element("Pictures").Add(new XElement("Picture", new XAttribute("id", textBox1.Text), 
//                    new XElement("Name", Convert.ToBase64String((byte[])convert.ConvertTo(bmp, typeof(byte[]))))));



//                xmlDoc.Save("data.xml");

//XDocument xmldoc = XDocument.Load("data.xml");
//                xmldoc.XPathSelectElement("//Picture[@id='" + comboBox1.Text + "']").Remove();
//                xmldoc.Save("data.xml");
//                loadcombo();
//                loadimage();
//                MessageBox.Show("Delete Thanh Cong");
