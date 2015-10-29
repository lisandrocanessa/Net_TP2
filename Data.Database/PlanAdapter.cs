using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Business.Entities;

namespace Data.Database
{
    public class PlanAdapter : Adapter
    {
        public DataTable GetAll()
        {
            this.OpenConnection();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM planes";
            MySqlCommand cmd = new MySqlCommand(query, SqlConn);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(dt);
            this.CloseConnection();
            return dt;
        }

            
        public Plan GetOne(int id)
        {
        	throw new NotImplementedException();
        }

        public void Add(Plan p)
        {
            try
            {
                this.OpenConnection();
                MySqlCommand cmdSave = new MySqlCommand("insert into planes (desc_plan,id_especialidad)" +
                "values (@desc_plan,@id_especialidad)", SqlConn); 

                cmdSave.Parameters.Add("@desc_plan", MySqlDbType.VarChar, 50).Value = p.Descripcion;
                cmdSave.Parameters.Add("@id_especialidad", MySqlDbType.Int32).Value = p.IDEspecialidad;
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
