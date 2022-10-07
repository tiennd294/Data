using System;

namespace CustomExceptionProject
{
    class myException:System.Exception 

    {
        private string strMessage;
        public myException(string Msg) 
        {
            strMessage = Msg ;           
        }
         
        public string ErrorMessage
        {
            set { strMessage = value;}
            get { return strMessage;}
        }
    }
}
