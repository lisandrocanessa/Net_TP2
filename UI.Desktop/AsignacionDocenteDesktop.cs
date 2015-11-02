using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class AsignacionDocenteDesktop : ApplicationForm
    {
        private int idCurso;

        public AsignacionDocenteDesktop()
        {
            InitializeComponent();
        }

        public AsignacionDocenteDesktop(int idCurso)
        {
            this.idCurso = idCurso;
            // TODO: Complete member initialization
            InitializeComponent();
            txtCurso.Text = idCurso.ToString();
            cmbCargo.DataSource = Enum.GetValues(typeof(DocenteCurso.TiposCargos));
        }


        private void AsignacionDocenteDesktop_Load(object sender, EventArgs e)
        {

        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            DocenteCursoLogic dcl = new DocenteCursoLogic();
            DocenteCurso dc=new DocenteCurso();
            dc.IDCurso=idCurso;
            dc.Cargo = (DocenteCurso.TiposCargos)cmbCargo.SelectedValue;
            dc.IDDocente=UsuarioSesion.Sesion.ID;
            dcl.AgregarDocenteACurso(dc);
            Notificar("Registro a curso generado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
