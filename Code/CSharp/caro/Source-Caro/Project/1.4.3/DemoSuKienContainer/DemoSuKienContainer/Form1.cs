using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoSuKienContainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.MouseLeave += new EventHandler(panel1_MouseLeave);
        }

        void panel1_MouseLeave(object sender, EventArgs e)
        {
            Panel pnl = (Panel)sender;
            pnl.BackColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Red;
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            Panel pnl = (Panel)sender;
            pnl.BackColor = Color.Green;
        }


        private void panel1_Click(object sender, EventArgs e)
        {
            Panel pnl = (Panel)sender;
            pnl.BackColor = Color.Yellow;
            MouseEventArgs me = (MouseEventArgs)e;
            label1.Text = me.X.ToString() + "," + me.Y.ToString();
        }
    }
}
