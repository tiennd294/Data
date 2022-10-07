using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UNGDUNG
{
    public partial class frmInput : Form
    {
        public frmInput()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInput_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Use?:
                Class1.strInput = (textBox1.Text!="")?textBox1.Text:"testing";
             #endregion
            this.Close();
        }
    }
}