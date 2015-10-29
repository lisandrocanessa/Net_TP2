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
    public class MateriaAdapter : Adapter
    {
        public DataTable GetAll(int idPlan)
        {
            this.OpenConnection();
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("select id_materia,desc_materia,hs_semanales,hs_totales from materias where id_plan = @id", SqlConn);
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = idPlan;
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(dt);
            this.CloseConnection();
            return dt;
        }

        public void Delete(int id)
        {
            try
            {
                //abrimos la conexion
                this.OpenConnection();

                //creamos la sentencia sql yield asignamos un valor al parametro
                MySqlCommand cmdDelete =
                    new MySqlCommand("delete from materias where id_materia=@id", SqlConn);
                cmdDelete.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                //ejecutamos la sentencia sql
                cmdDelete.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Business.Entities.Materia MateriaActual)
        {
            if (MateriaActual.State == BusinessEntity.States.New)
            {
                this.Insert(MateriaActual);
            }
            else if (MateriaActual.State == BusinessEntity.States.Deleted)
            {
                this.Delete(MateriaActual.ID);
            }
            else if (MateriaActual.State == BusinessEntity.States.Modified)
            {
                this.Update(MateriaActual);
            }
            MateriaActual.State = BusinessEntity.States.Unmodified; 
        }

        private void Update(Materia MateriaActual)
        {
            try
            {
                this.OpenConnection();
                MySqlCommand cmdSave = new MySqlCommand("UPDATE materias " +
                "set desc_materia =@desc_materia, hs_semanales = @hs_semanales, " +
                "hs_totales = @hs_totales, id_plan = @id_plan " +
                "WHERE id_materia=@id", SqlConn);

                cmdSave.Parameters.Add("@id", MySqlDbType.Int32).Value = MateriaActual.ID;
                cmdSave.Parameters.Add("@desc_materia", MySqlDbType.VarChar, 50).Value = MateriaActual.Descripcion;
                cmdSave.Parameters.Add("@hs_semanales", MySqlDbType.Int32).Value = MateriaActual.HSSemanales;
                cmdSave.Parameters.Add("@hs_totales", MySqlDbType.Int32).Value = MateriaActual.HSTotales;
                cmdSave.Parameters.Add("@id_plan", MySqlDbType.Int32).Value = MateriaActual.IDPlan;
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

        private void Insert(Materia MateriaActual)
        {
            try
            {
                this.OpenConnection();
                MySqlCommand cmdSave = new MySqlCommand("insert into materias (desc_materia,hs_semanales,hs_totales,id_plan)" +
                "values (@desc_materia,@hs_semanales,@hs_totales,@id_plan)", SqlConn); //esta linea es para recuperar el id que mysql asigno automaticamente

                cmdSave.Parameters.Add("@desc_materia", MySqlDbType.VarChar, 50).Value = MateriaActual.Descripcion;
                cmdSave.Parameters.Add("@hs_semanales", MySqlDbType.Int32).Value = MateriaActual.HSSemanales;
                cmdSave.Parameters.Add("@hs_totales", MySqlDbType.Int32).Value = MateriaActual.HSTotales;
                cmdSave.Parameters.Add("@id_plan", MySqlDbType.Int32).Value = MateriaActual.IDPlan;
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

        public Materia GetOne(int idMateria)
        {
            Materia mt = new Materia();
            try
            {
                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("select * from materias where id_materia = @idmateria", SqlConn);
                cmd.Parameters.Add("@idmateria", MySqlDbType.Int32).Value = idMateria;
                MySqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {                    
                    mt.Descripcion = (string)dr["desc_materia"];
                    mt.HSSemanales = (int)dr["hs_semanales"];
                    mt.HSTotales = (int)dr["hs_totales"];
                    mt.ID = (int)dr["id_materia"];
                    mt.IDPlan = (int)dr["id_plan"];                    
                }
                dr.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return mt;
        }
    }
}
