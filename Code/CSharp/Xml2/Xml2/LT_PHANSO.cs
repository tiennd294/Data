using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Xml2
{
    class LT_PHANSO
    {
        public int tuso;

        public int mauso;
        public LT_PHANSO(string strFilename)
        {
            //
            // TODO: Add constructor logic here
            //
            XmlDocument doc = LT_XML.DocTaiLieu(strFilename);
            if (doc == null)
            {
                tuso = 0; mauso = 0; return;
            }

            XmlElement ele = doc.DocumentElement;
            tuso = int.Parse(ele.SelectSingleNode("Tu_so").InnerText);
            mauso = int.Parse(ele.SelectSingleNode("Mau_so").InnerText);
        }

        public void GhiPhanSo(string strFilename)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("PHANSO");
            doc.AppendChild(root); 
            XmlElement ele_Tuso = root.OwnerDocument.CreateElement("Tu_so"); 
            ele_Tuso.InnerText = this.tuso.ToString(); 
            root.AppendChild(ele_Tuso);
            XmlElement ele_Mauso =root.OwnerDocument.CreateElement("Mau_so");
            ele_Mauso.InnerText = this.mauso.ToString();
            root.AppendChild(ele_Mauso);

            LT_XML.GhiTaiLieu(strFilename, doc);
        }


    }
}
