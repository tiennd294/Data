using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IfElseProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                MessageBox.Show("Please enter username", 
                    "HUUKHANG.COM");
                txtUsername.Focus();
            }
            else
            {
                if (txtPassword.Text.Equals(""))
                {
                    MessageBox.Show("Please enter password",
                        "HUUKHANG.COM");
                    txtPassword.Focus();
                }
                else
                {
                    MessageBox.Show("Will check in Database",
                        "HUUKHANG.COM");
                }
            }
            
        }
    }
}