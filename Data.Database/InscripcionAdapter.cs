using Business.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class InscripcionAdapter:Adapter
    {

        public void AddInscripcion(AlumnoInscripcion ai)
        {
            try
            {
                this.OpenConnection();
                MySqlCommand cmdSave = new MySqlCommand("insert into alumnos_inscripciones (condicion,id_alumno,id_curso) " +
                "values (@condicion,@id_alumno,@id_curso)", SqlConn);

                cmdSave.Parameters.Add("@condicion", MySqlDbType.VarChar, 50).Value = ai.Condicion;
                cmdSave.Parameters.Add("@id_alumno", MySqlDbType.Int32).Value = ai.IDAlumno;
                cmdSave.Parameters.Add("@id_curso", MySqlDbType.Int32).Value = ai.IDCurso;
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

        public System.Data.DataTable GetAll(int idUsr)
        {
            this.OpenConnection();
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("select * from alumnos_inscripciones inner join cursos inner join materias "+
                "on alumnos_inscripciones.id_curso=cursos.id_curso and materias.id_materia=cursos.id_materia "+
                "where id_alumno = @id", SqlConn);
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = idUsr;
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(dt);
            this.CloseConnection();
            return dt;
        }
    }
}
