using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testCSDL
{
    public partial class Synhvien : Form
    {
        public Synhvien()
        {
            InitializeComponent();
        }

        private void Synhvien_Load(object sender, EventArgs e)
        {
            Chuoiketnoi.Openconnection();
            dgvsv.DataSource = Chuoiketnoi.dt("select *form SinhVien");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
