using System;
using System.Windows.Forms;

namespace FirstApplication
{
    class Class7
    {
        void UseFillValue()
        {
            Class3 cls = new Class3();
            ComboBox cb = new ComboBox();
            cb.Name = "Testing";
            string SQL = "select * from tblUsers";
            cls.FillValue(SQL, cb, "UserID", "Name");
        }
    }
}
