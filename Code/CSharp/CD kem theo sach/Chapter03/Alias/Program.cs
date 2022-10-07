using System;
using System.Data.SqlClient;

namespace Alias
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection cls = new SqlConnection();
            string strCon = "server=(local);";
            strCon+="database=myDB;uid=sa;pwd=;";
            cls.ConnectionString = strCon;
        }
    }
}
