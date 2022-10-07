using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UNGDUNG
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        
        Form frm;
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm = new frmRead();
            frm.MdiParent=this;
            frm.Show();
        }

        private void writeTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm = new frmWrite();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm = new frmAppend();
            frm.MdiParent = this;
            frm.Show();
        }

        private void driveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm = new frmDisks();
            frm.MdiParent = this;
            frm.Show();
        }

        private void folderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm = new frmFolders();
            frm.MdiParent = this;
            frm.Show();
        }

        private void filesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm = new frmFiles();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sQLDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm = new frmSQLServer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void accessDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm = new frmAccess();
            frm.MdiParent = this;
            frm.Show();
        }

         

        private void systemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm = new frmServices();
            frm.MdiParent = this;
            frm.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fileWatcherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm = new frmWatcher();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}