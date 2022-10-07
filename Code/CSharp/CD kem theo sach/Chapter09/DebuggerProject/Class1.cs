using System;
using System.Data;
using System.Data.SqlClient ;

namespace DebuggerProject
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
            
            try
            {
                SqlDataReader dr;
                Con.Open();
                dr = Com.ExecuteReader();
                while (dr.Read())
                {
                    Console.Write("{0}  ", dr[0]);
                    Console.Write("{0}  ", dr[1]);
                    Console.Write("{0}  ", dr[2]);
                    Console.WriteLine("{0}  ", dr[3]);
                }                             
                dr.Close();
                dr.Dispose();
                Con.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: {0}",ex.Message);
                if (Con.State != ConnectionState.Closed)
                {
                    Con.Close();
                }
            }
            finally
            {               
                Con.Dispose();
            }
        }
    }
}

