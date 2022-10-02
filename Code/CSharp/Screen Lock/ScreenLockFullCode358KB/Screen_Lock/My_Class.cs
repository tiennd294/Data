using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.IO;
using System.Data.SqlClient;

namespace Screen_Lock
{
    class My_Class
    {
        private static string _mypass;

        public static string Mypass
        {
            get { return My_Class._mypass; }
            set { My_Class._mypass = value; }
        }
        private static string _passclose;

        public static string Passclose
        {
            get { return My_Class._passclose; }
            set { My_Class._passclose = value; }
        }
        private static string _myuser;

        public static string Myuser
        {
            get { return My_Class._myuser; }
            set { My_Class._myuser = value; }
        }
        private static string _autolock;

        public static string Autolock
        {
            get { return My_Class._autolock; }
            set { My_Class._autolock = value; }
        }
        private static string _autostart;

        public static string Autostart
        {
            get { return My_Class._autostart; }
            set { My_Class._autostart = value; }
        }
        private static string _mylogo;

        public static string Mylogo
        {
            get { return My_Class._mylogo; }
            set { My_Class._mylogo = value; }
        }
        private static bool _closeapp;

        public static bool Closeapp
        {
            get { return My_Class._closeapp; }
            set { My_Class._closeapp = value; }
        }
        private static string _getpassclose;

        public static string Getpassclose
        {
            get { return My_Class._getpassclose; }
            set { My_Class._getpassclose = value; }
        }

        //Timer
        private static string _time_lock;

        public static string Time_lock
        {
            get { return My_Class._time_lock; }
            set { My_Class._time_lock = value; }
        }
        private static string _time_lock_value;

        public static string Time_lock_value
        {
            get { return My_Class._time_lock_value; }
            set { My_Class._time_lock_value = value; }
        }
        private static string _time_wait;

        public static string Time_wait
        {
            get { return My_Class._time_wait; }
            set { My_Class._time_wait = value; }
        }
        private static string _time_wait_value;

        public static string Time_wait_value
        {
            get { return My_Class._time_wait_value; }
            set { My_Class._time_wait_value = value; }
        }
        private static string _time_unlock;

        public static string Time_unlock
        {
            get { return My_Class._time_unlock; }
            set { My_Class._time_unlock = value; }
        }
        private static string _time_unlock_value;

        public static string Time_unlock_value
        {
            get { return My_Class._time_unlock_value; }
            set { My_Class._time_unlock_value = value; }
        }
        private static string _lockf;

        public static string Lockf
        {
            get { return My_Class._lockf; }
            set { My_Class._lockf = value; }
        }
        private static string _clTask;

        public static string ClTask
        {
            get { return My_Class._clTask; }
            set { My_Class._clTask = value; }
        }
        private static string _endTask;

        public static string EndTask
        {
            get { return My_Class._endTask; }
            set { My_Class._endTask = value; }
        }
        private static string _paCustomer;

        public static string PaCustomer
        {
            get { return My_Class._paCustomer; }
            set { My_Class._paCustomer = value; }
        }
        private static string _paScreen;

        public static string PaScreen
        {
            get { return My_Class._paScreen; }
            set { My_Class._paScreen = value; }
        }
        private static string _paData;

        public static string PaData
        {
            get { return My_Class._paData; }
            set { My_Class._paData = value; }
        }

        public static string _path_autorun = @"Software\Microsoft\Windows\CurrentVersion\Run";
        public static string _path_screen = @"Software\Screen";

        public static bool Check_SubKey(string _subkey = "", string _path = @"Software\")
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(_path + _subkey, true);
            bool vlkey = false;
            if (key != null) vlkey = true;
            return vlkey;
        }

        public static bool Check_Key(string _keyname = "", string _path = @"Software\Screen")
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(_path, true);
            return (key.GetValueNames().Contains(_keyname));
        }

        public static void CreateSubKey(string _subkey = "subkey", string _path = @"Software")
        {
            //Creating a sub Key
            //A key is a subfolder, in which you can add multiple values.
            //To create a sub key:
            RegistryKey key = Registry.CurrentUser.OpenSubKey(_path, true);
            //create a new sub key 
            key.CreateSubKey(_subkey);
            key.Close();
        }

