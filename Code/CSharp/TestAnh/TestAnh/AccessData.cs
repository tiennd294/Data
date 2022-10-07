using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Data.SqlClient;
    
    namespace ImageInSQL
    {
        class AccessData
        {
            public SqlConnection conn;
    
            public string connectionString ="Data Source=NGUYEN_TIEN\SQLEXPRESS;Initial Catalog=Testanh2;Integrated Security=True";
            public AccessData()
            {
                conn = new SqlConnection(connectionString);
            }
            public void StorePicture(string filename)
            {
                byte[] imageData = null;
                // Read the file into a byte array
                using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    imageData = new Byte[fs.Length];
                    fs.Read(imageData, 0, (int) fs.Length);
                }
                string shortFileName = filename.Split('\\').Last();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("InsertImage", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@filename", shortFileName);
                    cmd.Parameters["@filename"].Direction = ParameterDirection.Input;
                    cmd.Parameters.Add("@Image",SqlDbType.Image);
                    cmd.Parameters["@Image"].Direction = ParameterDirection.Input;
                    // Store the byte array within the image field
                    cmd.Parameters["@Image"].Value = imageData;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
    
            public byte[] RetrieveImage(int id)
            {
                byte[] imageData = null;
                conn.Open();
                SqlCommand cmd = new SqlCommand("select Image from tbl_Image where ID="+id+"",conn);
                // Assume previously established command and connection
                // The command SELECTs the IMAGE column from the table
    
                using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SequentialAccess))
                {
                    reader.Read();
                    // Get size of image data – pass null as the byte array parameter
                    long bytesize = reader.GetBytes(0, 0, null, 0, 0);
                    // Allocate byte array to hold image data
                    imageData = new byte[bytesize];
                    long bytesread = 0;
                    int curpos = 0;
                    int chunkSize = 1;
                    while (bytesread < bytesize)
                    {
                        // chunkSize is an arbitrary application defined value
                        bytesread += reader.GetBytes(0, curpos, imageData, curpos, chunkSize);
                        curpos += chunkSize;
                    }
                }
                conn.Close();
                // byte array ‘imageData’ now contains BLOB from database
                return imageData;
            }
            public int NumberImageInDB()
            {
                conn.Open();
                SqlCommand cmd=new SqlCommand("select Max(ID) from tbl_Image",conn);
                int kq = int.Parse(cmd.ExecuteScalar().ToString());
                cmd.Dispose();
                conn.Close();
                return kq;
            }
            public string  FileNameOfImage(int id)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select FileName from tbl_Image where ID="+id+"", conn);
                string kq = cmd.ExecuteScalar().ToString();
                cmd.Dispose();
                conn.Close();
                return kq;
            }
        }
    }