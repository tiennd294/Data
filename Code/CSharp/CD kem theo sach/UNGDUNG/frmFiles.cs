using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace UNGDUNG
{
    public partial class frmFiles : Form
    {
        public frmFiles()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Folder(comboBox1.Text);
        }
        void Disks()
        {
            comboBox1.DataSource = Directory.GetLogicalDrives();            
            comboBox1.Text = @"D:\";

        }
        void Folder(string diskname)
        {
            comboBox2.DataSource = (Directory.Exists(diskname))?
               Directory.GetDirectories(diskname):null;
        }
        private void frmFiles_Load(object sender, EventArgs e)
        {
            Disks();
            Folder(comboBox1.Text);
            listView1.View = View.Details;
            listView1.Columns.Add("Stt", 30);
            listView1.Columns.Add("Name", 200);
            listView1.Columns.Add("Created", 100);
            listView1.Columns.Add("Last Access", 100);
            listView1.Columns.Add("Size", 100);            
            Files(comboBox2.Text);
        }
        void Files(string path)
        {
            if (!path.Equals(""))
            {
                listView1.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(path);
                if (dir.Exists)
                {
                    FileInfo[] files = dir.GetFiles("*.*");
                    ListViewItem lvi;
                    int i = 0;
                    #region while
                        while (i < files.Length)
                        {
                            lvi = new ListViewItem((i + 1).ToString());
                            lvi.SubItems.Add(files[i].Name);
                            lvi.SubItems.Add(files[i].CreationTime.ToShortDateString());
                            lvi.SubItems.Add(files[i].LastAccessTime.ToShortDateString());
                            lvi.SubItems.Add(files[i].Length.ToString());
                            listView1.Items.Add(lvi);
                            i++;
                        }
                    #endregion
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Files(comboBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem liv = listView1.FocusedItem;
            string name = liv.SubItems[1].Text;
            if (MessageBox.Show("Are you sure to delete " + name, "C# 2005", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                File.Delete(comboBox2.Text +"\\" + name);
                listView1.Items.Remove(liv);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListViewItem liv = listView1.FocusedItem;
            string name = liv.SubItems[1].Text;
            Form frm = new frmInput();
            frm.Text = "Move to new location";
            frm.ShowDialog(this);
            string newname = Class1.strInput;
            if (MessageBox.Show("Are you sure to rename " + name + " to new name " + newname, "C# 2005", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (!File.Exists(comboBox2.Text + newname))
                    File.Move(comboBox2.Text +"\\" + name, comboBox2.Text + "\\" + newname);
                else
                    MessageBox.Show(comboBox2.Text +"\\" + newname + " is existing");
                Files(comboBox2.Text);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListViewItem liv = listView1.FocusedItem;
            string name = liv.SubItems[1].Text;
            Form frm = new frmInput();
            frm.Text = "Copy to new location";
            frm.ShowDialog(this);
            string newname = Class1.strInput;
            if (MessageBox.Show("Are you sure to copy " + name + " to new folder " + newname, "C# 2005", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (!Directory.Exists(newname))
                    Directory.CreateDirectory(newname);
                File.Copy(comboBox2.Text + "\\" + name, newname);
                Folder(comboBox1.Text);
            }
        }
    }
}