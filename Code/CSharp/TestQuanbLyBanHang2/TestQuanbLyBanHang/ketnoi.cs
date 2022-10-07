using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestQuanbLyBanHang
{
    class ketnoi
    {
        public SqlConnection con;
        public void ket_noi()
        {
            try
            {
                con = new SqlConnection(@"Data Source=.\NGUYENTIEN;Initial Catalog=QLBH;Integrated Security=True");
                con.Open();

            }
            catch
            {
                MessageBox.Show("ket noi that bai!");
                //SqlCommand cmd = new SqlCommand();
                //ketnoi kn = new ketnoi();
                //kn.ket_noi();
                //cmd.Connection = kn.con;
            }
        }
    }
}
