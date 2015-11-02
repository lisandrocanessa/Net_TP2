using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class DocenteCursoAdapter:Adapter
    {
        public System.Data.DataTable GetAll(int idDocente)
        {
            this.OpenConnection();
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("select * from docentes_cursos where id_docente = @id", SqlConn);
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = idDocente;
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(dt);
            this.CloseConnection();
            return dt;
        }

        public void Insert(Business.Entities.DocenteCurso dc)
        {
            try
            {
                this.OpenConnection();
                MySqlCommand cmdSave = new MySqlCommand("insert into docentes_cursos (cargo,id_curso,id_docente)" +
                "values (@cargo,@id_curso,@id_docente)", SqlConn);
                cmdSave.Parameters.Add("@cargo", MySqlDbType.VarChar, 25).Value = dc.Cargo;
                cmdSave.Parameters.Add("@id_curso", MySqlDbType.Int32).Value = dc.IDCurso;
                cmdSave.Parameters.Add("@id_docente", MySqlDbType.Int32).Value = dc.IDDocente;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            } 
        }
    }
}
