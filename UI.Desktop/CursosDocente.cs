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
    public partial class CursosDocente : ApplicationForm
    {
        public CursosDocente()
        {
            InitializeComponent();
            Listar();
        }

        private void Listar()
        {
            DocenteCursoLogic dcl=new DocenteCursoLogic();
            dgvCursosDocente.AutoGenerateColumns = false;
            dgvCursosDocente.DataSource = dcl.DameCursosDocente(UsuarioSesion.Sesion.ID);
        }

        private void CursosDocente_Load(object sender, EventArgs e)
        {

        }
    }
}
