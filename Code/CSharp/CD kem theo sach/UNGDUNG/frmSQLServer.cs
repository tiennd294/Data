using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Data.SqlClient ;
using System.Drawing;
using System.Windows.Forms;

namespace UNGDUNG
{
    public partial class frmSQLServer : Form
    {
        public frmSQLServer()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListViewItem liv = lvData.FocusedItem;
            string name = liv.SubItems[1].Text;
            if (MessageBox.Show("Are you sure to backup " + name, "C# 2005", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (BackupDatabase(name, comboBox1.Text, textBox1.Text, textBox2.Text))
                {
                    MessageBox.Show(name + " was backup");                    
                }
            }
        }
        #region BienDungChung
            protected string strCon="";
            private string strSQL = "";
        #endregion
        private void frmSQLServer_Load(object sender, EventArgs e)
        {
            #region Columns
                lvData.View = View.Details;
                lvData.Columns.Add("Stt", 30);
                lvData.Columns.Add("Name", 150);
                lvData.Columns.Add("Created", 100);
                lvData.Columns.Add("Path", 200);
                lvData.Columns.Add("Size", 100);
             #endregion
            ShowDatabase(comboBox1.Text, textBox1.Text, textBox2.Text, radioButton1.Checked);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowDatabase(comboBox1.Text, textBox1.Text, textBox2.Text,radioButton1.Checked );
        }
        /// <summary>
        /// Liet ke danh sach database name
        /// </summary>
        /// <param name="servername"></param>
        /// <param name="userid"></param>
        /// <param name="password"></param>
        /// <param name="MDF"></param>
        void ShowDatabase(string servername, string userid, string password, bool MDF)
        {
            lvData.Items.Clear();
            #region Const
                strSQL = "select S.name, crdate,F.filename,size ";
                strSQL+="from master.dbo.sysdatabases S, ";
                strSQL += " sysaltfiles F where S.dbid=F.dbid and fileid=" ;
                if (MDF)
                    strSQL += ((short)myConst.MDF).ToString();
                else
                    strSQL += ((short)myConst.LDF).ToString();
            #endregion
            #region Connection
                strCon = "server=" + servername +";";
                strCon += "database=master";
                strCon += ";uid=" + userid;
                strCon += ";pwd=" + password + ";";
            #endregion
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = strCon;
            SqlCommand Com;
            Com = new SqlCommand(strSQL, Con);
            #region UseTryCatch
                try
                {
                    SqlDataReader dr;
                    Con.Open();
                    dr = Com.ExecuteReader();
                    ListViewItem item1;
                    int i = 1;
                    while (dr.Read())
                    {
                        item1 = new ListViewItem(i.ToString());
                        item1.SubItems.Add(dr[0].ToString());
                        #region ConvertDataType
                        item1.SubItems.Add(((DateTime)dr[1]).ToLongDateString());
                        #endregion
                        item1.SubItems.Add((string)dr[2]);
                        
                        
                        item1.SubItems.Add(dr[3].ToString());
                        lvData.Items.Add(item1);
                        i++;
                    }


                    dr.Close();
                    dr.Dispose();
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    if (Con.State != ConnectionState.Closed)
                    {
                        Con.Close();
                    }
                }
                finally
                {
                    Con.Dispose();
                }
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmInput();
            frm.Text = "New Database";
            frm.ShowDialog(this);
            string newname = Class1.strInput;
            if (newname!="")
            {
                if (CheckDatabase(newname, comboBox1.Text, textBox1.Text, textBox2.Text))
                   
                { 
                    MessageBox.Show(newname + " was created");
                    ShowDatabase(comboBox1.Text, textBox1.Text, textBox2.Text, radioButton1.Checked);
                }
                else
                    MessageBox.Show(newname + " is existing");
                
            }
           
        }
        bool DeleteDatabase(string name, string servername, string userid, string password)
        {
            bool delete = false;
            strSQL = " drop database " + name ;
            strCon = "server=" + servername + ";";
            strCon += "database=master";
            strCon += ";uid=" + userid;
            strCon += ";pwd=" + password + ";";
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = strCon;
            SqlCommand Com;
            Com = new SqlCommand(strSQL, Con);
            try
            {
                Con.Open();
                Com.ExecuteNonQuery() ;
                delete = true;
                Con.Close();
            }
            catch (Exception ex)
            {
                if (Con.State != ConnectionState.Closed)
                {
                    Con.Close();
                }
                
            }
            finally
            {
                Con.Dispose();
            }
            return delete;
        }

