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
    public partial class PlanEstudio : ApplicationForm
    {
        public PlanEstudio()
        {
            InitializeComponent();
            Listar();
        }

        private void Listar()
        {
            MateriaLogic ml=new MateriaLogic();
            dgvPlanEstudio.AutoGenerateColumns = false;
            dgvPlanEstudio.DataSource = ml.GetAll(UsuarioSesion.Sesion.IDPlan);
        }

        private void PlanEstudio_Load(object sender, EventArgs e)
        {

        }
    }
}
