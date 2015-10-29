using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Planes : ApplicationForm
    {
        public Planes()
        {
            InitializeComponent();
            dgvPlanes.AutoGenerateColumns = false;
            Listar();
        }

        private void Planes_Load(object sender, EventArgs e)
        {

        }

        public void Listar()
        {
            try
            {
                PlanLogic pl = new PlanLogic();
                this.dgvPlanes.DataSource = pl.GetAll();
            }
            catch (Exception Ex)
            {
                Notificar("Error", Ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            PlanDesktop pd = new PlanDesktop();
            pd.Show();
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}