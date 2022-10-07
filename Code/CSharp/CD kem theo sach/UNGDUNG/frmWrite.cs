using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace UNGDUNG
{
    public partial class frmWrite : Form
    {
        public frmWrite()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileName();
            
        }
        void FileName()
        {
            FolderBrowserDialog od = new FolderBrowserDialog();
            od.RootFolder = Environment.SpecialFolder.DesktopDirectory;
            if (od.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = od.SelectedPath;
            }
        }
        void WriteFile(string fullpath )
        {
            try
            { 

                string path, filename;
                path = fullpath.Substring(0, fullpath.LastIndexOf("\\"));
                filename = fullpath.Substring(fullpath.LastIndexOf("\\"));
                if (Directory.Exists(path) && filename.LastIndexOf(".txt")!=-1)
                {
                    using (StreamWriter sw = new StreamWriter(fullpath))
                    {
                        sw.WriteLine("Written by C# 2005");
                        sw.WriteLine("in " + DateTime.Now.ToLongDateString());
                        sw.WriteLine(richTextBox1.Text);
                        sw.Flush();
                        sw.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
            WriteFile(textBox1.Text);
            MessageBox.Show("Saved");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}