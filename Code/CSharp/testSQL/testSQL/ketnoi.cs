using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace testSQL
{
    class ketnoi
    {
        public SqlConnection con;
        public SqlDataAdapter da;
        public ketnoi()
        {
            con = new SqlConnection();
            con.ConnectionString = @"server=.\sqlexpress;database=qlsv;uid=tien;pwd=123";
            con.Open();
        }
        public DataTable ham(string t)
        {
            da=new SqlDataAdapter(t,con);
            DataTable dt=new DataTable();
            da.Fill(dt);
            return dt;
        }//win service
    }
}
