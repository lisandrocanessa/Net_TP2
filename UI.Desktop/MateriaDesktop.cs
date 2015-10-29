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
    public partial class MateriaDesktop : ApplicationForm
    {
        public MateriaDesktop()
        {
            InitializeComponent();
        }

        public MateriaDesktop(int idMateria, ModoForm modoForm)//:this()
        {
            InitializeComponent();
            
            this.modoForm = modoForm;
            MateriaLogic ml = new MateriaLogic();
            if (modoForm == ModoForm.Baja)
            {
                ml.Delete(idMateria);
            }
            else
            {                
                MateriaActual = ml.GetOne(idMateria);
                this.MapearDeDatos();
            }  
        }

        public MateriaDesktop(ModoForm modoForm):this()
        {
            this.modoForm = modoForm;
        }

        private Materia _materiaActual;
        private ModoForm modoForm;
        public Materia MateriaActual
        {
            get
            {
                return _materiaActual;
            }
            set
            {
                _materiaActual = value;
            }
        }

        private void MateriaDesktop_Load(object sender, EventArgs e)
        {
            PlanLogic pl = new PlanLogic();
            cmbPlanes.DataSource = pl.GetAll();
            cmbPlanes.DisplayMember = "desc_plan";
            cmbPlanes.ValueMember = "id_plan";
            if (MateriaActual != null)
            {
                this.cmbPlanes.SelectedValue = (this.MateriaActual.IDPlan).ToString();
                this.cmbPlanes.Enabled = false;
            }
        }

        public override void MapearDeDatos()
        {
            this.txtDescMateria.Text = this.MateriaActual.Descripcion;            
            this.txtHsSem.Text = (this.MateriaActual.HSSemanales).ToString();
            this.txtHsTot.Text = (this.MateriaActual.HSTotales).ToString();
        }
        
        public override void MapearADatos()
        {
            if (modoForm == ModoForm.Alta)
            {
                Materia m = new Materia();
                MateriaActual = m;
                m.Descripcion = this.txtDescMateria.Text;
                m.IDPlan = (int)this.cmbPlanes.SelectedValue;
                m.HSSemanales = int.Parse(this.txtHsSem.Text);
                m.HSTotales = int.Parse(this.txtHsTot.Text);
                this.MateriaActual.State = BusinessEntity.States.New;
            }
            else if (modoForm == ModoForm.Modificacion)
            {
                this.MateriaActual.IDPlan = (int)this.cmbPlanes.SelectedValue;
                this.MateriaActual.Descripcion = this.txtDescMateria.Text;
                this.MateriaActual.HSSemanales = int.Parse(this.txtHsSem.Text);
                this.MateriaActual.HSTotales = int.Parse(this.txtHsTot.Text);
                this.MateriaActual.State = BusinessEntity.States.Modified;
            }
        }

        public override bool Validar()
        {
            if (false)
            {
                Notificar("Error", "Debe completar todos los campos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            MateriaLogic ul = new MateriaLogic();
            ul.Save(MateriaActual);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(Validar())
                GuardarCambios();
            this.Dispose();
        }
    }
}
