using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace controldeexperimento
{
    public partial class frmConfiguracion : Form
    {
        public string puerto;
        public string num_repeticiones;
        public string nombre;
        public string prueba;
        public string xmin, xmax, ymin, ymax;
        private OpenFileDialog openFileDialog1;
        String archivo_config;
        OpenFileDialog OpenFile = new OpenFileDialog();
        bool config_nueva = true;
        String im_alto, im_largo;

        public frmConfiguracion(bool ocultar)
        {
            InitializeComponent();
            Portname();
            cmbTipoPruebas.Text = cmbTipoPruebas.Items[1].ToString();

            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.Title = "Selecciona un archivo de configuración";
            openFileDialog1.Multiselect = false;

            //se ocultan, cuando se va a hacer una configuración
            this.btnIniciar.Visible = !ocultar;
           
            this.txtNombre.Visible = !ocultar;
            this.txtDescripcion.Visible = !ocultar;
            this.label2.Visible = !ocultar;
            this.groupBox5.Visible = !ocultar;
            

        }
        public void Portname()
        {
            cmbPuertos.Text = "";
            cmbPuertos.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            cmbPuertos.Items.AddRange(ports);
            try
            {
                cmbPuertos.Text = cmbPuertos.Items[0].ToString();
            }
            catch
            {
                cmbPuertos.Text = "No hay puerto de conexión";
            }

            return;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        //btnIniciar
        private void button1_Click(object sender, EventArgs e)
        {
            puerto = this.cmbPuertos.Text;
            num_repeticiones = this.cmbNumRepeticiones.Value.ToString();
            nombre = this.txtNombre.Text;
            prueba = this.cmbTipoPruebas.Text;
            xmin = this.cmbXMin.Value.ToString();
            xmax = this.cmbXMax.Value.ToString();
            ymin = this.cmbYMin.Value.ToString();
            ymax = this.cmbYMax.Value.ToString();
            String descripcion = this.txtDescripcion.Text;
            String delay = this.cmbTiempoVisualizacionFeedback.Value.ToString(); //recien agregado
            String delay_espera_imagen = this.cmbTiempoPresentarImagen.Value.ToString();
            String delay_espera_target = this.cmbTiempoVisualizacionTarget.Value.ToString();

            im_alto = this.cmbImagenAlto.Value.ToString();
            im_largo = this.cmbImagenLargo.Value.ToString();

            String direccionImagenes = this.txtRutaImagenes.Text;

            //agregando  mensajes de instrucciones para el usuario
            String instrucciones = this.txtInstrucciones.Text;
            String mensaje_fin_experimento = this.txtMensajeFinExperimento.Text;
            Boolean activar_recompensa;

            if (this.chkRecompensa.Checked)
                activar_recompensa = true;
            else
                activar_recompensa = false;

            //Ensayos 24/oct/19
            Boolean activar_tiempo_ensayo;

            if (this.chkEnsayo.Checked)
                activar_tiempo_ensayo = true;
            else
                activar_tiempo_ensayo = false;


            //Más configuraciones sobre imágenes 24/oct/19
            Boolean imagen_centrada;

            if (this.chkImagenCentrada.Checked)
                imagen_centrada = true;
            else
                imagen_centrada = false;

            Boolean imagenes_aleatorias;

            if (this.chkImagenAleatorias.Checked)
                imagenes_aleatorias = true;
            else
                imagenes_aleatorias = false;



            if (rdbImagenesSi.Checked == true)
            {
                if (puerto != null && num_repeticiones != null && nombre != null && prueba != null && this.txtRutaImagenes.TextLength > 0)
                {
                    frmPanelExperimento f2 = new frmPanelExperimento(puerto, num_repeticiones, nombre,
                        prueba, xmin, xmax, ymin, ymax, descripcion, delay, direccionImagenes, instrucciones,
                        mensaje_fin_experimento, delay_espera_imagen, delay_espera_target, im_alto, im_largo,
                        this.cmbEdad.Value.ToString(), this.cmbSexo.Text, this.cmbEscolaridad.Value.ToString(),
                        this.cmbRetrasoMostrarTarget.Value.ToString(), this.cmbPuntosRecompensa.Value.ToString(),
                        activar_recompensa, this.cmbTiempoEnsayo.Value.ToString(), activar_tiempo_ensayo, 
                        imagen_centrada, imagenes_aleatorias); //creamos un objeto del formulario 2

                    f2.Show(); //abrimos el formulario 2 como cuadro de dialogo modal
                               //this.numericUpDown1.Value = 1;
                }
                else
                {
                    MessageBox.Show("Faltan datos para iniciar experimento CON IMÁGENES, verifique.", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else //sin imágenes
            {
                if (puerto != null && num_repeticiones != null && nombre != null && prueba != null)
                {

                    frmPanelExperimento f2 = new frmPanelExperimento(puerto, num_repeticiones, nombre,
                    prueba, xmin, xmax, ymin, ymax, descripcion, delay, instrucciones,
                    mensaje_fin_experimento, delay_espera_target, im_alto, im_largo,
                    this.cmbEdad.Value.ToString(), this.cmbSexo.Text, this.cmbEscolaridad.Value.ToString(),
                    this.cmbRetrasoMostrarTarget.Value.ToString(), this.cmbPuntosRecompensa.Value.ToString(), 
                    activar_recompensa, this.cmbTiempoEnsayo.Value.ToString(), activar_tiempo_ensayo); //creamos un objeto del formulario 2

                    f2.Show(); //abrimos el formulario 2 como cuadro de dialogo modal
                }
                else
                {
                    MessageBox.Show("Faltan datos para iniciar experimento, verifique.", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void terminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Portname();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            /*if (cmbXMin.Value >= cmbXMax.Value)
            {
                cmbXMin.Value = cmbXMax.Value;
                //numericUpDown3.Minimum = numericUpDown2.Value;
            }*/

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dlCarpeta.RootFolder = System.Environment.SpecialFolder.Desktop;
            dlCarpeta.ShowNewFolderButton = false;
            dlCarpeta.Description = "Selecciona la carpeta";
            if (dlCarpeta.ShowDialog() == DialogResult.OK)
            {
                txtRutaImagenes.Text = dlCarpeta.SelectedPath;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.btnBuscarImagenes.Enabled = true;
            
            //habilitando tiempos de espera para las imágenes
            this.cmbTiempoPresentarImagen.Enabled = true;

            this.cmbImagenAlto.Enabled = true;
            this.cmbImagenLargo.Enabled = true;
            this.chkImagenCentrada.Enabled = true;
            this.chkImagenAleatorias.Enabled = true;
        }

        //no imágenes
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.btnBuscarImagenes.Enabled = false;
            this.txtRutaImagenes.Clear();

            //ocultando tiempos de espera para las imágenes
            this.cmbTiempoPresentarImagen.Enabled = false;
            this.cmbImagenAlto.Enabled = false;
            this.cmbImagenLargo.Enabled = false;
            this.chkImagenCentrada.Enabled = false;
            this.chkImagenAleatorias.Enabled = false;

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void SalirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Confirma que desea cerrar esta ventana?", "Prismas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    serialPort1.Close();
                    this.Close();
                }
                catch
                {
                    this.Close();
                }
            }
        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GuardarConfiguraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txtInstrucciones.TextLength > 0 )
            {
                if (config_nueva)
                {
                    GuardarComoToolStripMenuItem_Click(sender, e);
                }
                else
                {
                    bool guardar = false;

                    if (this.rdbImagenesSi.Checked && this.txtRutaImagenes.TextLength > 0)
                        guardar = true;
                    else if (!this.rdbImagenesSi.Checked && this.txtRutaImagenes.TextLength == 0)
                        guardar = true;
                    else
                        MessageBox.Show("¡Revise todos los parámetros de su configuración!", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    // validación para evitar que el valor X-Ymenor, sea mayor que el X-Ymayor
                    if (cmbXMin.Value >= cmbXMax.Value)
                    {
                        //cmbXMin.Value = cmbXMax.Value;
                        MessageBox.Show("¡En los valores del área del target, el valor de X-min es mayor a X-max!", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        guardar = false;
                    }
                    else if (cmbYMin.Value >= cmbYMax.Value)
                    {
                        //cmbYMin.Value = cmbYMax.Value;
                        MessageBox.Show("¡En los valores del área del target,el valor de Y-min es mayor a Y-max!", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        guardar = false;
                    }
                    else
                    {
                        guardar = true;
                    }


                    if (guardar)
                    {
                        if (MessageBox.Show("¿Desea Actualizar la información archivo? " + OpenFile.FileName, "Prismas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            String aux;

                            if (OpenFile.FileName != null)
                            {
                                aux = "1|" + this.txtNombre.Text + "\n";
                                aux += "2|" + this.cmbNumRepeticiones.Value + "\n";
                                aux += "3|" + this.cmbTipoPruebas.SelectedIndex + "\n";

                                //preprocesamiento para quitar enter, etc
                                String descripcion_experimento = this.txtDescripcion.Text.Replace("\r\n", "_");
                                aux += "4|" + descripcion_experimento + "\n";


                                aux += "5|" + this.cmbPuertos.SelectedIndex + "\n";
                                aux += "6|" + this.cmbXMin.Value + "\n";
                                aux += "7|" + this.cmbXMax.Value + "\n";
                                aux += "8|" + this.cmbYMin.Value + "\n";
                                aux += "9|" + this.cmbYMax.Value + "\n";

                                //preprocesamiento para quitar enter, etc
                                String instrucciones = this.txtInstrucciones.Text.Replace("\r\n", "_");
                                String mensaje_final = this.txtMensajeFinExperimento.Text.Replace("\r\n", "_");

                                aux += "10|" + instrucciones + "\n"; //recien agregado
                                aux += "11|" + mensaje_final + "\n"; //recien agregado

                                if (rdbImagenesSi.Checked)
                                {
                                    aux += "12|" + rdbImagenesSi.Text + "\n";
                                    if (txtRutaImagenes.TextLength > 0)
                                    {
                                        aux += "13|" + this.txtRutaImagenes.Text + "\n";
                                        aux += "14|" + this.cmbTiempoVisualizacionFeedback.Value + "\n";
                                        aux += "15|" + cmbTiempoPresentarImagen.Value + "\n";
                                        aux += "16|" + this.cmbTiempoVisualizacionTarget.Value + "\n";
                                        aux += "17|" + this.cmbImagenAlto.Value + "\n";
                                        aux += "18|" + this.cmbImagenLargo.Value + "\n";
                                        aux += "19|" + this.cmbRetrasoMostrarTarget.Value + "\n";
                                        aux += "20|" + this.chkRecompensa.CheckState + "\n";
                                        aux += "21|" + this.cmbPuntosRecompensa.Value + "\n";
                                        aux += "22|" + this.chkEnsayo.CheckState + "\n";
                                        aux += "23|" + this.cmbTiempoEnsayo.Value + "\n";
                                        aux += "24|" + this.chkImagenCentrada.CheckState + "\n";
                                        aux += "25|" + this.chkImagenAleatorias.CheckState + "\n";

                                    }
                                    else
                                    {
                                        MessageBox.Show("Falta ingresar una ruta para las imágenes, verifique.", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else //cuando no eliges imágenes
                                {
                                    aux += "12|" + this.rdbImagenesNo.Text + "\n";
                                    aux += "13|" + "\n"; // no se guarda la ruta de la carpeta de las imágenes
                                    aux += "14|" + cmbTiempoVisualizacionFeedback.Value + "\n";
                                    aux += "15|" + "0.0" + "\n"; //no es necesario el tiempo de espera con las imágenes
                                    aux += "16|" + this.cmbTiempoVisualizacionTarget.Value + "\n";
                                    aux += "17|" + this.cmbImagenAlto.Value + "\n";
                                    aux += "18|" + this.cmbImagenLargo.Value + "\n";
                                    aux += "19|" + this.cmbRetrasoMostrarTarget.Value + "\n";
                                    aux += "20|" + this.chkRecompensa.CheckState + "\n";
                                    aux += "21|" + this.cmbPuntosRecompensa.Value + "\n";
                                    aux += "22|" + this.chkEnsayo.CheckState + "\n";
                                    aux += "23|" + this.cmbTiempoEnsayo.Value + "\n";
                                    aux += "24|" + this.chkImagenCentrada.CheckState + "\n";
                                    aux += "25|" + this.chkImagenAleatorias.CheckState + "\n";

                                }

                                using (StreamWriter sw = new StreamWriter(OpenFile.FileName))
                                    sw.Write(aux);

                                MessageBox.Show("¡Configuración guardada con éxito!", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                                MessageBox.Show("¡Se canceló la actualización!", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Debe llenar toda la información referente a la configuración, verifique.", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.rdbImagenesNo.Checked = true;

                //recompensa
                this.chkRecompensa.Checked = false;
                if (this.chkRecompensa.Checked)
                {
                    this.cmbPuntosRecompensa.Enabled = true;
                    this.label36.Enabled = true;
                }
                else
                {
                    this.cmbPuntosRecompensa.Enabled = false;
                    this.label36.Enabled = false;
                }

                //Ensayos
                this.chkEnsayo.Checked = false;
                if (this.chkEnsayo.Checked)
                {
                    this.cmbTiempoEnsayo.Enabled = true;
                    this.label37.Enabled = true;
                }
                else
                {
                    this.cmbTiempoEnsayo.Enabled = false;
                    this.label37.Enabled = false;
                }

                /* var directory = new DirectoryInfo(Application.StartupPath);
                 var myFile = directory.GetFiles("*.txt")
                  .OrderByDescending(f => f.LastWriteTime)
                  .First();

                 //validando que el archivo no esté vacío
                 if (myFile != null)
                 {
                     LlenarComponentes(myFile.DirectoryName + "\\" + myFile.Name);
                 }
                 else
                 {
                     MessageBox.Show("No se cargó ningún archivo de configuración", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }*/
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
                
            }
        }

        public void LlenarComponentes(string filePath)
        {
            try
            {
                String aux = "";

                using (StreamReader sr = new StreamReader(filePath))
                {
                    aux = sr.ReadToEnd();
                }

                config_nueva = false;

                //En el ejemplo convertimos el string a un string[], es decir, de una cadena de caracteres a un array de cadenas de caracteres, luego convertimos el texto del string[] a List usando como cambio de elemento del List el carácter \n que representa "Nueva línea".
                List<string> configuraciones = aux.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();

                //List<string> configuraciones = IOFiles.Read(filePath); //programación anterior

                archivo_config = filePath;
                this.lblArchivoConfiguracion.Text = "Archivo actual: " + archivo_config;

                this.txtNombre.Text = configuraciones[0].Split('|')[1];
                this.cmbNumRepeticiones.Value = decimal.Parse(configuraciones[1].Split('|')[1]);
                this.cmbTipoPruebas.SelectedIndex = int.Parse(configuraciones[2].Split('|')[1]);

                //preprocesamiento de los mensajes
                if (configuraciones[3].Length > 0)
                {
                    String descripcion = configuraciones[3].Split('|')[1].Replace("_", "\r\n");
                    this.txtDescripcion.Text = descripcion;
                }

                if (int.Parse(configuraciones[4].Split('|')[1]) < this.cmbPuertos.Items.Count)
                {
                    this.cmbPuertos.SelectedIndex = int.Parse(configuraciones[4].Split('|')[1]);
                }

                this.cmbXMin.Value = decimal.Parse(configuraciones[5].Split('|')[1]);
                this.cmbXMax.Value = decimal.Parse(configuraciones[6].Split('|')[1]);
                this.cmbYMin.Value = decimal.Parse(configuraciones[7].Split('|')[1]);
                this.cmbYMax.Value = decimal.Parse(configuraciones[8].Split('|')[1]);

                //preprocesamiento de los mensajes
                if (configuraciones[9].Length > 0 && configuraciones[10].Length > 0)
                {
                    String instrucciones = configuraciones[9].Split('|')[1].Replace("_", "\r\n");
                    String mensaje_final = configuraciones[10].Split('|')[1].Replace("_", "\r\n");

                    this.txtInstrucciones.Text = instrucciones; //recien agregado
                    this.txtMensajeFinExperimento.Text = mensaje_final; //recien agregado
                }

                String aux2 = configuraciones[11].Split('|')[1].Replace("\r\n", "").Replace("\n", "").Replace("\r", "");

                if (aux2.Equals("Sí"))
                {
                    this.rdbImagenesSi.Checked = true;
                    //this.rdbImagenesNo.Checked = false;
                }
                else
                {
                    //this.rdbImagenesSi.Checked = false;
                    this.rdbImagenesNo.Checked = true;
                }

                this.txtRutaImagenes.Text = configuraciones[12].Split('|')[1].Replace("\r\n", "").Replace("\n", "").Replace("\r", "");
                this.cmbTiempoVisualizacionFeedback.Value = decimal.Parse(configuraciones[13].Split('|')[1]);
                this.cmbTiempoPresentarImagen.Value = decimal.Parse(configuraciones[14].Split('|')[1]);//recien agregado
                this.cmbTiempoVisualizacionTarget.Value = decimal.Parse(configuraciones[15].Split('|')[1]);//recien agregado
                this.cmbImagenAlto.Value = decimal.Parse(configuraciones[16].Split('|')[1]);//recien agregado
                this.cmbImagenLargo.Value = decimal.Parse(configuraciones[17].Split('|')[1]);//recien agregado
                this.cmbRetrasoMostrarTarget.Value = decimal.Parse(configuraciones[18].Split('|')[1]);//recien agregado

                //Sistema de recompensas 2/oct/2019
                if (configuraciones[19].Split('|')[1].Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Equals("Unchecked")) {
                    this.chkRecompensa.Checked = false;
                }
                else {
                    this.chkRecompensa.Checked = true;
                }

                this.cmbPuntosRecompensa.Value = decimal.Parse(configuraciones[20].Split('|')[1]);//recien agregado


                //Activación de tiempo para ensayos-trials 24/oct/2019
                if (configuraciones[21].Split('|')[1].Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Equals("Unchecked"))
                {
                    this.chkEnsayo.Checked = false;
                }
                else
                {
                    this.chkEnsayo.Checked = true;
                }

                this.cmbTiempoEnsayo.Value = decimal.Parse(configuraciones[22].Split('|')[1]);//recien agregado

                //Imágenes, otras configuraciones. Agregada el 29/ago/2020
                if (configuraciones[23].Split('|')[1].Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Equals("Unchecked"))
                {
                    this.chkImagenCentrada.Checked = false;
                }
                else
                {
                    this.chkImagenCentrada.Checked = true;
                }


                if (configuraciones[24].Split('|')[1].Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Equals("Unchecked"))
                {
                    this.chkImagenAleatorias.Checked = false;
                }
                else
                {
                    this.chkImagenAleatorias.Checked = true;
                }


                OpenFile.FileName = filePath;

            }
            catch (SecurityException ex)
            {
                //MessageBox.Show("Error al cargar configuración, posiblemente el archivo está dañado.");
                 MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
            }

        }

        private void CargarConfiguraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {

                /*if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    LlenarComponentes(OpenFile.FileName);
                }*/

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "@:\\";
                    openFileDialog.Title = "Selecciona las Condiciones";
                    openFileDialog.Filter = "Archivos COND (*.cond)|*.COND|Archivos TXT (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    //if (OpenFile.ShowDialog() == DialogResult.OK)
                    {
                        OpenFile.FileName = openFileDialog.FileName; //le voy a hacer la asignación manual de la ruta

                        LlenarComponentes(OpenFile.FileName);
                    }
                }

            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
            }


            /////////////////////////////
            /*if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = openFileDialog1.FileName;
                    LlenarComponentes(filePath);
                    
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }*/
        }

        private void GroupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void Label19_Click(object sender, EventArgs e)
        {

        }

        private void GuardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool guardar = false;

            try
            {

                if (this.rdbImagenesSi.Checked && this.txtRutaImagenes.TextLength > 0)
                    guardar = true;
                else if (!this.rdbImagenesSi.Checked && this.txtRutaImagenes.TextLength == 0)
                    guardar = true;
                else
                    MessageBox.Show("¡Revise todos los parámetros de su configuración!", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // validación para evitar que el valor X-Ymenor, sea mayor que el X-Ymayor
                if (cmbXMin.Value >= cmbXMax.Value)
                {
                    //cmbXMin.Value = cmbXMax.Value;
                    MessageBox.Show("¡El valor de X-min es mayor a X-max, verifique!", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    guardar = false;
                }
                else if (cmbYMin.Value >= cmbYMax.Value)
                {
                    //cmbYMin.Value = cmbYMax.Value;
                    MessageBox.Show("¡El valor de Y-min es mayor a Y-max, verifique!", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    guardar = false;
                }
                else {
                    guardar = true;
                }

                if (guardar)
                {
                    // Mostrando ventana de navegación para guardar los registros del experimento
                    SaveFileDialog dlg = new SaveFileDialog();
                    if (this.rdbImagenesSi.Checked)
                    {
                        dlg.FileName = "CONFIG_" + this.cmbTipoPruebas.Text + "_" + DateTime.Now.ToString("yyyy-MM-dd-HHmmsss") + "_" + "CON_IMAGENES.cond";
                    }
                    else
                    {
                        dlg.FileName = "CONFIG_" + this.cmbTipoPruebas.Text + "_" + DateTime.Now.ToString("yyyy-MM-dd-HHmmsss") + ".cond";
                    }

                    dlg.Filter = "Condiciones | *.cond";
                    dlg.DefaultExt = "cond";


                    if (dlg.ShowDialog() == DialogResult.OK)
                    {

                        //// Guardando las configuraciones de experimentación
                        //string ruta = Application.StartupPath + "\\" + "CONFIG_" + DateTime.Now.ToString("yyyy-MM-dd-HHmmsss") + "_" + this.txtNombre.Text + "_" + this.cmbTipoPruebas.Text + ".txt";
                        String ruta = dlg.FileName;
                        //if (!this.txtNombre.Text.Equals(""))
                        //{
                        //if (MessageBox.Show("¿Está seguro(a) qué desea guardar la configuración actual?", "Guardar configuración", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        //{
                        IOFiles.Write("1|" + this.txtNombre.Text.Replace("\r\n", "").Replace("\n", "").Replace("\r", ""), ruta);
                        IOFiles.Write("2|" + this.cmbNumRepeticiones.Value, ruta);
                        IOFiles.Write("3|" + this.cmbTipoPruebas.SelectedIndex, ruta);

                        //preprocesamiento para quitar enter, etc
                        String descripcion_experimento = this.txtDescripcion.Text.Replace("\r\n", "_");
                        IOFiles.Write("4|" + descripcion_experimento, ruta);


                        IOFiles.Write("5|" + this.cmbPuertos.SelectedIndex, ruta);
                        IOFiles.Write("6|" + this.cmbXMin.Value, ruta);
                        IOFiles.Write("7|" + this.cmbXMax.Value, ruta);
                        IOFiles.Write("8|" + this.cmbYMin.Value, ruta);
                        IOFiles.Write("9|" + this.cmbYMax.Value, ruta);

                        //preprocesamiento para quitar enter, etc

                        String instrucciones = this.txtInstrucciones.Text.Replace("\r\n", "_");
                        String mensaje_final = this.txtMensajeFinExperimento.Text.Replace("\r\n", "_");

                        IOFiles.Write("10|" + instrucciones.Replace("\r\n", "").Replace("\n", "").Replace("\r", ""), ruta); //recien agregado
                        IOFiles.Write("11|" + mensaje_final.Replace("\r\n", "").Replace("\n", "").Replace("\r", ""), ruta); //recien agregado

                        if (rdbImagenesSi.Checked)
                        {
                            IOFiles.Write("12|" + rdbImagenesSi.Text, ruta);
                            if (!txtRutaImagenes.Text.Equals(""))
                            {
                                IOFiles.Write("13|" + this.txtRutaImagenes.Text, ruta);
                                IOFiles.Write("14|" + this.cmbTiempoVisualizacionFeedback.Value, ruta);
                                IOFiles.Write("15|" + cmbTiempoPresentarImagen.Value, ruta);
                                IOFiles.Write("16|" + this.cmbTiempoVisualizacionTarget.Value, ruta);
                                IOFiles.Write("17|" + this.cmbImagenAlto.Value, ruta);
                                IOFiles.Write("18|" + this.cmbImagenLargo.Value, ruta);
                                IOFiles.Write("19|" + this.cmbRetrasoMostrarTarget.Value, ruta);
                                IOFiles.Write("20|" + this.chkRecompensa.CheckState, ruta);
                                IOFiles.Write("21|" + this.cmbPuntosRecompensa.Value, ruta);
                                IOFiles.Write("22|" + this.chkEnsayo.CheckState, ruta);
                                IOFiles.Write("23|" + this.cmbTiempoEnsayo.Value, ruta);
                                IOFiles.Write("24|" + this.chkImagenCentrada.CheckState, ruta);
                                IOFiles.Write("25|" + this.chkImagenAleatorias.CheckState, ruta);
                                

                            }
                            else
                            {
                                MessageBox.Show("Ingrese una ruta de imágenes.", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                File.Delete(ruta);
                            }
                        }
                        else //cuando no eliges imágenes
                        {
                            IOFiles.Write("12|" + this.rdbImagenesNo.Text, ruta);
                            IOFiles.Write("13|", ruta); // no se guarda la ruta de la carpeta de las imágenes
                            IOFiles.Write("14|" + cmbTiempoVisualizacionFeedback.Value, ruta);
                            IOFiles.Write("15|" + "0.0", ruta); //no es necesario el tiempo de espera con las imágenes
                            IOFiles.Write("16|" + this.cmbTiempoVisualizacionTarget.Value, ruta);
                            IOFiles.Write("17|" + this.cmbImagenAlto.Value, ruta);
                            IOFiles.Write("18|" + this.cmbImagenLargo.Value, ruta);
                            IOFiles.Write("19|" + this.cmbRetrasoMostrarTarget.Value, ruta);
                            IOFiles.Write("20|" + this.chkRecompensa.CheckState, ruta);
                            IOFiles.Write("21|" + this.cmbPuntosRecompensa.Value, ruta);
                            IOFiles.Write("22|" + this.chkEnsayo.CheckState, ruta);
                            IOFiles.Write("23|" + this.cmbTiempoEnsayo.Value, ruta);
                            IOFiles.Write("24|" + this.chkImagenCentrada.CheckState, ruta);
                            IOFiles.Write("25|" + this.chkImagenAleatorias.CheckState, ruta);

                        }

                        //} 
                        // si no le falta el nombre del paciente, entonces lo guarda y manda mensaje
                        MessageBox.Show("¡Configuración de Condición, guardada con éxito!", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //vuelvo a leerlo para que se pueda trabajar sobre este archivo en el futuro.
                        OpenFile.FileName = ruta;
                        LlenarComponentes(ruta);


                        //}
                        //else
                        //{
                        //MessageBox.Show("Ingrese un nombre", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}
                        //////////////////////////////////////////////////////////////

                    }
                }
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
            }
        }

        private void ConfiguracionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ChkRecompensa_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkRecompensa.Checked)
            {
                this.cmbPuntosRecompensa.Enabled = true;
                this.label36.Enabled = true;
            }
            else {
                this.cmbPuntosRecompensa.Enabled = false;
                this.label36.Enabled = false;
            }
        }

        private void ChkEnsayo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkEnsayo.Checked)
            {
                this.cmbTiempoEnsayo.Enabled = true;
                this.label37.Enabled = true;
            }
            else
            {
                this.cmbTiempoEnsayo.Enabled = false;
                this.label37.Enabled = false;
            }

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NuevaConfiguraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea crear una nueva configuración?" , "Prismas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                config_nueva = true;
                this.txtNombre.Clear();
                this.txtDescripcion.Clear();
                this.txtRutaImagenes.Clear();
                this.txtInstrucciones.Clear();
                this.txtMensajeFinExperimento.Clear();
                this.cmbNumRepeticiones.Value = 1;
                this.rdbImagenesNo.Checked = true;
                this.rdbImagenesSi.Checked = false;
                this.lblArchivoConfiguracion.Text = "Archivo actual: N U E V O";
            }
            else {
                MessageBox.Show("¡Se canceló la creación de un nuevo archivo de configuración!", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            /*if (cmbXMax.Value <= cmbXMin.Value)
            {
                cmbXMax.Value = cmbXMin.Value;
                //numericUpDown3.Minimum = numericUpDown2.Value;
            }*/
        }
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            /*if (cmbYMin.Value >= cmbYMax.Value)
            {
                cmbYMin.Value = cmbYMax.Value;
                //numericUpDown5.Minimum = numericUpDown4.Value;
            }*/
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            /*if (cmbYMax.Value <= cmbYMin.Value)
            {
                cmbYMax.Value = cmbYMin.Value;
                //numericUpDown5.Minimum = numericUpDown4.Value;
            }*/
        }
    }
}
