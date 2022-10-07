using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace TuDienAV
{
    class ketnoi
    {
         
        public  SqlConnection con;
        public void ket_noi()
        {
            try
            {
               con=new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=tudien;Integrated Security=True");
               con.Open();
                
            }
            catch 
            {
                MessageBox.Show("ket noi that bai!");
                
            }
        }

    }
}
