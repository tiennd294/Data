using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Notepad_k4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string name;
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)//hop thoai open
        {
            try
            {
                
                openFileDialog1.Filter = "All files (*.*)|*.*|Text Documents (*.txt)|*.txt";//cho phep chi mo nhung file trog bo loc
                openFileDialog1.FilterIndex = 2;// mac dinh hien thj bo loc thu 2: Text Documents (*.txt)
                openFileDialog1.ShowDialog();//dua hop thoai open ra man hinh
                string fileName = openFileDialog1.FileName;//gan dia chi duong dan file duoc chon vao bien srReader
                name = fileName;
                StreamReader stReader = new StreamReader(fileName);//khai bao va cap phat luong doc chuan cua C# cho fileName
                richTextBox1.Text = stReader.ReadToEnd();// doc gja tri cua finame dua vao richTextBox1: cai bang mau trang soan thao
                stReader.Close();//dong luong doc lai
            }
            catch { }		
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)//hop thoai save
        {
            try
            {
                if (this.name != "")//neu file da co ten thi hi de len
                {
                    StreamWriter stWriter = new StreamWriter(name);//khai bao va cap phat luong viet chuan cua C# cho name
                    stWriter.WriteLine(richTextBox1.Text);//ghi du lieu tu 
                    stWriter.Close();//dong luong write
                }
            }
            catch { }
            if(this.name=="")//neu k co ten <=> la file moi thi luu voi ten khac
            {
                string fileName = "";//gan chuoi fileName= ro~ng

                saveFileDialog1.Filter = "TEXT Documents. (*.txt)|*.txt|All files|*.*";//luu file duoi dang txt
                DialogResult resVal = saveFileDialog1.ShowDialog();//show hop thoai save ra man hinh
                if (resVal == DialogResult.Cancel)//neu nguoi dung nhan nut cancel 
                {
                    return;//thi tro lai notepad
                }
                fileName = saveFileDialog1.FileName;//gan duong dan luu file vao bien fiName

                try// neu k co loi gi xay ra thi thuc hien khoi lenh trong ngoac{}
                {
                    StreamWriter stWriter = new StreamWriter(fileName);//khai bao va cap phat luong viet chuan cua C# cho fileName
                    stWriter.WriteLine(richTextBox1.Text);//ghi du lieu tu richTextBox1.Text
                    stWriter.Close();//dong luong write
                }
                catch//neu o loi thi dua ra thong bao
                {
                    MessageBox.Show(this, "The file " + fileName + " is Read only. \n\n File Could not saved.", "Notepad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) //ham saveas tuong tu nha save
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

        private void printToolStripMenuItem_Click(object sender, EventArgs e)//hop thoai print
        {
            printDocument1.DocumentName = richTextBox1.Text;
            printDialog1.Document = printDocument1;
            printDialog1.ShowDialog();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.DocumentName = richTextBox1.Text;
            printPreviewDialog1.Document = printDocument1;
            pageSetupDialog1.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//ham exit
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Undo(); //ham undo
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Cut();//ham cut
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Copy();//ham copy
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();//ham paste
        }

        private void deleteStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectedText = "";//ham delete
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectAll();//ham select all
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = DateTime.Now.ToString();//ham data/time
        }

        private void wordwrapToolStripMenuItem_Click(object sender, EventArgs e)//ham word wrap
        {
            if (wordwrapToolStripMenuItem.Checked = !wordwrapToolStripMenuItem.Checked)//neu wordwrap duoc chon
            {
                this.richTextBox1.WordWrap = true;//thi ap dun vao van ban
            }
            else//con k duoc chon
            {
                this.richTextBox1.WordWrap = false;//thi k duoc ap dun vao van ban
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)//chon font chu
        {
            fontDialog1.ShowColor = true;//hien thi che do chon mau
            fontDialog1.ShowDialog();//show man hinh chon mau
            richTextBox1.Font = fontDialog1.Font;//ap dung font da chon
            richTextBox1.ForeColor = fontDialog1.Color;//ap dung mau da chon
        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Undo();//ham menu ngu canh undo
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Cut();//ham menu ngu canh cut
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Copy();//ham menu ngu canh copy
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();//ham menu ngu canh paste
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectedText = "";//ham menu ngu canh delete
        }

        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectAll();//ham menu ngu canh chon toan bo van ban
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)// ham thon tin tac gia
        {
            MessageBox.Show("K4_CNTT-CQ.Tay Ha","About Notepad",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        

        
    }
}
