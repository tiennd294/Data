﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TuDienAV
{
    public partial class Them : Form
    {
        public Them()
        {
            InitializeComponent();
        }
        string ds; string ng;
        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
        public string DS
        {
            get { return ds; }
            set{ ds = value; }
        }
        public string NG
        {
            get { return ng; }
            set { ng = value; }
        }
    }
}
