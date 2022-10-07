using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.IO;


namespace TuDienAV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hashtable ha = new Hashtable();

        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                //string ds = textBox1.Text;
                //string ng = textBox2.Text;
                //listBox2.Items.Add(ds);
                //ha.Add(ds, ng);
                //MessageBox.Show(ha[ds].ToString());
                //this.comboBox1.Items.AddRange(new object[] { ds });
                //ketnoi.ket_noi();
                if (textBox2.Text != "")
                {
                    SqlCommand cmd = new SqlCommand();
                    ketnoi kn = new ketnoi();
                    kn.ket_noi();
                    string sql = "";
                    sql = "INSERT INTO dataanhviet( tu, nghia) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "')";
                    cmd.Connection = kn.con;

                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    hienthi();
                    hienthi2();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox1.Focus();
                    //MessageBox.Show("add complete", "insert thanh cong",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                MessageBox.Show("nhap sai!");
            }
            catch (Exception ie)
            {
                MessageBox.Show("hay nhap tu can them!"+ie);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void hienthi()
        {
            SqlCommand cmd1 = new SqlCommand();
            ketnoi kn1 = new ketnoi();
            kn1.ket_noi();
            cmd1.Connection = kn1.con;
            SqlDataAdapter da = new SqlDataAdapter("SELECT tu FROM dataanhviet", kn1.con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "tu";
            
            
        }
        public void hienthi2()
        {
            ketnoi kn2 = new ketnoi();
            SqlCommand cmd2 = new SqlCommand();
            
            kn2.ket_noi();
            cmd2.Connection = kn2.con;
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT tu FROM dataanhviet", kn2.con);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            DataTable dt2 = new DataTable("tu");
            da2.Fill(dt2);
            listBox2.DataSource = ds2.Tables[0];
            listBox2.DisplayMember = "tu";
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //string str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\db.mdb";
            //OleDbConnection conn = new OleDbConnection(str);
            //string sql = @"Select * from tbEX";
            //conn.Open();
            //OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
            //DataSet ds = new DataSet();
            //da.Fill(ds, "tbEX");
            //DataTable dtEx = ds.Tables["tbEX"];
            //conn.Close();
            /// gán kế quả và hiển thị
            //this.comboBox1.DataSource = dtEx;
            //comboBox1.DisplayMember = "Name";
            //ketnoi.ket_noi();
            
            this.hienthi();
            this.hienthi2();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand();
            ketnoi kn1 = new ketnoi();
            kn1.ket_noi();
            cmd1.Connection = kn1.con;
            SqlDataAdapter da = new SqlDataAdapter("SELECT tu FROM dataanhviet", kn1.con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "tu";
            listBox1.Text = "";
            listBox1.Items.Add(ha[comboBox1.Text].ToString());
            SqlCommand cmd3 = new SqlCommand();
            ketnoi kn3 = new ketnoi();
            kn3.ket_noi();
            cmd3.Connection = kn3.con;
            SqlDataAdapter da3 = new SqlDataAdapter("SELECT nghia FROM dataanhviet WHERE tu='"+comboBox1.Text+"'", kn3.con);
            DataSet ds3 = new DataSet();
            da3.Fill(ds3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            listBox1.DataSource = ds3.Tables[0];
            listBox1.DisplayMember = "nghia";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand();
            ketnoi kn3 = new ketnoi();
            kn3.ket_noi();
            cmd3.Connection = kn3.con;
            SqlDataAdapter da3 = new SqlDataAdapter("SELECT nghia,tu FROM dataanhviet WHERE tu='" + listBox2.Text + "'", kn3.con);
            DataSet ds3 = new DataSet();
            da3.Fill(ds3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            listBox1.DataSource = ds3.Tables[0];
            listBox1.DisplayMember = "nghia";
            comboBox1.DataSource = ds3.Tables[0];
            comboBox1.DisplayMember = "tu";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                
                ketnoi kn = new ketnoi();
                kn.ket_noi();
                string sql = "";
                sql = "DELETE FROM dataanhviet WHERE tu='"+comboBox1.Text+"'";
                cmd.Connection = kn.con;

                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                
                //MessageBox.Show("Delete thanh cong!");
                hienthi();
                hienthi2();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
            catch (Exception ie)
            {
                MessageBox.Show("Delete 0 thanh cong!" + ie);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                ketnoi kn = new ketnoi();
                kn.ket_noi();
                string sql = "";
                sql = "UPDATE dataanhviet SET tu='"+textBox1.Text+"',nghia='"+textBox2.Text+"' WHERE tu='" + comboBox1.Text + "'";
                cmd.Connection = kn.con;

                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                //MessageBox.Show("Edit thanh cong!");
                hienthi();
                hienthi2();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
            catch (Exception ie)
            {
                MessageBox.Show("Edit 0 thanh cong!" + ie);
            }
        }
    }
}
