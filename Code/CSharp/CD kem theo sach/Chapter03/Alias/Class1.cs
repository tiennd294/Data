using System;
using Sql = System.Data.SqlClient.SqlConnection;

namespace Alias
{
    class Class1
    {
        void myAlias()
        {
            Sql cls = new Sql();
            string strCon = "server=(local);";
            strCon += "database=myDB;uid=sa;pwd=;";
            cls.ConnectionString = strCon;
        }
    }
}
