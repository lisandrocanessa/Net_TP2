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

        public DataTable GetCursosAInscribir(int idPlan, int idUsr)
        {
            this.OpenConnection();
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM cursos inner join comisiones inner join materias "+
                "on cursos.id_comision=comisiones.id_comision and cursos.id_materia=materias.id_materia "+
                "where comisiones.id_plan=@id and cursos.cupo>=0 and id_curso not in "+
                "(select id_curso from alumnos_inscripciones where id_alumno=@id_usr)", SqlConn);
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = idPlan;
            cmd.Parameters.Add("@id_usr", MySqlDbType.Int32).Value = idUsr;
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(dt);
            this.CloseConnection();
            return dt;
        }

        public void UpdateCurso(int idCurso, int cupoActualizado)
        {
            try
            {
                this.OpenConnection();
                MySqlCommand cmdSave = new MySqlCommand("UPDATE cursos " +
                "set cupo =@cupo " +
                "WHERE id_curso=@id", SqlConn);
                cmdSave.Parameters.Add("@id", MySqlDbType.Int32).Value = idCurso;
                cmdSave.Parameters.Add("@cupo", MySqlDbType.Int32).Value = cupoActualizado;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de la materia", Ex);
                throw ExcepcionManejada;

            }
            finally
            {
                this.CloseConnection();
            }
        }

        public DataTable GetAll()
        {
            this.OpenConnection();
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("select * from cursos", SqlConn);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(dt);
            this.CloseConnection();
            return dt;
        }

        public DataTable GetAlumnosDocente(int id_docente)
        {
            this.OpenConnection();
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM docentes_cursos inner join alumnos_inscripciones inner join personas " +
                "on docentes_cursos.id_curso=alumnos_inscripciones.id_curso and alumnos_inscripciones.id_alumno=personas.id_persona " +
                "where id_docente=@id" , SqlConn);
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id_docente;
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(dt);
            this.CloseConnection();
            return dt;
        }
    }
}
