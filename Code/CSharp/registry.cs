//public string Read_data(string KeyName, string subKey)
        //{
        //    // Opening the registry key
        //    RegistryKey rk = baseRegistryKey;
        //    // Open a subKey as read-only
        //    RegistryKey sk1 = rk.OpenSubKey(subKey);
        //    // If the RegistrySubKey doesn't exist -> (null)
        //    if (sk1 == null)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        try
        //        {
        //            // If the RegistryKey exists I get its value
        //            // or null is returned.
        //            return (string)sk1.GetValue(KeyName.ToUpper());
        //        }
        //        catch (Exception e)
        //        {
        //            // AAAAAAAAAAARGH, an error!
        //            ShowErrorMessage(e, "Reading registry " + KeyName.ToUpper());
        //            return null;
        //        }
        //    }

                //RegistryKey rk = Registry.CurrentUser;
                //RegistryKey srk = rk.CreateSubKey(@"Databin");
                //string SUB_KEY_NAME = @"SOFTWARE\Demo";
                //Registry.LocalMachine.CreateSubKey(SUB_KEY_NAME);
                //Registry.LocalMachine.CreateSubKey(@"SOFTWARE\SomeNewKey");
                //RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\WinRegistry"); SOFTWARE\Adobe\test
                //RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Adobe\test");
                //string data = key.GetValue("demo").ToString();
                //string data = Read_data("demo", @"SOFTWARE\Adobe\test");
                //RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Adobe\test");
                ////key.SetValue("sadsda", "asdsd");
                //MessageBox.Show("Successfuly!", "Infomartions!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //string data = key.GetValue("demo").ToString();

                //string asdss = "11";
                //if (key != null)
                //{
                //    //int width = int.Parse(key.GetValue("Width").ToString());
                //    //int height = int.Parse(key.GetValue("Height").ToString());
                //    //this.Size = new Size(width, height);
                //    asdss = key.GetValue("demo").ToString();

                //};
        //}

        //private void ShowErrorMessage(Exception e, string p)
        //{
        //    throw new NotImplementedException();
        //}





        //public RegistryKey baseRegistryKey { get; set; }

        //public string subKey { get; set; }