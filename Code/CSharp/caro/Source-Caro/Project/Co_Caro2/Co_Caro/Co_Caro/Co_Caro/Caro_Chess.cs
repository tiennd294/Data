using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Co_Caro
{
    class Caro_Chess
    {
        #region Cac Thuoc Tinh
        private O_Co[,] Mang_O_Co = new O_Co[20, 20];
        public List<O_Co> l_Cac_Nuoc_Da_Di = new List<O_Co>();
        private List<O_Co> l_Cac_Nuoc_Di_Lai = new List<O_Co>();
        public static int LuotDi = 1;//1 là máy , 2 là người
        private Ban_Co BanCo = new Ban_Co();
        private bool bReady = false;
        public bool BReady
        {
            get { return bReady; }
            set { bReady = value; }
        }
        private int iGame_Mode = 0;
        public int IGame_Mode
        {
            get { return iGame_Mode; }
            set { iGame_Mode = value; }
        }
        private Image ImageO = new Bitmap(Properties.Resources.o);
        private Image ImageX = new Bitmap(Properties.Resources.x);
        #endregion
        #region Cac Ham Tao
        public Caro_Chess()
        { }
        public Caro_Chess(int GameMode)
        {
            iGame_Mode = GameMode;
        }
        #endregion
        #region Cac Phuong Thuc
        public void Tao_Mang_O_Co()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Mang_O_Co[i, j].IDong = i;
                    Mang_O_Co[i, j].ICot = j;
                    Mang_O_Co[i, j].ISo_Huu = 0;
                }
            }
        }
        public void Ve_Ban_Co(Graphics g)
        {
            BanCo.VeBanCo(g, Mang_O_Co);
        }
        public void Kiem_Tra_Ve_Lai(Graphics g)
        {
            if (l_Cac_Nuoc_Da_Di.Count == 0)
                BanCo.VeBanCo(g, Mang_O_Co);
            else
                BanCo.VeLaiBanCo(g, Mang_O_Co,ImageX,ImageO);

        }
        public void Start_Player_vs_Player()
        {
            iGame_Mode = 1;
            l_Cac_Nuoc_Da_Di.RemoveRange(0, l_Cac_Nuoc_Da_Di.Count);
            l_Cac_Nuoc_Di_Lai.RemoveRange(0, l_Cac_Nuoc_Di_Lai.Count);
        }
        public void Start_Com_vs_Player()
        {
            iGame_Mode = 2;
            l_Cac_Nuoc_Da_Di.RemoveRange(0, l_Cac_Nuoc_Da_Di.Count);
            l_Cac_Nuoc_Di_Lai.RemoveRange(0, l_Cac_Nuoc_Di_Lai.Count);
        }
        public void End_Game()
        {
            switch (iGame_Mode)
            { 
                case 1:
                    switch (LuotDi)
                    { 
                        case 1 :
                            MessageBox.Show("Player 2 win");
                            break;
                        case 2 :
                            MessageBox.Show("Player 1 win");
                            break;
                    }
                    break;
                case 2:
                    switch (LuotDi)
                    {
                        case 1:
                            MessageBox.Show("Player win");
                            break;
                        case 2:
                            MessageBox.Show("Computer win");
                            break;
                    }
                    break;
            }
                       
        }
        public void Undo()
        {
            if (iGame_Mode == 1)
            {
                if (l_Cac_Nuoc_Da_Di.Count < 1)
                    return;
                l_Cac_Nuoc_Di_Lai.Add(l_Cac_Nuoc_Da_Di[l_Cac_Nuoc_Da_Di.Count - 1]);
                O_Co o_Co = l_Cac_Nuoc_Da_Di[l_Cac_Nuoc_Da_Di.Count - 1];
                Mang_O_Co[o_Co.IDong, o_Co.ICot].ISo_Huu = 0;
                l_Cac_Nuoc_Da_Di.RemoveAt(l_Cac_Nuoc_Da_Di.Count - 1);
                if (LuotDi == 1)
                    LuotDi = 2;
                else
                    LuotDi = 1;
            }
            else
            {
                if (l_Cac_Nuoc_Da_Di.Count <= 1)
                    return;
                l_Cac_Nuoc_Di_Lai.Add(l_Cac_Nuoc_Da_Di[l_Cac_Nuoc_Da_Di.Count - 2]);
                O_Co o_Co = l_Cac_Nuoc_Da_Di[l_Cac_Nuoc_Da_Di.Count - 2];
                Mang_O_Co[o_Co.IDong, o_Co.ICot].ISo_Huu = 0;
                l_Cac_Nuoc_Da_Di.RemoveAt(l_Cac_Nuoc_Da_Di.Count - 2);

                l_Cac_Nuoc_Di_Lai.Add(l_Cac_Nuoc_Da_Di[l_Cac_Nuoc_Da_Di.Count - 1]);
                o_Co = l_Cac_Nuoc_Da_Di[l_Cac_Nuoc_Da_Di.Count - 1];
                Mang_O_Co[o_Co.IDong, o_Co.ICot].ISo_Huu = 0;
                l_Cac_Nuoc_Da_Di.RemoveAt(l_Cac_Nuoc_Da_Di.Count - 1);
            }

        }
        public void Redo()
        {
            if (iGame_Mode == 1)
            {
                if (l_Cac_Nuoc_Di_Lai.Count < 1)
                    return;
                l_Cac_Nuoc_Da_Di.Add(l_Cac_Nuoc_Di_Lai[l_Cac_Nuoc_Di_Lai.Count - 1]);
                O_Co o_Co = l_Cac_Nuoc_Di_Lai[l_Cac_Nuoc_Di_Lai.Count - 1];
                if (LuotDi == 1)
                    o_Co.ISo_Huu = 1;
                else
                    o_Co.ISo_Huu = 2;
                Mang_O_Co[o_Co.IDong, o_Co.ICot] = o_Co;
                l_Cac_Nuoc_Di_Lai.RemoveAt(l_Cac_Nuoc_Di_Lai.Count - 1);
                if (LuotDi == 1)
                    LuotDi = 2;
                else
                    LuotDi = 1;
            }
            else
            {
                if (l_Cac_Nuoc_Di_Lai.Count <= 1)
                    return;
                l_Cac_Nuoc_Da_Di.Add(l_Cac_Nuoc_Di_Lai[l_Cac_Nuoc_Di_Lai.Count - 2]);
                O_Co o_Co = l_Cac_Nuoc_Di_Lai[l_Cac_Nuoc_Di_Lai.Count - 2];
                o_Co.ISo_Huu = 2;
                Mang_O_Co[o_Co.IDong, o_Co.ICot] = o_Co;
                l_Cac_Nuoc_Di_Lai.RemoveAt(l_Cac_Nuoc_Di_Lai.Count - 2);

                l_Cac_Nuoc_Da_Di.Add(l_Cac_Nuoc_Di_Lai[l_Cac_Nuoc_Di_Lai.Count - 1]);
                o_Co = l_Cac_Nuoc_Di_Lai[l_Cac_Nuoc_Di_Lai.Count - 1];
                o_Co.ISo_Huu = 1;
                Mang_O_Co[o_Co.IDong, o_Co.ICot] = o_Co;
                l_Cac_Nuoc_Di_Lai.RemoveAt(l_Cac_Nuoc_Di_Lai.Count - 1);
            }

        }
        public void Xac_Dinh_O_Co(int Mouse_X, int Mouse_Y, Graphics g)
        {
            for (int i = 0; i < BanCo.ISoDong; i++)
            { 
                if(BanCo.Dinh_Vi_Dong(Mouse_Y,i,Mang_O_Co))
                {
                    for (int j = 0; j < BanCo.ISoCot; j++)
                    {
                        if (BanCo.Dinh_Vi_Cot(Mouse_X, j, Mang_O_Co))
                        {
                            switch (LuotDi)
                            { 
                                case 1:
                                    if (Mang_O_Co[i, j].ISo_Huu != 0)
                                        return;
                                    BanCo.Ve_Quan_Co(g, i, j, ImageO, Mang_O_Co);
                                    Mang_O_Co[i, j].ISo_Huu = 1;
                                    Mang_O_Co[i, j].IDong = i;
                                    Mang_O_Co[i, j].ICot = j;
                                    l_Cac_Nuoc_Da_Di.Add(Mang_O_Co[i, j]);
                                    LuotDi = 2;
                                    return;
                                case 2:
                                    if (Mang_O_Co[i, j].ISo_Huu != 0)
                                        return;
                                    BanCo.Ve_Quan_Co(g, i, j, ImageX, Mang_O_Co);
                                    Mang_O_Co[i, j].ISo_Huu = 2;
                                    Mang_O_Co[i, j].IDong = i;
                                    Mang_O_Co[i, j].ICot = j;
                                    l_Cac_Nuoc_Da_Di.Add(Mang_O_Co[i, j]);
                                    LuotDi = 1;
                                    return;
                            }
                        }
                    }
                }
            }
        }
        #region Duyet_Chien_Thang
        public bool Kiem_Duyet_Chien_Thang()
        {
            if (l_Cac_Nuoc_Da_Di.Count == 400)
            {
                MessageBox.Show("Hòa cờ");
                bReady = false;
                return false;
            }
            for (int i = 0; i < BanCo.ISoDong ; i++)
            {
                for (int j = 0; j < BanCo.ISoCot; j++)
                {
                    if (Mang_O_Co[i, j].ISo_Huu == 1)
                    {
                        if (Kiem_Tra_Player(i, j, 1))
                            return true;
                    }
                    if (Mang_O_Co[i, j].ISo_Huu == 2)
                    {
                        if (Kiem_Tra_Player(i, j, 2))
                            return true;
                    }
                }
            }
            return false;
        }
        private bool Kiem_Tra_Player(int Dong, int Cot, int Player_SoHuu)
        {
            if (Duyet_Phuong_Doc(Dong, Cot, Player_SoHuu) || Duyet_Phuong_Ngang(Dong, Cot, Player_SoHuu) || Duyet_Cheo_Xuoi(Dong,Cot,Player_SoHuu) || Duyet_Cheo_Nguoc(Dong, Cot, Player_SoHuu))
                return true;
            return false;
        }
        private bool Duyet_Phuong_Doc(int Current_Dong, int Current_Cot, int Player_SoHuu)
        {
            if (Current_Dong > 15)
                return false;
            long iDem;
            for (iDem = 1; iDem < 5; iDem++)
            {
                if (Mang_O_Co[Current_Dong + iDem, Current_Cot].ISo_Huu != Player_SoHuu)
                    return false;
            }
            if (Current_Dong == 0 || Current_Dong + iDem == BanCo.ISoDong)
                return true;
            else
            {
                if (Mang_O_Co[Current_Dong - 1, Current_Cot].ISo_Huu == 0 || Mang_O_Co[Current_Dong + iDem, Current_Cot].ISo_Huu == 0)
                    return true;
                else
                    return false;
            }
        }
        private bool Duyet_Phuong_Ngang(int Current_Dong, int Current_Cot, int Player_SoHuu)
        {
            if (Current_Cot > 15)
                return false;
            long iDem;
            for (iDem = 1; iDem < 5; iDem++)
            {
                if (Mang_O_Co[Current_Dong, Current_Cot + iDem].ISo_Huu != Player_SoHuu)
                    return false;
            }
            if (Current_Cot == 0 || Current_Cot +iDem == BanCo.ISoCot)
                return true;
            else
            {
                if (Mang_O_Co[Current_Dong, Current_Cot - 1].ISo_Huu == 0 || Mang_O_Co[Current_Dong, Current_Cot + iDem].ISo_Huu == 0)
                    return true;
                else
                    return false;
            }
        }
        private bool Duyet_Cheo_Xuoi(int Current_Dong, int Current_Cot, int Player_SoHuu)
        {
            if (Current_Dong > 15 || Current_Cot > 15)
                return false;
            long iDem;
            for (iDem = 1; iDem < 5; iDem++)
            {
                if (Mang_O_Co[Current_Dong + iDem, Current_Cot + iDem].ISo_Huu != Player_SoHuu)
                    return false;
            }
            if (Current_Cot == 0 || Current_Dong == 0 || Current_Cot + iDem == BanCo.ISoCot || Current_Dong + iDem == BanCo.ISoDong)
                return true;
            else
            {
                if (Mang_O_Co[Current_Dong - 1, Current_Cot - 1].ISo_Huu == 0 || Mang_O_Co[Current_Dong + iDem, Current_Cot + iDem].ISo_Huu == 0)
                    return true;
                else
                    return false;
            }
        }
        private bool Duyet_Cheo_Nguoc(int Current_Dong, int Current_Cot, int Player_SoHuu)
        {
            if (Current_Dong > 15 || Current_Cot < 4)
                return false;
            long iDem;
            for (iDem = 1; iDem < 5; iDem++)
            {
                if (Mang_O_Co[Current_Dong + iDem, Current_Cot - iDem].ISo_Huu != Player_SoHuu)
                    return false;
            }
            if (Current_Cot == BanCo.ISoCot - 1 || Current_Dong == 0 || Current_Cot - iDem == 0 || Current_Dong + iDem == BanCo.ISoDong)
                return true;
            else
            {
                if (Mang_O_Co[Current_Dong - 1, Current_Cot + 1].ISo_Huu == 0 || Mang_O_Co[Current_Dong + iDem, Current_Cot - iDem].ISo_Huu == 0)
                    return true;
                else
                    return false;
            }
        }
        #endregion
        #region AI_Computer
        public long[] Defend_Score = new long[7] { 0, 3, 27, 99, 729, 6561, 59049 };//Mảng điểm chặn
        public long[] Attack_Score = new long[7] { 0, 9, 54, 162, 1458, 13112, 118008 };//Mảng điểm tấn công
        //public long[] AScore = new long[5] { 0, 3, 24, 243, 2197 };
        //public long[] Attack_Score = new long[5] { 0, 1, 9, 81, 729 };

        public void Khoi_Dong_Computer(Graphics g)
        {
            if (l_Cac_Nuoc_Da_Di.Count == 0)
            {
                BanCo.Ve_Quan_Co(g, 9, 9, ImageO, Mang_O_Co);
                Mang_O_Co[9, 9].ISo_Huu = 1;
                l_Cac_Nuoc_Da_Di.Add(Mang_O_Co[9, 9]);
                LuotDi = 2;
            }
            else
            {
                O_Co o_Co_Danh = Tim_Kiem_Nuoc_Di();
                BanCo.Ve_Quan_Co(g, o_Co_Danh.IDong, o_Co_Danh.ICot, ImageO, Mang_O_Co);
                Mang_O_Co[o_Co_Danh.IDong, o_Co_Danh.ICot].ISo_Huu = 1;
                l_Cac_Nuoc_Da_Di.Add(Mang_O_Co[o_Co_Danh.IDong, o_Co_Danh.ICot]);
                LuotDi = 2;
            }                        
        }
        public O_Co Tim_Kiem_Nuoc_Di()
        {
            O_Co o_CoTemp = new O_Co();
            long iScore = 0;
            for (int i = 0; i < BanCo.ISoDong; i++)
            {
                for (int j = 0; j < BanCo.ISoCot; j++)
                {
                    long iScoreAttack = 0;
                    long iScoreDefend = 0;
                    if (Mang_O_Co[i, j].ISo_Huu == 0)
                    {
                        iScoreAttack += Score_Attack_Duyet_Doc(i, j);
                        iScoreAttack += Score_Attack_Duyet_Ngang(i, j);
                        iScoreAttack += Score_Attack_Duyet_Cheo_Nguoc(i, j);
                        iScoreAttack += Score_Attack_Duyet_Cheo_Xuoi(i, j);

                        iScoreDefend += Score_Defend_Duyet_Doc(i, j);
                        iScoreDefend += Score_Defend_Duyet_Ngang(i, j);
                        iScoreDefend += Score_Defend_Duyet_Cheo_Nguoc(i, j);
                        iScoreDefend += Score_Defend_Duyet_Cheo_Xuoi(i, j);

                        if (iScoreDefend <= iScoreAttack)
                        {
                            if (iScore <= iScoreAttack)
                            {
                                iScore = iScoreAttack;
                                o_CoTemp = Mang_O_Co[i, j];
                            }
                        }
                        else
                        {
                            if (iScore <=  iScoreDefend)
                            {
                                iScore = iScoreDefend;
                                o_CoTemp = Mang_O_Co[i, j];
                            }
                        }
                    }
                }
            }
            return o_CoTemp;
        }
        #region Attack
        private long Score_Attack_Duyet_Doc(long Dong, long Cot)
        {
            long iScoreTempDoc = 0;
            long iScoreAttack = 0;
            int iSoQuanTa = 0;
            int iSoQuanDich = 0;
            for (int iDem = 1; iDem < 6 && Dong + iDem < BanCo.ISoDong; iDem++)
            {
                if (Mang_O_Co[Dong + iDem, Cot].ISo_Huu == 1)
                    iSoQuanTa++;
                if (Mang_O_Co[Dong + iDem, Cot].ISo_Huu == 2)
                {
                    iSoQuanDich++;
                    iScoreTempDoc -= 9;
                    break;
                }
                if (Mang_O_Co[Dong + iDem, Cot].ISo_Huu == 0)
                    break;
            }
            //iScoreAttack += Attack_Score[iSoQuanTa];
            //iSoQuanTa = 0;

            for (int iDem = 1; iDem < 6 && Dong - iDem >= 0; iDem++)
            {
                if (Mang_O_Co[Dong - iDem, Cot].ISo_Huu == 1)
                    iSoQuanTa++;
                if (Mang_O_Co[Dong - iDem, Cot].ISo_Huu == 2)
                {
                    iScoreTempDoc -= 9;
                    iSoQuanDich++;
                    break;
                }
                if (Mang_O_Co[Dong - iDem, Cot].ISo_Huu == 0)
                    break;
            }
            if (iSoQuanDich == 2)
                return 0;
            iScoreAttack += Attack_Score[iSoQuanTa];
            iScoreAttack -= Attack_Score[iSoQuanDich];
            iScoreTempDoc += iScoreAttack;

            return iScoreTempDoc;
        }
        private long Score_Attack_Duyet_Ngang(long Dong, long Cot)
        {
            long iScoreTempNgang = 0;
            long iScoreAttack = 0;
            int iSoQuanTa = 0;
            int iSoQuanDich = 0;
            for (int iDem = 1; iDem < 6 && Cot + iDem < BanCo.ISoCot; iDem++)
            {
                if (Mang_O_Co[Dong, Cot + iDem].ISo_Huu == 1)
                    iSoQuanTa++;
                if (Mang_O_Co[Dong, Cot + iDem].ISo_Huu == 2)
                {
                    iSoQuanDich++;
                    iScoreTempNgang -= 9;
                    break;
                }
                if (Mang_O_Co[Dong, Cot + iDem].ISo_Huu == 0)
                    break;
            }
            //iScoreAttack += Attack_Score[iSoQuanTa];
            //iSoQuanTa = 0;

            for (int iDem = 1; iDem < 6 && Cot - iDem >= 0; iDem++)
            {
                if (Mang_O_Co[Dong, Cot - iDem].ISo_Huu == 1)
                    iSoQuanTa++;
                if (Mang_O_Co[Dong, Cot - iDem].ISo_Huu == 2)
                {
                    iScoreTempNgang -= 9;
                    iSoQuanDich++;
                    break;
                }
                if (Mang_O_Co[Dong, Cot - iDem].ISo_Huu == 0)
                    break;
            }
            if (iSoQuanDich == 2)
                return 0;
            iScoreAttack += Attack_Score[iSoQuanTa];
            iScoreAttack -= Attack_Score[iSoQuanDich];
            iScoreTempNgang += iScoreAttack;

            return iScoreTempNgang;
        }
        private long Score_Attack_Duyet_Cheo_Nguoc(long Dong, long Cot)
        {
            long iScoreTempCheoNguoc = 0;
            long iScoreAttack = 0;
            int iSoQuanTa = 0;
            int iSoQuanDich = 0;
            for (int iDem = 1; iDem < 6 && Cot + iDem < BanCo.ISoCot && Dong + iDem < BanCo.ISoDong; iDem++)
            {
                if (Mang_O_Co[Dong + iDem, Cot + iDem].ISo_Huu == 1)
                    iSoQuanTa++;
                if (Mang_O_Co[Dong + iDem, Cot + iDem].ISo_Huu == 2)
                {
                    iScoreTempCheoNguoc -= 9;
                    iSoQuanDich++;
                    break;
                }
                if (Mang_O_Co[Dong + iDem, Cot + iDem].ISo_Huu == 0)
                    break;
            }
            //iScoreAttack += Attack_Score[iSoQuanTa];
            //iSoQuanTa = 0;

            for (int iDem = 1; iDem < 6 && Cot - iDem >= 0 && Dong - iDem >= 0; iDem++)
            {
                if (Mang_O_Co[Dong - iDem, Cot - iDem].ISo_Huu == 1)
                    iSoQuanTa++;
                if (Mang_O_Co[Dong - iDem, Cot - iDem].ISo_Huu == 2)
                {
                    iScoreTempCheoNguoc -= 9;
                    iSoQuanDich++;
                    break;
                }
                if (Mang_O_Co[Dong - iDem, Cot - iDem].ISo_Huu == 0)
                    break;
            }
            if (iSoQuanDich == 2)
                return 0;
            iScoreAttack += Attack_Score[iSoQuanTa];
            iScoreAttack -= Attack_Score[iSoQuanDich];
            iScoreTempCheoNguoc += iScoreAttack;

            return iScoreTempCheoNguoc;
        }
        private long Score_Attack_Duyet_Cheo_Xuoi(long Dong, long Cot)
        {
            long iScoreTempCheoXuoi = 0;
            long iScoreAttack = 0;
            int iSoQuanTa = 0;
            int iSoQuanDich = 0;
            for (int iDem = 1; iDem < 6 && Cot - iDem >= 0 && Dong + iDem < BanCo.ISoDong; iDem++)
            {
                if (Mang_O_Co[Dong + iDem, Cot - iDem].ISo_Huu == 1)
                    iSoQuanTa++;
                if (Mang_O_Co[Dong + iDem, Cot - iDem].ISo_Huu == 2)
                {
                    iScoreTempCheoXuoi -= 9;
                    iSoQuanDich++;
                    break;
                }
                if (Mang_O_Co[Dong + iDem, Cot - iDem].ISo_Huu == 0)
                    break;
            }
            //iScoreAttack += Attack_Score[iSoQuanTa];
            //iSoQuanTa = 0;

            for (int iDem = 1; iDem < 6 && Cot + iDem < BanCo.ISoCot && Dong - iDem >= 0; iDem++)
            {
                if (Mang_O_Co[Dong - iDem, Cot + iDem].ISo_Huu == 1)
                    iSoQuanTa++;
                if (Mang_O_Co[Dong - iDem, Cot + iDem].ISo_Huu == 2)
                {
                    iScoreTempCheoXuoi -= 9;
                    iSoQuanDich++;
                    break;
                }
                if (Mang_O_Co[Dong - iDem, Cot + iDem].ISo_Huu == 0)
                    break;
            }
            if (iSoQuanDich == 2)
                return 0;
            iScoreAttack += Attack_Score[iSoQuanTa];
            iScoreAttack -= Attack_Score[iSoQuanDich];
            iScoreTempCheoXuoi += iScoreAttack;

            return iScoreTempCheoXuoi;
        }
        #endregion









        // Tính điểm phòng ngự
        #region Defense

        private long Score_Defend_Duyet_Doc(long Dong, long Cot)
        {
            long iScoreTempDoc = 0;
            long iScoreDefend = 0;
            int iSoQuanDich = 0;
            int iSoQuanTa = 0;
            for (int iDem = 1; iDem < 6 && Dong + iDem < BanCo.ISoDong; iDem++)
            {
                if (Mang_O_Co[Dong + iDem, Cot].ISo_Huu == 1)
                {
                    iSoQuanTa++;
                    break;
                }
                if (Mang_O_Co[Dong + iDem, Cot].ISo_Huu == 2)
                    iSoQuanDich++;
                if (Mang_O_Co[Dong + iDem, Cot].ISo_Huu == 0)
                    break ;
            }
            //iScoreDefend += Defend_Score[iSoQuanDich];
            //iSoQuanDich = 0;

            for (int iDem = 1; iDem < 6 && Dong - iDem >= 0; iDem++)
            {
                if (Mang_O_Co[Dong - iDem, Cot].ISo_Huu == 1)
                {
                    iSoQuanTa++;
                    break;
                }
                if (Mang_O_Co[Dong - iDem, Cot].ISo_Huu == 2)
                    iSoQuanDich++;
                if (Mang_O_Co[Dong - iDem, Cot].ISo_Huu == 0)
                    break;
            }
            if (iSoQuanTa == 2)
                return 0;

            iScoreDefend += Defend_Score[iSoQuanDich];
            if (iSoQuanDich > 0)
                iScoreDefend -= Attack_Score[iSoQuanTa] * 2;
            iScoreTempDoc += iScoreDefend;

            return iScoreTempDoc;
        }
        private long Score_Defend_Duyet_Ngang(long Dong, long Cot)
        {
            long iScoreTempNgang = 0;
            long iScoreDefend = 0;
            int iSoQuanDich = 0;
            int iSoQuanTa = 0;
            for (int iDem = 1; iDem < 6 && Cot + iDem < BanCo.ISoCot; iDem++)
            {
                if (Mang_O_Co[Dong, Cot + iDem].ISo_Huu == 1)
                {
                    iSoQuanTa++;
                    break;
                }
                if (Mang_O_Co[Dong, Cot + iDem].ISo_Huu == 2)
                    iSoQuanDich++;
                if (Mang_O_Co[Dong, Cot + iDem].ISo_Huu == 0)
                    break;
            }
            //iScoreDefend += Defend_Score[iSoQuanDich];
            //iSoQuanDich = 0;

            for (int iDem = 1; iDem < 6 && Cot - iDem >= 0; iDem++)
            {
                if (Mang_O_Co[Dong, Cot - iDem].ISo_Huu == 1)
                {
                    iSoQuanTa++;
                    break;
                }
                if (Mang_O_Co[Dong, Cot - iDem].ISo_Huu == 0)
                    break;
                if (Mang_O_Co[Dong, Cot - iDem].ISo_Huu == 2)
                    iSoQuanDich++;
            }
            if (iSoQuanTa == 2)
                return 0;
            iScoreDefend += Defend_Score[iSoQuanDich];
            if (iSoQuanDich > 0)
                iScoreDefend -= Attack_Score[iSoQuanTa] * 2;
            iScoreTempNgang += iScoreDefend;

            return iScoreTempNgang;
        }
        private long Score_Defend_Duyet_Cheo_Nguoc(long Dong, long Cot)
        {
            long iScoreTempCheoNguoc = 0;
            long iScoreDefend = 0;
            int iSoQuanDich = 0;
            int iSoQuanTa = 0;
            for (int iDem = 1; iDem < 6 && Cot + iDem < BanCo.ISoCot && Dong + iDem < BanCo.ISoDong; iDem++)
            {
                if (Mang_O_Co[Dong + iDem, Cot + iDem].ISo_Huu == 1)
                {
                    iSoQuanTa++;
                    break;
                }
                if (Mang_O_Co[Dong + iDem, Cot + iDem].ISo_Huu == 0)
                    break;
                if (Mang_O_Co[Dong + iDem, Cot + iDem].ISo_Huu == 2)
                    iSoQuanDich++;
            }
            //iScoreDefend += Defend_Score[iSoQuanDich];
            //iSoQuanDich = 0;

            for (int iDem = 1; iDem < 6 && Cot - iDem >= 0 && Dong - iDem >= 0; iDem++)
            {
                if (Mang_O_Co[Dong - iDem, Cot - iDem].ISo_Huu == 1)
                {
                    iSoQuanTa++;
                    break;
                }

                if (Mang_O_Co[Dong - iDem, Cot - iDem].ISo_Huu == 0)
                    break;
                if (Mang_O_Co[Dong - iDem, Cot - iDem].ISo_Huu == 2)
                    iSoQuanDich++;
            }
            if (iSoQuanTa == 2)
                return 0;
            iScoreDefend += Defend_Score[iSoQuanDich];
            if (iSoQuanDich > 0)
                iScoreDefend -= Attack_Score[iSoQuanTa] * 2; 
            iScoreTempCheoNguoc += iScoreDefend;

            return iScoreTempCheoNguoc;
        }

        private long Score_Defend_Duyet_Cheo_Xuoi(long Dong, long Cot)
        {
            long iScoreTempCheoXuoi = 0;
            long iScoreDefend = 0;
            int iSoQuanDich = 0;
            int iSoQuanTa = 0;
            for (int iDem = 1; iDem < 6 && Cot - iDem >= 0 && Dong + iDem < BanCo.ISoDong; iDem++)
            {
                if (Mang_O_Co[Dong + iDem, Cot - iDem].ISo_Huu == 1)
                {
                    iSoQuanTa++;
                    break;
                }
                if (Mang_O_Co[Dong + iDem, Cot - iDem].ISo_Huu == 0)
                    break;
                if (Mang_O_Co[Dong + iDem, Cot - iDem].ISo_Huu == 2)
                    iSoQuanDich++;
            }
            //iScoreDefend += Defend_Score[iSoQuanDich];
            //iSoQuanDich = 0;
                
            for (int iDem = 1; iDem < 6 && Cot + iDem < BanCo.ISoCot && Dong - iDem >= 0; iDem++)
            {
                if (Mang_O_Co[Dong - iDem, Cot + iDem].ISo_Huu == 1)
                {
                    iSoQuanTa++;
                    break;
                }
                if (Mang_O_Co[Dong - iDem, Cot + iDem].ISo_Huu == 0)
                    break;
                if (Mang_O_Co[Dong - iDem, Cot + iDem].ISo_Huu == 2)
                    iSoQuanDich++;
            }
            if (iSoQuanTa == 2)
            {
                return 0;
            }
            iScoreDefend += Defend_Score[iSoQuanDich];
            if (iSoQuanDich > 0)
                iScoreDefend -= Attack_Score[iSoQuanTa] * 2;
            iScoreTempCheoXuoi += iScoreDefend;

            return iScoreTempCheoXuoi;
        }
        #endregion
        #endregion
        #endregion
    }
}
