using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;


namespace Xml2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            xl_PhanSo1 = new XL_PHANSO(new LT_PHANSO("phanso1.xml"), tH_PHANSO1);
            xl_PhanSo2 = new XL_PHANSO(new LT_PHANSO("phanso2.xml"), tH_PHANSO2);
            xl_PhanSo3 = new XL_PHANSO(new LT_PHANSO(""), tH_PHANSO3);
            

        }
        private PhanSo.XL_PHANSO xl_PhanSo1; 
        private PhanSo.XL_PHANSO xl_PhanSo2; 
        private PhanSo.XL_PHANSO xl_PhanSo3;
        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
