using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Messaging;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DataAcessLayer
{
    public class DBManager
    {
        static SqlConnection MyConnection;
        string connString;
        static DBManager()
        {
            string connString = new ConfigurationBuilder().AddJsonFile("AppSetting.json").Build().GetSection("conn1").Value;
            MyConnection = new SqlConnection(connString); 
        }

        public static DataTable GetQueryResult(string cmdText)
        {
                SqlCommand cmd = new SqlCommand(cmdText, MyConnection);
                SqlDataAdapter MyAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                MyAdapter.Fill(dt);
                return dt;           
        }

        public static int ExcuteNonQuery(string cmdText)
        {
            SqlCommand cmd = new SqlCommand(cmdText, MyConnection);
            MyConnection.Open();
            int AffectedRows = cmd.ExecuteNonQuery();
            MyConnection.Close();
            return AffectedRows;
        }

        public static int Scaller(string cmdText)
        {
            SqlCommand cmd = new SqlCommand(cmdText, MyConnection);
            MyConnection.Open();
            int value = (int)cmd.ExecuteScalar();
            MyConnection.Close();
            return value;
        }
       

    }
}
