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
    public partial class Login : ApplicationForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public void Registro(string Usu, string Pass)
        {
            Usuario usu = new Usuario();
            UsuarioLogic ul = new UsuarioLogic();
            usu=ul.GetOne(Usu, Pass);
            if (usu.ID == 0)
            {
                Notificar("Error de identificación", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                UsuarioSesion.Sesion = usu;
                MenuPadre mp = new MenuPadre();
                this.DialogResult = DialogResult.OK;                
            }
        }

        public override bool Validar()
        {
            if (txtContraseña.Text == "" || txtUsuario.Text == "")
            {
                Notificar("Error de identificación", "Hay campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(Validar())
            {
                Registro(txtUsuario.Text, txtContraseña.Text);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
    }
}
