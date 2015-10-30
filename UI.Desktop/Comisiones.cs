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
    public partial class Comisiones : ApplicationForm
    {
        public Comisiones(int idPlan)
        {
            InitializeComponent();
            ComisionLogic cl=new ComisionLogic();
            dgvComisiones.AutoGenerateColumns = false;
            dgvComisiones.DataSource = cl.DameComisiones(idPlan);
        }

        private void Comisiones_Load(object sender, EventArgs e)
        {

        }
    }
}
