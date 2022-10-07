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
using LTND;

namespace LOADSAVEIMAGE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Open image
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File (*.jpg;*.jpge;*.bmp;*.gif)|*.jpg;*.bmp;*.gif;*.jpge;";
            openFileDialog1.ShowDialog();
            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                textBox1.Text = openFileDialog1.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromFile(textBox1.Text);
            }
        }
        #endregion
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("ĐƯờng dẫn ảnh không được trống.");
                return;
            }

            if (File.Exists(textBox1.Text)==false)
            {
                MessageBox.Show("ĐƯờng dẫn ảnh không tồn tại.");
                return;
            }
            if (MessageBox.Show("Bạn muốn lưu file ảnh " + textBox1.Text + " vào CSDL?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SaveImage(textBox1.Text,textBox2.Text);
            }
        }

        

#region Data event
        private void LoadImageIntoCbo()
        {
            //comboBox1.Items.Clear();

            LTND.BaseObject b = new LTND.BaseObject();
            comboBox1.DataSource = b.ExecDataTable("select ID,PicName from ltnd_STORE_IMG", null);
            comboBox1.DisplayMember = "PicName";
            comboBox1.ValueMember = "ID";
        }

        private void SaveImage(string file, string id)
        {
            FileStream fs= new FileStream(file, FileMode.Open, FileAccess.Read);

            byte[] picbyte = new byte[fs.Length];

            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));

            fs.Close();

            string query = "insert into ltnd_STORE_IMG(id, picname, pic) values(@id,@picname, @pic)";

            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@id", id);
            para[1]= new SqlParameter("@picname",file.Substring(file.LastIndexOf("\\")));

            para[2] = new SqlParameter("@pic",picbyte);
            para[2].SqlDbType = SqlDbType.Image;
            BaseObject b = new BaseObject();
            try
            {
                b.ExcuteUpdateCommand(query, para);
                LoadImageIntoCbo();
                MessageBox.Show("Đã lưu thành công.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra do"+ ex.Message +".");
            }
            

        }

        private void LoadImage(string ID_IMG)
        {
            if (pictureBox2.Image != null)
            {
                pictureBox2.Image.Dispose();
            }

            BaseObject b = new BaseObject();
            DataTable tbl = b.ExecDataTable("select pic from ltnd_STORE_IMG where ID="+ID_IMG, null);

            if (tbl != null && tbl.Rows.Count>0)
            {
                FileStream FS1 = new FileStream("image.jpg", FileMode.Create);
                byte[] blob = (byte[])tbl.Rows[0]["pic"];
                FS1.Write(blob, 0, blob.Length);
                FS1.Close();
                FS1 = null;
                pictureBox2.Image = Image.FromFile("image.jpg");
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Refresh();
            }

        }
#endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadImageIntoCbo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue!=null)
                LoadImage(comboBox1.SelectedValue.ToString());
        }
    }
}
