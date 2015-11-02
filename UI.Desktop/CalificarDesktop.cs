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
    public partial class CalificarDesktop : ApplicationForm
    {
        public CalificarDesktop(AlumnoInscripcion ai)
        {
            InitializeComponent();
            for (int i = 1; i < 11; i++)
            {
                cmbCalificacion.Items.Add(i);
            }
            txtEstado.Text = ai.Condicion;
            txtIDInscripcion.Text = ai.ID.ToString();

        }

        private void CalificarDesktop_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public override bool Validar()
        {
            return !(cmbCalificacion.Text == "" || txtEstado.Text=="");
        }
        private void btnCalificar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                InscripcionLogic il = new InscripcionLogic();
                AlumnoInscripcion ai = new AlumnoInscripcion();
                ai.ID = int.Parse(txtIDInscripcion.Text);
                ai.Nota = int.Parse(cmbCalificacion.Text);
                ai.Condicion = txtEstado.Text;
                il.ActualizarInscripcion(ai);
                Notificar("Nota y Condicion actualizada correctamente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
                Notificar("Todos los campos deben estar completos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
