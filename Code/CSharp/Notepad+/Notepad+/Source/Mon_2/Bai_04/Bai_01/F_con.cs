using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mon_2.Bai_04.Bai_01
{
    public partial class F_con : Form
    {
        public F_con()
        {
            InitializeComponent();
        }

        private void F_con_Load(object sender, EventArgs e)
        {
        }

        private void F_con_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((this.MdiParent).MdiChildren.Length == 1)
            {
                ((F_chinh)this.MdiParent).closeToolStripMenuItem.Enabled = false;
                ((F_chinh)this.MdiParent).saveToolStripMenuItem.Enabled = false;
                ((F_chinh)this.MdiParent).toolStripSave.Enabled = false;
                ((F_chinh)this.MdiParent).tsmauto.Enabled = false;
            }
        }

        private void txtnoidung_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
