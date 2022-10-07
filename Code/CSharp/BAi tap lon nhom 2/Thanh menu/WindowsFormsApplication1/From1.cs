using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class frmChildLab32 : Form
    {
        public frmChildLab32()
        {
            InitializeComponent();
        }

        private void Form1_MdiChildActivate(object sender, EventArgs e)
        {

           
        }
        public string Content { get; set; }
        
        private void frmChildLab32_Load(object sender, EventArgs e)
        {
            txtContent.Text = Content;

            stsDate.Text = "Hôm này là ngày " + DateTime.Now.ToString("dd/MM/yyyy");


        }

       


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {


            //tạo mới đối tượng formchild
            frmChildLab32 frmchild = new frmChildLab32();
            //tạo và hiển thị hộp hội thoại open file
            OpenFileDialog dlgopen = new OpenFileDialog();
            dlgopen.Title = "Open files";
            dlgopen.Filter = "Files *.txt|*.txt";
            dlgopen.ShowDialog();
            //nếu file được chọn thì hiển thị nội dung 
            //sang textbox của form child
            if (dlgopen.FileName != "")
            {
                StreamReader sr = File.OpenText(dlgopen.FileName);
                frmchild.Content = sr.ReadToEnd();
                sr.Close();
                frmchild.MdiParent = this;
                frmchild.Show();
            }
            else
            {
                MessageBox.Show("Open fail!", "Open file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
           
        }

        private void savefToolStripMenuItem_Click(object sender, EventArgs e)
        {


            SaveFileDialog dlgsave = new SaveFileDialog();
            dlgsave.Filter = "Files *.txt|*.txt|Files .htm|*.htm|Files *.html|*.html";
            dlgsave.Title = "Save files";
            dlgsave.ShowDialog();
            if (dlgsave.FileName != "")
            {
                StreamWriter sw = File.CreateText(dlgsave.FileName);
                sw.Write(txtContent.Text);
                sw.Close();
                MessageBox.Show("Save success!", "Save file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Save fail!", "Save file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

            stsDate.Text = "Hôm này là ngày " + DateTime.Now.ToString("dd/MM/yyyy");



        }

       
        }
    }
