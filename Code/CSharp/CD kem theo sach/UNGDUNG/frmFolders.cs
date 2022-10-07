using System;
using System.IO;
using System.Windows.Forms;

namespace UNGDUNG
{
    public partial class frmFolders : Form
    {
        public frmFolders()
        {
            InitializeComponent();
        }

         
        void Disks()
        {
            foreach (string d in Directory.GetLogicalDrives())
            {
                comboBox1.Items.Add(d);
            }
            comboBox1.Text = @"D:\";

        }
        void Folder(string diskname)
        {
            listView1.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(diskname);
            if (dir.Exists)
            {
                DirectoryInfo[] dirs = dir.GetDirectories();
                ListViewItem lvi;
                for (int i = 0; i < dirs.Length; i++)
                {
                    lvi = new ListViewItem((i+1).ToString());
                    lvi.SubItems.Add(dirs[i].Name);
                    lvi.SubItems.Add(dirs[i].CreationTime.ToShortDateString());
                    lvi.SubItems.Add(dirs[i].LastAccessTime.ToShortDateString());
                    lvi.SubItems.Add(dirs[i].GetFiles().Length.ToString());

                    listView1.Items.Add(lvi);
                }
            }
        }
        private void frmFolders_Load(object sender, EventArgs e)
        {
            Disks();
            listView1.View = View.Details;
            listView1.Columns.Add("Stt",30);
            listView1.Columns.Add("Name",100);
            listView1.Columns.Add("Created",50);
            listView1.Columns.Add("Last Access", 50);
            listView1.Columns.Add("Number of Files",50);
            Folder(comboBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Folder(comboBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox1.Text);
            if (dir.Exists)
            {              
                Form frm = new frmInput();
                frm.Text = "Create new folder";
                frm.ShowDialog(this);
                string name = Class1.strInput;
                if (!Directory.Exists(comboBox1.Text + "\\" + name))
                {
                    Directory.CreateDirectory(comboBox1.Text + name);
                    Folder(comboBox1.Text);
                }
                else
                    MessageBox.Show("Folder is existing ");
            }
            else
                MessageBox.Show("Disk " + comboBox1.Text + " not ready");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem liv = listView1.FocusedItem;
            string name = liv.SubItems[1].Text;
            if (MessageBox.Show("Are you sure to delete " + name, "C# 2005", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                listView1.Items.Remove(liv);
                Directory.Delete(comboBox1.Text + name);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListViewItem liv = listView1.FocusedItem;
            string name = liv.SubItems[1].Text;
            Form frm = new frmInput();
            frm.Text = "Rename folder";
            frm.ShowDialog(this);
            string newname = Class1.strInput;
            if (MessageBox.Show("Are you sure to rename " + name + " to new name " + newname, "C# 2005", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (!Directory.Exists(comboBox1.Text + newname))
                    Directory.Move(comboBox1.Text + name, comboBox1.Text + newname);
                else
                    MessageBox.Show(comboBox1.Text + newname + " is existing");
                Folder(comboBox1.Text);
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
            if (MessageBox.Show("Are you sure to copy " + name + " to folder " + newname, "C# 2005", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (!Directory.Exists(newname))                
                    Directory.CreateDirectory(newname);
                CopyDirectory(comboBox1.Text + name, comboBox1.Text+newname);
                Folder(comboBox1.Text);
            }
            
        }
        public void CopyDirectory(string Src,string Dst)
        {
            String[] Files;

            if(Dst[Dst.Length-1]!=Path.DirectorySeparatorChar) 
                Dst+=Path.DirectorySeparatorChar;
            if(!Directory.Exists(Dst)) 
                Directory.CreateDirectory(Dst);
            Files=Directory.GetFileSystemEntries(Src);
            foreach(string Element in Files)
            {               
                if(Directory.Exists(Element))
                    CopyDirectory(Element, Dst + 
                        Path.GetFileName(Element));                
                else 
                    File.Copy(Element,Dst+
                        Path.GetFileName(Element),true);
            }
               
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}