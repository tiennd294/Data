using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace thunghiemsercong
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]//k viet cai nay co dc k a? ko dc day la cau bat bc
             //cai nay viet tren winform dc can j toi servies  a? day chi la vi du cho e coi thuj chu 
            /// ai o ko ma viet may cai nay service dung khi mot cty muon chia se nhung j ma doi tac can ma khong phai dua ra toan bo csdl cua minh cho toi tac
            /// //vi duhang dng a muon cho khach hang cua ngan hang quan doi rut tien thi ngan hang quan doi o csdl cua ngan hang q doi cho ngan hang dong a sao nen service dc sinh ra nhu vay
            /// e hieu a noi roi ma k biet ung dung vao bai tap the nao? thuj toi roi a ngu co j mai tiep divag pp a
        public int add(int a, int b)
        {
            return a + b;// day la 1 service do cai nay de hieu hon service cua form sao a k lam cua form a
            // form ngoi 3 gio chua chac da xong nua form ko hon niu form cung lam 1+1=2 ma lau vay a uh form kho hon rat nhiu 
            //the cai nay app;y vao dau a? ?vao dau tuy thich a dc
        }
    }
}