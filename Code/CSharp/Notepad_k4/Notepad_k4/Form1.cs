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
        string name = "";//bien trung gian
        string tg = "";
        string name1 = "";
        

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";//tao file moi
        }

        public void saveall()//ham save
        {

            if (name != "")//neu da co ten thi hi de len file
            {
                StreamWriter sw = File.CreateText(name);
                sw.Write(richTextBox1.Text);
                sw.Close();
                MessageBox.Show("Save success!", "Save file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                if (name == "")//neu chua co ten thi thuc hien khoi lenh
                {
                    saveFileDialog1.Filter = "TEXT Documents. (*.txt)|*.txt|All files|*.*";//chi mo nhung file trong bo loc
                    DialogResult resVal = saveFileDialog1.ShowDialog();//tạo một biến kết quả từ việc mở tập tin
                    //lúc đó hộp thoại mở tập tin sẽ có 2 nút là Open và Cancel
                    if (resVal == DialogResult.Cancel)//neu chon nut cancel
                    {
                        return;
                    }
                    name = saveFileDialog1.FileName;
                    if (resVal == DialogResult.OK)//neu nut nhan la ok
                    {
                        try
                        {
                            StreamWriter stWriter = new StreamWriter(name);
                            stWriter.WriteLine(richTextBox1.Text);
                            stWriter.Close();
                        }
                        catch
                        {
                            MessageBox.Show(this, "The file " + name + " is Read only. \n\n File Could not saved.", "Notepad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Save fail!", "Save file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                tg = richTextBox1.Text;
                name1 = System.IO.Path.GetFileName(fileName);

                int tg11=name1.LastIndexOf(".");
                string tg12 = name1.Remove(tg11);

                this.Text = tg12+" - Notepad";
                
               
            }
            catch { }
        }
        
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)//hop thoai save
        {

            saveFileDialog1.Title = "Save files";
            saveall();
           
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) //ham saveas tuong tu nha save
        {
            name = "";
            saveFileDialog1.Title = "Save As files";
            saveall();
            
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)//hop thoai print
        {
            printDocument1.DocumentName = richTextBox1.Text;
            printDialog1.Document = printDocument1;
            printDialog1.ShowDialog();
        }
        private void pagePreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.DocumentName = richTextBox1.Text;
            pageSetupDialog1.Document = printDocument1;
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)// ham thong tin tac gia
        {
            MessageBox.Show("K4_CNTT-CQ.Tay Ha", "About Notepad", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (tg != richTextBox1.Text)//neu du lieu da bi thay doi
            {
                try
                {
                    if (MessageBox.Show("Ban co muon luu lai truoc khi thoat khong!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        //
                        saveall();
                }
                catch { }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void findStripMenuItem1_Click(object sender, EventArgs e)//ham tim kien
        {
            Form2 a = new Form2();
            a.ShowDialog();
            richTextBox1.Find(a.fi);
        }
        
        
    }
}
