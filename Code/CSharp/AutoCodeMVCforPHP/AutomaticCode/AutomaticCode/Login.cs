using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Collections;


namespace AutomaticCode
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection();

        string ServerNameMySql="";
        string strpathdefault = "";
        string strpathView = "";
        string strpathModel = "";
        string strpathControler = "";
        string filename="";
        string UrlView = "View";
        string UrlModel = "Model";
        string UrlControler = "Controller";
        string urlpath = "";
        DataSet dstb = new DataSet();
        string test = "Error!";
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            txtServer.Text = "localhost";
            txtUsername.Text = "root";
            btncreatcode.Enabled = false;
            btnsetview.Enabled = false;
        }

        public void Createforder(string strpath)
        {
            try
            {
              
                urlpath = strpath + @"\" + cmbDatabase.Text;
              
                strpathdefault = urlpath;
                strpathView = urlpath + @"\View";
                strpathModel = urlpath + @"\Model";
                strpathControler = urlpath + @"\Controller";
                if (!System.IO.Directory.Exists(strpathdefault))
                {
                    System.IO.Directory.CreateDirectory(strpathdefault);
                    System.IO.Directory.CreateDirectory(strpathView);
                    System.IO.Directory.CreateDirectory(strpathModel);
                    System.IO.Directory.CreateDirectory(strpathControler);
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());            
            }
        }
        public void CreateCode(string strpath, string strcode,string filename)
        {
            try
            {
               
                string filePath = strpath + @"\"+filename;
                
                File.WriteAllText(filePath,strcode);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void btncn_Click(object sender, EventArgs e)
        {
            
            #region Connect Mysql
           
                cmbDatabase.Items.Clear();//Server=localhost;Database=webtintuc;Uid=root;Pwd=
                ServerNameMySql = ServerNameMySql + "Server=" + txtServer.Text + ";UID=" + txtUsername.Text + ";PASSWORD="+txtPassword.Text;
                //ServerNameMySql="Server=localhost;Database=webtintuc;Uid=root;Pwd=";
                try
                {
                    MySqlConnection connection = new MySqlConnection(ServerNameMySql);
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "SHOW DATABASES;";
                    MySqlDataReader Reader;
                    connection.Open();
                    Reader = command.ExecuteReader();
                    while (Reader.Read())
                    {
                        string row = "";
                        for (int i = 0; i < Reader.FieldCount; i++)
                            row = Reader.GetValue(i).ToString();
                        cmbDatabase.Items.Add(row);
                    }
                    connection.Close();

                    cmbDatabase.Enabled = true;
                    MessageBox.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbDatabase.SelectedIndex = 0;
                    btncreatcode.Enabled = true;

                    cmbTable.Items.Clear();
                    DataSet dst = new DataSet();
                    string sqlt = "SHOW TABLES FROM " + cmbDatabase.SelectedItem;
                    dst = MySql.ExecuteDataTable_MySQL(ServerNameMySql, sqlt);
                    for (int i = 0; i < dst.Tables[0].Rows.Count; i++)
                    {
                        cmbTable.Items.Add(dst.Tables[0].Rows[i][0].ToString());
                    }
                    cmbTable.SelectedIndex = 0;
                    cmbTable.Enabled = true;
                    btncn.Enabled = false;
                    txtServer.Enabled = false;
                    txtUsername.Enabled = false;
                    txtPassword.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Lỗi, vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    
                }
            
            #endregion
            
        }

        private void btncreatcode_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Createforder(dialog.SelectedPath);
                    WriteCodeData(cmbDatabase.Text, UrlView);
                    WriteCodeData(cmbDatabase.Text, UrlModel);
                    WriteCodeData(cmbDatabase.Text, UrlControler);
                    MessageBox.Show("thanh cong", "Thông báo");
                }
            }
            catch { MessageBox.Show("Error!"); }
            
        }
        public void WriteCodeData(string strdb, string strnamespace)
        {

            try
            {
                string data = "";
                DataSet ds = new DataSet();
                DataSet dsc = new DataSet();
                string sqltb = "SHOW TABLES FROM " + cmbDatabase.Text;
                ds = MySql.ExecuteDataTable_MySQL(ServerNameMySql, sqltb);
                string columnname = "";
                string enddata = "";
                string newdata = "";
                #region ____Controller_____
                if (strnamespace == "Controller")
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        TextInfo UsaTextInfo = new CultureInfo("en-US", false).TextInfo;

                        filename = UsaTextInfo.ToTitleCase(ds.Tables[0].Rows[i][0].ToString());
                        string sqlcl = "SHOW COLUMNS FROM " + cmbDatabase.Text + "." + filename;
                        dsc = MySql.ExecuteDataTable_MySQL(ServerNameMySql, sqlcl);

                        data = data + "<?php if ( ! defined('PATH_SYSTEM')) die ('Bad requested!');\n\n" +

                        "class " + filename + "_" + strnamespace + " extends Base_Controller\n" +
                        "{\n" +
                            "    public function IndexAction()\n" +
                            "    {\n" +
                                "        $this->library->load('messenger');\n" +
                                "        $this->model->load('" + filename + "');\n" +
                                "        $data=$this->model->" + filename + "->load_table('" + filename + "');\n" +
                                "        $this->view->load('" + filename + "','" + filename + "',$data);\n" +
                            "    }\n\n" +

                            "    public function AddAction()\n" +
                            "    {\n" +
                                "        $data = array(\n";
                                for (int i1 = 0; i1 < dsc.Tables[0].Rows.Count; i1++)
                                {
                                    if ("auto_increment" != dsc.Tables[0].Rows[i1][5].ToString())
                                    {
                                        if (i1 + 1 == dsc.Tables[0].Rows.Count)
                                        {
                                            columnname = dsc.Tables[0].Rows[i1][0].ToString();
                                            enddata = "            '" + columnname + "' => $_POST['" + columnname + "'],\n";
                                            data = data + enddata.Replace(",", "");
                                        }
                                        else
                                        {
                                            columnname = dsc.Tables[0].Rows[i1][0].ToString();
                                            data = data + "            '" + columnname + "' => $_POST['" + columnname + "'],\n";
                                        }
                                    }
                                }
                                data = data + "        );\n" +
                                "        $this->model->load('" + filename + "');\n" +
                                "        $this->model->" + filename + "->insert_table('" + filename + "',$data);\n" +
                                "        $this->IndexAction();\n" +
                            "    }\n\n\n" +


                            "    public function EditAction()\n" +
                            "    {\n" +
                                "        $data = array(\n";
                                    int newkey = 0;
                                    for (int i1 = 0; i1 < dsc.Tables[0].Rows.Count; i1++)
                                    {
                                        
                                        if ("PRI" != dsc.Tables[0].Rows[i1][3].ToString())
                                        {
                                            newkey++;
                                            if (i1 + 1 == dsc.Tables[0].Rows.Count)
                                            {
                                                columnname = dsc.Tables[0].Rows[i1][0].ToString();
                                                newdata = "etextdata" + (newkey).ToString();
                                                enddata = "            '" + columnname + "' => $_POST['" + newdata + "'],\n";
                                                data = data + enddata.Replace(",", "");
                                            }
                                            else
                                            {
                                                columnname = dsc.Tables[0].Rows[i1][0].ToString();
                                                newdata = "etextdata" + (newkey).ToString();
                                                data = data + "            '" + columnname + "' => $_POST['" + newdata + "'],\n";
                                            }
                                        }
                                    }
                                    data = data + "        );\n" +
                                    "        if(isset($_POST['etextid'])){\n" +
                                    "        $where = array(\n";
                                    for (int i1 = 0; i1 < dsc.Tables[0].Rows.Count; i1++)
                                    {

                                        if ("PRI" == dsc.Tables[0].Rows[i1][3].ToString())
                                        {
                                            data = data + "            '" + dsc.Tables[0].Rows[i1][0].ToString() + "' => $_POST['etextid']\n";
                                        }
                                    }



                                    data = data + "        );\n" +
                                   "        $this->model->load('" + filename + "');\n" +
                                   "        $this->model->" + filename + "->update_table('" + filename + "',$data,$where);\n" +
                                   "        $this->IndexAction();\n" +
                                   "        }\n" +
                                   "        else {\n" +
                                       "            $this->library->load('messenger');\n" +
                                       "            $this->library->messenger->ViewError('show');\n" +
                                   "        }\n" +
                               "    }\n\n\n" +


                               "   public function DeleteAction()\n" +
                               "   {\n" +
                                   "        if(isset($_POST['textid'])){\n" +
                                   "        $where = array(\n";

                                    for (int i1 = 0; i1 < dsc.Tables[0].Rows.Count; i1++)
                                    {

                                        if ("PRI" == dsc.Tables[0].Rows[i1][3].ToString())
                                        {
                                            data = data + "            '" + dsc.Tables[0].Rows[i1][0].ToString() + "' => $_POST['textid']\n";
                                        }
                                    }
                                data = data + "        );\n" +
                                "        $this->model->load('" + filename + "');\n" +
                                "        $this->model->" + filename + "->delete_table('" + filename + "',$where);\n" +
                                "        $this->IndexAction();\n" +
                                "        }\n" +
                                "        else {\n" +
                                    "            $this->library->load('messenger');\n" +
                                    "            $this->library->messenger->ViewError('show');\n" +
                                "        }\n" +
                            "    }\n" +
                        "}";
                        CreateCode(strpathControler, data, filename + "_" + strnamespace + ".php");
                        data = "";
                    }
                }
                #endregion Controller

                #region ___Model___
                else
                    if (strnamespace == "Model")
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            TextInfo UsaTextInfo = new CultureInfo("en-US", false).TextInfo;

                            filename = UsaTextInfo.ToTitleCase(ds.Tables[0].Rows[i][0].ToString());
                            data += "<?php if ( ! defined('PATH_SYSTEM')) die ('Bad requested!');\n\n" +

                                    "class " + filename + "_" + strnamespace + " extends My_Model\n" +
                                    "{\n" +
                                        "    public function load_table($table)\n" +
                                        "    {\n" +
                                            "        parent::connect();\n" +
                                            "        $data=parent::loaddata($table);\n" +
                                            "        return $data;\n" +
                                        "    }\n\n" +

                                        "    public function insert_table($table, $data)\n" +
                                        "    {\n" +
                                            "        parent::connect();\n" +
                                            "        return parent::insert($table,$data);\n" +
                                        "    }\n\n" +

                                        "    public function update_table($table, $data, $where)\n" +
                                        "    {\n" +
                                            "        parent::connect();\n" +
                                            "        return parent::update($table,$data, $where);\n" +
                                        "    }\n\n" +

                                        "    public function delete_table($table, $where)\n" +
                                        "    {\n" +
                                            "        parent::connect();\n" +
                                            "        return parent::remove($table,$where);\n" +
                                        "    }\n" +
                                    "}";
                            CreateCode(strpathModel, data, filename + "_" + strnamespace + ".php");
                            data = "";
                        }
                    }
                #endregion Model

                #region View
                    else
                        if (strnamespace == "View")
                        {
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                TextInfo UsaTextInfo = new CultureInfo("en-US", false).TextInfo;
                                string urlform = ds.Tables[0].Rows[i][0].ToString();
                                filename = UsaTextInfo.ToTitleCase(ds.Tables[0].Rows[i][0].ToString());
                                string newpathview = strpathView + @"\"+filename;
                                if (!System.IO.Directory.Exists(newpathview))
                                {
                                    System.IO.Directory.CreateDirectory(newpathview);
                                }

                                string sqlclv = "SHOW COLUMNS FROM " + cmbDatabase.Text + "." + filename;
                                dsc = MySql.ExecuteDataTable_MySQL(ServerNameMySql, sqlclv);

                                //Load data
                                #region __Load data__
                                data += "    <div id='datatable' class='container-fluid'>\n" +
                                             "        <input id='searchInput' value='' placeholder='Key' class='span3 email' style='margin-left: 5%;'/>\n" +
                                                "        <div class='row-fluid'>\n" +
                                                  "            <div class='span12'>\n" +
                                                    "                <div class='widget-box'>\n" +
                                                      "                    <div class='widget-title'>\n" +
                                                         "                        <span class='icon'><i class='icon-th'></i></span>\n\n" +


                                                            "                        <div class='table-action'>\n" +
                                                               "                            <a href='#' class='btnadd tip-top' data-original-title='Add'><i class='icon-plus'></i> Thêm mới</a>\n" +
                                                            "                        </div>\n" +





                                                      "                    </div>\n" +
                                                      "                    <div class='widget-content nopadding' style='overflow: auto;'>\n" +
                                                        "                        <table class='table table-bordered data-table paginated'>\n" +
                                                          "                            <thead>\n" +
                                                           "                                <tr>\n";
                                for (int cv = 0; cv < dstb.Tables[ds.Tables[0].Rows[i][0].ToString()].Rows.Count; cv++)
                                {
                                    data += "                                    <th>" + dstb.Tables[ds.Tables[0].Rows[i][0].ToString()].Rows[cv][2].ToString() + "</th>  \n";
                                }


                                data += "                                    <th>Quan Ly</th>\n" +
                                    "                                </tr>\n" +
                                 "                            </thead>\n" +
                                 "                            <tbody id='fbody'>\n" +

                    "                            <?php\n" +
                           "                                $i=0;\n" +
                           "                                while($row=mysql_fetch_array($data))\n" +
                           "                                {\n" +
                             "                                    $i++;\n" +
                       "                            ?>\n" +
                                           "                                <tr class='gradeU' id='<?php echo $row['" + dsc.Tables[0].Rows[0][0].ToString() + "']; ?>'>\n";

                                           for(int clv=0;clv<dsc.Tables[0].Rows.Count;clv++)
                                           {
                                               data += "                                    <td><?php echo $row['" + dsc.Tables[0].Rows[clv][0].ToString() + "']; ?></td>\n";
                                           }


                                           data += "                                    <td style='text-align: center;'><a href='#' class='btn btn-mini tip-top btnedit btn-primary' data-original-title='Edit'>Sửa</a> <a href='#' class='btn btn-mini tip-top btndelete btn-danger' data-original-title='Delete'>Xóa</a></td>\n" +
                                           "                                </tr>\n" +

                       "                            <?php\n" +
                           "                            }\n" +
                       "                            ?>\n" +
                                 "                            </tbody>\n" +
                               "                        </table>\n\n\n" +


                           "                    </div>\n" +
                          "                </div><div id='pagination' class='' style='text-align: center;'></div>\n" +

                         "            </div>\n" +
                       "        </div>\n" +
                     "    </div>\n\n\n\n\n";
                                    #endregion 

                               #region __Form Add__
                                           data += "	<div class='frmadd' style='width:50%;text-align: center; margin-left: 24%;'>\n" +
                                           "		<div class='container-fluid'>\n" +
                                           "			<div class='row-fluid'>\n" +
                                           "				<div class='span12'>\n" +
                                           "					<div class='widget-box'>\n" +
                                           "						<div class='widget-title'>\n" +
                                           "									<span class='icon'>\n" +
                                           "										<i class='icon-align-justify'></i>\n" +
                                           "									</span>\n" +
                                           "									<h5>Personal-info</h5>\n" +
                                           "						</div>\n" +
                                           "						<div class='widget-content nopadding'  align='left'>\n" +
                                           "							<form id='form1' class='form-horizontal' name='form1' method='post' action='?c=" + urlform + "&a=add'>\n\n";
                                           for (int ca = 0; ca < dstb.Tables[ds.Tables[0].Rows[i][0].ToString()].Rows.Count; ca++)
                                           {
                                               string strid = dstb.Tables[ds.Tables[0].Rows[i][0].ToString()].Rows[ca][0].ToString();
                                               string strvalue = dstb.Tables[ds.Tables[0].Rows[i][0].ToString()].Rows[ca][2].ToString();
                                               string strtype = dstb.Tables[ds.Tables[0].Rows[i][0].ToString()].Rows[ca][3].ToString();
                                               if (dsc.Tables[0].Rows[ca][5].ToString() == "auto_increment" && dsc.Tables[0].Rows[ca][0].ToString() == strid)
                                                   data += "\n";
                                               else
                                                   data += getcontrol(strid,strvalue,strtype);
                                           }
                                           data += "								<div class='form-actions'   align='center'>\n" +
                                           "									<button id='btnadd' class='btn btn-success'>Save</button>\n" +
                                           "									<button type='button' class='btn btn-back'> </button>\n" +
                                           "								</div>\n" +
                                           "							</form>\n" +
                                           "						</div>\n" +
                                           "					</div>\n" +
                                           "				</div>\n" +
                                           "			</div>\n" +
                                           "		</div>\n" +
                                           "	</div>\n\n\n\n\n\n\n";

                               #endregion 

                               #region  ____Form Edit____
                                           data += "	<div class='frmedit' style='width:50%;text-align: center; margin-left: 24%;'>\n" +
                                                   "		<div class='container-fluid'>\n" +
                                                   "			<div class='row-fluid'>\n" +
                                                   "				<div class='span12'>\n" +
                                                   "					<div class='widget-box'>\n" +
                                                   "						<div class='widget-title'>\n" +
                                                   "									<span class='icon'>\n" +
                                                   "										<i class='icon-align-justify'></i>\n" +
                                                   "									</span>\n" +
                                                   "									<h5>Personal-info</h5>\n" +
                                                   "						</div>\n" +
                                                   "						<div class='widget-content nopadding'  align='left'>\n" +
                                                   "							<form id='form3' class='form-horizontal' name='form3' method='post' action='?c=" + urlform + "&a=edit'>\n";
                                           int ide = 1;
                                            for (int ce = 0; ce < dstb.Tables[ds.Tables[0].Rows[i][0].ToString()].Rows.Count; ce++)
                                            {
                                                
                                                string strid = dstb.Tables[ds.Tables[0].Rows[i][0].ToString()].Rows[ce][0].ToString();
                                                string strvalue = dstb.Tables[ds.Tables[0].Rows[i][0].ToString()].Rows[ce][2].ToString();
                                                string strtype = dstb.Tables[ds.Tables[0].Rows[i][0].ToString()].Rows[ce][3].ToString();
                                                if (dsc.Tables[0].Rows[ce][3].ToString() == "PRI" && dsc.Tables[0].Rows[ce][0].ToString() == strid)
                                                    data += "								<div class='control-group'>\n" +
                                                    "										<label class='control-label'>" + strvalue + " :</label>\n" +
                                                    "										<div class='controls'><input id='etextid' name='etextid' type='text' class='span20 etextid'/></div>\n" +
                                                    "								</div>\n";
                                                else
                                                {
                                                    strid = "etextdata" + (ide).ToString();
                                                    data += getcontrol(strid, strvalue, strtype);
                                                    ide++;
                                                }
                                               
                                            }
                                            data += "								<div class='form-actions'   align='center'>\n" +
                                                    "									<button id='btnedit' class='btn btn-success'>Save</button>\n" +
                                                    "									<button type='button' class='btn btn-back'> </button>\n" +
                                                    "								</div>\n" +
                                                    "							</form>\n" +
                                                    "						</div>\n" +
                                                    "					</div>\n" +
                                                    "				</div>\n" +
                                                    "			</div>\n" +
                                                    "		</div>\n" +
                                                    "	</div>\n\n\n\n\n\n\n\n"; 	

                               #endregion


                               #region  _________Form Delete_________

                                            data += "	<div class='frmdelete' style='width:50%;text-align: center; margin-left: 24%;'>\n" +
                                        "		<div class='container-fluid'>\n" +
                                        "			<div class='row-fluid'>\n" +
                                        "				<div class='span12'>\n" +
                                        "					<div class='widget-box'>\n" +
                                        "						<div class='widget-title'>\n" +
                                        "									<span class='icon'>\n" +
                                        "										<i class='icon-align-justify'></i>\n" +
                                        "									</span>\n" +
                                        "									<h5>Xóa</h5>\n" +
                                        "						</div>\n" +
                                        "						<div class='widget-content nopadding'  align='left'>\n" +
                                        "							<form id='form2' class='form-horizontal' name='form2' method='post' action='?c=" + urlform + "&a=delete'>\n" +
                                        "								<div class='control-group' style='padding-left:5px; padding-top:5px;'>\n"+                       
                                        "                                   	<div class='control-group'>\n"+
                                        "                                        <label class='control-label'>ID " + urlform + ":</label>\n" +
                                        "                                        <div class='controls'>\n"+
                                        "                                        <input id='textid' class='textid' name='textid' type='text' class='span20' />\n"	+										
                                        "                                        </div>\n"+
                                        "                                    </div>\n"+
                                        "                                    <label id='Label2' class='control-label'> Bạn có chắc chắn muốn xóa không?</label>\n"+
                                        "                                </div>\n"+
		
                                        "								<div class='form-actions  txtc'   align='center'>\n"+
                                        "									<button id='btndelete' class='btn btnyes btn-success'>Có</button>\n"+
                                        "									<button id='btnhuy'  class='btn btn-success btncancel' style='margin-left:10px'> Không</button>\n"+
                                        "								</div>\n"+
                                        "							</form>\n"+
                                        "						</div>\n"+
                                        "					</div>\n"+
                                        "				</div>\n"+
                                        "			</div>\n"+
                                        "		</div>\n"+
                                        "	</div>\n</div>\n"; 	
                               #endregion

                                            CreateCode(newpathview, data, filename + ".php");
                                    data = "";
                            }
                        }
                #endregion View


            }
            catch { }
            
        }

        #region GetDataType
        public string GetDataType(string s)
        {
            if (s == "char" || s == "nchar" || s == "varchar" || s == "nvarchar" || s == "nvarchar(max)" || s == "text" || s == "ntext")
                return "string";
            if (s == "int" || s == "smallint" || s == "tinyint" || s == "bigint" || s == "numeric" || s == "smallmoney")
                return "int";
            if (s == "money")
                return "long";
            if (s == "float" || s == "real")
                return "float";
            if (s == "decimal" || s == "binary" || s == "varbinary" || s == "image")
                return "decimal";
            if (s == "datetime" || s == "smalldatetime" || s == "date" || s == "time")
            return "DateTime";
            if (s == "bit")
                return "bool";
            return s;
        }
        #endregion GetDataType

        private void cmbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dstb.Clear();
                cmbTable.Items.Clear();
                DataSet dst = new DataSet();
                string sqlt = "SHOW TABLES FROM " + cmbDatabase.SelectedItem;
                dst = MySql.ExecuteDataTable_MySQL(ServerNameMySql, sqlt);
                for (int i = 0; i < dst.Tables[0].Rows.Count; i++)
                {
                    cmbTable.Items.Add(dst.Tables[0].Rows[i][0].ToString());
                }
                cmbTable.SelectedIndex = 0;
            }
            catch { MessageBox.Show("Error!"); }
        }

        private void cmbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //dstb.Clear();
                GVView.DataSource = null;
                GVView.Rows.Clear();
                btnsetview.Enabled = true;
                adddata(cmbTable.SelectedItem.ToString());

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
            }
        }

        public void adddata(string strtb)
        {
            DataSet dstda = new DataSet();
            string sqltb = "SHOW COLUMNS FROM " + cmbDatabase.SelectedItem + "." + strtb;
            dstda = MySql.ExecuteDataTable_MySQL(ServerNameMySql, sqltb);
            //MessageBox.Show(sqlt);
            
            //add columns
            GVView.ColumnCount = 3;
            GVView.Columns[0].Name = "NameID";
            GVView.Columns[1].Name = "Type";
            GVView.Columns[2].Name = "ViewName";

            for (int a = 0; a < dstda.Tables[0].Rows.Count; a++)
            {
                    //add items
                    ArrayList row = new ArrayList();
                    row.Add(dstda.Tables[0].Rows[a][0].ToString());
                    row.Add(dstda.Tables[0].Rows[a][1].ToString());
                    GVView.Rows.Add(row.ToArray());  
            }

            DataGridViewComboBoxColumn combodata = new DataGridViewComboBoxColumn();
            combodata.HeaderText = "ViewType";
            combodata.Name = "ViewType";
            ArrayList row2 = new ArrayList();
            row2.AddRange(new String[] { "Textbox", "Checkboxes", "Select", "Password", "Images", "Textarea", "Radio" });
            combodata.Items.AddRange(row2.ToArray());
            GVView.Columns.Add(combodata);

            
            
        }

        private void btnsetview_Click(object sender, EventArgs e)
        {
            try
            {
                //dstb.Clear();
                DataTable dttb = new DataTable(cmbTable.SelectedItem.ToString());
                dttb.Columns.Add("NameID");
                dttb.Columns.Add("Type");
                dttb.Columns.Add("ViewName");
                dttb.Columns.Add("ViewType");
                //dttb.Rows.Add("2", "3", "4", "5");
                bool testv = false;



                DataSet dstda = new DataSet();
                string sqltb = "SHOW COLUMNS FROM " + cmbDatabase.SelectedItem + "." + cmbTable.SelectedItem;
                dstda = MySql.ExecuteDataTable_MySQL(ServerNameMySql, sqltb);
                for (int ids = 0; ids < dstda.Tables[0].Rows.Count; ids++)
                {
                
                        string strname = GVView.Rows[ids].Cells[0].Value.ToString();
                        string strtype = GVView.Rows[ids].Cells[1].Value.ToString();
                        string strviewname = GVView.Rows[ids].Cells[2].Value.ToString();
                        string strviewtype = GVView.Rows[ids].Cells[3].Value.ToString();
                        dttb.Rows.Add(strname, strtype, strviewname, strviewtype);
                        testv = true;
                
                }

                if (testv==true)
                {
                    dstb.Tables.Add(dttb);
                    test = dstb.Tables[cmbTable.SelectedItem.ToString()].Rows[0][2].ToString();
                    lblinfoview.Text = lblinfoview.Text + cmbTable.SelectedItem.ToString()+" ";
                }

            }
            catch 
            {
                    MessageBox.Show("Nhap sai!");
            }
        }

        public string getcontrol(string id,string viewname,string viewtype)
        {
            
            string data="";
            if (viewtype == "Textbox")
            {
                    data += "								<div class='control-group'>\n" +
                            "									<label class='control-label'>" + viewname + " :</label>\n" +
                            "									<div class='controls'>\n" +
                            "										<input  name='" + id + "' type='text' class='span20 " + id + "' placeholder='" + viewname + "' />\n" +
                            "									</div>\n" +
                            "								</div>\n\n";
            }

            if (viewtype == "Checkboxes")
            {
                data += "<div class='control-group'>" +
                                        "<label class='control-label'>" + viewname + "</label>" +
                                        "<div class='controls'>" +
                                            "<label><input type='checkbox' name='radios' /> First One</label>" +
                                            "<label><input type='checkbox' name='radios' /> Second One</label>" +
                                            "<label><input type='checkbox' name='radios' /> Third One</label>" +
                                        "</div>" +
                                    "</div>	";
            }

            if (viewtype == "Select")
            {
                data += "<div class='control-group'>" +
                                        "<label class='control-label'>" + viewname + "</label>" +
                                        "<div class='controls '>" +
                                            "<select id='" + id + "'>" +
                                                "<option>First option</option>" +
                                            "</select>" +
                                        "</div>" +
                                    "</div>";
            }

            if (viewtype == "Images")
            {
                data+="<div class='control-group'>"+
                                        "<label class='control-label'>" + viewname + " :</label>" +
										"<div class='controls'>"+
                                            "<img id='" + id + "' src='#' alt='Example'/>" +
										"</div>"+
									"</div>";
            }

            if (viewtype == "Textarea")
            {
                            data += "<div class='control-group'>" +
                                        "<label class='control-label'>" + viewname + ":</label>" +
                                        "<div class='controls'>" +
                                        "</div>" +
                                    "</div>" +
                                    "<div class='control-group' style='padding-right: 1%;'>" +
                                    "<textarea  name='" + id + "' class='span20 " + id + " ckeditor' rows='5' ></textarea>" +
                                    "</div>";
            }

            if (viewtype == "Radio")
            {
                data += "<div class='control-group'>" +
                                        "<label class='control-label'>" + viewname + "</label>" +
                                        "<div class='controls'>" +
                                            "<label><input type='radio' name='radios' /> First One</label>" +
                                            "<label><input type='radio' name='radios' /> Second One</label>" +
                                            "<label><input type='radio' name='radios' /> Third One</label>" +
                                        "</div>" +
                                    "</div>";
            }

            if (viewtype == "Password")
            {
                data += "<div class='control-group'>" +
                                        "<label class='control-label'>" + viewname + " :</label>" +
                                        "<div class='controls'>" +
                                            "<input id='" + id + "' name='" + id + "' type='password  class='span20 " + id + "' placeholder='Enter Password'  />" +
                                        "</div>" +
                                    "</div>";
            }
            return data;
        }
    }
}
