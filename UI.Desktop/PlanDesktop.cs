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
    public partial class PlanDesktop : ApplicationForm
    {
        public PlanDesktop()
        {
            InitializeComponent();
        }

        private void PlanDesktop_Load(object sender, EventArgs e)
        {
            EspecialidadLogic el=new EspecialidadLogic();
            cmbEspecialidad.DisplayMember = "desc_especialidad";
            cmbEspecialidad.ValueMember = "id_especialidad";
            cmbEspecialidad.DataSource = el.DameEspecialidades();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                PlanLogic pl = new PlanLogic();
                Plan p = new Plan();
                p.IDEspecialidad = (int)cmbEspecialidad.SelectedValue;
                p.Descripcion = txtDescripcion.Text;
                pl.AddPlan(p);
                Notificar("Plan creado satisfactoriamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                Notificar("Los campos deben estar completos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override bool Validar()
        {
            if (txtDescripcion.Text == "")
                return false;
            else
                return true;
        }
    }
}
