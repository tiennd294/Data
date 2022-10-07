using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class MainMaster : System.Web.UI.MasterPage
{
    public SqlConnection con = new SqlConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            getMenu();            
        }
    }

    private void getMenu()
    {
        Connect();
        con.Open();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        string sql = "Select * from tbl_WebMenu";
        SqlDataAdapter da = new SqlDataAdapter(sql, con);
        da.Fill(ds);
        dt = ds.Tables[0];
        DataRow[] drowpar = dt.Select("ParentID=" + 0);

        foreach (DataRow dr in drowpar)
        {
            menuBar.Items.Add(new MenuItem(dr["MenuName"].ToString(), dr["MenuID"].ToString(), 
			"", dr["MenuLocation"].ToString()));
        }

        foreach (DataRow dr in dt.Select("ParentID >" + 0))
        {
            MenuItem mnu = new MenuItem(dr["MenuName"].ToString(), dr["MenuID"].ToString(),
			"", dr["MenuLocation"].ToString());            
            menuBar.FindItem(dr["ParentID"].ToString()).ChildItems.Add(mnu);
        }
        con.Close();
    }

    public void Connect()
    {
        con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["cnstring"].ConnectionString);
    }
}
