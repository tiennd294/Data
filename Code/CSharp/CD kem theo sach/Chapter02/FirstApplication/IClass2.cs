using System;
namespace FirstApplication
{
    interface IClass2
    {
        System.Data.DataSet GetDataSet(string strSQL);
        System.Data.DataTable GetDataTable(string strSQL);
    }
}
