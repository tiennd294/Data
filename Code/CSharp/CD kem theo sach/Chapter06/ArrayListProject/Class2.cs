using System;
using System.Collections ;
using System.Data;
using System.Data.SqlClient;

namespace ArrayListProject
{
    public  class Class2
    {
        public ArrayList GetObject()
        {
            ArrayList arr = new ArrayList();
            string strCon = "server=(local);";
            strCon = "database=northwind";
            strCon += ";uid=sa;pwd=sa;";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = strCon;
            string strSQL = "select  CustomerID,";
            strSQL += "CompanyName,City,Country";
            strSQL += " from Customers";
            try
            {
                SqlDataAdapter da;
                da = new SqlDataAdapter(strSQL, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    object[] o ;
                    o =dr.ItemArray;
                    arr.Add(o);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message );
            }
            return arr;
        }
    }
}