        public static void DeleteSubKey(string _subkey = "subkey", string _path = @"Software")
        {
            //Deleting a sub Key
            //A key is a subfolder, in which you can add multiple values.
            //To deleting a sub key:
            RegistryKey key = Registry.CurrentUser.OpenSubKey(_path, true);
            //Deleting a new sub key 
            key.DeleteSubKey(_subkey);
            key.Close();
        }

        public static void SetValue(string _keyname = "keyname", string _keyvalue = "subkeyvalue", string _path = @"Software\Screen")
        {
            //try
            //{
                RegistryKey key = Registry.CurrentUser.OpenSubKey(_path, true);
                //adding/editing a value 
                key.SetValue(_keyname, _keyvalue); //sets 'someData' in 'someValue' 
                key.Close();
            //}
            //catch { }
            //Adding/Editing a value
            //Before doing this, you have to set the path to the key where you want to add that value. You can use the code below for adding or editing values.
            
        }

        public static void DeleteValue(string __keyname = "_keyname", string _path = @"Software\Screen")
        {
            //Deleting a value
            //And finally, when we got bored of values, we can delete them:
            //To deleting a value key:
            RegistryKey key = Registry.CurrentUser.OpenSubKey(_path, true);
            //deleting the value
            key.DeleteValue(__keyname);
            key.Close();
        }

        public static string GetValue(string __keyname = "_keyname", string _path = @"Software\Screen")
        {
            //Reading a value
            //You can get a value from a key by knowing its name:
            RegistryKey key = Registry.CurrentUser.OpenSubKey(_path, true);
            //getting the value
            string data = key.GetValue(__keyname).ToString();  //returns the text found in 'someValue'
            key.Close();
            return data;
        }

        public static string setdatetime(string date = "")
        {
            string mydata = "";
            DateTime dtwt = new DateTime();
            dtwt = DateTime.Parse(date);
            TimeSpan ts;
            ts = dtwt.Subtract(DateTime.Now);
            mydata = ts.ToString().Substring(0, 8);
            return mydata;
        }

