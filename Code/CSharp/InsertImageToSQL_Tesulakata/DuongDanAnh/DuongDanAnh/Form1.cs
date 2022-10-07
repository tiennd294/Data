using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace DuongDanAnh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string imagename;
        SqlDataAdapter empadap1;
        DataSet dset;

        private void button2_Click(object sender, EventArgs e)
        {
            //update
            try
            {

                if (imagename != "")
                {
                    FileStream fs;
                    fs = new FileStream(@imagename, FileMode.Open, FileAccess.Read);

                    byte[] picbyte = new byte[fs.Length];
                    fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
                    fs.Close();
         string connstr = "server=(local);database=TestImage;user=sa;password=sa";
                    SqlConnection conn = new SqlConnection(connstr);
                    conn.Open();
                    string querry;
                    querry = "insert into test_tabel(id_Image,pic)values(" + textBox1.Text + "," + "@pic)";
                    SqlParameter picparemeter = new SqlParameter();
                    picparemeter.SqlDbType = SqlDbType.Image;
                   
                    picparemeter.ParameterName = "pic";
                    picparemeter.Value = picbyte;
                    SqlCommand cmd = new SqlCommand(querry, conn);
                    cmd.Parameters.Add(picparemeter);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Image add succesffull");

                    cmd.Dispose();
                    conn.Close();
                    conn.Dispose();
                    connection1();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void connection1()
        {
            try
            {
                string connstr = "server=(local);database=TestImage;user=sa;password=sa";
                SqlConnection conn = new SqlConnection(connstr);
                conn.Open();
                empadap1 = new SqlDataAdapter();
                empadap1.SelectCommand = new SqlCommand("select*from test_tabel", conn);
                dset = new DataSet("dset");
                empadap1.Fill(dset);
                DataTable dtable;
                dtable = dset.Tables[0];
                comboBox1.Items.Clear();
                foreach (DataRow drow in dtable.Rows)
                {
                    comboBox1.Items.Add(drow[0].ToString());
                    comboBox1.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try{
                FileDialog dldlg= new OpenFileDialog();
                dldlg.InitialDirectory=@":D\";
                dldlg.Filter="Image File(*.jpg;*.bmp;*.gif)|*jpg;*bmp;*gif";
                if(dldlg.ShowDialog()==DialogResult.OK)
                {
                    imagename= dldlg.FileName;
                    Bitmap newimg= new Bitmap(imagename);
                    pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image=(Image)newimg;
                }
                dldlg=null;
              
               }
            catch(System.ArgumentException ae)
            {
                imagename=" ";
                MessageBox.Show(ae.Message.ToString());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable datatable = dset.Tables[0];
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
    }
}
