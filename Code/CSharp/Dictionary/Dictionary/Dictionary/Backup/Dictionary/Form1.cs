using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using SpeechLib;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Collections;
using System.IO;
namespace Dictionary
{
    
    public partial class Form1 : Form
    {
        string filename = Application.StartupPath + "\\source.xml";
        string fs = Application.StartupPath + "\\leftmid.txt";
        private string alphabet = "'-abcdefghijklmnopqrstuvwxyz";
        int[] postion = new int[29];
        XmlDocument Source = new XmlDocument();
        ArrayList English = new ArrayList();
        bool Insert_Click = false;
        bool Edit_Clk = false;
        bool Delete_Clk = false;
        Color Specialword = Color.Red;
        Color Colortxt = Color.Black;
        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);
        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);
        CompareInfo ci = CultureInfo.GetCultureInfo("vi-Vn").CompareInfo;
        public SpVoice voice = new SpVoice();
        int ScrollOld = 0;
        int len = 30;
        int max = 0;
        int left, mid, right;
        public Form1()
        {
            InitializeComponent();
            // By the default set the volume to 0   
            uint CurrVol = 0;
            // At this point, CurrVol gets assigned the volume   
            waveOutGetVolume(IntPtr.Zero, out CurrVol);
            // Calculate the volume   
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            // Get the volume on a scale of 1 to 10 (to fit the trackbar)   
            trackWave.Value = CalcVol / (ushort.MaxValue / 10);   
        }
        private void Loadpostion()
        {
            FileStream fst = new FileStream(fs, FileMode.Open);
            StreamReader r = new StreamReader(fst, Encoding.UTF8);
            string temp = r.ReadToEnd();
            int i=0;
            foreach (string pos in temp.Split(' '))
            {
                postion[i] = Convert.ToInt32(pos);
                i++;
            }
            r.Close();
            fst.Close();
        }
        private int Postion1(string word)
        {
            if(word =="") return 0;
            string temp = word.Substring(0, 1).ToUpper();
            char c = Convert.ToChar(temp);
            if(temp == "'") return 0;
            if (temp == "-") return 1;
                return (int)c - 63;
        }
        private void Loaddata()
        {
            try
            {
                Source.Load(filename);
                int i = 0;
                XmlNodeList List_word = Source.GetElementsByTagName("English");
                max = List_word.Count;
                foreach (XmlNode word in List_word)
                {
                    English.Add(word.InnerText);
                    //progressBar1.PerformStep();
                    i++;
                }
                len = (List_english.Height - 4) / List_english.ItemHeight;
                vScrollBar1.Minimum = 1;
                vScrollBar1.Maximum = i-len;
                vScrollBar1.Value = 1;
                for (i = 0; i < len; i++)
                {
                    List_english.Items.Add(English[i]);
                }
                Loadpostion();
            }
            catch (Exception err)
            {
                Error.Text = err.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
          
        }
        
        private int Compare(string word)
        {
            left = postion[Postion1(word)]; right = postion[Postion1(word) + 1];
            //int mid;
            int temp;
            do
            {
                mid = (left + right) / 2;
                string word2 = English[mid].ToString();
                temp = ci.Compare(word,word2,CompareOptions.StringSort);
                if (temp == 0)
                    return mid;
                if (temp > 0)
                    left = mid + 1;
                else
                    right = mid - 1;
              } while (left <= right);
              
            return -1;
              
          
        }

        /*private int Compare_Startwith(string word)
        {
            left = postion[Postion1(word)]; right = postion[Postion1(word) + 1];
            //int mid;
            int temp;
            do
            {
                mid = (left + right) / 2;
                string word2 = English[mid].ToString();
                temp = ci.Compare(word, word2, CompareOptions.StringSort);
                if (temp == 0 || word2.StartsWith(word))
                    return mid;
                if (temp > 0 || word2.StartsWith("'") || word2.StartsWith("-"))
                    left = mid + 1;
                 else
                    right = mid - 1;
              } while (left <= right);
              return -1;
        }*/
        private void Search_Mean(String word)
        {
            if (!Insert_Click && !Edit_Clk &&!Delete_Clk)
            {
                word = word.ToLower();
                XmlNode Node = Search_Node(word);
                string[] Special_word ={ "Danh từ", "Noun", "Tính từ", "Adj", "Adjective", "Trạng từ", "Adv", "Adverb", "Mạo từ", "Thán từ", "Article", "Interjection", "Giới từ", "Pre", "Preposition" };
                if (Node != null)
                {
                    foreach (XmlElement Element in Node)
                    {
                        switch(Element.LocalName)
                        {
                            case "Phonetic":
                                txt_Phonetic.Text = Element.InnerText;
                                break;
                            case "Vietnamese":
                                Vietnamese_text.Clear();
                                Vietnamese_text.SelectionColor = Colortxt;
                                Vietnamese_text.Text = Element.InnerText;
                                break;
                        }
                    }
                    foreach (string temp in Special_word)
                    {
                        int t = Vietnamese_text.Text.IndexOf(temp);
                        if (t != -1)
                        {
                            Vietnamese_text.Select(t, temp.Length);
                            Vietnamese_text.SelectionColor = Specialword;
                        }
                       
                    }
                }

            }

        }

        private void Editword(string word)
        {
            Search_box.Items.Clear();
            List_editword.Items.Clear();
            int cout = 0;
            // Deletion
            for (int i = 0; i != word.Length; i++)
            {
                string temp = word.Substring(0, i) + word.Substring(i + 1);
                if (Compare(temp) != -1 && !List_editword.Items.Contains(temp) && cout < 4) 
                { 
                    
                    List_editword.Items.Add(temp);
                    cout++;
                }
            }
            // Transposition
            if (word.Length == 2)
            {
                string temp = word.Substring(1, 1) + word.Substring(0, 1);
                if (Compare(temp) != -1 && !List_editword.Items.Contains(temp) && cout < 8)
                {
                    
                    List_editword.Items.Add(temp);
                    cout++;
                }
            }
            else
            {
                for (int i = 0; i < word.Length - 1; i++)
                {
                    string temp = word.Substring(0, i) + word.Substring(i + 1, 1) + word.Substring(i, 1) + word.Substring(i + 2);
                    if (Compare(temp) != -1 && !List_editword.Items.Contains(temp) && cout < 8)
                    {
                        List_editword.Items.Add(temp);
                        cout++;
                    }
                }
            }
            // Alteration
            for (int i = 0; i != word.Length; i++)
            {
                foreach (char c in alphabet)
                {
                    string temp = word.Substring(0, i) + c.ToString() +word.Substring(i + 1);
                    if (Compare(temp) != -1 && cout < 12 && !List_editword.Items.Contains(temp)) 
                    { 
                        
                        List_editword.Items.Add(temp);
                        cout++;
                    }
                }
            }
            // Insertion
            for (int i = 0; i != word.Length + 1; i++)
            {
                foreach (char c in alphabet)
                {
                    string temp = word.Substring(0, i) + c.ToString() +word.Substring(i);
                    if (Compare(temp) != -1 && !List_editword.Items.Contains(temp) && cout < 16) 
                    { 
                        
                        List_editword.Items.Add(temp);
                        cout++;
                    }
                }
            }
      
        }
        private void Listdown()
        {
            Search_box.DroppedDown = true;
        }
        private void Search_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                int t = Compare(Search_box.Text);
                if (t == -1)
                {
                    Editword(Search_box.Text);
                    if (List_editword.Items.Count >= 1)
                    {
                        List_editword.SelectedItem = List_editword.Items[0];
                        List_editword.Visible = true;
                        Hide_listbox.Visible = true;
                        List_editword.Focus();
                    }
                }
               // else
                //{
                  //  List_english.SelectedItem = List_english.Items[t];
                //}


            }
            //else
            //{
              //  int t = Compare_Startwith(Search_box.Text);
                //if (t != -1)
                  //  List_english.SelectedItem = List_english.Items[t];
            //}
        }

       

        private void Search_box_TextChanged(object sender, EventArgs e)
        {
            int t = Compare(Search_box.Text);
            if (t != -1)
            {
                Search_box.BackColor = Color.White;
                if (t - vScrollBar1.Value < len && t > vScrollBar1.Value)
                {
                    List_english.SelectedItem = List_english.Items[t - vScrollBar1.Value];
                }
                else
                {
                    vScrollBar1.Value = t;
                    List_english.SelectedItem = List_english.Items[0];
                }
            }
            else
            {
                t = left;
                if(!English[t].ToString().StartsWith(Search_box.Text))
                    Search_box.BackColor = Color.Orange;
                else
                    Search_box.BackColor = Color.White;
                if (t != -1)
                {
                    if (t - vScrollBar1.Value < len && t > vScrollBar1.Value)
                    {
                        List_english.SelectedItem = List_english.Items[t - vScrollBar1.Value];
                    }
                    else
                    {
                        vScrollBar1.Value = t;
                        List_english.SelectedItem = List_english.Items[0];
                    }
                }
            }
            
        }

        private void Add_Click(object sender, EventArgs e)
        {
            lb_AddEdit.Text = "Thêm Từ";
            panel1.Visible = true;
            panel1.Enabled = true;
            Insert_Click = true;
        }

        private void List_editword_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search_box.Text = List_editword.SelectedItem.ToString();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            List_editword.Visible = false;
            Hide_listbox.Visible = false;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Edit_Clk = false;
            Insert_Click = false;
            lb_AddEdit.Text = "Tra Từ";
            
        }
        private void Updatepostion()
        {
            FileStream fst = new FileStream(fs, FileMode.Create);
            StreamWriter w = new StreamWriter(fst, Encoding.UTF8);
            for (int i = 0; i < 29; i++)
            {
                w.Write(postion[i].ToString() + " ");
            }
            w.Close();
            fst.Close();
        }
        private void Button_Update_Click(object sender, EventArgs e)
        {
            if (Insert_Click)
            {
                int temp = Compare(txt_English.Text);
                if (temp == -1)
                {
                    XmlNodeList root = Source.GetElementsByTagName("Dictionary");
                    XmlElement newElement;
                    newElement = Source.CreateElement("Word");
                    XmlElement Element = Source.CreateElement("English");
                    Element.InnerText = txt_English.Text;
                    newElement.AppendChild(Element);
                    Element = Source.CreateElement("Phonetic");
                    Element.InnerText = Phonetic.Text;
                    newElement.AppendChild(Element);
                    Element = Source.CreateElement("Vietnamese");
                    Element.InnerText = Vietnamese.Text;
                    newElement.AppendChild(Element);
                    XmlNode Node = Search_Node(English[left].ToString());
                    int i = ci.Compare(txt_English.Text.ToString(), English[left].ToString());
                    if (i == 1)
                    {
                        root[0].InsertAfter(newElement, Node);
                        English.Insert(left+1, txt_English.Text);
                    }
                    if (i == -1)
                    {
                        root[0].InsertBefore(newElement, Node);
                        English.Insert(left, txt_English.Text);
                    }
                    Source.Save(filename);
                    for (i = Postion1(txt_English.Text)+1; i < 29; i++)
                    {
                        postion[i] = postion[i] + 1;
                    }
                    Updatepostion();
                    if (vScrollBar1.Value < vScrollBar1.Maximum)
                        vScrollBar1.Value = vScrollBar1.Value + 1;
                    else
                        vScrollBar1.Value = vScrollBar1.Value - 1;
                    txt_English.Text = "";
                    Phonetic.Text = "";
                    Vietnamese.Text = "";
                   
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Từ thêm vào đã có trong từ điển, bạn có muốn chuyển sang edit ?", "Trùng từ", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        Insert_Click = false;
                        List_english.SelectedItem = List_english.Items[temp];
                        Edit_Click(null, null);

                    }
                    else
                    {
                        Vietnamese.Text = "";
                        txt_English.Text = "";
                        Phonetic.Text = "";
                    }
                }


            }
            else
            {
                int temp = Compare(txt_English.Text);
                if (temp != -1)
                {
                    XmlNode Node = Search_Node(txt_English.Text);
                    foreach (XmlElement Element in Node)
                    {
                        switch (Element.LocalName)
                        {
                            case "Phonetic":
                                Element.InnerText = Phonetic.Text;
                                break;
                            case "Vietnamese":
                                Element.InnerText = Vietnamese.Text;
                                break;
                        }
                    }
                    Source.Save(filename);
                }
                else
                {
                    DialogResult rs = MessageBox.Show("Từ này không có trong từ điển, Bạn có muốn chuyển qua chế độ ADD", "Lỗi", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        Add_Click(null, null);
                    }
                    else
                    {
                        Edit_Clk = false;
                        panel1.Visible = false;
                    }
                }
            }

        }
        private XmlNode Search_Node(String word)
        {
            String SearchString = "/Dictionary/Word[English=" + '"' + word.ToString() + '"' + ']';
            XmlNodeList List_word = Source.SelectNodes(SearchString);
            if(List_word.Count >= 1) 
                return List_word[0];
            else
                return null;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            lb_AddEdit.Text = "Sửa Từ";
            panel1.Visible = true;
            if (List_english.SelectedItem != null)
            {
                String word = List_english.SelectedItem.ToString();
                Edit_Clk = true;
                panel1.Enabled = true;

                txt_English.Text = word.ToString();
                XmlNode Node = Search_Node(word);
                if (Node != null)
                {
                    foreach (XmlElement Element in Node)
                    {
                        if (Element.LocalName == "Phonetic")
                            Phonetic.Text = Element.InnerText;
                        if (Element.LocalName == "Vietnamese")
                            Vietnamese.Text = Element.InnerText;
                    }
                }
            }
            else
            {
                DialogResult rs = MessageBox.Show("Từ rổng bạn nên chuyển qua chế độ thêm từ", "Lỗi", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    Add_Click(null, null);
                }
                else
                {
                    panel1.Visible = false;
                    lb_AddEdit.Text ="Tra Từ";
                    Edit_Clk = false;
                }
            }
        
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (List_english.SelectedItem != null)
            {
                Delete_Clk = true;
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa từ " + List_english.SelectedItem.ToString(), "Xóa", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    String word = List_english.SelectedItem.ToString();
                    int t=Compare(word);
                    XmlNode Node = Search_Node(word);
                    Source.DocumentElement.RemoveChild(Node);
                    Source.Save(filename);
                    English.RemoveAt(t);
                    if (vScrollBar1.Value < vScrollBar1.Maximum)
                        vScrollBar1.Value = vScrollBar1.Value + 1;
                    else
                        vScrollBar1.Value = vScrollBar1.Value - 1;
                    for (int i = Postion1(word) + 1; i < 29; i++)
                    {
                        postion[i] = postion[i] - 1;
                    }
                    Updatepostion();
                }
            }
            Delete_Clk = false;
            
        }

        private void Sound_Click(object sender, EventArgs e)
        {
            voice.Speak(Search_box.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }

        private void List_english_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (List_english.SelectedItem != null)
            {
                //Search_box.Text = List_english.SelectedItem.ToString();
                Search_Mean(Search_box.Text);
            }
        }

        private void List_editword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                List_editword.Visible = false;
                Hide_listbox.Visible = false;
            }
        }

        private void List_english_Click(object sender, EventArgs e)
        {
            List_editword.Visible = false;
            Hide_listbox.Visible = false;
            if (List_english.SelectedItem != null)
                Search_box.Text = List_english.SelectedItem.ToString();
        }

        private void trackWave_Scroll(object sender, EventArgs e)
        {
            // Calculate the volume that's being set   
            int NewVolume = ((ushort.MaxValue / 10) * trackWave.Value);
            // Set the same volume for both the left and the right channels   
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            // Set the volume   
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels); 
        }

        private void Hide_listbox_Click(object sender, EventArgs e)
        {
            if (List_editword.Visible == true)
                List_editword.Visible = false;
            else
                List_editword.Visible = true;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void hiddenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AboutBox1 About = new AboutBox1();
            About.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loaddata();
            panel2.Visible = false;
        }

        private void List_editword_DoubleClick(object sender, EventArgs e)
        {
            List_editword.Visible = false;
            Hide_listbox.Visible = false;
        }
        private void Loadword(int Start, int len)
        {
        
            for (int i = 0; i < len; i++)
            {
                List_english.Items[i] = English[Start];
                Start++;
                if (Start > max) break;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ScrollOld != vScrollBar1.Value)
            {
                Loadword(vScrollBar1.Value, len);
            }
            ScrollOld = vScrollBar1.Value;
        }
        public void Getindexsound(int t)
        {
            voice.Voice = voice.GetVoices("", "").Item(t);
        }
        private void Getcolor_rtb(Color b)
        {
            Specialword = b;
        }
        private void Getcolor_txt(Color b)
        {
            Colortxt = b;
        }
        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config formconfig = new Config();
            formconfig.getvalue = new Config.Getvalue(Getindexsound);
            formconfig.getcolor = new Config.Getcolor(Getcolor_rtb);
            formconfig.getcolor1 = new Config.Getcolor(Getcolor_txt);
            formconfig.Show();
        }

        private void List_english_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Down")
            {
                if (vScrollBar1.Value < vScrollBar1.Maximum - 1 && List_english.SelectedIndex == len-1)
                    vScrollBar1.Value = vScrollBar1.Value + 1;
            }
            if (e.KeyCode.ToString() == "Up" && List_english.SelectedIndex == 0)
            {
                if (vScrollBar1.Value >=1)
                    vScrollBar1.Value = vScrollBar1.Value - 1;
            }
            if (e.KeyCode.ToString() == "Return")
            {
                Search_box.Text = List_english.SelectedItem.ToString();
            }
        }

       

    }
   
}