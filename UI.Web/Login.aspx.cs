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

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            UsuarioLogic ul = new UsuarioLogic();
            if (txtUsu.Text == "" || txtPass.Text == "")
            {
                lblError.Text = "Todos los campos deben ser completados";
            }
            else 
            {

            }
        }


    }
}