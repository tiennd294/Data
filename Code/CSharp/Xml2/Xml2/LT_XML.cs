using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Xml2
{
    class LT_XML
    {
        public static XmlDocument DocTaiLieu(string strFilename)
        {
            XmlDocument kq = new XmlDocument();
            try
            {
                kq.Load(strFilename);
            }
            catch
            {
                return null;
            }
            return kq;
        }
        public static void GhiTaiLieu(string strFilename, XmlDocument doc)
 
        {
            try
            {
                doc.Save(strFilename);
            }
            catch{}
        }

    }
}
