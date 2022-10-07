using System;
using System.Data;
using System.Data.SqlClient ;
using System.Collections.Generic;
using System.Text;

namespace FirstApplication
{
    class Class2 : FirstApplication.IClass2  
    {
        public DataSet GetDataSet(string strSQL)
        {
            DataSet ds = new DataSet();
            /*Code here*/
            return ds;
        }
        public DataTable GetDataTable(string strSQL)
        {
            DataTable dt = new DataTable();
            /*Code here*/
            return dt;
        }
    }
}
