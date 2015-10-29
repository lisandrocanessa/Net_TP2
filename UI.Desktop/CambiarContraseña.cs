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
    public partial class CambiarContraseña : ApplicationForm
    {
        public CambiarContraseña()
        {
            InitializeComponent();
        }

        private void btmCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btmAceptar_Click(object sender, EventArgs e)
        {
            validar();
        }

        private void validar()
        {
            if (this.txtContraseñaNueva.Text == "" || this.txtContraseñaVieja.Text == "" || this.txtContraseñaRepetida.Text == "")
            {
                Notificar("Error", "Todos los campos deben estar completos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (this.txtContraseñaVieja.Text == UsuarioSesion.Sesion.Clave)
                {
                    if (this.txtContraseñaNueva.Text == this.txtContraseñaRepetida.Text)
                    {
                        UsuarioLogic ul = new UsuarioLogic();
                        ul.CambiarContraseña(UsuarioSesion.Sesion.ID, this.txtContraseñaNueva.Text);
                        Notificar("Aviso","La contraseña ha sido cambiada correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    else
                    {
                        Notificar("Error", "Las contraseñas no coinciden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Notificar("Error", "La contraseña antigua fue mal ingresada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void CambiarContraseña_Load(object sender, EventArgs e)
        {

        }

        

    }
}
