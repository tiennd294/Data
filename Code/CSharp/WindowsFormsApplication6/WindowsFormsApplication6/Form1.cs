using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (txtUser.Text.ToLower().Equals("aptech") && txtPassword.Text.ToLower().Equals("aptech"))
                MessageBox.Show("Login successful!", "Login");
            else
                MessageBox.Show("Login fail", "Login");



        }

        private void btnExit_Click(object sender, EventArgs e)
        {



            this.Close();



        }
    }
}
