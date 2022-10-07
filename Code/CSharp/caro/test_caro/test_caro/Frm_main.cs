using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace test_caro
{
    public partial class Frm_main : Form
    {
        private carochess carochess;
        private Graphics grs;
        public Frm_main()
        {
            InitializeComponent();
            carochess = new carochess();
            carochess.khoitaomangoco();
            grs = palbanco.CreateGraphics();
        }

        private void tmtxtlc_Tick(object sender, EventArgs e)
        {
            lbllc.Location = new Point(lbllc.Location.X,lbllc.Location.Y-1);
            if (lbllc.Location.Y + lbllc.Height == 0)
            {
                lbllc.Location = new Point(11, 89);
                //lbllc.Location = new Point(lbllc.Location.X,lbllc.Height);
            }
        }

        private void Frm_main_Load(object sender, EventArgs e)
        {
            lbllc.Text = "Xin chao cac ban den voi cho choi \ncaro!";
            tmtxtlc.Enabled = true;
            
        }

        private void palbanco_Paint(object sender, PaintEventArgs e)
        {
            carochess.vebanco(grs);
            carochess.velai(grs);
        }

        private void palbanco_MouseClick(object sender, MouseEventArgs e)
        {
            if (!carochess._Sansang)
                return;
            carochess.danhco(e.X,e.Y,grs);
            if (carochess.kiemtra())
                carochess.gameover();
        }

        private void PVSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grs.Clear(palbanco.BackColor);
            carochess.PVSP(grs);
        }

        private void btnpvp_Click(object sender, EventArgs e)
        {
            grs.Clear(palbanco.BackColor);
            carochess.PVSP(grs);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //grs.Clear(palbanco.BackColor);
            carochess.Undo(grs);
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carochess.Redo(grs);
        }
       
    }
}
