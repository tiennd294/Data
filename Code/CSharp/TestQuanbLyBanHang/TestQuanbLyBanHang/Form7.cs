using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestQuanbLyBanHang
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        public bool Them;
        public void loaddata2()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                ketnoi kn = new ketnoi();
                kn.ket_noi();
                cmd.Connection = kn.con;
                               
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NhanVien", kn.con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                // Đưa dữ liệu lên DataGridView
                dataGridView1.DataSource = dt;
                // Thay đổi độ rộng cột
                dataGridView1.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.textBox1.ResetText();
                this.textBox2.ResetText();
                this.textBox3.ResetText();
                this.textBox4.ResetText();
                this.textBox5.ResetText();
                this.comboBox1.ResetText();
                this.maskedTextBox1.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
                
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnTroVe.Enabled = true;

                // Không cho thao tác trên Panel
                this.groupBox1.Enabled = false;

            }
            catch
            { }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            loaddata2();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            loaddata2();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.textBox1.ResetText();
            this.textBox2.ResetText();
            this.textBox3.ResetText();
            this.textBox4.ResetText();
            this.textBox5.ResetText();
            this.comboBox1.ResetText();
            this.maskedTextBox1.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.groupBox1.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;
            // Đưa con trỏ đến TextField txtThanhPho
            this.textBox1.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Them = false;
                // Cho phép thao tác trên Panel this.panel.Enabled = true;
                // Thứ tự dòng hiện hành
                int r = dataGridView1.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel 
                this.textBox1.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
                this.textBox2.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
                this.textBox3.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
                this.textBox4.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();
                this.textBox5.Text = dataGridView1.Rows[r].Cells[6].Value.ToString();
                this.comboBox1.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
                this.maskedTextBox1.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
                // Cho thao tác trên các nút Lưu / Hủy / Panel
                this.btnLuu.Enabled = true;
                this.btnHuyBo.Enabled = true;
                this.groupBox1.Enabled = true;
                // Không cho thao tác trên các nút Thêm / Xóa / Thoát
                this.btnThem.Enabled = false;
                this.btnSua.Enabled = false;
                this.btnXoa.Enabled = false;
                this.btnTroVe.Enabled = false;
                // Đưa con trỏ đến TextField txtMaKH
                this.textBox1.Focus();
            }
            catch { }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            ketnoi kn = new ketnoi();
            kn.ket_noi();
            cmd.Connection = kn.con;
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    string tg = maskedTextBox1.Text.ToString();
                    //DateTime ctg = Convert.ToDateTime(tg);
                    cmd.CommandType = CommandType.Text;
                    // Lệnh Insert InTo
                    cmd.CommandText = System.String.Concat("Insert Into NhanVien(MaNV, Ho, Ten, Nu, NgayNV, DiaChi, DienThoai) Values(" + "'" + this.textBox1.Text.ToString() + "','" + this.textBox2.Text.ToString() + "','" + this.textBox3.Text.ToString() + "','" + this.comboBox1.Text.ToString() + "','" + Convert.ToDateTime(tg)+ "','"+this.textBox4.Text.ToString()+"','"+this.textBox5.Text.ToString()+"')");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    // Load lại dữ liệu trên DataGridView
                    loaddata2();
                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");
                }
                catch 
                {
                    
                }
            }
            if (!Them)
            {
                try
                {
                    // Thực hiện lệnh
                    string tg = maskedTextBox1.Text.ToString();
                    cmd.CommandType = CommandType.Text;
                    // Thứ tự dòng hiện hành
                    int r = dataGridView1.CurrentCell.RowIndex;
                    // MaKH hiện hành 
                    string str = dataGridView1.Rows[r].Cells[0].Value.ToString();
                    // Câu lệnh SQL
                    cmd.CommandText = System.String.Concat("Update NhanVien Set Ho='" + this.textBox2.Text.ToString() + "',Ten='" + this.textBox3.Text.ToString() + "', Nu='" + this.comboBox1.Text.ToString() + "', NgayNV='" + Convert.ToDateTime(tg) + "', DiaChi= '" + this.textBox4.Text.ToString() + "', DienThoai= '" + this.textBox5.Text.ToString() + "'  Where MaNV='" + str + "'");
                    // Cập nhật

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    // Load lại dữ liệu trên DataGridView
                    loaddata2();
                    // Thông báo
                    MessageBox.Show("Đã sửa xong!");
                }
                catch { }
            }
            // Đóng kết nối
            kn.con.Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTroVe.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
            this.groupBox1.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                ketnoi kn = new ketnoi();
                kn.ket_noi();
                cmd.Connection = kn.con;
                cmd.CommandType = CommandType.Text;
                // Lấy thứ tự record hiện hành
                int r = dataGridView1.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string str = dataGridView1.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL
                cmd.CommandText = System.String.Concat("Delete From NhanVien Where MaNV='" + str + "'");
                cmd.CommandType = CommandType.Text;
                // Thực hiện câu lệnh SQL
                cmd.ExecuteNonQuery();
                // Cập nhật lại DataGridView
                loaddata2();
                // Thông báo
                MessageBox.Show("Đã xóa xong!");

            }
            catch
            { }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
