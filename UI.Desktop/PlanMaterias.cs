using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class PlanMaterias : ApplicationForm
    {
        MateriaLogic ml = new MateriaLogic();
        public PlanMaterias()
        {
            InitializeComponent();
        }

        private void Planes_Load(object sender, EventArgs e)
        {
            PlanLogic pl = new PlanLogic();
            cmbPlanes.DataSource = pl.GetAll();
            cmbPlanes.DisplayMember = "desc_plan";
            cmbPlanes.ValueMember = "id_plan";
            Listar();
        }

        public void Listar()
        {
            this.dgvMaterias.DataSource = ml.GetAll((int)cmbPlanes.SelectedValue);
        }

        private void btmSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmbPlanes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Listar();
        }

        private void btmEliminar_Click(object sender, EventArgs e)
        {
            int id = (int)dgvMaterias.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("¿Está seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                ml.Delete(id);
            this.Listar();
        }

        private void btmAgregar_Click(object sender, EventArgs e)
        {
            MateriaDesktop md = new MateriaDesktop(ApplicationForm.ModoForm.Alta);            
            md.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btmModificar_Click(object sender, EventArgs e)
        {    
            int id = (int)dgvMaterias.CurrentRow.Cells[0].Value;
            MateriaDesktop md = new MateriaDesktop(id, ApplicationForm.ModoForm.Modificacion);
            md.Show();
        }

        private void btmAdministrarPlanes_Click(object sender, EventArgs e)
        {
            Planes p = new Planes();
            p.Show();
        }


    }
}
