using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLSVAT
{
    class xuli
    {
        public SqlConnection con;
        public xuli()
        {
            con = new SqlConnection();
            con.ConnectionString = @"server=.\sqlexpress;database=qlsv;uid=tien;pwd=123";
            con.Open();
        }
        public DataTable ham(string t)
        {
            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(t,con);
            da.Fill(dt);
            return dt;
        }
    }
}
