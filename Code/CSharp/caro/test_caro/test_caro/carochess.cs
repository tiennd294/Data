using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_caro
{
    public enum ketthuc
    { 
        hoaco,
        player1,
        player2,
        com
    }
    class carochess
    {
        public static Pen pen;
        public static SolidBrush sbblack;
        public static SolidBrush sbwhite;
        public static SolidBrush sbtest;
        private Oco[,] _mangoco;
        private Banco _banco;
        private Stack<Oco> stack_nuocdi;
        private Stack<Oco> stack_redo;
        private int _luotdi;
        private ketthuc _ketthuc;
        private bool _sansang;

        public bool _Sansang
        {
            get { return _sansang; }
            //set { _sansang = value; }
        }
       
        public carochess()
        {
            pen = new Pen(Color.Red);
            sbblack = new SolidBrush(Color.Black);
            sbwhite = new SolidBrush(Color.White);
            sbtest = new SolidBrush(Color.Gainsboro);
            _banco = new Banco(20,20);
            _mangoco = new Oco[_banco.Sodong,_banco.Socot];
            stack_nuocdi = new Stack<Oco>();
            stack_redo = new Stack<Oco>();
            _luotdi = 1;
        }
        public void vebanco(Graphics g)
        {
            _banco.Vebanco(g);
        }
        public void khoitaomangoco()
        {
            for (int i = 0; i < _banco.Sodong; i++)
            {
                for (int j = 0; j < _banco.Socot; j++)
                {
                    _mangoco[i, j] = new Oco(i,j,new Point(j*Oco._chieurong,i*Oco._chieucao),0);
                }
            }
        }
        public bool danhco(int MouseX,int MouseY, Graphics g)
        {
            if(MouseX%Oco._chieurong==0||MouseY%Oco._chieucao==0)
            return false;
            int cot = MouseX / Oco._chieurong;
            int dong = MouseY / Oco._chieucao;
            if (_mangoco[dong, cot].Sohuu != 0)
                return false;
            switch (_luotdi)
            { 
                case 1:
                    _mangoco[dong, cot].Sohuu = 1;
                    _banco.vequanco(g, _mangoco[dong, cot].Vitri, sbblack);
                    _luotdi = 2;
                    break;
                case 2:
                    _mangoco[dong, cot].Sohuu = 2;
                    _banco.vequanco(g, _mangoco[dong, cot].Vitri, sbwhite);
                    _luotdi = 1;
                    break;
                default:
                    MessageBox.Show("Error!");
                    break;
            }
            stack_redo = new Stack<Oco>();
            Oco oco = new Oco(_mangoco[dong, cot].Dong, _mangoco[dong, cot].Cot, _mangoco[dong, cot].Vitri, _mangoco[dong, cot].Sohuu);
            stack_nuocdi.Push(oco);
            return true;
        }
        public void velai(Graphics g)
        {
            foreach (Oco oco in stack_nuocdi)
            {
                if (oco.Sohuu == 1)
                    _banco.vequanco(g, oco.Vitri, sbblack);
                else if (oco.Sohuu == 2)
                    _banco.vequanco(g, oco.Vitri, sbwhite);
            }
        }
        public void PVSP(Graphics g)
        {
            _sansang = true;
            
            stack_nuocdi = new Stack<Oco>();
            stack_redo = new Stack<Oco>();
            _luotdi = 1;
            khoitaomangoco();
            vebanco(g);

        }
        public void Undo(Graphics g)
        {
            if(stack_nuocdi.Count!=0)
            {
                Oco oco = stack_nuocdi.Pop();

                stack_redo.Push(new Oco(oco.Dong,oco.Cot,oco.Vitri,oco.Sohuu));
                _mangoco[oco.Dong, oco.Cot].Sohuu = 0;
                _banco.xoaco(g, oco.Vitri, sbtest);
                if (_luotdi == 1)
                    _luotdi = 2;
                else _luotdi = 1;
            }
                //vebanco(g);
                //velai(g);
            
        }
        public void Redo(Graphics g)
        {
            if (stack_redo.Count != 0)
            {
                Oco oco = stack_redo.Pop();
                stack_nuocdi.Push(new Oco(oco.Dong, oco.Cot, oco.Vitri, oco.Sohuu));
                _mangoco[oco.Dong, oco.Cot].Sohuu = oco.Sohuu;
                _banco.vequanco(g, oco.Vitri, oco.Sohuu == 1 ? sbblack : sbwhite);
                if (_luotdi == 1)
                    _luotdi = 2;
                else _luotdi = 1;
            }
        }

        public void gameover()
        {
            switch (_ketthuc)
            { 
                case ketthuc.hoaco:
                    MessageBox.Show("Flower!");
                    break;
                case ketthuc.player1:
                    MessageBox.Show("Player 1 will!");
                    break;
                case ketthuc.player2:
                    MessageBox.Show("Player 2 will!");
                    break;
                case ketthuc.com:
                    MessageBox.Show("Computer will!");
                    break;
            }
        }
        public bool kiemtra()
        {
            if (stack_nuocdi.Count == _banco.Socot * _banco.Sodong)
            {
                return true;
            }
            foreach (Oco oco in stack_nuocdi)
            {
                if (duyetdoc(oco.Dong, oco.Cot, oco.Sohuu))
                {
                    _ketthuc = oco.Sohuu == 1 ? ketthuc.player1 : ketthuc.player2;
                    return true;
                }
            }
            return false;
        }
        private bool duyetdoc(int currdong, int currcot, int currsohuu)
        {
            if (currdong > _banco.Sodong - 5)
                return false;
            int dem;
            for (dem = 1; dem < 5; dem++)
            {
                if (_mangoco[currdong + dem, currcot].Sohuu != currsohuu)
                    return false;
            }
            if (currdong == 0 || currdong + dem == _banco.Sodong)
                return true;
            return false;
        }
    }
}
