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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public bool Them;
        public void loaddata()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                ketnoi kn = new ketnoi();
                kn.ket_noi();
                cmd.Connection = kn.con;
                
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ThanhPho", kn.con);
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
                this.groupBox1.Enabled = false;

            }
            catch
            { }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Dispose(); 
            dt = null;
            ketnoi kn = new ketnoi();
            kn.con = null;
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.textBox1.ResetText();
            this.textBox2.ResetText();
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
            Them = false;
            // Cho phép thao tác trên Panel this.panel.Enabled = true;
            // Thứ tự dòng hiện hành
            int r = dataGridView1.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.textBox1.Text = dataGridView1.Rows[r].Cells[0].Value.ToString(); 
            this.textBox2.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
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
                string strTHANHPHO = dataGridView1.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL
                cmd.CommandText = System.String.Concat("Delete From ThanhPho Where ThanhPho='" + strTHANHPHO + "'");
                cmd.CommandType = CommandType.Text;
                // Thực hiện câu lệnh SQL
                cmd.ExecuteNonQuery();
                // Cập nhật lại DataGridView
                loaddata();
                // Thông báo
                MessageBox.Show("Đã xóa xong!");

            }
            catch
            { }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel this.txtThanhPho.ResetText(); this.txtTenThanhPho.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnThem.Enabled = true; 
            this.btnSua.Enabled = true; 
            this.btnXoa.Enabled = true; 
            this.btnTroVe.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
            this.groupBox1.Enabled = false;

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
                   
                    cmd.CommandType = CommandType.Text;
                    // Lệnh Insert InTo
                    cmd.CommandText = System.String.Concat("Insert Into ThanhPho Values(" + "'" + this.textBox1.Text.ToString() + "','" + this.textBox2.Text.ToString() + "')"); 
                    cmd.CommandType = CommandType.Text; 
                    cmd.ExecuteNonQuery();
                    // Load lại dữ liệu trên DataGridView
                    loaddata();
                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");
                    }
                    catch (SqlException)
                    {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                    }
                }
            if (!Them)
            {
                    // Thực hiện lệnh
                    
                    cmd.CommandType = CommandType.Text;
                    // Thứ tự dòng hiện hành
                    int r =dataGridView1.CurrentCell.RowIndex;
                    // MaKH hiện hành 
                    string strTHANHPHO = dataGridView1.Rows[r].Cells[0].Value.ToString();
                    // Câu lệnh SQL
                    cmd.CommandText = System.String.Concat("Update ThanhPho Set TenThanhPho='" + this.textBox1.Text.ToString() + "' Where ThanhPho='" + strTHANHPHO + "'");
                    // Cập nhật
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    // Load lại dữ liệu trên DataGridView
                    loaddata();
                    // Thông báo
                    MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
            kn.con.Close();


        }
    }
}
