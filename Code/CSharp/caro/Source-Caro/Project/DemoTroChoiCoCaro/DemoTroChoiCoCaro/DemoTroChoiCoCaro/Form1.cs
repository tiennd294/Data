using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoTroChoiCoCaro
{
    public partial class frmCoCaro : Form
    {
        private CaroChess caroChess;
        private Graphics grs;
        public frmCoCaro()
        {
            InitializeComponent();
            btnPlayervsPlayer.Click += new EventHandler(PvsP);
            caroChess = new CaroChess();
            caroChess.KhoiTaoMangOCo();
            grs = pnlBanCo.CreateGraphics();

            playerVsComToolStripMenuItem.Click += new EventHandler(PvsC_Click);
            btnPlayervsCom.Click += new EventHandler(PvsC_Click);
        }

        private void tmChuChay_Tick(object sender, EventArgs e)
        {
            lblChuoiChu.Location = new Point(lblChuoiChu.Location.X, lblChuoiChu.Location.Y - 1);
            if (lblChuoiChu.Location.Y + lblChuoiChu.Height < 0)
            {
                lblChuoiChu.Location = new Point(lblChuoiChu.Location.X, pnlChuChay.Height);
            }
        }

        private void frmCoCaro_Load(object sender, EventArgs e)
        {
            lblChuoiChu.Text = "Xin chào các bạn đã đến với\nhệ thống khóa học miễn phí\ncủa myclass.vn!";
            tmChuChay.Enabled = true;
            
        }

        private void pnlBanCo_Paint(object sender, PaintEventArgs e)
        {
            caroChess.VeBanCo(grs);
            caroChess.VeLaiQuanCo(grs);
        }

        private void pnlBanCo_MouseClick(object sender, MouseEventArgs e)
        {
            if (!caroChess.SanSang)
                return;
            if (caroChess.DanhCo(e.X, e.Y, grs))
            {
                if (caroChess.KiemTraChienThang())
                    caroChess.KetThucTroChoi();
                else
                {
                    if (caroChess.CheDoChoi == 2)
                    {
                        caroChess.KhoiDongComputer(grs);
                        if (caroChess.KiemTraChienThang())
                            caroChess.KetThucTroChoi();
                    }
                }
            }
        }

        private void PvsP(object sender, EventArgs e)
        {
            grs.Clear(pnlBanCo.BackColor);
            caroChess.StartPlayerVsPlayer(grs);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caroChess.Undo(grs);
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caroChess.Redo(grs);
        }
        private void PvsC_Click(object sender, EventArgs e)
        {
            grs.Clear(pnlBanCo.BackColor);
            caroChess.StartPlayerVsCom(grs);
        }

    }
}
