using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class CursoAdapter:Adapter
    {

        public DataTable GetAll(int idCom)
        {
            this.OpenConnection();
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("select * from cursos where id_comision = @id", SqlConn);
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = idCom;
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(dt);
            this.CloseConnection();
            return dt;
        }
    }
}
