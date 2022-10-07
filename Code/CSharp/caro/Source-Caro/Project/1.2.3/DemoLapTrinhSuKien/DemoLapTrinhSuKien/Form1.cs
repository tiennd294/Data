using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoLapTrinhSuKien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button1_Click);
            button3.Click += new EventHandler(button1_Click);
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
        }

        void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.Checked.ToString());
        }

        void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
        }

        
    }
}
