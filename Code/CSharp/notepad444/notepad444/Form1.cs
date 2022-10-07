using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace notepad444
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Undo();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Undo();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Cut();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";//sẽ cho phép chọn lọc và hiển thị một số loại tập tin
                openFileDialog1.FilterIndex = 2;//Quy định loại tập tin nào sẽ được hiển thị mặc định khi mở hộp thoại
                openFileDialog1.ShowDialog();
                string fileName = openFileDialog1.FileName;//gives the file name with the location
                StreamReader stReader = new StreamReader(fileName);//luong doc chuan
                richTextBox1.Text = stReader.ReadToEnd();
                stReader.Close();
            }
            catch { }		
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = "";
            if (fileName == "")
            {
                saveFileDialog1.Filter = "TEXT Documents. (*.txt)|*.txt|All files|*.*";
                DialogResult resVal = saveFileDialog1.ShowDialog();
                if (resVal == DialogResult.Cancel)
                {
                    return;
                }
                fileName = saveFileDialog1.FileName;
            }
            try
            {
                StreamWriter stWriter = new StreamWriter(fileName);
                stWriter.WriteLine(richTextBox1.Text);
                stWriter.Close();
            }
            catch
            {
                MessageBox.Show(this, "The file " + fileName + " is Read only. \n\n File Could not saved.", "Notepad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = "";
            if (fileName == "")
            {
                saveFileDialog1.Filter = "TEXT Documents. (*.txt)|*.txt|All files|*.*";
                DialogResult resVal = saveFileDialog1.ShowDialog();
                if (resVal == DialogResult.Cancel)
                {
                    return;
                }
                fileName = saveFileDialog1.FileName;
            }
            try
            {
                StreamWriter stWriter = new StreamWriter(fileName);
                stWriter.WriteLine(richTextBox1.Text);
                stWriter.Close();
            }
            catch
            {
                MessageBox.Show(this, "The file " + fileName + " is Read only. \n\n File Could not saved.", "Notepad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.DocumentName = richTextBox1.Text;
            printDialog1.Document = printDocument1;
            printDialog1.ShowDialog();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.DocumentName = richTextBox1.Text;
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.ShowDialog();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectAll();
        }

        private void wordWrapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem1.Checked = !wordWrapToolStripMenuItem1.Checked)
            {
                this.richTextBox1.WordWrap = true;
            }
            else
            {
                this.richTextBox1.WordWrap = false;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
            richTextBox1.ForeColor = fontDialog1.Color;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cao Dang Bach Nghe Tay Ha");
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        

        private void selecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectAll();
        }

        

        private void pasteStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Cut();
        }

        

        
    }
}
