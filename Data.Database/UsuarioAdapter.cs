using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Data.Database
{
    public class UsuarioAdapter:Adapter
    {      

        public List<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                
                this.OpenConnection();

                MySqlCommand cmdUsuarios = new MySqlCommand("select * from personas", SqlConn);
                MySqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();

                while (drUsuarios.Read())
                {
                    Usuario usr = new Usuario();
                    usr.ID = (int)drUsuarios["id_persona"];
                    usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    usr.Clave = (string)drUsuarios["clave"];
                    usr.Habilitado = (bool)drUsuarios["habilitado"];
                    usr.Nombre = (string)drUsuarios["nombre"];
                    usr.Apellido = (string)drUsuarios["apellido"];
                    usr.Email = (string)drUsuarios["email"];
                    usr.TipoPersona = (BusinessEntity.TiposPersonas)drUsuarios["id_tipo_persona"];

                    usuarios.Add(usr);
                }
                drUsuarios.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de usuarios", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }        

            return usuarios;
        }

        public Business.Entities.Usuario GetOne(int ID)
        {
            Usuario usr = new Usuario();
            try
            {
                this.OpenConnection();
                MySqlCommand cmdUsuarios = new MySqlCommand("select * from personas where id_persona=@id", SqlConn);
                cmdUsuarios.Parameters.Add("@id", MySqlDbType.Int32).Value = ID;
                MySqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
                if (drUsuarios.Read())
                {
                    usr.ID = (int)drUsuarios["id_persona"];
                    usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    usr.Clave = (string)drUsuarios["clave"];
                    usr.Habilitado = (bool)drUsuarios["habilitado"];
                    usr.Nombre = (string)drUsuarios["nombre"];
                    usr.Apellido = (string)drUsuarios["apellido"];
                    usr.Email = (string)drUsuarios["email"];
                    usr.Telefono = (string)drUsuarios["telefono"];
                    usr.Direccion = (string)drUsuarios["direccion"];
                    usr.TipoPersona = (Business.Entities.BusinessEntity.TiposPersonas)drUsuarios["id_tipo_persona"];
                }
                drUsuarios.Close();
            } 
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return usr;
        }

        public Business.Entities.Usuario GetOne(string Usu, string Pass)
        {
            Usuario usr = new Usuario();
            try
            {
                this.OpenConnection();
                MySqlCommand cmdUsuarios = new MySqlCommand("select * from personas p inner join tipos_personas t on t.id_tipo_persona=p.id_tipo_persona where p.nombre_usuario=@Usu and p.clave=@Pass", SqlConn);
                cmdUsuarios.Parameters.Add("@Usu", MySqlDbType.String).Value = Usu;
                cmdUsuarios.Parameters.Add("@Pass", MySqlDbType.String).Value = Pass;
                MySqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
                if (drUsuarios.Read())
                {
                    usr.ID = (int)drUsuarios["id_persona"];
                    usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    usr.Clave = (string)drUsuarios["clave"];
                    usr.Apellido = (string)drUsuarios["apellido"];
                    usr.Nombre = (string)drUsuarios["nombre"];
                    usr.setTipoPersona((string)drUsuarios["desc_tipo_persona"]);
                }
                drUsuarios.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return usr;
        }
        public DataTable CargarCombo()
        {
            this.OpenConnection();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM tipos_personas";
            MySqlCommand cmd = new MySqlCommand(query, SqlConn);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(dt);
            this.CloseConnection();
            return dt;
        }

        public void Delete(int ID)
        {
            try
            {
                //abrimos la conexion
                this.OpenConnection();

                //creamos la sentencia sql yield asignamos un valor al parametro
                MySqlCommand cmdDelete =
                    new MySqlCommand("delete from personas where id_persona=@id", SqlConn);
                cmdDelete.Parameters.Add("@id", MySqlDbType.Int32).Value = ID;

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

        public void Save(Usuario usuario)
        {
            if (usuario.State == BusinessEntity.States.New)
            {
                this.Insert(usuario);
            }
            else if (usuario.State == BusinessEntity.States.Deleted)
            {
                this.Delete(usuario.ID);
            }
            else if (usuario.State == BusinessEntity.States.Modified)
            {
                this.Update(usuario);
            }
            usuario.State = BusinessEntity.States.Unmodified;            
        }


        protected void Update(Usuario usuario)
        {
            try
            {
                this.OpenConnection();
                MySqlCommand cmdSave = new MySqlCommand("UPDATE personas " +
                "set nombre_usuario =@nombre_usuario, clave = @clave, " +
                "habilitado = @habilitado, nombre = @nombre, apellido=@apellido, email=@email " +
                "WHERE id_persona=@id", SqlConn);

                cmdSave.Parameters.Add("@id", MySqlDbType.Int32).Value = usuario.ID;
                cmdSave.Parameters.Add("@nombre_usuario", MySqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmdSave.Parameters.Add("@habilitado", MySqlDbType.Bit).Value = usuario.Habilitado;
                cmdSave.Parameters.Add("@nombre", MySqlDbType.VarChar, 50).Value = usuario.Nombre;
                cmdSave.Parameters.Add("@apellido", MySqlDbType.VarChar, 50).Value = usuario.Apellido;
                cmdSave.Parameters.Add("@email", MySqlDbType.VarChar, 50).Value = usuario.Email;
                cmdSave.Parameters.Add("@clave", MySqlDbType.VarChar, 50).Value = usuario.Clave;
                cmdSave.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos usuario", Ex);
                throw ExcepcionManejada;
                
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Usuario usuario)
        {
            try
            {
                this.OpenConnection();
                MySqlCommand cmdSave = new MySqlCommand("insert into personas (nombre_usuario,clave,habilitado,id_persona,nombre,apellido,email,id_tipo_persona,legajo,fecha_nac,direccion,telefono)" +
                "values (@nombre_usuario,@clave,@habilitado,@id_persona,@nombre,@apellido,@email,@id_tipo_persona,@legajo,@fecha_nac,@direccion,@telefono)", SqlConn); //esta linea es para recuperar el id que mysql asigno automaticamente
                                
                cmdSave.Parameters.Add("@nombre_usuario", MySqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmdSave.Parameters.Add("@clave", MySqlDbType.VarChar, 50).Value = usuario.Clave;
                cmdSave.Parameters.Add("@habilitado", MySqlDbType.Bit).Value = usuario.Habilitado;
                cmdSave.Parameters.Add("@id_persona", MySqlDbType.Int32).Value = usuario.ID;
                cmdSave.Parameters.Add("@nombre", MySqlDbType.VarChar, 50).Value = usuario.Nombre;
                cmdSave.Parameters.Add("@apellido", MySqlDbType.VarChar, 50).Value = usuario.Apellido;
                cmdSave.Parameters.Add("@email", MySqlDbType.VarChar, 50).Value = usuario.Email;
                cmdSave.Parameters.Add("@id_tipo_persona", MySqlDbType.Int32).Value = usuario.getIdPersona(usuario.TipoPersona);
                cmdSave.Parameters.Add("@legajo", MySqlDbType.Int32).Value = int.Parse(usuario.NombreUsuario);
                cmdSave.Parameters.Add("@fecha_nac", MySqlDbType.Date).Value = usuario.FechaNacimiento;
                cmdSave.Parameters.Add("@direccion", MySqlDbType.VarChar, 50).Value = usuario.Direccion;
                cmdSave.Parameters.Add("@telefono", MySqlDbType.VarChar, 50).Value = usuario.Telefono;
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

        public void CambiarContraseña(int id,string nuevaContraseña)
        {
            try
            {
                this.OpenConnection();
                MySqlCommand cmdCambiarContra = new MySqlCommand("update personas set clave=@clave where id_persona = @id", SqlConn);
                cmdCambiarContra.Parameters.Add("@clave", MySqlDbType.VarChar, 45).Value = nuevaContraseña;
                cmdCambiarContra.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                cmdCambiarContra.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al cambiar contraseña", Ex);
                throw ExcepcionManejada;

            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
