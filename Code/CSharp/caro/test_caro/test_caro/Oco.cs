using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;

namespace test_caro
{
    class Oco
    {
        
        public const int _chieucao = 25;
        public const int _chieurong = 25;
        private int _dong;

        public int Dong
        {
            get { return _dong; }
            set { _dong = value; }
        }
        private int _cot;

        public int Cot
        {
            get { return _cot; }
            set { _cot = value; }
        }
        private Point _vitri;

        public Point Vitri
        {
            get { return _vitri; }
            set { _vitri = value; }
        }
        private int _sohuu;

        public int Sohuu
        {
            get { return _sohuu; }
            set { _sohuu = value; }
        }
        public Oco(int dong, int cot, Point vitri, int sohuu)
        { 
            _dong = dong;
            _cot = cot;
            _vitri = vitri;
            _sohuu = sohuu;
        }
    }
}
