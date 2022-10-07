using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace QLNV_NGUYENTIEN
{
    public class Sqlhelper
    {
        public static string ConnectString = "Data Source=.\\SQLEXPRESS;Initial Catalog=QLNV_NGUYENTIEN;Integrated Security=True";
        public static string mySqlConnectString = "Server=localhost;Database=testmysql;Uid=root;Pwd=";

        public static DataTable MySqlExecuteDataTable_SQL(string sql)
        {
            using (MySqlConnection con = new MySqlConnection(mySqlConnectString))
            {
                using (MySqlDataAdapter dad = new MySqlDataAdapter(sql, con))
                {
                    using (DataSet dst = new DataSet())
                    {
                        dad.Fill(dst);
                        return dst.Tables[0];
                    }
                }
            }

        }
        
        public static DataTable ExecuteDataTable_SQL(string sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectString))
            {
                using (SqlDataAdapter dad = new SqlDataAdapter(sql, con))
                {
                    using (DataSet dst = new DataSet())
                    {
                        dad.Fill(dst);
                        return dst.Tables[0];
                    }
                }
            }

        }

        public static void ExecuteNonQuery_SQL(string sql)//Dung de xoa va update
        {
            using (SqlConnection con = new SqlConnection(ConnectString))
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.CommandType = CommandType.Text;
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                con.Close();
                con.Dispose();
            }
        }

        public static bool isTrungMa(string sql)//= true nếu đã tồn tại. = false nếu ngược lại
        {
            DataTable tb = new DataTable();
            tb = Sqlhelper.ExecuteDataTable_SQL(sql);
            if (tb.Rows.Count > 0)
                return true;
            return false;
        }
    }
}

