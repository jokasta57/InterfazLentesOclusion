using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Text.RegularExpressions;

namespace controldeexperimento
{
    public partial class frmExperimentoGral : Form
    {
        private OpenFileDialog openFileDialog1; // este se usa de manera genérica para abrir las condiciones o archivos de los experimentos
        bool ocultar = true;
        bool config_nueva = true;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        //OpenFileDialog OpenFile = new OpenFileDialog();// este guarda la ruta de los archivos de exp. grales., de forma global!!
        bool experimento_modificado = false;


        public frmExperimentoGral()
        {
            InitializeComponent();

            //cargando los puertos de comunicación con los lentes
            Portname();

            //openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            //openFileDialog1.Title = "Selecciona un archivo de configuración";
            //openFileDialog1.Multiselect = false;
        }

        public void Portname()
        {
            try
            {
                cmbPuertos.Items.Clear();
                string[] ports = SerialPort.GetPortNames();
                cmbPuertos.Items.AddRange(ports);
                cmbPuertos.Text = cmbPuertos.Items[0].ToString();
            }
            catch
            {
                cmbPuertos.Text = "No hay puerto de conexión";
            }

            return;
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            
        }



        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracion f = new frmConfiguracion(ocultar);
            f.Show();
        }

        private void BtnBuscarPrePrueba_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Experimentos (*.cond)|*.COND";
                openFileDialog1.Title = "Selecciona un archivo de configuración";
                openFileDialog1.Multiselect = false;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    this.txtRutaPrePrueba.Text = openFileDialog1.FileName;
                }
                experimento_modificado = true;
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
            }
            
        }

        private void BtnBuscarPostPrueba_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Experimentos (*.cond)|*.COND";
                openFileDialog1.Title = "Selecciona un archivo de configuración";
                openFileDialog1.Multiselect = false;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    this.txtRutaPostPrueba.Text = openFileDialog1.FileName;
                }
                experimento_modificado = true;
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n{ex.StackTrace}");
            }
        }

        private void BtnBuscarPrismasPrueba_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Experimentos (*.cond)|*.COND";
                openFileDialog1.Title = "Selecciona un archivo de configuración";
                openFileDialog1.Multiselect = false;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    this.txtRutaPrismasPrueba.Text = openFileDialog1.FileName;
                }
                experimento_modificado = true;
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n{ex.StackTrace}");
            }
        }

        private void BtnActulizarPuertos_Click(object sender, EventArgs e)
        {
            Portname();
        }

        /*String puerto, num_repeticiones, nombre,
                prueba, xmin, xmax, ymin, ymax,
                descripcion, delay, direccionImagenes,
                instrucciones, mensaje_fin_experimento,
                delay_espera_imagen;*/

        //botón de busqueda de configuracion de propiocepción
        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Experimentos (*.cond)|*.COND";
                openFileDialog1.Title = "Selecciona un archivo de configuración";
                openFileDialog1.Multiselect = false;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    this.txtRutaPropiocepcion.Text = openFileDialog1.FileName;
                }

                experimento_modificado = true;
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
            }
        }

        private void TxtRutaPropiocepcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevoExperimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txtRutaPropiocepcion.TextLength > 0 || this.txtRutaPrePrueba.TextLength > 0
                || this.txtRutaPrismasPrueba.TextLength > 0 || this.txtRutaPostPrueba.TextLength > 0)
            {
                if (MessageBox.Show("Se borrará la información actual, ¿desea continuar? "+ openFileDialog.FileName, "Prismas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.txtRutaPostPrueba.Clear();
                    this.txtRutaPrePrueba.Clear();
                    this.txtRutaPrismasPrueba.Clear();
                    this.txtRutaPropiocepcion.Clear();
                    this.lblOrdenEjecucion.Clear();
                    this.lblArchivoConfiguracion.Text = "";
                    this.txtRutaProbe.Clear();
                    config_nueva = true;

                }
            }
        }

        private void TxtRutaPropiocepcion_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.txtRutaPropiocepcion.Text.Replace("\r\n", "").Replace("\n", "").Replace("\r", "");

                if (this.txtRutaPropiocepcion.TextLength > 0)
                {
                    frmConfiguracion f = new frmConfiguracion(ocultar);
                    f.Show();
                    f.Text = "Edición de PROPIOCEPCIÓN, de Experimento Gral.";
                    f.FormBorderStyle = FormBorderStyle.Sizable;

                    f.LlenarComponentes(this.txtRutaPropiocepcion.Text.Replace("\r\n", "").Replace("\n", "").Replace("\r", ""));
                }
                else
                {
                    MessageBox.Show("No ha seleccionado el archivo de configuración de la Prueba de Propiocepción.", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
            }
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (this.txtRutaPropiocepcion.TextLength > 0)
            {
                this.lblOrdenEjecucion.Text += ">Propiocepción";
                experimento_modificado = true;
            }
            else {
                MessageBox.Show("No ha seleccionado el archivo de configuración de la Prueba de Propiocepción.", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void GuardarExperimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // guardar el experimento
            if ( this.txtRutaPrePrueba.TextLength > 0 && this.txtRutaPrismasPrueba.TextLength > 0 
                && this.txtRutaPostPrueba.TextLength > 0 && this.lblOrdenEjecucion.TextLength > 0)
            {
                if (config_nueva)
                {
                    GuardarExperimentoComoToolStripMenuItem_Click(sender, e);
                }
                else
                {
                    if (MessageBox.Show("¿Desea Actualizar la información del experimento? " + openFileDialog.FileName, "Prismas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        experimento_modificado = false;

                        String aux;

                        if (openFileDialog.FileName != null)
                        {
                            aux = "1|" + this.txtRutaPropiocepcion.Text + "\n";
                            aux += "2|" + this.txtRutaPrePrueba.Text + "\n";
                            aux += "3|" + this.txtRutaPrismasPrueba.Text + "\n";
                            aux += "4|" + this.txtRutaPostPrueba.Text + "\n";
                            aux += "5|" + this.lblOrdenEjecucion.Text.Replace("\r\n", "").Replace("\n", "").Replace("\r", "") + "\n";
                            aux += "6|" + this.txtRutaProbe.Text + "\n";
                            aux += "7|" + this.cmbPuertos.SelectedIndex + "\n";

                            using (StreamWriter sw = new StreamWriter(openFileDialog.FileName))
                                sw.Write(aux);

                            MessageBox.Show("¡Experimento guardado con éxito!", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                            MessageBox.Show("¡Se canceló la actualización!", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
            }
            else {
                MessageBox.Show("Debe seleccionar al menos tres tipos de pruebas (pre, prismas y post) y el orden de ejecución, para iniciar el experimento, verifique.", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void GuardarExperimentoComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                experimento_modificado = false;

                // Mostrando ventana de navegación para guardar los registros del experimento
                SaveFileDialog dlg = new SaveFileDialog();

                dlg.FileName = "EXPERIMENTO_" + DateTime.Now.ToString("yyyy-MM-dd-HHmmsss") + ".exp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    //// Guardando las configuraciones de experimentación
                    String ruta = dlg.FileName;

                    IOFiles.Write("1|" + this.txtRutaPropiocepcion.Text.Replace("\r\n", "").Replace("\n", "").Replace("\r", ""), ruta);
                    IOFiles.Write("2|" + this.txtRutaPrePrueba.Text.Replace("\r\n", "").Replace("\n", "").Replace("\r", ""), ruta);
                    IOFiles.Write("3|" + this.txtRutaPrismasPrueba.Text.Replace("\r\n", "").Replace("\n", "").Replace("\r", ""), ruta);
                    IOFiles.Write("4|" + this.txtRutaPostPrueba.Text.Replace("\r\n", "").Replace("\n", "").Replace("\r", ""), ruta);

                    //this.lblOrdenEjecucion.Text += ">fin";
                    IOFiles.Write("5|" + this.lblOrdenEjecucion.Text.Replace("\r\n", "").Replace("\n", "").Replace("\r", ""), ruta);

                    IOFiles.Write("6|" + this.txtRutaProbe.Text.Replace("\r\n", "").Replace("\n", "").Replace("\r", ""), ruta);
                    IOFiles.Write("7|" + this.cmbPuertos.SelectedIndex, ruta);

                    MessageBox.Show("¡Experimento guardado con éxito!", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //vuelvo a leerlo para que se pueda trabajar sobre este archivo en el futuro.
                    openFileDialog.FileName = ruta;
                    LlenarComponentes(ruta);
                }



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

                this.lblArchivoConfiguracion.Text = "Archivo actual: " + filePath;

                this.txtRutaPropiocepcion.Text = configuraciones[0].Split('|')[1];
                this.txtRutaPrePrueba.Text = configuraciones[1].Split('|')[1];
                this.txtRutaPrismasPrueba.Text = configuraciones[2].Split('|')[1];
                this.txtRutaPostPrueba.Text = configuraciones[3].Split('|')[1];
                this.lblOrdenEjecucion.Text = configuraciones[4].Split('|')[1];
                this.txtRutaProbe.Text = configuraciones[5].Split('|')[1];

                if (int.Parse(configuraciones[6].Split('|')[1]) < this.cmbPuertos.Items.Count)
                {
                    this.cmbPuertos.SelectedIndex = int.Parse(configuraciones[6].Split('|')[1]);
                }
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
            }

        }

        private void BtnQuitarPruebasOrdenEjecucion_Click(object sender, EventArgs e)
        {
            if (this.lblOrdenEjecucion.TextLength > 0)
            {
                if (MessageBox.Show("¿Confirma que desea quitar la última prueba en el 'Orden de ejecución' actual? " + openFileDialog.FileName, "Prismas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //funcion para quitar pruebas, dentro de un "orden de ejecución"
                    String aux = "";
                    string[] strArr;
                    char[] splitchar = { '>' };
                    strArr = this.lblOrdenEjecucion.Text.Split(splitchar);
                    for (int i = 1; i <= strArr.Length - 2; i++)
                    {
                        aux += ">" + (strArr[i]);
                    }

                    this.lblOrdenEjecucion.Text = aux;
                    experimento_modificado = true;
                }
            }
            
        }

        private void LblOrdenEjecucion_TextChanged(object sender, EventArgs e)
        {
            if (this.lblOrdenEjecucion.TextLength > 0)
                this.btnQuitarPruebasOrdenEjecucion.Enabled = true;
            else
                this.btnQuitarPruebasOrdenEjecucion.Enabled = false;
        }

        private void BtnQuitarPruebasOrdenEjecucion_Click_1(object sender, EventArgs e)
        {
            BtnQuitarPruebasOrdenEjecucion_Click(sender, e);
        }

        private void BtnPropiocepcion_Click(object sender, EventArgs e)
        {
            Button1_Click_1(sender, e);
        }

        private void BtnIniciarPrePrueba_Click(object sender, EventArgs e)
        {
            BtnIniciar_Click_1(sender, e);
        }

        private void BtnIniciarPostPrueba_Click_1(object sender, EventArgs e)
        {
            BtnIniciarPostPrueba_Click( sender,  e);
        }

        private void BtnIniciarPrismasPrueba_Click_1(object sender, EventArgs e)
        {
            BtnIniciarPrismasPrueba_Click( sender,  e);
        }

        private void BtnQuitarPropiocepcion_Click(object sender, EventArgs e)
        {
            if (this.txtRutaPropiocepcion.TextLength > 0)
            {
                if (MessageBox.Show("¿Confirma que desea eliminar prueba de Propiocepcion? ", "Prismas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.txtRutaPropiocepcion.Clear();
                    experimento_modificado = true;
                }
            }
        }

        private void BtnQuitarPreprueba_Click(object sender, EventArgs e)
        {
            if (this.txtRutaPrePrueba.TextLength > 0)
            {
                if (MessageBox.Show("¿Confirma que desea eliminar la Pre-prueba? ", "Prismas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.txtRutaPrePrueba.Clear();
                    experimento_modificado = true;

                }
            }
        }

        private void BtnQuitarPrismas_Click(object sender, EventArgs e)
        {
            if (this.txtRutaPrismasPrueba.TextLength > 0)
            {
                if (MessageBox.Show("¿Confirma que desea eliminar la prueba de Prismas? ", "Prismas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.txtRutaPrismasPrueba.Clear();
                    experimento_modificado = true;
                }
            }
        }

        private void BtnQuitarPostPrueba_Click(object sender, EventArgs e)
        {
            if (this.txtRutaPostPrueba.TextLength > 0)
            {
                if (MessageBox.Show("¿Confirma que desea eliminar la Post-prueba? ", "Prismas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.txtRutaPostPrueba.Clear();
                    experimento_modificado = true;
                }
            }
        }

        private void BtnIniciarProbe_Click(object sender, EventArgs e)
        {
            if (this.txtRutaProbe.TextLength > 0)
            {
                this.lblOrdenEjecucion.Text += ">Probe";
                experimento_modificado = true;
            }
            else {
                MessageBox.Show("No ha seleccionado el archivo de configuración de la Prueba de Probe.", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBuscarProbe_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Experimentos (*.cond)|*.COND";
                openFileDialog1.Title = "Selecciona archivo de la condición Probe";
                openFileDialog1.Multiselect = false;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.txtRutaProbe.Text = openFileDialog1.FileName;
                }
                experimento_modificado = true;
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n{ex.StackTrace}");
            }
        }

        private void TxtRutaProbe_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void TxtRutaProbe_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.txtRutaProbe.TextLength > 0)
                {
                    frmConfiguracion f = new frmConfiguracion(ocultar);
                    f.Show();
                    f.Text = "Edición de PROBE, de Experimento Gral.";
                    f.FormBorderStyle = FormBorderStyle.Sizable;

                    f.LlenarComponentes(this.txtRutaProbe.Text.Replace("\r\n", "").Replace("\n", "").Replace("\r", ""));
                }
                else
                {
                    MessageBox.Show("No ha seleccionado el archivo de configuración de la Prueba de Propiocepción.", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
            }
        }

        private void BtnQuitarPostProbe_Click(object sender, EventArgs e)
        {
            if (this.txtRutaProbe.TextLength > 0)
            {
                if (MessageBox.Show("¿Confirma que desea eliminar la Prueba de Probe? ", "Prismas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.txtRutaProbe.Clear();
                    experimento_modificado = true;
                }
            }
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Confirma que desea cerrar esta ventana?", "Prismas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    this.Close();
                }
                catch
                {
                    this.Close();
                }
            }
        }

        private void TxtRutaPrismasPrueba_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtRutaPostPrueba_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.txtRutaPostPrueba.TextLength > 0)
                {
                    frmConfiguracion f = new frmConfiguracion(ocultar);
                    f.Show();
                    f.FormBorderStyle = FormBorderStyle.Sizable;
                    f.Text = "Edición de POST-PRUEBA, de Experimento Gral.";
                    f.LlenarComponentes(this.txtRutaPostPrueba.Text.Replace("\r\n", "").Replace("\n", "").Replace("\r", ""));
                }
                else
                {
                    MessageBox.Show("No ha seleccionado el archivo de configuración de la Post-Prueba.", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
            }
        }

        private void TxtRutaPrismasPrueba_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.txtRutaPrismasPrueba.TextLength > 0)
                {
                    frmConfiguracion f = new frmConfiguracion(ocultar);
                    f.Show();
                    f.FormBorderStyle = FormBorderStyle.Sizable;
                    f.Text = "Edición de Prueba de PRISMAS, de Experimento Gral.";
                    f.LlenarComponentes(this.txtRutaPrismasPrueba.Text.Replace("\r\n", "").Replace("\n", "").Replace("\r", ""));
                }
                else
                {
                    MessageBox.Show("No ha seleccionado el archivo de configuración de la prueba de Prismas.", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
            }
        }

        private void AbrirExperimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                /*openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Archivos EXP (*.EXP) | *.EXP";
                openFileDialog1.Title = "Selecciona un archivo de experimentación";
                openFileDialog1.RestoreDirectory = true;

                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    LlenarComponentes(OpenFile.FileName);
                }*/

                /*var fileContent = string.Empty;
                var filePath = string.Empty;
                var fileName = string.Empty;*/
                //using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "@:\\";
                    openFileDialog.Title = "Selecciona un archivo de experimentación";
                    openFileDialog.Filter = "Archivos EXP (*.EXP)|*.EXP|Archivos TXT (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    //if (OpenFile.ShowDialog() == DialogResult.OK)
                    {
                        //OpenFile.FileName = openFileDialog.FileName; //le voy a hacer la asignación manual de la ruta, porque lo tienen en muchas partes del código

                        LlenarComponentes(openFileDialog.FileName);
                    }
                }

            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
            }

        }

        private void TxtRutaPrePrueba_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            try
            {
                if (this.txtRutaPrePrueba.TextLength > 0)
                {
                    frmConfiguracion f = new frmConfiguracion(ocultar);
                    f.Show();
                    f.Text = "Edición de PRE-PRUEBA, de Experimento Gral.";
                    f.FormBorderStyle = FormBorderStyle.Sizable;
                    f.LlenarComponentes(this.txtRutaPrePrueba.Text.Replace("\r\n", "").Replace("\n", "").Replace("\r", ""));
                }
                else {
                    MessageBox.Show("No ha seleccionado el archivo de configuración de la Pre-prueba.", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
            }
            
        }

        private void TxtRutaPrePrueba_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AbrirConfiguraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    frmConfiguracion f = new frmConfiguracion(ocultar);
                    f.Show();
                    var filePath = openFileDialog1.FileName;
                    f.LlenarComponentes(filePath);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e) //btn Inicio Experimento Gral.
        {
            if (!experimento_modificado)
            {
                if (this.txtRutaPrePrueba.TextLength > 0 && this.txtRutaPostPrueba.TextLength > 0
                    && this.txtRutaPrismasPrueba.TextLength > 0 && this.lblOrdenEjecucion.TextLength > 0)
                {
                    //Comparando que no tenga problemas
                    string[] words = this.lblOrdenEjecucion.Text.Split('>');
                    Boolean abrir_ventana = true;

                    foreach (string word in words)
                    {
                        if (word == "Propiocepción")
                        {
                            if (this.txtRutaPropiocepcion.TextLength == 0)
                            {
                                MessageBox.Show("No ha seleccionado las configuraciones para la condición de Propiocepción, verifique.", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                abrir_ventana = false;
                                break;
                            }
                        }
                        else if (word == "Probe")
                        {
                            if (this.txtRutaProbe.TextLength == 0)
                            {
                                MessageBox.Show("No ha seleccionado las configuraciones para la condición de Probe, verifique.", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                abrir_ventana = false;
                                break;
                            }
                        }
                    }

                    if (abrir_ventana)
                    {
                        frmDatosPaciente f = new frmDatosPaciente(openFileDialog.FileName, this.cmbPuertos.Text);
                        f.Text = "Experimento Prismas";
                        f.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar al menos tres tipos de pruebas (pre, prismas y post) para iniciar el experimento, verifique.", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("El Experimento actual ha sido modificado en alguno de sus parámetros, " +
                    "debe guardarlo primero para que los cambios se vean reflejados en la orden de ejecución de las condiciones.", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnIniciarPrismasPrueba_Click(object sender, EventArgs e)
        {
            if (this.txtRutaPrismasPrueba.TextLength > 0)
            {
                this.lblOrdenEjecucion.Text += ">Prismas-prueba";
                experimento_modificado = true;
            }
            else {
                MessageBox.Show("No ha seleccionado el archivo de configuración de la Prueba de Prismas.", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    /*try
    {

        if (this.txtRutaPrismasPrueba.TextLength > 0)
        {
            if (MessageBox.Show("¿Iniciar prueba de Prismas?",  "Prismas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                llamarConfiguraciones(this.txtRutaPrismasPrueba.Text);
                //MessageBox.Show("Inicia Prismas-prueba", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Information);


                if (direccionImagenes.Length > 0)
                {

                    frmPanelExperimento f2 = new frmPanelExperimento(puerto, num_repeticiones, nombre, prueba, xmin, xmax, ymin, ymax, descripcion, delay, direccionImagenes, instrucciones, mensaje_fin_experimento, delay_espera_imagen); //creamos un objeto del formulario 2
                    f2.Show();
                }
                else
                {
                    frmPanelExperimento f2 = new frmPanelExperimento(puerto, num_repeticiones, nombre, prueba, xmin, xmax, ymin, ymax, descripcion, delay, instrucciones, mensaje_fin_experimento); //creamos un objeto del formulario 2
                    f2.Show();
                }
            }

        }
        else
        {
            MessageBox.Show("No ha seleccionado la configuración de la prueba Prismas.", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    catch (SecurityException ex)
    {
        MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
        $"Details:\n\n{ex.StackTrace}");
    }*/
}

        private void BtnIniciarPostPrueba_Click(object sender, EventArgs e)
        {
            if (this.txtRutaPostPrueba.TextLength > 0)
            {
                this.lblOrdenEjecucion.Text += ">Post-prueba";
                experimento_modificado = true;
            }
            else
            {
                MessageBox.Show("No ha seleccionado el archivo de configuración de la Post-Prueba.", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*try
            {

                if (this.txtRutaPostPrueba.TextLength > 0)
                {

                    if (MessageBox.Show("¿Iniciar Post-prueba?", "Prismas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                        llamarConfiguraciones(this.txtRutaPostPrueba.Text);

                        //MessageBox.Show("Inica Post-prueba", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Information);
           

                        if (direccionImagenes.Length > 0)
                        {

                            frmPanelExperimento f2 = new frmPanelExperimento(puerto, num_repeticiones, nombre, prueba, xmin, xmax, ymin, ymax, descripcion, delay, direccionImagenes, instrucciones, mensaje_fin_experimento, delay_espera_imagen); //creamos un objeto del formulario 2
                            f2.Show();
                        }
                        else
                        {
                            frmPanelExperimento f2 = new frmPanelExperimento(puerto, num_repeticiones, nombre, prueba, xmin, xmax, ymin, ymax, descripcion, delay, instrucciones, mensaje_fin_experimento); //creamos un objeto del formulario 2
                            f2.Show();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("No ha seleccionado la configuración de la Post-prueba.", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n{ex.StackTrace}");
            }*/
        }

        private void BtnIniciar_Click_1(object sender, EventArgs e)
        {
            if (this.txtRutaPrePrueba.TextLength > 0)
            {
                this.lblOrdenEjecucion.Text += ">Pre-prueba";
                experimento_modificado = true;
            }
            else {
                MessageBox.Show("No ha seleccionado el archivo de configuración de la Pre-Prueba.", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    /*try
    {


        //if (this.txtRutaPrePrueba.TextLength > 0 && this.txtRutaPostPrueba.TextLength > 0 && this.txtRutaPrismasPrueba.TextLength > 0)
        if (this.txtRutaPrePrueba.TextLength > 0)
        {

            //Hacer cada uno de las pruebas
            //for (int i = 1; i <= 3; i++)
            //{
            //int i = 1;
            // switch (i)
            //{
            //  case 1:
            if (MessageBox.Show("¿Iniciar Pre-prueba?", "Prismas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                llamarConfiguraciones(this.txtRutaPrePrueba.Text);
                //MessageBox.Show("Inicia Pre-prueba", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                /*    break;
                case 2:
                    llamarConfiguraciones(this.txtRutaPostPrueba.Text);
                    MessageBox.Show("Inica Post-prueba", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    llamarConfiguraciones(this.txtRutaPrismasPrueba.Text);
                    MessageBox.Show("Inica Prismas-prueba", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }*/

    /*         if (direccionImagenes.Length > 0)
             {

                 frmPanelExperimento f2 = new frmPanelExperimento(puerto, num_repeticiones, nombre, prueba, xmin, xmax, ymin, ymax, descripcion, delay, direccionImagenes, instrucciones, mensaje_fin_experimento, delay_espera_imagen); //creamos un objeto del formulario 2
                 f2.Show();
             }
             else
             {
                 frmPanelExperimento f2 = new frmPanelExperimento(puerto, num_repeticiones, nombre, prueba, xmin, xmax, ymin, ymax, descripcion, delay, instrucciones, mensaje_fin_experimento); //creamos un objeto del formulario 2
                 f2.Show();
             }
         }
         //}
     }
     else {
         //MessageBox.Show("Debe seleccionar los tres tipos de pruebas para iniciar.", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Error);
         MessageBox.Show("No ha seleccionado la configuración de la Pre-prueba.", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Error);
     }
 }
 catch (SecurityException ex)
 {
     MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
     $"Details:\n\n{ex.StackTrace}");
 }*/

}

        private void TxtRutaPostPrueba_TextChanged(object sender, EventArgs e)
        {

        }

        /*//ya no se usa esta funcion
        public void llamarConfiguraciones(string filePath)
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
                    default:
                        prueba = "PRISMAS_GRAL";
                        break;
                }

                //preprocesamiento de los mensajes
                descripcion = configuraciones[3].Split('|')[1];
              

                //puerto = configuraciones[4].Split('|')[1];
                puerto = this.cmbPuertos.Text;


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
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
               $"Details:\n\n{ex.StackTrace}");
            }

        }*/
    }
}
