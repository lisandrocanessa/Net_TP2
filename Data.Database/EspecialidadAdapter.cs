using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class EspecialidadAdapter:Adapter
    {
        public DataTable GetAll()
        {
            this.OpenConnection();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM especialidades";
            MySqlCommand cmd = new MySqlCommand(query, SqlConn);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(dt);
            this.CloseConnection();
            return dt;
        }
    }
}