        public static void get_data()
        {
            if (!My_Class.Check_SubKey("Screen"))
            {
                My_Class.CreateSubKey("Screen");
            };
            if (My_Class.Check_SubKey("Screen"))
            {
                if (!My_Class.Check_Key("ClTask")) My_Class.SetValue("ClTask", My_Class.Base64Encoding("False"));
                My_Class.ClTask = My_Class.Base64Decoding(My_Class.GetValue("ClTask"));

                if (!My_Class.Check_Key("EndTask")) My_Class.SetValue("EndTask", My_Class.Base64Encoding("False"));
                My_Class.EndTask = My_Class.Base64Decoding(My_Class.GetValue("EndTask"));

                if (!My_Class.Check_Key("PaData")) My_Class.SetValue("PaData", My_Class.Base64Encoding(""));
                My_Class.PaData = My_Class.Base64Decoding(My_Class.GetValue("PaData"));

                if (!My_Class.Check_Key("PaCustomer")) My_Class.SetValue("PaCustomer", My_Class.Base64Encoding(""));
                My_Class.PaCustomer = My_Class.Base64Decoding(My_Class.GetValue("PaCustomer"));

                if (!My_Class.Check_Key("PaScreen")) My_Class.SetValue("PaScreen", My_Class.Base64Encoding(""));
                My_Class.PaScreen = My_Class.Base64Decoding(My_Class.GetValue("PaScreen"));

                if (!My_Class.Check_Key("MyPass")) My_Class.SetValue("MyPass", My_Class.Base64Encoding("sdv"));
                My_Class.Mypass = My_Class.Base64Decoding(My_Class.GetValue("MyPass"));

                if (!My_Class.Check_Key("PassClose")) My_Class.SetValue("PassClose", My_Class.Base64Encoding("1325"));
                My_Class.Passclose = My_Class.Base64Decoding(My_Class.GetValue("PassClose"));

                if (!My_Class.Check_Key("AutoStart")) My_Class.SetValue("AutoStart", My_Class.Base64Encoding("False"));
                My_Class.Autostart = My_Class.Base64Decoding(My_Class.GetValue("AutoStart"));
                if (My_Class.Autostart == "True") My_Class.autostartup();

                if (!My_Class.Check_Key("AutoLock")) My_Class.SetValue("AutoLock", My_Class.Base64Encoding("False"));
                My_Class.Autolock = My_Class.Base64Decoding(My_Class.GetValue("AutoLock"));

                if (!My_Class.Check_Key("MyLogo")) My_Class.SetValue("MyLogo", My_Class.Base64Encoding("Team 3D5S Inspection"));
                My_Class.Mylogo = My_Class.Base64Decoding(My_Class.GetValue("MyLogo"));


                //Timer

                if (!My_Class.Check_Key("Time_wait")) My_Class.SetValue("Time_wait", My_Class.Base64Encoding("0"));
                My_Class.Time_wait = My_Class.Base64Decoding(My_Class.GetValue("Time_wait"));

                if (!My_Class.Check_Key("Time_wait_value")) My_Class.SetValue("Time_wait_value", My_Class.Base64Encoding(""));
                My_Class.Time_wait_value = My_Class.Base64Decoding(My_Class.GetValue("Time_wait_value"));


                if (!My_Class.Check_Key("Time_lock")) My_Class.SetValue("Time_lock", My_Class.Base64Encoding("Never"));
                My_Class.Time_lock = My_Class.Base64Decoding(My_Class.GetValue("Time_lock"));

                if (!My_Class.Check_Key("Time_lock_value")) My_Class.SetValue("Time_lock_value", My_Class.Base64Encoding(""));
                My_Class.Time_lock_value = My_Class.Base64Decoding(My_Class.GetValue("Time_lock_value"));

                if (!My_Class.Check_Key("Time_unlock")) My_Class.SetValue("Time_unlock", My_Class.Base64Encoding("Never"));
                My_Class.Time_unlock = My_Class.Base64Decoding(My_Class.GetValue("Time_unlock"));

                if (!My_Class.Check_Key("Time_unlock_value")) My_Class.SetValue("Time_unlock_value", My_Class.Base64Encoding(""));
                My_Class.Time_unlock_value = My_Class.Base64Decoding(My_Class.GetValue("Time_unlock_value"));
            }
        }

        public static string _convert_time(long _time = 1)
        {
            string _data = "";
            string __day, __hour, __minute, __seconds;
            long _day, _hour, _minute, _seconds;
            _seconds = _time % 60;
            _minute = (_time / 60) % 60;
            _hour = ((_time / 60) / 60) % 24;
            _day = ((_time / 60) / 60) / 24;
            if (_hour < 10) __hour = "0" + _hour.ToString(); else __hour = "" + _hour.ToString();
            if (_minute < 10) __minute = "0" + _minute.ToString(); else __minute = "" + _minute.ToString();
            if (_seconds < 10) __seconds = "0" + _seconds.ToString(); else __seconds = "" + _seconds.ToString();
            _data = __hour + ":" + __minute + ":" + __seconds;
            if (_day > 0) _data = _day + " day " + _data;
            return _data;
        }

        public static string _path_data = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "//Screen.xml";
        private static string getPath()
        {
            string _path = "";
            if (My_Class.PaData != "") _path = My_Class.PaData + "//Screen.xml";
            if (My_Class.PaData == "") _path = _path_data;
            return _path;
        }
        
        public static void add_data(string _status = "", string _datetime = "", string _content = "", string _table = "History")
        {
            //string _data = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "//Screen.xml";
            if (getPath().Substring(0, 1).ToUpper() != "C")
            {
                if (!File.Exists(getPath()))
                {
                    My_Class.CreateXML(_status, _datetime, _content, _table);
                }
                else My_Class.AddXElement(_status, _datetime, _content, _table);
            }
        }

