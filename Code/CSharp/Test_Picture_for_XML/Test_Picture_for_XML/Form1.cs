using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace BMP2XML
{
    public partial class Form1 : Form
    {
        Dictionary<string, Bitmap> bmpList = new Dictionary<string, Bitmap>();

        public Form1()
        {
            InitializeComponent();
        }

        private void mnuLoadBMPFiles_Click(object sender, EventArgs e)
        {
            dlgFileOpen.FileName = "";
            dlgFileOpen.FilterIndex = 1; // *.bmp files
            dlgFileSave.DefaultExt = "bmp";
            if (dlgFileOpen.ShowDialog() == DialogResult.OK)
            {
                bmpList.Clear();
                lstImages.Items.Clear();
                int n = 1;
                foreach (string fn in dlgFileOpen.FileNames)
                {
                    Bitmap bmp = new Bitmap(fn);
                    string bmpName = "BMP_" + n.ToString();
                    bmpList.Add(bmpName,bmp);
                    lstImages.Items.Add(bmpName);
                    n++;
                }
            }
        }

        private void mnuWriteToXML_Click(object sender, EventArgs e)
        {
            dlgFileSave.FileName = "";
            dlgFileSave.FilterIndex = 2; // *.xml files
            dlgFileSave.DefaultExt = "xml";
            if (dlgFileSave.ShowDialog() == DialogResult.OK)
            {
                ExportToXML(bmpList, dlgFileSave.FileName);
            }
        }

        private void mnuLoadFromXML_Click(object sender, EventArgs e)
        {
            dlgFileOpen.FileName = "";
            dlgFileOpen.FilterIndex = 2; // *.xml files
            dlgFileSave.DefaultExt = "xml";
            if (dlgFileOpen.ShowDialog() == DialogResult.OK)
            {
                ImportFromXML(bmpList, dlgFileOpen.FileName);
                lstImages.Items.Clear();
                foreach (string bmpName in bmpList.Keys)
                {
                    lstImages.Items.Add(bmpName);
                }
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bmpName = lstImages.SelectedItem.ToString();
            Bitmap bmp = bmpList[bmpName];
            imgBox.Image = bmp;
            imgBox.Refresh();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            imgBox.Image = null;
            imgBox.Refresh();
            bmpList.Clear();
            lstImages.Items.Clear();
        }

        public void ExportToXML(Dictionary<string, Bitmap> BmpList, string Filename)
        {
            XmlNode node = null;
            XmlNode subnode = null;
            XmlAttribute attr = null;
            XmlDocument doc = new XmlDocument();
            if (System.IO.File.Exists(Filename))
                doc.Load(Filename);
            // Select or create a Graphics root node
            XmlNode root = doc.SelectSingleNode("/Graphics");
            if (root == null)
            {
                root = doc.CreateNode(XmlNodeType.Element, "Graphics", null);
                doc.AppendChild(root);
            }
            // If the Symbols section exists, get rid of it
            node = root.SelectSingleNode("descendant::Symbols");
            if (node != null)
                root.RemoveChild(node);
            // Create a new Symbols section
            node = doc.CreateNode(XmlNodeType.Element, "Symbols", null);
            root.AppendChild(node);
            // Save the pattern info
            foreach (string bmpName in BmpList.Keys)
            {
                Bitmap bmp = BmpList[bmpName];
                subnode = doc.CreateNode(XmlNodeType.Element, "symbol", null);
                attr = doc.CreateAttribute("name");
                attr.Value = bmpName;
                subnode.Attributes.Append(attr);
                byte[] bb = ByteArrayFromBitmap(ref bmp);
                string ss = Convert.ToBase64String(bb); 
                attr = doc.CreateAttribute("bitmap");
                attr.Value = ss;
                subnode.Attributes.Append(attr);
                node.AppendChild(subnode);
            }
            doc.Save(Filename);
        }

        public void ImportFromXML(Dictionary<string, Bitmap> BmpList, string Filename)
        {
            BmpList.Clear();
            XmlNode node = null;
            XmlDocument doc = new XmlDocument();
            doc.Load(Filename);
            XmlNode root = doc.SelectSingleNode("/Graphics");
            if (root == null)
                MessageBox.Show(Filename + " is not an XML Graphics file");
            else
            {
                // Find the "Symbols" section
                node = root.SelectSingleNode("descendant::Symbols");
            }
            if (node != null)
            {
                foreach (XmlNode subnode in node.ChildNodes)
                {
                    if (subnode.Name == "symbol")
                    {
                        Bitmap bmp = null;
                        string bmpName = "";
                        foreach (XmlAttribute attr in subnode.Attributes)
                        {
                            if (attr.Name == "name")
                                bmpName = attr.Value;
                            else if (attr.Name == "bitmap")
                            {
                                string patternStr = attr.Value;
                                // Convert from Hex to binary Bitmap
                                byte[] ba = Convert.FromBase64String(patternStr);
                                bmp = BitmapFromByteArray(ba);
                            }
                        }
                        BmpList.Add(bmpName, bmp);
                    }
                }
            }
        }

        private Bitmap BitmapFromByteArray(byte[] byteArray)
        {
            int n = 0;
            // Get the width
            uint x = (((uint)byteArray[n] * 256 + (uint)byteArray[n + 1]) * 256 + (uint)byteArray[n + 2]) * 256 + (uint)byteArray[n + 3];
            int width = (int)x;
            n += 4;
            // Get the height
            x = (((uint)byteArray[n] * 256 + (uint)byteArray[n + 1]) * 256 + (uint)byteArray[n + 2]) * 256 + (uint)byteArray[n + 3];
            int height = (int)x;
            n += 4;
            // Create the Bitmmap object
            Bitmap bmp = new Bitmap(width, height);
            // The pixels are stored in order by rows
            for (int j = 0; j < height; j++)
            {
                // Read the pixels for each row
                for (int i = 0; i < width; i++)
                {
                    x = (((uint)byteArray[n] * 256 + (uint)byteArray[n + 1]) * 256 + (uint)byteArray[n + 2]) * 256 + (uint)byteArray[n + 3];
                    bmp.SetPixel(i, j, Color.FromArgb((int)x));
                    n += 4;
                }
            }
            return bmp;
        }

        private byte[] ByteArrayFromBitmap(ref Bitmap bitmap)
        {
            // The bitmap contents are coded with Width and Height followed by pixel colors (uint)
            byte[] b = new byte[4 * (bitmap.Height * bitmap.Width + 2)];
            int n = 0;
            // encode the width
            uint x = (uint)bitmap.Width;
            int y = (int)x;
            b[n] = (byte)(x / 0x1000000);
            x = x % (0x1000000);
            n++;
            b[n] = (byte)(x / 0x10000);
            x = x % (0x10000);
            n++;
            b[n] = (byte)(x / 0x100);
            x = x % 0x100;
            n++;
            b[n] = (byte)x;
            n++;
            // encode the height
            x = (uint)bitmap.Height;
            y = (int)x;
            b[n] = (byte)(x / 0x1000000);
            x = x % (0x1000000);
            n++;
            b[n] = (byte)(x / 0x10000);
            x = x % (0x10000);
            n++;
            b[n] = (byte)(x / 0x100);
            x = x % 0x100;
            n++;
            b[n] = (byte)x;
            n++;
            // Loop through each row
            for (int j = 0; j < bitmap.Height; j++)
            {
                // Loop through the pixel on this row
                for (int i = 0; i < bitmap.Width; i++)
                {
                    x = (uint)bitmap.GetPixel(i, j).ToArgb();
                    y = (int)x;
                    b[n] = (byte)(x / 0x1000000);
                    x = x % (0x1000000);
                    n++;
                    b[n] = (byte)(x / 0x10000);
                    x = x % (0x10000);
                    n++;
                    b[n] = (byte)(x / 0x100);
                    x = x % 0x100;
                    n++;
                    b[n] = (byte)x;
                    n++;
                }
            }
            return b;
        }


    }
}
