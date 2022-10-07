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

namespace ImageInSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AccessData ac=new AccessData();
        private string filename;
        private int i ;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter ="All File (*.*)|*.*|JPG Files(*.JPG)|*.JPG | GIF Files(*.GIF)|*.GIF";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dlg.FileName);
                filename = dlg.FileName;
                blFileName.Text = filename.Split('\\').Last();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ac.StorePicture(filename);
                MessageBox.Show("Successful!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            byte[] img = ac.RetrieveImage(1);
            MemoryStream str = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(str);
            i = 1;
            button5.Enabled = false;
            button3.Enabled = true;
            blFileName.Text = ac.FileNameOfImage(1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            byte[] img = ac.RetrieveImage(ac.NumberImageInDB());
            MemoryStream str = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(str);
            i = ac.NumberImageInDB();
            button3.Enabled = false;
            button5.Enabled = true;
            blFileName.Text = ac.FileNameOfImage(ac.NumberImageInDB());
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            if (i < ac.NumberImageInDB()) i++;
            else button3.Enabled = false;
            byte[] img = ac.RetrieveImage(i);
            MemoryStream str = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(str);
            blFileName.Text = ac.FileNameOfImage(i);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            if (i >1) i--;
            else button5.Enabled = false;
            byte[] img = ac.RetrieveImage(i);
            MemoryStream str = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(str);
            blFileName.Text = ac.FileNameOfImage(i);
        }
        
    }
}
