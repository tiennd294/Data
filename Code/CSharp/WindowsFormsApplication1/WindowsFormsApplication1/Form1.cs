using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = textBox1.Text;
            string truong = textBox2.Text;
            ListViewItem add = new ListViewItem(new string[] { truong, ten });
            listView1.Items.Add(add);
            //ListViewItem item = new ListViewItem("1");
            //item.SubItems.Add("Teo");
            //item.SubItems.Add("HCM");
            //listView1.Items.Add(item); 
        }

        private void errorProvider1_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void button1_Validated(object sender, EventArgs e)
        {
            
        }

        private void button1_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }
}
