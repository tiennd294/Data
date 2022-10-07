using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyNhaSach.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLyNhaSach.Control
{
    public class DanhMucSachCtrl
    {
        DanhMucSachData dmsdt = new DanhMucSachData();
        
        public void HienThi(DataGridView dg,string theloaisach)
        {
            BindingSource bs = new BindingSource();
            dg.DataSource = bs;
            bs.DataSource = dmsdt.Ds_DMS(theloaisach);
        }

        DataShow datashow = new DataShow();
        public void LoadComboBox(ComboBox cbo,string Display,string Value)
        {
            datashow.LoadToComboBox(cbo, dmsdt.table_sach(),Display,Value);
        }
    }
}
