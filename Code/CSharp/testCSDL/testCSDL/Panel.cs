using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testCSDL
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void Panel_Load(object sender, EventArgs e)
        {

        }

        private void btnsv_Click(object sender, EventArgs e)
        {
            Synhvien frm = new Synhvien();
            frm.ShowDialog(); 
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
