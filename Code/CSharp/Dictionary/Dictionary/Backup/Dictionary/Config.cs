using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SpeechLib;
using System.Xml;
using System.Collections;
using System.IO;
using System.Globalization;
namespace Dictionary
{
    public partial class Config : Form
    {
        private int i;
        XmlDocument OldSource = new XmlDocument();
        public Config()
        {
            InitializeComponent();
        }
        public delegate void Getvalue(int a);
        public delegate void Getcolor(Color b);
        public Getcolor getcolor;
        public Getcolor getcolor1;
        public Getvalue getvalue;
        private void Config_Load(object sender, EventArgs e)
        {
            SpVoice voice = new SpVoice();
            foreach (ISpeechObjectToken t in voice.GetVoices("", ""))
            {
                listbox_sound.Items.Add(t.GetAttribute("Name"));
            }
            Colorsp.BackColor = colorDialog1.Color;
            Colortxt.BackColor = colorDialog2.Color;

        }

        private void listbox_sound_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = listbox_sound.SelectedIndex;        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (getvalue != null)
            {
                getvalue(i);
            }
            if (getcolor != null)
            {
                getcolor(colorDialog1.Color);
            }
            if(getcolor1 != null)
            {
                getcolor1(colorDialog2.Color);
            }
            this.Close();
        }
        private XmlNode Search_Node(String word)
        {
            String SearchString = "/Dictionary/Word[English=" + '"' + word.ToString() + '"' + ']';
            XmlNodeList List_word = OldSource.SelectNodes(SearchString);
            if (List_word.Count >= 1)
                return List_word[0];
            else
                return null;
        }
        private void Repairdatabase_Click(object sender, EventArgs e)
        {
            String filename = Application.StartupPath + "\\source.xml";
            XmlDocument Source = new XmlDocument();
            OldSource.Load(filename);
            Source.Load(filename);
            XmlNodeList List = Source.GetElementsByTagName("English");
            progressBar1.Maximum = List.Count * 2;
            progressBar1.Visible = true;
            progressBar1.Step = 1;
            progressBar1.Minimum = 0;
            String[] Words = new string[List.Count];
            int i=0;
            foreach(XmlNode Node in List)
            {
                Words[i] = Node.InnerText;
                i++;
                progressBar1.PerformStep();
            }
            IComparer ss = new SoSanh(CultureInfo.GetCultureInfo("vi-Vn").CompareInfo);
            Array.Sort(Words, ss);
            string Oldchar ="'";
            string filepath = Application.StartupPath + "\\leftmid.txt";
            FileStream fs = new FileStream(filepath,FileMode.Create);
            StreamWriter w = new StreamWriter(fs,Encoding.UTF8);
            w.Write("0 ");
            i = 0;
            foreach(XmlNode node in List)
            {
                node.InnerText = Words[i].ToString();
                if (Words[i].Substring(0, 1) != Oldchar)
                {
                    w.Write(i.ToString() + " ");
                    Oldchar = Words[i].Substring(0, 1);
                }
                i++;
                progressBar1.PerformStep();
            }
                        
            w.Write(i.ToString() + " ");
            w.Close();
            fs.Close();
            Source.Save(filename);
            progressBar1.Visible = false;
            MessageBox.Show("Đã repair file source.xml");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Colorsp.BackColor = colorDialog1.Color;
           
        }

        private void Colortxt_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            Colortxt.BackColor = colorDialog2.Color;
        }
    }
}