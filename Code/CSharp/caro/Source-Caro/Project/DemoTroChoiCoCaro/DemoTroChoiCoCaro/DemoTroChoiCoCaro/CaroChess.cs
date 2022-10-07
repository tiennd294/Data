﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace DemoTroChoiCoCaro
{
    public enum KETTHUC
    { 
        HoaCo,
        Player1,
        Player2,
        COM
    }
    class CaroChess
    {
        public static Pen pen;
        public static SolidBrush sbWhite;
        public static SolidBrush sbBlack;
        public static SolidBrush sbGreen;
        private OCo[,] _MangOCo;
        private BanCo _BanCo;
        private int _LuotDi;
        private int _CheDoChoi;
        private bool _SanSang;
        private Stack<OCo> stkCacNuocDaDi;
        private Stack<OCo> stkCacNuocUndo;
        private KETTHUC _ketThuc;
        public bool SanSang
        {
            get { return _SanSang; }
        }
        public int CheDoChoi
        {
            get { return _CheDoChoi; }
        }
        public CaroChess()
        {
            pen = new Pen(Color.Green);
            sbWhite = new SolidBrush(Color.White);
            sbBlack = new SolidBrush(Color.Black);
            sbGreen = new SolidBrush(Color.FromArgb(0, 192, 0));
            _BanCo = new BanCo(20, 20);
            _MangOCo = new OCo[_BanCo.SoDong, _BanCo.SoCot];
            stkCacNuocDaDi = new Stack<OCo>();
            stkCacNuocUndo = new Stack<OCo>();
            _LuotDi = 1;
        }

        public void VeBanCo(Graphics g)
        {
            _BanCo.VeBanCo(g);
        }

        public void KhoiTaoMangOCo()
        {
            for (int i = 0; i < _BanCo.SoDong; i++)
            {
                for (int j = 0; j < _BanCo.SoCot; j++)
                {
                    _MangOCo[i, j] = new OCo(i, j, new Point(j * OCo._ChieuRong, i * OCo._ChieuCao), 0);
                }
            }
        }

        public bool DanhCo(int MouseX, int MouseY, Graphics g)
        {
            if (MouseX % OCo._ChieuRong == 0 || MouseY % OCo._ChieuCao == 0)
                return false;
            int Cot = MouseX / OCo._ChieuRong;
            int Dong = MouseY / OCo._ChieuCao;
            if (_MangOCo[Dong, Cot].SoHuu != 0)
                return false;

            switch (_LuotDi)
            { 
                case 1:
                    _MangOCo[Dong, Cot].SoHuu = 1;
                    _BanCo.VeQuanCo(g, _MangOCo[Dong, Cot].ViTri, sbBlack);
                    _LuotDi = 2;
                    break;
                case 2:
                    _MangOCo[Dong, Cot].SoHuu = 2;
                    _BanCo.VeQuanCo(g, _MangOCo[Dong, Cot].ViTri, sbWhite);
                    _LuotDi = 1;
                    break;
                default:
                    MessageBox.Show("Có lỗi");
                    break;
            }
            stkCacNuocUndo = new Stack<OCo>();
            OCo oco = new OCo(_MangOCo[Dong, Cot].Dong, _MangOCo[Dong, Cot].Cot, _MangOCo[Dong, Cot].ViTri, _MangOCo[Dong, Cot].SoHuu);
            stkCacNuocDaDi.Push(oco);
      
            return true;
        }

        public void VeLaiQuanCo(Graphics g)
        {
            foreach (OCo oco in stkCacNuocDaDi)
            {
                if(oco.SoHuu == 1)
                    _BanCo.VeQuanCo(g, oco.ViTri, sbBlack);
                else if(oco.SoHuu == 2)
                    _BanCo.VeQuanCo(g, oco.ViTri, sbWhite);
            }
        }

        public void StartPlayerVsPlayer(Graphics g)
        {
            _SanSang = true;
            stkCacNuocDaDi = new Stack<OCo>();
            stkCacNuocUndo = new Stack<OCo>();
            _LuotDi = 1;
            _CheDoChoi = 1;
            KhoiTaoMangOCo();
            VeBanCo(g);
        }
        public void StartPlayerVsCom(Graphics g)
        {
            _SanSang = true;
            stkCacNuocDaDi = new Stack<OCo>();
            stkCacNuocUndo = new Stack<OCo>();
            _LuotDi = 1;
            _CheDoChoi = 2;
            KhoiTaoMangOCo();
            VeBanCo(g);
            KhoiDongComputer(g);
        }

        #region Undo Redo
        public void Undo(Graphics g)
        {
            if (stkCacNuocDaDi.Count != 0)
            {
                OCo oco = stkCacNuocDaDi.Pop();
                stkCacNuocUndo.Push(new OCo(oco.Dong,oco.Cot,oco.ViTri,oco.SoHuu));
                _MangOCo[oco.Dong, oco.Cot].SoHuu = 0;
                _BanCo.XoaQuanCo(g, oco.ViTri, sbGreen);
                if (_LuotDi == 1)
                    _LuotDi = 2;
                else
                    _LuotDi = 1;
            }
        }
        public void Redo(Graphics g)
        {
            if (stkCacNuocUndo.Count != 0)
            {
                OCo oco = stkCacNuocUndo.Pop();
                stkCacNuocDaDi.Push(new OCo(oco.Dong, oco.Cot, oco.ViTri, oco.SoHuu));
                _MangOCo[oco.Dong, oco.Cot].SoHuu = oco.SoHuu;
                _BanCo.VeQuanCo(g, oco.ViTri, oco.SoHuu == 1 ? sbBlack : sbWhite);
                if (_LuotDi == 1)
                    _LuotDi = 2;
                else
                    _LuotDi = 1;
            }
        }
        #endregion

        #region Duyệt chiến thắng
        public void KetThucTroChoi()
        {
            switch (_ketThuc)
            { 
                case KETTHUC.HoaCo:
                    MessageBox.Show("Hòa cờ!");
                    break;
                case KETTHUC.Player1:
                    MessageBox.Show("Người chơi 1 thắng!");
                    break;
                case KETTHUC.Player2:
                    MessageBox.Show("Người chơi 2 thắng!");
                    break;
                case KETTHUC.COM:
                    MessageBox.Show("Computer thắng!");
                    break;
            }
            _SanSang = false;
        }

        public bool KiemTraChienThang()
        {
            if (stkCacNuocDaDi.Count == _BanCo.SoCot * _BanCo.SoDong)
            {
                _ketThuc = KETTHUC.HoaCo;
                return true;
            }

            foreach (OCo oco in stkCacNuocDaDi)
            { 
                if(DuyetDoc(oco.Dong,oco.Cot,oco.SoHuu) || DuyetNgang(oco.Dong,oco.Cot,oco.SoHuu) || DuyetCheoXuoi(oco.Dong,oco.Cot,oco.SoHuu) || DuyetCheoNguoc (oco.Dong,oco.Cot,oco.SoHuu))
                {
                    _ketThuc = oco.SoHuu == 1 ? KETTHUC.Player1 : KETTHUC.Player2;
                    return true;
                }
            }
            return false;
        }

        private bool DuyetDoc(int currDong,int currCot, int currSoHuu)
        {
            if (currDong > _BanCo.SoDong - 5)
                return false;
            int Dem;
            for (Dem = 1; Dem < 5; Dem++)
            {
                if (_MangOCo[currDong + Dem, currCot].SoHuu != currSoHuu)
                    return false;
            }
            if (currDong == 0 || currDong + Dem == _BanCo.SoDong)
                return true;
            if (_MangOCo[currDong - 1, currCot].SoHuu == 0 || _MangOCo[currDong + Dem,currCot].SoHuu == 0)
                return true;
            return false;
        }
        private bool DuyetNgang(int currDong, int currCot, int currSoHuu)
        {
            if (currCot > _BanCo.SoCot - 5)
                return false;
            int Dem;
            for (Dem = 1; Dem < 5; Dem++)
            {
                if (_MangOCo[currDong, currCot + Dem].SoHuu != currSoHuu)
                    return false;
            }
            if (currCot == 0 || currCot + Dem == _BanCo.SoCot)
                return true;
            if (_MangOCo[currDong, currCot - 1].SoHuu == 0 || _MangOCo[currDong, currCot + Dem].SoHuu == 0)
                return true;
            return false;
        }
        private bool DuyetCheoXuoi(int currDong, int currCot, int currSoHuu)
        {
            if (currDong > _BanCo.SoDong - 5 || currCot > _BanCo.SoCot - 5)
                return false;
            int Dem;
            for (Dem = 1; Dem < 5; Dem++)
            {
                if (_MangOCo[currDong + Dem, currCot + Dem].SoHuu != currSoHuu)
                    return false;
            }
            if (currDong == 0 || currDong + Dem == _BanCo.SoDong || currCot == 0 || currCot + Dem == _BanCo.SoCot)
                return true;
            if (_MangOCo[currDong- 1, currCot - 1].SoHuu == 0 || _MangOCo[currDong + Dem, currCot + Dem].SoHuu == 0)
                return true;
            return false;
        }
        private bool DuyetCheoNguoc(int currDong, int currCot, int currSoHuu)
        {
            if (currDong < 4 || currCot > _BanCo.SoCot - 5)
                return false;
            int Dem;
            for (Dem = 1; Dem < 5; Dem++)
            {
                if (_MangOCo[currDong - Dem, currCot + Dem].SoHuu != currSoHuu)
                    return false;
            }
            if (currDong == 4 || currDong == _BanCo.SoDong - 1 || currCot == 0 || currCot + Dem == _BanCo.SoCot)
                return true;
            if (_MangOCo[currDong + 1, currCot - 1].SoHuu == 0 || _MangOCo[currDong - Dem, currCot + Dem].SoHuu == 0)
                return true;
            return false;
        }
        #endregion

        #region AI
        private long[] MangDiemTanCong = new long[7] { 0, 9, 54, 162, 1458, 13112, 118008 };
        private long[] MangDiemPhongNgu = new long[7] { 0, 3, 27, 99, 729, 6561, 59049 };
        
        public void KhoiDongComputer(Graphics g)
        {
            if (stkCacNuocDaDi.Count == 0)
            {
                DanhCo(_BanCo.SoCot / 2 * OCo._ChieuRong + 1, _BanCo.SoDong / 2 * OCo._ChieuCao + 1, g);
            }
            else
            {
                OCo oco = TimKiemNuocDi();
                DanhCo(oco.ViTri.X + 1, oco.ViTri.Y + 1, g);
            }
        }

        private OCo TimKiemNuocDi()
        {
            OCo oCoResult = new OCo();
            long DiemMax = 0;
            for (int i = 0; i < _BanCo.SoDong; i++)
            {
                for (int j = 0; j < _BanCo.SoCot; j++)
                {
                    if (_MangOCo[i, j].SoHuu == 0)
                    {
                        long DiemTanCong = DiemTanCong_DuyetDoc(i, j) + DiemTanCong_DuyetNgang(i, j) + DiemTanCong_DuyetCheoNguoc(i, j) + DiemTanCong_DuyetCheoXuoi(i, j);
                        long DiemPhongNgu = DiemPhongNgu_DuyetDoc(i, j) + DiemPhongNgu_DuyetNgang(i, j) + DiemPhongNgu_DuyetCheoNguoc(i, j) + DiemPhongNgu_DuyetCheoXuoi(i, j);
                        long DiemTam = DiemTanCong > DiemPhongNgu ? DiemTanCong : DiemPhongNgu;
                        if (DiemMax < DiemTam)
                        {
                            DiemMax = DiemTam;
                            oCoResult = new OCo(_MangOCo[i, j].Dong, _MangOCo[i, j].Cot, _MangOCo[i,j].ViTri, _MangOCo[i, j].SoHuu);
                        
                        }
                    }
                }
            }

            return oCoResult;
        }
        #region Tấn công
        private long DiemTanCong_DuyetDoc(int currDong,int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int Dem = 1; Dem < 6 && currDong + Dem < _BanCo.SoDong; Dem++)
            {
                if (_MangOCo[currDong + Dem, currCot].SoHuu == 1)
                    SoQuanTa++;
                else if (_MangOCo[currDong + Dem, currCot].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                    break;
            }

            for (int Dem = 1; Dem < 6 && currDong - Dem >= 0; Dem++)
            {
                if (_MangOCo[currDong - Dem, currCot].SoHuu == 1)
                    SoQuanTa++;
                else if (_MangOCo[currDong - Dem, currCot].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                    break;
            }
            if (SoQuanDich == 2)
                return 0;
            DiemTong -= MangDiemPhongNgu[SoQuanDich + 1]*2;
            DiemTong += MangDiemTanCong[SoQuanTa];
            return DiemTong;
        }
        private long DiemTanCong_DuyetNgang(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int Dem = 1; Dem < 6 && currCot + Dem < _BanCo.SoCot; Dem++)
            {
                if (_MangOCo[currDong, currCot + Dem].SoHuu == 1)
                    SoQuanTa++;
                else if (_MangOCo[currDong, currCot + Dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                    break;
            }

            for (int Dem = 1; Dem < 6 && currCot - Dem >= 0; Dem++)
            {
                if (_MangOCo[currDong, currCot - Dem].SoHuu == 1)
                    SoQuanTa++;
                else if (_MangOCo[currDong, currCot - Dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                    break;
            }
            if (SoQuanDich == 2)
                return 0;
            DiemTong -= MangDiemPhongNgu[SoQuanDich + 1] * 2;
            DiemTong += MangDiemTanCong[SoQuanTa];
            return DiemTong;
        }
        private long DiemTanCong_DuyetCheoNguoc(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int Dem = 1; Dem < 6 && currCot + Dem < _BanCo.SoCot && currDong - Dem >= 0; Dem++)
            {
                if (_MangOCo[currDong - Dem, currCot + Dem].SoHuu == 1)
                    SoQuanTa++;
                else if (_MangOCo[currDong - Dem, currCot + Dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                    break;
            }

            for (int Dem = 1; Dem < 6 && currCot - Dem >= 0 && currDong + Dem < _BanCo.SoDong; Dem++)
            {
                if (_MangOCo[currDong + Dem, currCot - Dem].SoHuu == 1)
                    SoQuanTa++;
                else if (_MangOCo[currDong + Dem, currCot - Dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                    break;
            }
            if (SoQuanDich == 2)
                return 0;
            DiemTong -= MangDiemPhongNgu[SoQuanDich + 1] * 2;
            DiemTong += MangDiemTanCong[SoQuanTa];
            return DiemTong;
        }
        private long DiemTanCong_DuyetCheoXuoi(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int Dem = 1; Dem < 6 && currCot + Dem < _BanCo.SoCot && currDong + Dem < _BanCo.SoDong; Dem++)
            {
                if (_MangOCo[currDong + Dem, currCot + Dem].SoHuu == 1)
                    SoQuanTa++;
                else if (_MangOCo[currDong + Dem, currCot + Dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                    break;
            }

            for (int Dem = 1; Dem < 6 && currCot - Dem >= 0 && currDong - Dem >= 0; Dem++)
            {
                if (_MangOCo[currDong - Dem, currCot - Dem].SoHuu == 1)
                    SoQuanTa++;
                else if (_MangOCo[currDong - Dem, currCot - Dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                    break;
            }
            if (SoQuanDich == 2)
                return 0;
            DiemTong -= MangDiemPhongNgu[SoQuanDich + 1] * 2;
            DiemTong += MangDiemTanCong[SoQuanTa];
            return DiemTong;
        }
        #endregion

        #region Phòng ngự
        private long DiemPhongNgu_DuyetDoc(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int Dem = 1; Dem < 6 && currDong + Dem < _BanCo.SoDong; Dem++)
            {
                if (_MangOCo[currDong + Dem, currCot].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong + Dem, currCot].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else
                    break;
            }

            for (int Dem = 1; Dem < 6 && currDong - Dem >= 0; Dem++)
            {
                if (_MangOCo[currDong - Dem, currCot].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong - Dem, currCot].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else
                    break;
            }
            if (SoQuanTa == 2)
                return 0;
            DiemTong += MangDiemPhongNgu[SoQuanDich];
            return DiemTong;
        }
        private long DiemPhongNgu_DuyetNgang(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int Dem = 1; Dem < 6 && currCot + Dem < _BanCo.SoCot; Dem++)
            {
                if (_MangOCo[currDong, currCot + Dem].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong, currCot + Dem].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else
                    break;
            }

            for (int Dem = 1; Dem < 6 && currCot - Dem >= 0; Dem++)
            {
                if (_MangOCo[currDong, currCot - Dem].SoHuu == 1)
                {
                    SoQuanTa++;
                         break;
                }
                else if (_MangOCo[currDong, currCot - Dem].SoHuu == 2)
                {
                    SoQuanDich++;
                 
                }
                else
                    break;
            }
            if (SoQuanTa == 2)
                return 0;
            DiemTong += MangDiemPhongNgu[SoQuanDich];
            return DiemTong;
        }
        private long DiemPhongNgu_DuyetCheoNguoc(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int Dem = 1; Dem < 6 && currCot + Dem < _BanCo.SoCot && currDong - Dem >= 0; Dem++)
            {
                if (_MangOCo[currDong - Dem, currCot + Dem].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong - Dem, currCot + Dem].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else
                    break;
            }

            for (int Dem = 1; Dem < 6 && currCot - Dem >= 0 && currDong + Dem < _BanCo.SoDong; Dem++)
            {
                if (_MangOCo[currDong + Dem, currCot - Dem].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong + Dem, currCot - Dem].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else
                    break;
            }
            if (SoQuanTa == 2)
                return 0;
            DiemTong += MangDiemPhongNgu[SoQuanTa];
            return DiemTong;
        }
        private long DiemPhongNgu_DuyetCheoXuoi(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int Dem = 1; Dem < 6 && currCot + Dem < _BanCo.SoCot && currDong + Dem < _BanCo.SoDong; Dem++)
            {
                if (_MangOCo[currDong + Dem, currCot + Dem].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong + Dem, currCot + Dem].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else
                    break;
            }

            for (int Dem = 1; Dem < 6 && currCot - Dem >= 0 && currDong - Dem >= 0; Dem++)
            {
                if (_MangOCo[currDong - Dem, currCot - Dem].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong - Dem, currCot - Dem].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else
                    break;
            }
            if (SoQuanTa == 2)
                return 0;

            DiemTong += MangDiemPhongNgu[SoQuanTa];
            return DiemTong;
        }
        #endregion

        #endregion
    }
}
