using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaSach.Builder_layer
{
    public class ErrorInfo
    {
        private int loi;
        public int Loi
        {
            get { return loi; }
            set { loi = value; }
        }

        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }
}
