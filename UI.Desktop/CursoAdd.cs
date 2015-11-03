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
    public partial class CursoAdd : ApplicationForm
    {
        private int plan;
        private string comision;

        public CursoAdd()
        {
            InitializeComponent();
        }

        private void CursoAdd_Load(object sender, EventArgs e)
        {
            this.txtComision.Text = comision;
            this.cmbMateria.DataSource = new MateriaLogic().GetAll(plan, int.Parse(comision));
            this.cmbMateria.DisplayMember = "desc_materia";
            this.cmbMateria.ValueMember = "id_materia";
        }

        public CursoAdd(int idPlan, int idComision)
            : this()
        {
            comision = idComision.ToString();
            plan = idPlan;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtCupo.Text != "" || this.txtDescr.Text != "")
                {
                    Curso c = new Curso();
                    c.AnioCalendario = DateTime.Now.Year;
                    c.Cupo = int.Parse(this.txtCupo.Text);
                    c.Descripcion = this.txtDescr.Text;
                    c.IDComision = int.Parse(comision);
                    c.IDMateria = (int)this.cmbMateria.SelectedValue;

                    CursoLogic cl = new CursoLogic();
                    cl.AddCurso(c);
                    this.Dispose();

                }
                else
                {
                    Notificar("Error de ingreso", "Todos los campos son obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Notificar("Error de ingreso", "Hay campos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
