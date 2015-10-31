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

        public DataTable GetCursosAInscribir(int idPlan)
        {
            this.OpenConnection();
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM cursos inner join comisiones inner join materias "+
                "on cursos.id_comision=comisiones.id_comision and cursos.id_materia=materias.id_materia "+
                "where comisiones.id_plan=@id and cursos.cupo>=0", SqlConn);
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = idPlan;
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(dt);
            this.CloseConnection();
            return dt;
        }
    }
}
