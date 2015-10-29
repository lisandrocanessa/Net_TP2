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
    public partial class UsuarioDesktop : ApplicationForm
    {
        private Usuario _usuarioActual;
        public Usuario UsuarioActual
        {
            get
            {
                return _usuarioActual;
            }
            set
            {
                _usuarioActual = value;
            }
        }
        public UsuarioDesktop()
        {
            InitializeComponent();
        }

        private void UsuarioDesktop_Load(object sender, EventArgs e)
        {
            UsuarioLogic ul = new UsuarioLogic();
            cmbTipoPersona.DataSource = ul.GetTiposPersonas();
            cmbTipoPersona.DisplayMember="desc_tipo_persona";
            cmbTipoPersona.ValueMember="id_tipo_persona";
            if(UsuarioActual != null)
                this.cmbTipoPersona.Text = (this.UsuarioActual.TipoPersona).ToString();
        }

        public override void MapearDeDatos()
        {
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtEmail.Text = this.UsuarioActual.Email;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtTelefono.Text = this.UsuarioActual.Telefono;
            this.txtDireccion.Text = this.UsuarioActual.Direccion;
            if (this.Modo == ModoForm.Alta || this.Modo == ModoForm.Modificacion)
            {
                this.btnAceptar.Text = "Guardar";
            }
            else if (this.Modo == ModoForm.Baja)
            {
                this.btnAceptar.Text = "Eliminar";
            }
            else
            {
                this.btnAceptar.Text = "Aceptar";
            }
        }
        public override void MapearADatos()
        {
            if(Modo==ModoForm.Alta)
            {
                Usuario usr = new Usuario();
                UsuarioActual = usr;
                usr.Apellido = this.txtApellido.Text;
                usr.Clave = "123456";
                usr.Email = this.txtEmail.Text;
                usr.setTipoPersona(this.cmbTipoPersona.Text);
                usr.Habilitado = this.chkHabilitado.Checked;
                usr.Nombre = this.txtNombre.Text;
                usr.NombreUsuario = this.txtUsuario.Text;
                usr.Legajo = int.Parse(this.txtUsuario.Text);
                usr.FechaNacimiento = Convert.ToDateTime(this.txtFecNac.Text);
                usr.Direccion = this.txtDireccion.Text;
                usr.Telefono = this.txtTelefono.Text;
                this.UsuarioActual.State = BusinessEntity.States.New;
            }else if(Modo==ModoForm.Modificacion)
            {
                this.UsuarioActual.Legajo = int.Parse(this.txtUsuario.Text);
                this.UsuarioActual.Apellido = this.txtApellido.Text;
                this.UsuarioActual.Nombre = this.txtNombre.Text;
                this.UsuarioActual.Email = this.txtEmail.Text;
                this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                this.UsuarioActual.Telefono = this.txtTelefono.Text;
                this.UsuarioActual.Direccion = this.txtDireccion.Text;
                this.UsuarioActual.FechaNacimiento = Convert.ToDateTime(this.txtFecNac.Text);
                this.UsuarioActual.State = BusinessEntity.States.Modified;
            }
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            UsuarioLogic ul = new UsuarioLogic();
            ul.Save(UsuarioActual);
        }
        public override bool Validar()
        {
            if (txtApellido.Text == "" ||   txtEmail.Text == ""
                || txtNombre.Text == "" || txtUsuario.Text == "" )
            {
                Notificar("Todos los campos son obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }           
            else if (!txtEmail.Text.Contains("@") && !txtEmail.Text.Contains("."))
            {
                Notificar("Ingrese un Email valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }        

        public UsuarioDesktop(ModoForm modo):this()
        {
            this.Modo = modo;
        }
        public UsuarioDesktop(int ID, ModoForm modo):this()
        {            
            this.Modo = modo;
            UsuarioLogic ul = new UsuarioLogic();
            if (modo == ModoForm.Baja)
            {
                ul.Delete(ID);
            }
            else 
            {
                this.cmbTipoPersona.Enabled = false;
                UsuarioActual = ul.GetOne(ID);            
                this.MapearDeDatos();
            }          
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                this.Close();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

    
}
