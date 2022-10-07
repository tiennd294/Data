/*
---00--- Copyright by SmartCode ---00---
------ Website :http://www.kontac.net ------
            
---00--- Customize by Hoai Thanh Trinh ---00---
------ Email :hoaithanhtrinh@gmail.com ------
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace LTND
{
	/// <summary>
    /// This is base-class to all sub class which contact to database
    /// </summary>
 public class BaseObject
	{
		
		/// <summary>
		/// Return Sql connection object
		/// </summary>
		public SqlConnection CreateConnection()
		{
			//get
			{
				//return new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"].ToString());
                return new SqlConnection(@"Data Source=.\NGUYENTIEN;Initial Catalog=LTND_DEMO;Integrated Security=True");
			}            
		}
		
		/// <summary>
		/// Create a command object
		/// </summary>
		/// <param name="txtText"></param>
		/// <param name="cmdParams"></param>
		/// <returns></returns>
		public SqlCommand CreateCommand(string txtText,params SqlParameter[] cmdParams)
		{   
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = txtText;
			cmd.CommandType = CommandType.Text;

			if (cmdParams != null && cmdParams.Length>0 )
			{
				cmd.Parameters.AddRange(cmdParams);
			}
			return cmd;
		}
		
		/// <summary>
		/// Return datatable object which contain in cmdText command
		/// </summary>
		/// <param name="cmdText"></param>
		/// <param name="cmdParams"></param>
		/// <returns></returns>
		public DataTable ExecDataTable(string cmdText, params SqlParameter[] cmdParams)
		{
			DataTable resultDT = new DataTable();

			using (SqlConnection dbConn = CreateConnection())
			{

				using (SqlCommand dbCmd = CreateCommand(cmdText,cmdParams))
				{   
					dbCmd.Connection = dbConn;
					try
					{
						dbConn.Open();

						using (SqlDataAdapter dbDA = new SqlDataAdapter())
						{
							dbDA.SelectCommand = dbCmd;
							dbDA.Fill(resultDT);
						}
						dbConn.Close();
					}                   
					finally
					{
						if(dbConn.State==ConnectionState.Open)
							dbConn.Close();
					}
				}
			}
			return resultDT;
		}

		/// <summary>
		/// Run a update sql
		/// </summary>
		/// <param name="cmdText"></param>
		/// <param name="cmdParams"></param>
		/// <returns></returns>
		public int ExcuteUpdateCommand(string cmdText, params SqlParameter[] cmdParams)
		{
			int result = -1;
			using (SqlConnection dbConn = CreateConnection())
			{
				using (SqlCommand dbCmd = CreateCommand(cmdText, cmdParams))
				{
					dbCmd.Connection = dbConn;
					try
					{
						dbConn.Open();
						result=dbCmd.ExecuteNonQuery();                       
						dbConn.Close();
					}
					finally
					{
						if (dbConn.State == ConnectionState.Open)
							dbConn.Close();
					}
				}
			}
			return result;
		}
		
		 public string CreateSelect(int cout, string tableName,string where, string orderBy,string groupBy)
         {
             string sql = string.Empty;
             if ( cout > 0)
                 sql = "SELECT TOP " + cout.ToString() + " * FROM "+tableName;
             else
                 sql = "SELECT * FROM " + tableName;
             if (!string.IsNullOrEmpty(where))
             {
                 sql += " WHERE "+where;
             }
             if (!string.IsNullOrEmpty(orderBy))
             {
                 sql += " ORDER BY " + orderBy;
             }

             if (!string.IsNullOrEmpty(orderBy))
             {
                 sql += " GROUP BY " + groupBy;
             }

             return sql;



         }
	
	public object ExcuteSalarCommand(string cmdText, params SqlParameter[] cmdParams)
     {
         object result = null;
         using (SqlConnection dbConn = CreateConnection())
         {
             using (SqlCommand dbCmd = CreateCommand(cmdText, cmdParams))
             {
                 dbCmd.Connection = dbConn;
                 try
                 {
                     dbConn.Open();
                     result = dbCmd.ExecuteScalar();
                     dbConn.Close();
                 }
                 finally
                 {
                     if (dbConn.State == ConnectionState.Open)
                         dbConn.Close();
                 }
             }
         }
         return result;
     }
}
}		
