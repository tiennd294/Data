using System;
using System.Data.SqlClient;

namespace WhileStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection Con;
            string strCon = "server=(local);";
            strCon += "database=northwind;";
            strCon += "uid=sa;pwd=;";            
            Con = new SqlConnection(strCon);
            try
            {
                SqlCommand Com;
                Com = new SqlCommand();
                Con.Open();
                Com.Connection = Con;
                string SQL="Select top 10 CustomerID,";
                SQL+="CompanyName from Customers";
                Com.CommandText = SQL;
                SqlDataReader dr;
                dr = Com.ExecuteReader();
                while(dr.Read())
                {
                    Console.Write("{0}", 
                        dr.GetString(0));
                    Console.WriteLine("-{0}",
                        dr.GetString(1));
                }
                dr.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
