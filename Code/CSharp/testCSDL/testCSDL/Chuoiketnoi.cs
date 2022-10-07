using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace testCSDL
{
    class Chuoiketnoi
    {
        public static SqlConnection con = null;
        public static void Openconnection()
        {
            try
            {
                string connec = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True";
                con = new SqlConnection(connec);
                con.Open();
                //MessageBox.Show("Ket noi thanh cong! ");
            }
            catch
            {
                MessageBox.Show("Ket noi k thanh cong!");
            }
        }
        public static void Closeconnection()
        {
            try
            {
                string connec=@"Data Source=NGUYEN-99B795AB\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True";
                con = new SqlConnection(connec);
                con.Close();
            }
            catch
            {
            }
        }

        public static DataTable dt(string st)
        {
            SqlCommand cmd = new SqlCommand(st, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtt = new DataTable();
            da.Fill(dtt);
            return dtt;
        }
        public static void exc(string st)
        {
            SqlCommand cmd = new SqlCommand(st,con);
            cmd.CommandText = st;
            cmd.ExecuteNonQuery();

        }
        public static DataTable laybang(string tenbang)
        {
            string st = ("Selecte* from") + tenbang;
            SqlCommand cmd = new SqlCommand(st,con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds,tenbang);
            return  ds.Tables[0];
        }
    }
}
