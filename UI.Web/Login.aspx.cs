using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public void Registro(string Usu, string Pass)
        {
            Usuario usu = new Usuario();
            UsuarioLogic ul = new UsuarioLogic();
            usu = ul.GetOne(Usu, Pass);
            if (usu.ID == 0)
            {
                lblError.Text = "Usuario no encontrado!";
            }
            else
            {
                UsuarioSesion.Sesion = usu;
                Session["Usuario"] = usu;
                if (usu.TipoPersona.ToString() == "Alumno")
                {
                    Response.Redirect("Alumnos.aspx");
                }
                else if (usu.TipoPersona.ToString() == "Docente")
                {
                    Response.Redirect("Docentes.aspx");
                }
                else 
                {
                    Response.Redirect("Administrador.aspx");
                }
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {            
            if (txtusu.Value == "" || txtPass.Value == "")
            {
                lblError.Text = "Todos los campos deben ser completados";
            }
            else 
            {
                Registro(txtusu.Value, txtPass.Value);
            }
        }


    }
}