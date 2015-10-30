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
    public partial class CursosComisiones : Form
    {
        public CursosComisiones()
        {
            InitializeComponent();
            dgvCursos.AutoGenerateColumns = false;
            Listar();
        }

        private void Listar()
        {
            PlanLogic pl = new PlanLogic();
            cmbPlanes.ValueMember = "id_plan";
            cmbPlanes.DisplayMember = "desc_plan";
            cmbPlanes.DataSource = pl.GetAll();
            ComisionLogic cl = new ComisionLogic();
            cmbComision.ValueMember = "id_comision";
            cmbComision.DisplayMember = "desc_comision";
            cmbComision.DataSource = cl.DameComisiones((int)cmbPlanes.SelectedValue);
            CursoLogic curl=new CursoLogic();
            dgvCursos.DataSource = curl.DameCursos((int)cmbComision.SelectedValue);
            
        }

        private void CursosComisiones_Load(object sender, EventArgs e)
        {

        }

        private void cmbPlanes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComisionLogic cl = new ComisionLogic();
            cmbComision.ValueMember = "id_comision";
            cmbComision.DisplayMember = "desc_comision";
            cmbComision.DataSource = cl.DameComisiones((int)cmbPlanes.SelectedValue);
        }

        private void cmbComision_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CursoLogic curl = new CursoLogic();
            dgvCursos.DataSource = curl.DameCursos((int)cmbComision.SelectedValue);
        }

        private void btnAdmComision_Click(object sender, EventArgs e)
        {
            Comisiones c = new Comisiones((int)cmbPlanes.SelectedValue);
            c.Show();
        }
    }
}
