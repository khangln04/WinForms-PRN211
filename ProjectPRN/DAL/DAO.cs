using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN.DAL
{
    internal class DAO
    {
        public static SqlConnection GetConnection()
{
    var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
    string connectionString = config.GetConnectionString("MyConStr");
    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);
    builder.TrustServerCertificate = true;
    return new SqlConnection(builder.ConnectionString);
}

        //public static SqlConnection GetConnection() 
        // {   
        //     string Connect = "server = localhost; database = ProjectPRN291; user = sa; password = 123456";
        //     return new SqlConnection(Connect);
        // }



        public static DataTable GetDataBySql(string sql, params SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static int ExecuteSQL(string sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            if (parameters != null) command.Parameters.AddRange(parameters);
            command.Connection.Open();
            int k = command.ExecuteNonQuery();
            command.Connection.Close();
            return k;
        }
    }
}
