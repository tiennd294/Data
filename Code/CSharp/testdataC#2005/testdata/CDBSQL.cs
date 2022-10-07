using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

public class CDBSQL
{
    public static string strconn = "";//ConfigurationManager.ConnectionStrings["sqlconn"].ToString();

    //public CDBSQL()
    //{
    //    using (SqlConnection sqlconn = new SqlConnection(strconn))
    //    {
    //        if (sqlconn.State == ConnectionState.Open)
    //            sqlconn.Close();
    //        sqlconn.Open();
    //    }
    //}

    //____________________________________________________________________________________________________

	public static string mySqlConnectString = "Server=localhost;Database=webtintuc;Uid=root;Pwd='';";

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
	
	
	//____________________________________________________________________________________________________
    public static DataSet ExecuteDataTable_SQL(string sql)
    {
        using (SqlConnection con = new SqlConnection(strconn))
        {
			if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            using (SqlCommand command = new SqlCommand(sql, con))
            {
                command.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter dad = new SqlDataAdapter(command))
                {
                    using (DataSet dst = new DataSet())
                    {
                        dad.Fill(dst);
                        return dst;
                    }
                }
            }
            con.Close();
            con.Dispose();
        }

    }

    public static DataSet ExecuteDataTable_SQL(string sql, string[] name, object[] value, int Nparameter)
    {
        using (SqlConnection con = new SqlConnection(strconn))
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            using (SqlCommand command = new SqlCommand(sql, con))
            {
                command.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < Nparameter; i++)
                {
                    command.Parameters.AddWithValue(name[i], value[i]);
                }
                using (SqlDataAdapter dad = new SqlDataAdapter(command))
                {
                    using (DataSet dst = new DataSet())
                    {
                        dad.Fill(dst);
                        return dst;
                    }
                }
            }
            con.Close();
            con.Dispose();
        }
    }


   //____________________________________________________________________________________________________

    public static int Updates(string sql)
    {
        using (SqlConnection con = new SqlConnection(strconn))
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            using (SqlCommand command = new SqlCommand(sql, con))
            {
                //command.CommandType = CommandType.StoredProcedure;
                command.CommandType = CommandType.Text;
                return command.ExecuteNonQuery();
            }
            con.Close();
            con.Dispose();
        }
    }

    public static int Updates(string sql, string[] name, object[] value, int Nparameter)
    {
        using (SqlConnection con = new SqlConnection(strconn))
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            using (SqlCommand command = new SqlCommand(sql, con))
            {
                command.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < Nparameter; i++)
                {
                    command.Parameters.AddWithValue(name[i], value[i]);
                }
                return command.ExecuteNonQuery();
            }
            con.Close();
            con.Dispose();
        }
    }
    public static byte[] encryptData(string data)
    {
        System.Security.Cryptography.MD5CryptoServiceProvider md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
        byte[] hashedBytes;
        System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
        hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data));
        return hashedBytes;
    }
    public static string md5(string data)
    {
        return BitConverter.ToString(encryptData(data)).Replace("-", "").ToLower();
    }


}
