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
    public partial class RegistroCalificaciones : ApplicationForm
    {
        public RegistroCalificaciones()
        {
            InitializeComponent();
            Listar();
        }

        private void Listar()
        {
            dgvAlumnosDocente.AutoGenerateColumns = false;
            CursoLogic cl = new CursoLogic();
            dgvAlumnosDocente.DataSource=cl.DameAlumnosDocente(UsuarioSesion.Sesion.ID);
        }

        private void RegistroCalificaciones_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            AlumnoInscripcion ai = new AlumnoInscripcion();
            ai.ID = (int)dgvAlumnosDocente.CurrentRow.Cells[0].Value;
            ai.Condicion = dgvAlumnosDocente.CurrentRow.Cells[4].Value.ToString();
            CalificarDesktop cd = new CalificarDesktop(ai);
            cd.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
