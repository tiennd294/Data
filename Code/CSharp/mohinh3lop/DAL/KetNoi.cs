using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    class KetNoi
    {
        SqlConnection conn = new SqlConnection();
        public KetNoi()
        {
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=QLSV_CTHN;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            if(conn.State==ConnectionState.Closed)
            conn.Open();
        }
        public DataTable LOADDATA(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        
        public int Update(string sql, string[] name, object[] value, int nparameter)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            for (int i = 0; i < nparameter; i++)
            {
                cmd.Parameters.AddWithValue(name[i],value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        
    }
}
