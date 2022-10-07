using System;
using System.Windows.Forms;

namespace FirstApplication
{
    class Class6
    {
        void UseFillValue()
        {
            Class5 cls = new Class5();
            ComboBox cb = new ComboBox();
            cb.Name = "Testing";
            string SQL = "select * from tblUsers";
            int i = 0;
            cls.FillValue(ref i,SQL, cb, "UserID", "Name");
        }
    }
}
