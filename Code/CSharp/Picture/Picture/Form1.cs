using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.XPath;
using System.Xml.Linq;
using System.Xml;

namespace Picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        string filename;
        string filename2;
      //load anh len picture box 
        public void loadcombobox()
        {
            SqlCommand cmd1 = new SqlCommand();
            ket_noi kn1 = new ket_noi();
            kn1.ketnoi();
            cmd1.Connection = kn1.con;
            SqlDataAdapter da = new SqlDataAdapter("SELECT Name FROM DataImage", kn1.con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Name";
            string str = comboBox1.Text;
            string fbPath = Application.StartupPath + "\\Images\\" + str;
            if(comboBox1.Text!="")
            pictureBox1.Image = Image.FromFile(fbPath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All File (*.*)|*.*|JPG Files(*.JPG)|*.JPG | GIF Files(*.GIF)|*.GIF";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dlg.FileName);
                filename = dlg.FileName;
                textBox1.Text = filename.Split('\\').Last();
                filename2 = textBox1.Text;
            }
        }
        //luu anh tu picture box filename2 luu dc duog dan anh
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                ket_noi kn = new ket_noi();
                kn.ketnoi();
                cmd.Connection = kn.con;
                
                SqlDataAdapter da = new SqlDataAdapter("SELECT Count(*) FROM DataImage ", kn.con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                string str = dt.Rows[0][0].ToString();
                int a = Convert.ToInt32(str);
                string fbPath = Application.StartupPath + "\\Images\\" + filename2;
                string str2 = "capnhat";
                SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM DataImage ", kn.con);
                DataTable dt2 = new DataTable();
                dt2.Clear();
                da2.Fill(dt2);
                for (int i = 0; i < a; i++)
                {
                    if (this.textBox1.Text == dt2.Rows[i][1].ToString())
                    {
                            MessageBox.Show("Anh da co trong data!");
                            str2 = "capnhat2";
                            //File.Replace(filename,fbPath,true);
                            //File.Copy(filename, fbPath, true);
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "Update DataImage Set Name=@Name, Image=@Image Where Name='"+textBox1.Text+"'";
                            cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = textBox1.Text.ToString();
                            cmd.Parameters.Add("@Image", SqlDbType.NVarChar).Value = fbPath.ToString();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Đã thêm xong!");
                            break;
                    }
                }

                if (str2 == "capnhat")
                {
                    File.Copy(filename, fbPath, true); 
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert Into DataImage(Name,Image) Values(@Name,@Image) ";
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = textBox1.Text.ToString();
                    cmd.Parameters.Add("@Image", SqlDbType.NVarChar).Value = fbPath.ToString();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm xong!");

                }
                kn.huykn();
                //XDocument xmlDoc = XDocument.Load("data.xml");

                //xmlDoc.Element("DataImages").Add(new XElement("Picture", new XAttribute("Name", textBox1.Text),
                //                                                       new XElement("Image", textBox1.Text)));

                //xmlDoc.Save("data.xml");
                loadcombobox();
                
            }
            catch (SqlException ie)
            {
                MessageBox.Show("Không thêm được. Lỗi rồi!"+ie);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //string fbPath = Application.StartupPath + "\\Images\\" + filename2;
                //MessageBox.Show(fbPath);
                string str = comboBox1.Text;
                string fbPath = Application.StartupPath + "\\Images\\" + str;
                pictureBox1.Image = Image.FromFile(fbPath);
            }
            catch { MessageBox.Show("loi roi"); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadcombobox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                ket_noi kn = new ket_noi();
                kn.ketnoi();
                cmd.Connection = kn.con;
                cmd.CommandType = CommandType.Text;
                
                cmd.CommandText = System.String.Concat("Delete From DataImage Where Name='" + comboBox1.Text + "'");
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                string str = comboBox1.Text;
                string fbPath = Application.StartupPath + "\\Images\\" + str;
                File.Delete(fbPath);
                //if (Directory.Exists(Path.GetDirectoryName(fbPath)))
                //{
                //    File.Delete(fbPath);
                //}
                loadcombobox();
                MessageBox.Show("Đã xóa xong!");

            }
            catch
            { MessageBox.Show("loi roi"); }
        }
    }
}
