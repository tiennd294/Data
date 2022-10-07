using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyNhaSach.Control;
using QuanLyNhaSach.Builder_layer;

namespace QuanLyNhaSach
{
    public partial class frmChonSach : Form
    {
        public frmChonSach()
        {
            InitializeComponent();
        }
        ThongTinSachCtrl ctrl = new ThongTinSachCtrl();

        private ThongTinSachInfo ttsach;

        public ThongTinSachInfo ttSach
        {
            get { return ttsach; }

        }  

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            IEnumerator ie = listView2.SelectedItems.GetEnumerator();
            ttsach = new ThongTinSachInfo();
            ttsach.MaSach = null;
            if (ie.MoveNext())
            {
                ListViewItem item = (ListViewItem)ie.Current;

                ttsach.MaSach = item.SubItems[1].Text;
                ttsach.TenSach = item.SubItems[2].Text;
            }
            if (ttsach.MaSach != null)
                this.DialogResult = DialogResult.OK;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void frmChonSach_Load(object sender, EventArgs e)
        {
            ctrl.Hienthi_listtview(listView2);
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {                    
            IEnumerator ie = listView2.SelectedItems.GetEnumerator();
            ttsach = new ThongTinSachInfo();
            ttsach.MaSach = null; 
            if (ie.MoveNext())
            {
                ListViewItem item = (ListViewItem)ie.Current;

                ttsach.MaSach = item.SubItems[1].Text;
                ttsach.TenSach = item.SubItems[2].Text;
            }
            if (ttsach.MaSach != null)
                this.DialogResult = DialogResult.OK;       
           
        }

    }
}