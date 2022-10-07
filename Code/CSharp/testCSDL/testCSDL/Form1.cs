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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Chuoiketnoi.Openconnection();
            Panel frm = new Panel();
            frm.Show();
            //this.Hide();
        }
    }
}
