using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Co_Caro
{
    public partial class frmCaro : Form
    {
        Graphics g;
        Caro_Chess caro_Chess = new Caro_Chess();
        public frmCaro()
        {
            InitializeComponent();
            g = pnl.CreateGraphics();
            string sLuatChoi = "- Hai bên lần lượt đánh vào\n từng ô.\n- Bên nào đạt 5 con trên 1\n hàng ngang, hàng dọc, chéo\n xuôi, chéo ngược mà không\n bị chặn 2 đầu là người chiến\n thắng. \n- Nếu bàn cờ đầy thì hòa cờ .";
            lblLuatChoi.Text = sLuatChoi;
        }
        private void playerVsPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caro_Chess.BReady = true;
            g.Clear(pnl.BackColor);
            caro_Chess.Ve_Ban_Co(g);
            caro_Chess.Tao_Mang_O_Co();
            caro_Chess.Start_Player_vs_Player();
        }
        private void playerVsComToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caro_Chess.BReady = true;
            g.Clear(pnl.BackColor);
            caro_Chess.Ve_Ban_Co(g);
            caro_Chess.Tao_Mang_O_Co();
            caro_Chess.Start_Com_vs_Player();
            caro_Chess.Khoi_Dong_Computer(g);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void pnl_MouseClick(object sender, MouseEventArgs e)
        {
            if (!caro_Chess.BReady)
                return;
            caro_Chess.Xac_Dinh_O_Co(e.X, e.Y, g);
            if (caro_Chess.Kiem_Duyet_Chien_Thang())
            {
                caro_Chess.End_Game();
                caro_Chess.BReady = false;
                return;
            }
            if (caro_Chess.BReady)
            {
                if (caro_Chess.IGame_Mode == 2 && caro_Chess.l_Cac_Nuoc_Da_Di.Count % 2 == 0)
                {
                    caro_Chess.Khoi_Dong_Computer(g);
                    if (caro_Chess.Kiem_Duyet_Chien_Thang())
                    {
                        caro_Chess.End_Game();
                        caro_Chess.BReady = false;
                        return;
                    }
                }
            }
        }
        private void pnl_Paint(object sender, PaintEventArgs e)
        {
            caro_Chess.Kiem_Tra_Ve_Lai(g);
        }
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (caro_Chess.BReady)
            {
                caro_Chess.Undo();
                g.Clear(pnl.BackColor);
                caro_Chess.Kiem_Tra_Ve_Lai(g);
            }
        }
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (caro_Chess.BReady)
            {
                caro_Chess.Redo();
                g.Clear(pnl.BackColor);
                caro_Chess.Kiem_Tra_Ve_Lai(g);
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (caro_Chess.IGame_Mode == 0)
            {
                MessageBox.Show("Never play mode !", "Error!");
                return;
            }
            if (caro_Chess.IGame_Mode == 1)
            {
                caro_Chess.BReady = true;
                g.Clear(pnl.BackColor);
                caro_Chess.Ve_Ban_Co(g);
                caro_Chess.Tao_Mang_O_Co();
                caro_Chess.Start_Player_vs_Player();
            }
            else
            {
                caro_Chess.BReady = true;
                g.Clear(pnl.BackColor);
                caro_Chess.Ve_Ban_Co(g);
                caro_Chess.Tao_Mang_O_Co();
                caro_Chess.Start_Com_vs_Player();
                caro_Chess.Khoi_Dong_Computer(g);
            }
        }
        private void btnPvsP_Click(object sender, EventArgs e)
        {
            caro_Chess.BReady = true;
            g.Clear(pnl.BackColor);
            caro_Chess.Ve_Ban_Co(g);
            caro_Chess.Tao_Mang_O_Co();
            caro_Chess.Start_Player_vs_Player();
        }
        private void btnPvsC_Click(object sender, EventArgs e)
        {
            caro_Chess.BReady = true;
            g.Clear(pnl.BackColor);
            caro_Chess.Ve_Ban_Co(g);
            caro_Chess.Tao_Mang_O_Co();
            caro_Chess.Start_Com_vs_Player();
            caro_Chess.Khoi_Dong_Computer(g);
        }
    }
}
