using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Picture
{
    class ket_noi
    {
        public SqlConnection con;
        public void ketnoi()
        {
            try
            {
                con = new SqlConnection(@"Data Source=.\NGUYENTIEN;Initial Catalog=DataImages2;Integrated Security=True");
                con.Open();
                //MessageBox.Show("ket noi thanh cong");
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
        public void huykn()
        {
            con.Close();
        }
    }
}
