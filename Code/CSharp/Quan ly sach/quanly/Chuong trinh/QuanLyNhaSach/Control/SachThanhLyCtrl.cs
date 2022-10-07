using System;
using System.Collections.Generic;
using System.Text;
using QuanLyNhaSach.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhaSach.Control
{
    public class SachThanhLyCtrl
    {
        SachThanhLyData stlData = new SachThanhLyData();

        public void HienThi(TextBox txtMaThanhLy,TextBox txtMaSach,TextBox txtLyDoTL, DateTimePicker dtpNgayLap, TextBox txtGhiChu,DataGridView dg)
        {
            BindingSource bs = new BindingSource();
            dg.DataSource = bs;
            bs.DataSource = stlData.Ds_SachThanhLy();

            txtMaThanhLy.DataBindings.Add("Text",bs,"MATHANHLY");
            txtMaSach.DataBindings.Add("Text", bs, "MASACH");
            txtLyDoTL.DataBindings.Add("Text",bs,"LYDOTHANHLY");
            dtpNgayLap.DataBindings.Add("Text", bs, "NGAYLAP");
            txtGhiChu.DataBindings.Add("Text", bs, "GhiChu");
        }
    }
}
