using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class Usuarios : System.Web.UI.Page
    {
        UsuarioLogic _logic;
        private UsuarioLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new UsuarioLogic();
                }
                return _logic;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) 
            {
                CargarGrilla();
            }
        }

        private void CargarGrilla()
        {
            this.dgvUsuarios.DataSource = Logic.GetAll();
            this.dgvUsuarios.DataBind();
        }

    }
}