using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testlinq
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string str="";
        private void Form2_Load(object sender, EventArgs e)
        {
            QLTVEntities1 context = new QLTVEntities1();
            var query = from ls in context.LoaiSaches select ls;
            dataGridView1.DataSource = query.ToList();

            try
            {
                textBox1.Text = Convert.ToString(dataGridView1.Rows[0].Cells[0].Value);
                textBox2.Text = Convert.ToString(dataGridView1.Rows[0].Cells[1].Value);
            }
            catch
            { }
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button4.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            str = "Insert";
            textBox1.Text = "";
            textBox2.Text = "";
            
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
            button3.Enabled = true;
            button5.Enabled = true;
            textBox2.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            QLTVEntities1 context = new QLTVEntities1();
            LoaiSach lsach = new LoaiSach();
            if (str == "Insert")
            {
                
                lsach.LoaiSach_Ten = textBox2.Text.ToString();
                context.LoaiSaches.AddObject(lsach);
            }
            if (str == "Edit")
            {
                int tg = int.Parse(textBox1.Text);
                var loaisach = context.LoaiSaches.Single(p => p.LoaiSach_Ma == tg);
                loaisach.LoaiSach_Ten = textBox2.Text.ToString();
            }
            context.SaveChanges();
            Form2_Load(sender, e);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                try
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    //pictureBox2.Image = row.Cells[4].Value.GetType() ;
                    textBox1.Text = Convert.ToString(row.Cells[0].Value);
                    textBox2.Text = Convert.ToString(row.Cells[1].Value);
                    

                }
                catch { }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int tg = int.Parse(textBox1.Text);
                QLTVEntities1 context = new QLTVEntities1();
                var loaisach = context.LoaiSaches.Single(p => p.LoaiSach_Ma == tg);
                context.DeleteObject(loaisach);
                context.SaveChanges();
                Form2_Load(sender, e);
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            str = "Edit";
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
            button3.Enabled = true;
            button5.Enabled = true;
            textBox2.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
