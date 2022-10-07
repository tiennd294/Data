using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Co_Caro
{
    class Ban_Co 
    {
        private int iSoDong = 20;
        public int ISoDong
        {
            get { return iSoDong; }
            set { iSoDong = value; }
        }

        private int iSoCot = 20;
        public int ISoCot
        {
            get { return iSoCot; }
            set { iSoCot = value; }
        }


        public void VeBanCo(Graphics g,O_Co[,] Mang_O_Co)
        {
            for (int i = 0; i < iSoDong; i++)
            {
                for (int j = 0; j < iSoCot; j++)
                {
                    Mang_O_Co[i, j] = new O_Co(new Point(j * O_Co.iChieuDai_O, i * O_Co.iChieuCao_O), new Point(j * O_Co.iChieuDai_O + O_Co.iChieuDai_O, i * O_Co.iChieuCao_O + O_Co.iChieuCao_O));
                    Mang_O_Co[i, j].Ve_O_Co(g, Color.Black);
                }
            }
            
        }
        public void VeLaiBanCo(Graphics g, O_Co[,] Mang_O_Co,Image imgX,Image imgO)
        {
            for (int i = 0; i < iSoDong; i++)
            {
                for (int j = 0; j < iSoCot; j++)
                {
                    Mang_O_Co[i, j].Ve_O_Co(g, Color.Black);
                    if (Mang_O_Co[i,j].ISo_Huu == 1)
                        Ve_Quan_Co(g, Mang_O_Co[i, j].IStart_Position, imgO);
                    if (Mang_O_Co[i,j].ISo_Huu == 2)
                        Ve_Quan_Co(g, Mang_O_Co[i, j].IStart_Position, imgX);
                }
            }
        }
        public bool Dinh_Vi_Dong(int Mouse_Y, int Dong, O_Co[,] Mang_O_Co)
        {
         if (Mang_O_Co[Dong, 0].IStart_Position.Y < Mouse_Y && Mang_O_Co[Dong,0].IEnd_Position.Y > Mouse_Y)
                return true;
            return false;
        }
        public bool Dinh_Vi_Cot(int Mouse_X, int Cot, O_Co[,] Mang_O_Co)
        {
            if (Mang_O_Co[0, Cot].IStart_Position.X < Mouse_X && Mang_O_Co[0,Cot].IEnd_Position.X > Mouse_X )
                return true;
            return false;
        }
        public void Ve_Quan_Co(Graphics g, int Dong, int Cot, Image img, O_Co[,] Mang_O_Co)
        {          
            g.DrawImage(img, Mang_O_Co[Dong, Cot].IStart_Position.X+1, Mang_O_Co[Dong, Cot].IStart_Position.Y+1, O_Co.iChieuDai_O-1, O_Co.iChieuCao_O-1);
        }
        public void Ve_Quan_Co(Graphics g, Point Start, Image img)
        {
            g.DrawImage(img, (float)Start.X + 1, (float)Start.Y + 1, O_Co.iChieuDai_O - 1, O_Co.iChieuCao_O - 1);
        }
    }
}
