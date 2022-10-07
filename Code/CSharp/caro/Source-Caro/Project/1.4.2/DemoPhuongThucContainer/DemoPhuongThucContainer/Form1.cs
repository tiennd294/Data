using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoPhuongThucContainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button btn = new Button();
            btn.Text = "myclass.vn";
            btn.Location = new Point(100, 20);
            panel1.Controls.Add(btn);
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMo_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }
    }
}