        bool CheckDatabase(string name, string servername, string userid, string password)
        {
            bool exist=false;            
            strSQL = "select  name from master.dbo.sysdatabases   ";
            strSQL += " where name = '" + name  +"'";            
            strCon = "server=" + servername +";";
            strCon += "database=master";
            strCon += ";uid=" + userid;
            strCon += ";pwd=" + password + ";";
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = strCon;
            SqlCommand Com;
            Com = new SqlCommand(strSQL, Con);
            try
            {                
                Con.Open();
                exist=(Com.ExecuteScalar()== null)  ;
                if (exist)
                {
                    strSQL = "create database [" + name + "]";
                    Com = new SqlCommand(strSQL, Con);
                    Com.ExecuteNonQuery();
                }
                Con.Close();
            }
            catch (Exception ex)
            {                 
                if (Con.State != ConnectionState.Closed)
                {
                    Con.Close();
                }
                exist = false;
            }
            finally
            {
                Con.Dispose();
            }
            return exist;
        }
        bool BackupDatabase(string name, string servername, string userid, string password)
        {
            bool exist = false;
            strSQL = "select  name from master.dbo.sysdevices   ";
            strSQL += " where name = '" + name + "'";
            strCon = "server=" + servername + ";";
            strCon += "database=master";
            strCon += ";uid=" + userid;
            strCon += ";pwd=" + password + ";";
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = strCon;
            SqlCommand Com;
            Com = new SqlCommand(strSQL, Con);
            try
            {
                Con.Open();
                exist = (Com.ExecuteScalar() == null);
                if (exist)
                {
                    strSQL = "sp_addumpdevice 'Disk', '" + name + "', 'D:\\"+name+".bk'";
                    Com = new SqlCommand(strSQL, Con);
                    Com.ExecuteNonQuery();
                }
                strSQL = "BACKUP DATABASE  " + name + " to " + name ;
                Com = new SqlCommand(strSQL, Con);
                Com.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception ex)
            {
                if (Con.State != ConnectionState.Closed)
                {
                    Con.Close();
                }
                exist = false;
            }
            finally
            {
                Con.Dispose();
            }
            return exist;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem liv = lvData.FocusedItem;
            string name = liv.SubItems[1].Text;
            if (MessageBox.Show("Are you sure to delete " + name, "C# 2005", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
               if(DeleteDatabase(name, comboBox1.Text, textBox1.Text, textBox2.Text))
                {
                    MessageBox.Show(name + " was deleted");
                    lvData.Items.Remove(liv);
                }
            }
        }
        bool RenameDatabase(string name, string newname, string servername, string userid, string password)
        {
            bool rename = false;
            strSQL = " sp_renamedb @dbname = '" + name + "', @newname ='" + newname + "'";
            strCon = "server=" + servername + ";";
            strCon += "database=master";
            strCon += ";uid=" + userid;
            strCon += ";pwd=" + password + ";";
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = strCon;
            SqlCommand Com;
            Com = new SqlCommand(strSQL, Con);
            try
            {
                Con.Open();
                Com.ExecuteNonQuery();
                rename = true;
                Con.Close();
            }
            catch (Exception ex)
            {
                if (Con.State != ConnectionState.Closed)
                {
                    Con.Close();
                }

            }
            finally
            {
                Con.Dispose();
            }
            return rename;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ListViewItem liv = lvData.FocusedItem;
            string name = liv.SubItems[1].Text;
            Form frm = new frmInput();
            frm.Text = "New Name of Database";
            frm.ShowDialog(this);
            string newname = Class1.strInput;
            if (newname != "")
            {
                if (MessageBox.Show("Are you sure to reaname " + name + " to name " + newname, "C# 2005", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (RenameDatabase(name, newname, comboBox1.Text, textBox1.Text, textBox2.Text))
                    {
                        MessageBox.Show(name + " was rename to " + newname);
                        ShowDatabase(comboBox1.Text, textBox1.Text, textBox2.Text, radioButton1.Checked);
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}