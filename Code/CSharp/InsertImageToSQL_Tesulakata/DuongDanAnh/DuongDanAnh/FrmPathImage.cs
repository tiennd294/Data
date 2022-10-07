using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Khai bao thu vien
using System.IO;
using System.Data.SqlClient;

namespace DuongDanAnh
{
    public partial class FrmPathImage : Form
    {
        public FrmPathImage()
        {
            InitializeComponent();
        }
        // Bien dung chung

        string tenanh;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        string chuoi;

        private void moketnoi()
        {
            try
            {
                string ketnoi = "server=(local);database=csdl;user=sa;password=sa";
                con = new SqlConnection(ketnoi);
                con.Open();


                chuoi = "select*from csdl_anh";
                cmd = new SqlCommand();

                da = new SqlDataAdapter(chuoi, con);
                ds = new DataSet();
                da.Fill(ds);

                DataTable dat = new DataTable();
                dat = ds.Tables[0];
                comboBox1.Items.Clear();

                foreach (DataRow dr in dat.Rows)
                {
                    comboBox1.Items.Add(dr[0].ToString());
                    comboBox1.SelectedIndex = 0;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }




        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // dua file anh vao csdl
            try
            {
                if (tenanh != "")
                {
                    FileStream frm;
                    frm = new FileStream(@tenanh, FileMode.Open, FileAccess.Read);

                    byte[] picbyte = new byte[frm.Length];
                    frm.Read(picbyte, 0, System.Convert.ToInt32(frm.Length));
                    frm.Close();
                    // ketnoi
                    string ketnoi = "server=(local);database=csdl;user=sa;password=sa";
                    con = new SqlConnection(ketnoi);
                    con.Open();

                    chuoi = "insert into csdl_anh(Name) values(@pic)";

                    SqlParameter picpara = new SqlParameter();
                    picpara.SqlDbType = SqlDbType.Image;
                    picpara.ParameterName = "pic";
                    picpara.Value = picbyte;

                    cmd = new SqlCommand(chuoi, con);
                    cmd.Parameters.Add(picpara);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Image added succesfull");

                    cmd.Dispose();
                    con.Dispose();


                    moketnoi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Mo thu muc. Tim den file anh can load 
            try
            {
                FileDialog fdg = new OpenFileDialog();
                fdg.InitialDirectory = @"d:\";
                fdg.Filter = "File anh(*.jpg;*.bmp;*.gif)|*jpg;*bmp;*gif";
                if (fdg.ShowDialog() == DialogResult.OK)
                {
                    tenanh = fdg.FileName;
                    Bitmap anh = new Bitmap(tenanh);
                    //  pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.Image = (Image)anh;
                    toolStripStatusLabel1.Text = "Đường dẫn file ảnh : " + tenanh;
                    textBox1.Text = tenanh;
                    button2.Visible = true;
                }
                fdg = null;
            }
            catch (Exception ex)
            {
                tenanh = " ";
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable datatable = ds.Tables[0];
            if (pictureBox2.Image != null)
            {
                pictureBox2.Image.Dispose();
            }
            FileStream fs1 = new FileStream("image.jpg", FileMode.Create);
            foreach (DataRow datarow in datatable.Rows)
            {
                if (datarow[0].ToString() == comboBox1.SelectedItem.ToString())
                {
                    byte[] blob = (byte[])datarow[1];
                    fs1.Write(blob, 0, blob.Length);
                    fs1.Close();
                    fs1 = null;
                    pictureBox2.Image = Image.FromFile("image.jpg");
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox2.Refresh();


                }
            }
        }

        private void FrmPathImage_Load(object sender, EventArgs e)
        {
            moketnoi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon thoat ko?", "Thoat chuong trinh", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
            else
                MessageBox.Show("Do cui` bap'. \n \n Nhan thoat rui ma ko thoat luon di \n \n \n \n Vay thi tiep tuc heng, do` cui` bap'\n \n \n \n \n Tac gia chuong trinh :Tesulakata");

        }

        private void FrmPathImage_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Vinh biet ke ngoc nghech, chuc ke ngoc nghech co mot ngay vui ve");
        }
    }
}


       






