using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace UNGDUNG
{
    public partial class frmAccess : Form
    {
        public frmAccess()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog od = new FolderBrowserDialog();
            
            od.RootFolder = Environment.SpecialFolder.Desktop;
            if (od.ShowDialog() == DialogResult.OK)
            {
                Text = od.SelectedPath;
                ShowAccess(od.SelectedPath);
            }
        }
        void ShowAccess(string path)
        {                     
            if (!path.Equals(""))
            {
                lvData.Items.Clear();
                clsFile cls = new clsFile();
                List<FileInfo> Files = cls.GetFiles(path);
                ListViewItem lvi;
                int i = 0;
                foreach (FileInfo files in Files)
                {
                    lvi = new ListViewItem((i + 1).ToString());
                    lvi.SubItems.Add(files .Name);
                    lvi.SubItems.Add(files .CreationTime.ToShortDateString());
                    lvi.SubItems.Add(files .LastAccessTime.ToShortDateString());
                    lvi.SubItems.Add(files .Length.ToString());
                    lvData.Items.Add(lvi);
                    i++;
                }                
            }
       
        }

        private void frmAccess_Load(object sender, EventArgs e)
        {
            lvData.View = View.Details;
            lvData.Columns.Add("Stt", 30);
            lvData.Columns.Add("Name", 200);
            lvData.Columns.Add("Created", 100);
            lvData.Columns.Add("Last Access", 100);
            lvData.Columns.Add("Size", 100);   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem liv = lvData.FocusedItem;
            string name = liv.SubItems[1].Text;
            if (MessageBox.Show("Are you sure to delete " + name, "C# 2005", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (DeleteFile(name))
                {
                    MessageBox.Show(name + " was deleted");
                    lvData.Items.Remove(liv);
                }
            }
        }
        bool DeleteFile(string file)
        {
            bool Deleted = false;
            try
            {
                File.Delete(Text + "\\" +  file);
                Deleted = true;
            }
            catch (Exception ex)
            { 
                
            }
            return Deleted;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListViewItem liv = lvData.FocusedItem;
            string name = liv.SubItems[1].Text;
            Form frm = new frmInput();
            frm.Text = "Move to new location";
            frm.ShowDialog(this);
            string newname = Class1.strInput;
            if (MessageBox.Show("Are you sure to rename " + name + " to new name " + newname, "C# 2005", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (!File.Exists(this.Text + newname))
                    File.Move(this.Text + "\\" + name, this.Text + "\\" + newname);
                else
                    MessageBox.Show(this.Text + "\\" + newname + " is existing");
            }
            ShowAccess(Text);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}