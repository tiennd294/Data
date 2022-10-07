using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ketnoicsdl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public SqlConnection con;

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = @"server=.\sqlexpress;database=thu;uid='"+txt_user.Text+"';pwd='"+txt_pass.Text+"'";
                con.Open();//lon voi he thong
                MessageBox.Show("dang nhap he thong thanh cong");//a chi demo tren tai khoan he thong
                // chua demo tren bang du lieu sang roi a ngu day mai con lam viec nua 
                //vag a co gi mai a chi cho ket noi toi bang trong database do la bang info co 2 tai khaon la a va e do
                //vag good nght
                // angu ngon bye

            }
            catch (Exception ie)
            {
                MessageBox.Show("loi "+ie);
            }
        }
    }
}