        public static void CreateXML(string _status = "", string _datetime = "", string _content = "", string _table = "History")
        {
            //string _data = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "//Screen.xml";
            if (!File.Exists(getPath()))
            {
                XDocument doc = new XDocument(new XElement("Screen",
                                           new XElement(_table,
                                               new XAttribute("Id", "1"),
                                               new XElement("Status", _status),
                                               new XElement("DateTime", _datetime),
                                               new XElement("Content", _content))));
                doc.Save(getPath());
            }
        }

        public static void AddXElement(string _status = "", string _datetime = "", string _content = "", string _table = "History")
        {
            if (!File.Exists(getPath()))
            {
                XDocument doc = XDocument.Load(getPath());
                int i = 0;
                foreach (XElement p in doc.Descendants(_table))
                {
                    i++;
                }
                XDocument xmlDoc = XDocument.Load(getPath());
                xmlDoc.Element("Screen").Add(new XElement(_table, new XAttribute("Id", (i + 1).ToString()),
                                                                       new XElement("Status", _status),
                                                                       new XElement("DateTime", _datetime),
                                                                       new XElement("Content", _content)));
                xmlDoc.Save(getPath());
            }
            
        }

        private static XDocument LoadXmlDocument(string url)
        {
            try
            {
                return XDocument.Load(url);
            }
            catch
            {
                return null;
            }
        }

        public static DataTable loaddata(string _table = "History")
        {
            DataTable dtb = new DataTable();
            //if (dtb.Rows.Count > 0)
            try
            {
                XDocument doc = LoadXmlDocument(getPath());
                dtb.Columns.Add("Id");
                dtb.Columns.Add("Status");
                dtb.Columns.Add("Date Time");
                dtb.Columns.Add("Content");

                foreach (XElement p in doc.Descendants(_table))
                {
                    DataRow row = dtb.NewRow();
                    row[0] = p.Attribute("Id").Value;
                    row[1] = p.Element("Status").Value;
                    row[2] = p.Element("DateTime").Value;
                    row[3] = p.Element("Content").Value;
                    dtb.Rows.Add(row);
                }
            }
            catch
            { }
            return dtb;
        }

        

        private static string Base64Encoder(string value = "value")
        {
            var valueBytes = Encoding.UTF8.GetBytes(value);
            return Convert.ToBase64String(valueBytes);
        }

        private static string Base64Decoder(string value = "value")
        {
            var valueBytes = System.Convert.FromBase64String(value);
            return Encoding.UTF8.GetString(valueBytes);
        }

        public static string Base64Encoding(string value = "value")
        {
            return Base64Encoder(Base64Encoder(value));
        }

        public static string Base64Decoding(string value = "value")
        {
            return Base64Decoder(Base64Decoder(value));
        }

        public static void autostartup()
        {
            string _path_auto = @"Software\Microsoft\Windows\CurrentVersion\Run";
            if (My_Class.Autostart == "True")
            {
                My_Class.SetValue("Screen", System.Reflection.Assembly.GetExecutingAssembly().Location, _path_auto);
            }
            else My_Class.SetValue("Screen", "", _path_auto);
        }

        public static string md5(string data)
        {
            return BitConverter.ToString(encryptData(data)).Replace("-", "").ToLower();
        }

        public static byte[] encryptData(string data)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashedBytes;
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data));
            return hashedBytes;
        }

        public static string DecryptString(string Message, string Passphrase)
        {
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
            System.Security.Cryptography.MD5CryptoServiceProvider HashProvider = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));
            System.Security.Cryptography.TripleDESCryptoServiceProvider TDESAlgorithm = new System.Security.Cryptography.TripleDESCryptoServiceProvider();
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = System.Security.Cryptography.CipherMode.ECB;
            TDESAlgorithm.Padding = System.Security.Cryptography.PaddingMode.PKCS7;
            byte[] DataToDecrypt = Convert.FromBase64String(Message);
            try
            {
                System.Security.Cryptography.ICryptoTransform Decryptor = TDESAlgorithm.CreateDecryptor();
                Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length);
            }
            finally
            {
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }
            return UTF8.GetString(Results);
        }

    }
}