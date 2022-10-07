using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public class CDBSQL
{
    //public static string strconn = ConfigurationManager.ConnectionStrings["sqlconn"].ToString();

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

    //public static DataTable ExecuteDataTable_SQL(string sql)
    //{
    //    using (SqlConnection con = new SqlConnection(strconn))
    //    {
    //        if (con.State == ConnectionState.Open)
    //            con.Close();
    //        con.Open();
    //        using (SqlCommand command = new SqlCommand(sql, con))
    //        {
    //            //command.CommandType = CommandType.StoredProcedure;
    //            using (SqlDataAdapter dad = new SqlDataAdapter(command))
    //            {
    //                using (DataSet dst = new DataSet())
    //                {
    //                    dad.Fill(dst);
    //                    return dst.Tables[0];
    //                }
    //            }
    //        }
    //        con.Close();
    //        con.Dispose();
    //    }

    //}

    //public static DataTable ExecuteDataTable_SQL(string sql, string[] name, object[] value, int Nparameter)
    //{
    //    using (SqlConnection con = new SqlConnection(strconn))
    //    {
    //        if (con.State == ConnectionState.Open)
    //            con.Close();
    //        con.Open();
    //        using (SqlCommand command = new SqlCommand(sql, con))
    //        {
    //            //command.CommandType = CommandType.StoredProcedure;
    //            for (int i = 0; i < Nparameter; i++)
    //            {
    //                command.Parameters.AddWithValue(name[i], value[i]);
    //            }
    //            using (SqlDataAdapter dad = new SqlDataAdapter(command))
    //            {
    //                using (DataSet dst = new DataSet())
    //                {
    //                    dad.Fill(dst);
    //                    return dst.Tables[0];
    //                }
    //            }
    //        }
    //        con.Close();
    //        con.Dispose();
    //    }
    //}

    ////____________________________________________________________________________________________________

    //public static int Updates(string sql)
    //{
    //    using (SqlConnection con = new SqlConnection(strconn))
    //    {
    //        if (con.State == ConnectionState.Open)
    //            con.Close();
    //        con.Open();
    //        using (SqlCommand command = new SqlCommand(sql, con))
    //        {
    //            //command.CommandType = CommandType.StoredProcedure;
    //            command.CommandType = CommandType.Text;
    //            return command.ExecuteNonQuery();
    //        }
    //        con.Close();
    //        con.Dispose();
    //    }
    //}

    //public static int Updates(string sql, string[] name, object[] value, int Nparameter)
    //{
    //    using (SqlConnection con = new SqlConnection(strconn))
    //    {
    //        if (con.State == ConnectionState.Open)
    //            con.Close();
    //        con.Open();
    //        using (SqlCommand command = new SqlCommand(sql, con))
    //        {
    //            //command.CommandType = CommandType.StoredProcedure;
    //            for (int i = 0; i < Nparameter; i++)
    //            {
    //                command.Parameters.AddWithValue(name[i], value[i]);
    //            }
    //            return command.ExecuteNonQuery();
    //        }
    //        con.Close();
    //        con.Dispose();
    //    }
    //}
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

    public static string DecryptString(string Message, string Passphrase)
    {

        byte[] Results;

        System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();

        // Step 1. Bam chuoi su dung MD5

        System.Security.Cryptography.MD5CryptoServiceProvider HashProvider = new System.Security.Cryptography.MD5CryptoServiceProvider();

        byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));

        // Step 2. Tao doi tuong TripleDESCryptoServiceProvider moi

        System.Security.Cryptography.TripleDESCryptoServiceProvider TDESAlgorithm = new System.Security.Cryptography.TripleDESCryptoServiceProvider();

        // Step 3. Cai dat bo giai ma

        TDESAlgorithm.Key = TDESKey;

        TDESAlgorithm.Mode = System.Security.Cryptography.CipherMode.ECB;

        TDESAlgorithm.Padding = System.Security.Cryptography.PaddingMode.PKCS7;

        // Step 4. Convert chuoi (Message) thanh dang byte[]

        byte[] DataToDecrypt = Convert.FromBase64String(Message);

        // Step 5. Bat dau giai ma chuoi

        try
        {

            System.Security.Cryptography.ICryptoTransform Decryptor = TDESAlgorithm.CreateDecryptor();

            Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length);

        }

        finally
        {

            // Xoa moi thong tin ve Triple DES va HashProvider de dam bao an toan

            TDESAlgorithm.Clear();

            HashProvider.Clear();

        }
        return UTF8.GetString(Results);
    }
}
