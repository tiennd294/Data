using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace myWindowsApplicationFormat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 10, j = 15, k = 50;
            Console.WriteLine("Standard Format");
            Console.WriteLine("i={0}", i);
            Console.WriteLine("i={0}, j={1},k={2}", i, j, k);
        }
    }
}