using System;
using System.Data;
using System.Data.SqlClient;

namespace ObjectArray
{
    public class Class1
    {
        public object[] GetObject()
        {
            object[] o= null;
            string strCon="server=(local);";
            strCon="database=northwind";
            strCon +=";uid=sa;pwd=sa;";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = strCon;
            string strSQL = "select top 1 ";
            strSQL += "CustomerID,CompanyName,";
            strSQL += "City,Country from Customers";
            try
            {
                SqlDataAdapter da;
                da = new SqlDataAdapter(strSQL, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                o = dt.Rows[0].ItemArray;
            }
            catch (Exception ex)
            { }
            return o;
        }
    }
}
