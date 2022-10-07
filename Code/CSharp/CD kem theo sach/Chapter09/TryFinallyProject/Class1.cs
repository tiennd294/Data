using System;
using System.Data.SqlClient ;

namespace TryFinallyProject
{
    class Class1
    {
        public void PrintCustomers(string strSQL)
        {            
            string strCon = "server=(local);";
            strCon = "database=northwind";
            strCon += ";uid=sa;pwd=sa;";
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = strCon;            
            SqlCommand Com;
            Com = new SqlCommand(strSQL, Con);
            SqlDataReader dr=null;
            try
            {
                Con.Open();
                dr = Com.ExecuteReader();
                while (dr.Read())
                {
                    Console.Write("{0}  ", dr[0]);
                    Console.Write("{0}  ", dr[1]);
                    Console.Write("{0}  ", dr[2]);
                    Console.WriteLine("{0}  ", dr[3]);
                }
            }
            finally
            {
                dr.Dispose();
                Con.Dispose();
            }
        }
    }
}
