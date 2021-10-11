using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Models
{
    public class Model
    {
        public string SQLServerConnectionString = ConfigurationManager.ConnectionStrings["SQLServerConnectionString"].ConnectionString;
        public DataTable QuerySQLServer(string QueryString)
        {
            using (SqlConnection SQLServerConnection = new SqlConnection(SQLServerConnectionString))
            {
                SqlCommand SQLServerCommand = new SqlCommand(QueryString, SQLServerConnection);
                DataTable Data = new DataTable();
                SqlDataAdapter SQLServerAdapter = new SqlDataAdapter();
                SQLServerAdapter.SelectCommand = SQLServerCommand;
                SQLServerAdapter.Fill(Data);
                //SqlDataReader SQLData = SQLServerCommand.ExecuteReader();
                //DataBase.DataTable.Load(SQLData);
                //SQLData.Close();
                return Data;
            }
        }
    }
}