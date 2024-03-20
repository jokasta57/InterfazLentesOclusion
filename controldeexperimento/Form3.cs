using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controldeexperimento
{
    public partial class frmMenu : Form
    {
        bool ocultar = false;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void BtnExperimentoIndividuak_Click(object sender, EventArgs e)
        {
            ocultar = false;
            AbrirFormHijo(new frmConfiguracion(ocultar));

            /*frmConfiguracion f = new frmConfiguracion(ocultar);
            f.Text = "Ejecución de Pruebas Individuales";
            f.Show();*/

            /*frmDatosPaciente f = new frmDatosPaciente();
            f.Text = "Ejecución de Pruebas Individuales";
            f.Show();*/
        }

        private void BtnExperimentoGral_Click(object sender, EventArgs e)
        {
            /*frmExperimentoGral f = new frmExperimentoGral();
            f.Show();*/

            AbrirFormHijo(new frmExperimentoGral());
        }

        private void BtnConfiguraciones_Click(object sender, EventArgs e)
        {
            ocultar = true;

            /*frmConfiguracion f = new frmConfiguracion(ocultar);
            f.Text = "Configuración de pruebas";
            f.Show();*/

            AbrirFormHijo(new frmConfiguracion(ocultar));
        }

        private void AbrirFormHijo(object FormHija) {
            if (this.panelContenedor.Controls.Count > 0) {
                this.panelContenedor.Controls.RemoveAt(0);
            }

            Form fh = FormHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
