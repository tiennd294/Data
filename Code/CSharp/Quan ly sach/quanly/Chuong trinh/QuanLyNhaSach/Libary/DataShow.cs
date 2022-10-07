using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public class DataShow
    {
        public void HienThi(DataGridView dg, string sql)
        {
            DataService kn = new DataService();
            kn.LoadFromDB(sql);
            dg.DataSource = kn;
        }
        public void LoadToComboBox(ComboBox cmb, DataTable dt, string DisplayMember,string ValueMember)
        {
            string _DisplayMember, _ValueMember;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string temp = dt.Rows[i][0].ToString();
                if (temp == "NULL  ")
                    dt.Rows[i][0] = "";
            }
            cmb.DataSource = dt;
            _DisplayMember = dt.Columns[DisplayMember].ToString();
            _ValueMember = dt.Columns[ValueMember].ToString();
            cmb.ValueMember = _ValueMember;
            cmb.DisplayMember = _DisplayMember;
            cmb.Text = "";
        }

        public  ArrayList Load_ListView(ArrayList arr, ListView lv)
        {
            lv.Items.Clear();
            if (arr == null)
            {
                return null;
            }
            else
            {
                int intlenght = arr.Count;
                int intcount = 0;
                while (intcount < intlenght)
                {
                    string[] ar = (string[])arr[intcount];
                    ListViewItem item = new ListViewItem(ar[0].ToString());
                    for (byte i = 1; i < ar.Length; i++)
                    {
                        ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, ar[i].ToString());
                        item.SubItems.Add(subitem);
                    }
                    lv.Items.Add(item);
                    intcount++;
                }
            }
            return arr;
        }
    }
}
