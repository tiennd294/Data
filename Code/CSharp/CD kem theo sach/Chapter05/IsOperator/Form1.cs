using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IsOperator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
                if (c is RadioButton && c.Text=="Female")
                {
                    RadioButton gender =(RadioButton)c;
                    gender.Checked = true;
                }

            }
        }
    }
}