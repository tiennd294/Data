using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ketnoicsdl
{
    class ketnoi
    {
        public SqlConnection con;
        public ketnoi()
        {
            con = new SqlConnection();
            con.ConnectionString = @"server=.\sqlexpress;database=thu;integrated security=true";
            con.Open();
        }
        
    }
}
