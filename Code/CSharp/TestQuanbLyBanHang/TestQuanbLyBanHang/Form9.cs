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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        public bool Them2;
        public void loaddata2()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                ketnoi kn = new ketnoi();
                kn.ket_noi();
                cmd.Connection = kn.con;

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ChiTietHoaDon", kn.con);
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
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
                //this.panel.Enabled = false;
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

        public void hienthi()
        {
            SqlCommand cmd1 = new SqlCommand();
            ketnoi kn1 = new ketnoi();
            kn1.ket_noi();
            cmd1.Connection = kn1.con;
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaSP, MaHD FROM SanPham, HoaDon", kn1.con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "MaHD";
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "MaSP";

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            loaddata2();
            hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them2 = true;
            // Xóa trống các đối tượng trong Panel
            this.textBox1.ResetText();
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
            this.textBox2.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Them2 = false;
                // Cho phép thao tác trên Panel this.panel.Enabled = true;
                // Thứ tự dòng hiện hành
                int r = dataGridView1.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel 
                this.textBox2.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
                this.textBox1.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
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
                this.textBox2.Focus();
            }
            catch { }
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            loaddata2();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            ketnoi kn = new ketnoi();
            kn.ket_noi();
            cmd.Connection = kn.con;
            if (Them2)
            {
                try
                {
                    // Thực hiện lệnh

                    cmd.CommandType = CommandType.Text;
                    // Lệnh Insert InTo
                    cmd.CommandText = System.String.Concat("Insert Into ChiTietHoaDon(MaCT ,MaHD, MaSP, SoLuong) Values("+"'"+this.textBox2.Text.ToString()+"','"+comboBox1.Text.ToString()+"','"+comboBox2.Text.ToString()+"','" + this.textBox1.Text.ToString() + "')");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    // Load lại dữ liệu trên DataGridView
                    loaddata2();
                    // Thông báo
                    //MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            if (!Them2)
            {
                // Thực hiện lệnh

                cmd.CommandType = CommandType.Text;
                // Thứ tự dòng hiện hành
                int r = dataGridView1.CurrentCell.RowIndex;
                // MaKH hiện hành 
                string str = dataGridView1.Rows[r].Cells[0].Value.ToString();
                // Câu lệnh SQL
                int text = Convert.ToInt32(comboBox1.Text.ToString());
                int text2 = Convert.ToInt32(comboBox2.Text.ToString());
                cmd.CommandText = System.String.Concat("Update ChiTietHoaDon Set MaHD='" + text + "', MaSP='" + text2 + "', SoLuong='" + this.textBox1.Text.ToString() + "' WHERE MaCT='"+str+"'" );
                // Cập nhật

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                // Load lại dữ liệu trên DataGridView
                loaddata2();
                // Thông báo
                //MessageBox.Show("Đã sửa xong!");
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
                cmd.CommandText = System.String.Concat("Delete From ChiTietHoaDon Where MaCT='" + str + "'");
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
