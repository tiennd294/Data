using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_caro
{
    class Banco
    {
        private int _sodong;

        public int Sodong
        {
            get { return _sodong; }
            set { _sodong = value; }
        }
        private int _socot;

        public int Socot
        {
            get { return _socot; }
            set { _socot = value; }
        }
        public Banco()
        {
            _sodong = 0;
            _socot = 0;
        }
        public Banco(int sodong, int socot)
        {
            _sodong = sodong;
            _socot = socot;
        }
        public void Vebanco(Graphics g)
        {
            for (int i = 0; i <= _socot; i++)
            {
                g.DrawLine(carochess.pen, i * Oco._chieurong, 0, i * Oco._chieurong, _sodong * Oco._chieucao);
            }
            for (int j = 0; j <= _sodong; j++)
            {
                g.DrawLine(carochess.pen, 0, j * Oco._chieucao, _socot * Oco._chieurong, j * Oco._chieucao);
            }
        }
        public void vequanco(Graphics g, Point point, SolidBrush sb)
        {
            g.FillEllipse(sb, point.X+2, point.Y+2,Oco._chieurong-4,Oco._chieucao-4);
           
        }
        public void xoaco(Graphics g, Point point, SolidBrush sb)
        {
            g.FillRectangle(sb, point.X + 1, point.Y + 1, Oco._chieurong - 2, Oco._chieucao - 2);
        }
    }
}
