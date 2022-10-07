using System;
using System.Management ;
using System.IO;
using System.Windows.Forms;

namespace UNGDUNG
{
    public partial class frmDisks : Form
    {
        public frmDisks()
        {
            InitializeComponent();
        }

        private void frmDrive_Load(object sender, EventArgs e)
        {
            Disks();
            HardDisk();
        }
        void Disks()
        {
            foreach (string d in Directory.GetLogicalDrives())
            {
                listBox1.Items.Add(d);
            }           
        }
        void HardDisk()
        { 
            ManagementObjectSearcher LocalDisks;
            LocalDisks = new ManagementObjectSearcher( new SelectQuery("Select * from Win32_LogicalDisk  "));
            ManagementObjectCollection myDisks;
            myDisks = LocalDisks.Get();
            foreach (ManagementObject myDisk in myDisks)
            {
                switch (Convert.ToString(myDisk.GetPropertyValue("DriveType")))
                {
                    case "2":
                        comboBox2.Items.Add(myDisk.GetPropertyValue("Name"));
                        break;
                    case "3":
                        comboBox3.Items.Add (myDisk.GetPropertyValue("Name"));
                        break;
                    case "4":
                        comboBox4.Items.Add(myDisk.GetPropertyValue("Name"));
                        break;
                }
            }
            myDisks.Dispose();                    
            LocalDisks.Dispose ();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}