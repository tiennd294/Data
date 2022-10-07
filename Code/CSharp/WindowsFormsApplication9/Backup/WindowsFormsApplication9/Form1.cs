using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

      

        private void ctrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            openFileDialog1.CheckPathExists = true ;
            openFileDialog1.Filter = " Rich Text Format (*.rtf)|*.rtf |Text File (*text)|*.txt ";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            openFileDialog1.ShowDialog();
            richTextBox1.LoadFile(openFileDialog1);
            this.Text = openFileDialog1.FileName();

      
        
        
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.CheckPathExists = true;
            
           saveFileDialog1.Filter = " Rich Text Format (*.rtf)|*.rtf |Text File (*text)|*.txt ";
            if(ten_File_dang_mo = untile
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            
            saveFileDialog1.ShowDialog();
            richTextBox1.SaveFile(saveFileDialog1);
        
        
        
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void selcectFontToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void saveToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            String b = saveFileDialog1.FileName;
            richTextBox1.SaveFile(b);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {




        }

        
        

        }
    }

