using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Data.Database
{
    public class Adapter
    {
        //private SqlConnection sqlConnection = new SqlConnection("ConnectionString;");
        private string conexion = "Server=localhost;Database=academia;Uid=root;Pwd=root;";

        private MySqlConnection _sqlConn; 
        public MySqlConnection SqlConn
        {
            get { return _sqlConn; }
            set { _sqlConn = value; }
        }

        protected void OpenConnection()
        {            
            SqlConn = new MySqlConnection(conexion);
            SqlConn.Open();
        }

        protected void CloseConnection()
        {
            SqlConn.Close();
            SqlConn = null;
        }

        protected MySqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }
    }
}
