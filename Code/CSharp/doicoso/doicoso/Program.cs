using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace doicoso
{
    class Program
    {
        static void Main(string[] args)
        {
            long sothapphan = Convert.ToInt64(lblHienThi1.Text.Trim());
            lblHienThi1.Text = "";
            Stack stack1 = new Stack();
            do
            {

                stack1.Push(sothapphan % 16);
                sothapphan = sothapphan / 16;

            } while (sothapphan > 0);
            int count = stack1.Count;
            while (count > 0)
            {
                int a = Convert.ToInt32(stack1.Pop().ToString());
                switch (a)
                {
                    case 0: lblHienThi1.Text += 0; break;
                    case 1: lblHienThi1.Text += 1; break;
                    case 2: lblHienThi1.Text += 2; break;
                    case 3: lblHienThi1.Text += 3; break;
                    case 4: lblHienThi1.Text += 4; break;
                    case 5: lblHienThi1.Text += 5; break;
                    case 6: lblHienThi1.Text += 6; break;
                    case 7: lblHienThi1.Text += 7; break;
                    case 8: lblHienThi1.Text += 8; break;
                    case 9: lblHienThi1.Text += 9; break;
                    case 10: lblHienThi1.Text += "A"; break;
                    case 11: lblHienThi1.Text += "B"; break;
                    case 12: lblHienThi1.Text += "C"; break;
                    case 13: lblHienThi1.Text += "D"; break;
                    case 14: lblHienThi1.Text += "E"; break;
                    case 15: lblHienThi1.Text += "F"; break;
                    default: lblHienThi1.Text = "Không Thể Chuyển Đổi"; break;
                }
                count--;
            }
        }
    }
}
