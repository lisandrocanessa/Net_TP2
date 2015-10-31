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
    public partial class InscripcionCursado : ApplicationForm
    {
        public InscripcionCursado()
        {
            InitializeComponent();
            Listar();
        }

        private void Listar()
        {
            PlanLogic pl=new PlanLogic();
            lblPlan.Text = (pl.GetOne(UsuarioSesion.Sesion.IDPlan)).Descripcion;
            CursoLogic cl = new CursoLogic();
            dgvCurComMa.AutoGenerateColumns = false;
            int idPlan = UsuarioSesion.Sesion.IDPlan;
            dgvCurComMa.DataSource = cl.DameCursosAInscribir(idPlan);
        }

        private void InscripcionCursado_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
