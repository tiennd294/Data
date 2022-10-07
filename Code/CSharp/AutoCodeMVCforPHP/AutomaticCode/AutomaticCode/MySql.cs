using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;
using MySql.Data.MySqlClient;
using AutomaticCode.Properties;

namespace AutomaticCode
{
    class MySql
    {
       
        public static string mySqlConnectString = "Server=localhost;Database=webtintuc;Uid=root;Pwd=";

        public static DataSet ExecuteDataTable_MySQL(string connmysql, string sql)
        {
            using (MySqlConnection con = new MySqlConnection(connmysql))
            {
                using (MySqlDataAdapter dad = new MySqlDataAdapter(sql, con))
                {
                    using (DataSet dst = new DataSet())
                    {
                        dad.Fill(dst);
                        return dst;
                    }
                }
            }

        }


        public static void ExecuteNonQuery_SQL(string sql)//Dung de xoa va update
        {
            using (MySqlConnection con = new MySqlConnection(mySqlConnectString))
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                using (MySqlCommand com = new MySqlCommand(sql, con))
                {
                    com.CommandType = CommandType.Text;
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                con.Close();
                con.Dispose();
            }
        }

        public static bool isTrungMa(string connmysql, string sql)//= true nếu đã tồn tại. = false nếu ngược lại
        {
            DataSet tb = new DataSet();
            tb = MySql.ExecuteDataTable_MySQL(connmysql, sql);
            if (tb.Tables[0].Rows.Count > 0)
                return true;
            return false;
        }
    }
}
