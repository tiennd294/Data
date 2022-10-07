using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Xml2
{
    public partial class TH_PHANSO : UserControl
    {
        public TH_PHANSO()
        {
            InitializeComponent();
        }

        public int tuso
        {
            set
            {
                this.textBox1.Text = value.ToString();
            }
            get
            {
                return int.Parse(this.textBox1.Text);
            }
        }

        public int mauso
        {

            set
            {
                this.textBox2.Text = value.ToString();
            }
            get
            {
                return int.Parse(this.textBox2.Text);
            }
        }


        private void TH_PHANSO_Load(object sender, EventArgs e)
        {

        }
    }
}
