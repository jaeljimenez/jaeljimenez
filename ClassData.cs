using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Build.Tasks.Xaml;

namespace WindowsFormProject
{
    internal class ClassData
    {
        public static string stringConnectionSQL = ConfigurationManager.ConnectionStrings["DBConnectionSql"].ConnectionString;

        public static SqlConnection SQLConnectionDB()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ClassData.stringConnectionSQL;
            sqlConnection.Open();
            return sqlConnection;
        }

        public static SqlCommand SqlCommand(string stringCommand,CommandType SqlCommandType)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = ClassData.SQLConnectionDB();
            sqlCommand.CommandType = SqlCommandType;
            sqlCommand.CommandText = stringCommand;


            return sqlCommand;

        }
        public static SqlDataReader sqlDatareader(SqlCommand sqlCommand)
        {
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            return sqlDataReader;
        }
    }
}
