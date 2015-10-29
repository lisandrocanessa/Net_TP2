using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;
using System.Data;

namespace Business.Logic
{
    public class UsuarioLogic:BusinessLogic
    {
        UsuarioAdapter UsuarioData;

        public UsuarioLogic()
        {
            UsuarioData= new UsuarioAdapter();
        }

        public Usuario GetOne(int id)
        {
            return UsuarioData.GetOne(id);
        }
        public DataTable GetTiposPersonas()
        {
            return UsuarioData.CargarCombo();
        }

        public Usuario GetOne(string Usu, string Pass)
        {
            return UsuarioData.GetOne(Usu, Pass);
        }

        public List<Usuario> GetAll()
        {
            try
            {
                return UsuarioData.GetAll();
            }
            catch (Exception ExcepcionManejada)
            {
                throw ExcepcionManejada;
            }
               
        }

        public void Save(Usuario usr)
        {
            UsuarioData.Save(usr);
        }

        public void Delete(int id)
        {
            UsuarioData.Delete(id);
        }

        public void CambiarContraseña(int id, string nuevaContraseña)
        {
            UsuarioData.CambiarContraseña(id, nuevaContraseña);
        }
    }
}
