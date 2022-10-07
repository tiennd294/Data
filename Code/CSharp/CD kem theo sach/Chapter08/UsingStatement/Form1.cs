using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UsingStatement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {            
            string strCon = "server=(local);";
            strCon += "database=northwind;";
            strCon += "uid=sa;pwd=sa;";
            using (SqlConnection Con = new SqlConnection(strCon))
            {
                SqlCommand Com;
                Com = new SqlCommand();
                Con.Open();
                Com.Connection = Con;
                string SQL = "Select top 15 CustomerID,";
                SQL += "CompanyName,Country from Customers";
                Com.CommandText = SQL;
                using (SqlDataReader dr = Com.ExecuteReader())
                {
                    LV.Columns.Add("ID", 50, 0);
                    LV.Columns.Add("Name", 150, 0);
                    LV.Columns.Add("Country", 50, 0);
                    while (dr.Read())
                    {
                        ListViewItem lvi;
                        lvi = new ListViewItem(dr.GetString(0));
                        lvi.SubItems.Add(dr.GetString(1));
                        lvi.SubItems.Add(dr.GetString(2));
                        LV.Items.Add(lvi);
                    }
                    dr.Close();
                }
            }
        }
    }
}