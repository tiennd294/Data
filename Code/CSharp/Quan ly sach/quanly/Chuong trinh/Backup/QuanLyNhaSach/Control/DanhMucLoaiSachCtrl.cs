using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyNhaSach.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyNhaSach.Builder_layer;

namespace QuanLyNhaSach.Control
{
    public class DanhMucLoaiSachCtrl
    {
        DanhMucLoaiSachData ls_Data = new DanhMucLoaiSachData();
        public void HienThi(DataGridView dg)
        {
            BindingSource bs = new BindingSource();            
            bs.DataSource = ls_Data.layDanhMucLoaiSach();
            dg.DataSource = bs;
        }
        public void load_data(TextBox t1, TextBox t2, DataGridViewRow row)
        {
            t1.Text = row.Cells[0].Value.ToString();
            t2.Text = row.Cells[1].Value.ToString();
        }
        public ErrorInfo themLoaiSach(TextBox t1, TextBox t2)
        {
            DanhMucLoaiSachInfo ls_Info = new DanhMucLoaiSachInfo();
            ls_Info.MaLoaiSach = t1.Text;
            ls_Info.TenLoaiSach= t2.Text;
            return ls_Data.themLoaiSach(ls_Info);
        }
        public ErrorInfo xoaLoaiSach(TextBox t1, TextBox t2)
        {
            DanhMucLoaiSachInfo ls_Info = new DanhMucLoaiSachInfo();
            ls_Info.MaLoaiSach = t1.Text;
            ls_Info.TenLoaiSach = t2.Text;

            return ls_Data.XoaLoaiSach(ls_Info);
        }
        public ErrorInfo capnhatLoaiSach(TextBox t1, TextBox t2)
        {
            DanhMucLoaiSachInfo ls_Info = new DanhMucLoaiSachInfo();
            ls_Info.MaLoaiSach = t1.Text;
            ls_Info.TenLoaiSach = t2.Text;
            return ls_Data.CapNhatLoaiSach(ls_Info);
        }
    }
}
