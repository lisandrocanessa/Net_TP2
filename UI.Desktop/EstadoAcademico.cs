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
    public partial class EstadoAcademico : ApplicationForm
    {
        public EstadoAcademico()
        {
            InitializeComponent();
            Listar();
        }

        private void Listar()
        {
            InscripcionLogic il=new InscripcionLogic();
            dgvEstadoAcademico.AutoGenerateColumns = false;
            dgvEstadoAcademico.DataSource = il.DameInscripciones(UsuarioSesion.Sesion.ID);
        }

        private void EstadoAcademico_Load(object sender, EventArgs e)
        {

        }
    }
}
