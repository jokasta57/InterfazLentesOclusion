using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controldeexperimento
{
    public partial class frmDatosPaciente : Form
    {
        // private OpenFileDialog openFileDialog1;
        //bool ocultar = true;

        String ruta_archivo; //del experimento, con todas las configuraciones y el orden de ejecución
        String puerto_conexion;
        private void BtnCancelarExperimento_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void Button1_Click(object sender, EventArgs e)|
        {
            OpenFileDialog OpenFile = new OpenFileDialog();

            if (OpenFile.ShowDialog() == DialogResult.OK) {

                archivo = OpenFile.FileName;

                using (StreamReader sr = new StreamReader(archivo))
                {
                    this.richTextBox1.Text = sr.ReadToEnd();
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            if (archivo != null)
            {
                using (StreamWriter sw = new StreamWriter(archivo))
                    sw.Write(this.richTextBox1.Text);
            }
        }*/

        public frmDatosPaciente(String ruta_experimento, String puerto)
        {
            InitializeComponent();
            ruta_archivo = ruta_experimento.Replace("\r\n", "").Replace("\n", "").Replace("\r", "");
            this.txtRutaExperimento.Text = ruta_archivo;
            puerto_conexion = puerto;
        }

        private void BtnIniciarExperimento_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNombre.TextLength > 0 && this.txtDescripcion.TextLength > 0
                    && this.cmbEscolaridad.Text != "" && this.cmbSexo.Text != "")
                {
                    frmPanelExperimento f = new frmPanelExperimento(ruta_archivo, this.txtNombre.Text, this.txtDescripcion.Text,
                        this.cmbEdad.Value.ToString(), this.cmbSexo.Text, this.cmbEscolaridad.Value.ToString(), puerto_conexion,
                        this.cmbTipoDeVision.Text, this.cmbDiestro.Text, this.txtDesordenNeuronal.Text, this.txtCrisisAnsiedad.Text,
                        this.txtMedicamentos.Text);
                    f.Text = "Experimento Prismas";

                    try {
                        f.Show();
                    }
                    catch (SecurityException ex)
                    {
                        MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
                    }

                }
                else
                {
                    MessageBox.Show("Debe llenar todos los parámetros para este paciente, verifique.", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
            }


        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        /*public void llamarConfiguraciones(string filePath)
        {
            try
            {

                List<string> configuraciones = IOFiles.Read(filePath);

                nombre = configuraciones[0].Split('|')[1];
                num_repeticiones = configuraciones[1].Split('|')[1];
                prueba = configuraciones[2].Split('|')[1];

                switch (prueba)
                {
                    case "0":
                        prueba = "PRE_GRAL";
                        break;
                    case "1":
                        prueba = "POST_GRAL";
                        break;
                    case "2":
                        prueba = "PRISMAS_GRAL";
                        break;
                    default:
                        prueba = "PROPIOCEPCION";
                        break;
                }

                //preprocesamiento de los mensajes
                descripcion = configuraciones[3].Split('|')[1];


                //puerto = configuraciones[4].Split('|')[1];
                //puerto = this.cmbPuertos.Text; //<-- ver como pasar el nombre del puerto


                xmin = configuraciones[5].Split('|')[1];
                xmax = configuraciones[6].Split('|')[1];
                ymin = configuraciones[7].Split('|')[1];
                ymax = configuraciones[8].Split('|')[1];

                //preprocesamiento de los mensajes
                instrucciones = configuraciones[9].Split('|')[1].Replace("_", "\r\n");
                mensaje_fin_experimento = configuraciones[10].Split('|')[1].Replace("_", "\r\n");


                direccionImagenes = configuraciones[12].Split('|')[1];
                delay = configuraciones[13].Split('|')[1];
                delay_espera_imagen = configuraciones[14].Split('|')[1];//recien agregado
            }
            catch (SecurityException ex)
            {
                //MessageBox.Show("Error al cargar configuración, posiblemente el archivo está dañado.");
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
            }

        }*/
    }
}
