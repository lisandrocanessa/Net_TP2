using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web.Alumno
{
    public partial class InscribirMateria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null) 
            {
                Response.Redirect("../Login.aspx");
            }
            Usuario usu = (Usuario)Session["Usuario"];
            ddlMaterias.DataSource = new MateriaLogic().GetAll(usu.IDPlan);
            ddlMaterias.DataTextField = "desc_materia";
            ddlMaterias.DataValueField = "id_materia";
            ddlMaterias.DataBind();
        }
    }
}