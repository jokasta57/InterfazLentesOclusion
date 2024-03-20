using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Linq;
using System.Security;
using System.Collections;

namespace controldeexperimento
{
    public partial class frmPanelExperimento : Form
    {
        List<string> datos = new List<string>();
        List<string> img = new List<string>();
        
        //se crea la variable random
        Random random = new Random();

        //variables a utilizar en todo el formulario
        //int tt, tiempot;

        int x, y; //coordenadas X y Y para el target, y otros elementos 
        int xtouch, ytouch;
        int x1, y1;
        Double distancia; //agregado el 2/oct/2019 para sistema de Recompensa

        //variables nuevas
        string nombre_paciente; //nombre del paciente
        string tipo_prueba; //tipo de tipo_pruebaebas
        int cont; //(numero de repeticiones)
        int numero_repeticiones;

        String num_puerto; //puerto de conexión con los lentes
        string num_repeticiones_inicio; //guardar el numero de repeticiones desde el inicio
        int xmi,xma,ymi,yma; //estas variables se usan para denominar min y max de la posicion del target al pintarlo en la pantalla
      
        int delay;
        int delay_presentar_imagen; //tiempo de espera en presentar la imagen, después de haber dado click
        int delay_target; //tiempo de espera en presentar la imagen, después de haber dado click
        int delay_mostrar_target; //tiempo de espera "ANTES DE" mostrar "target"

        string dir_imagenes; //dirección de las imágenes
        int altura, largo; // de las imágenes

        //variable para crear el fondo de pantalla
        //Image img1, img2, img3, img4, img5, img6;

        //bandera para evitar que al darle click desde el principio, y que espere hasta que se presione "spacebar"
        bool inicio_experimento = false;

        //banderas para iniciar una secuencia de pruebas, pero debe primero terminar una, para continuar con las demás (Exp. Gral.).
        bool es_experimento_gral = false;
        bool iniciar_prueba = false;
        bool es_propiocepcion = false;
        bool no_feedback = false;
        bool es_probe = false;
        String[] Pruebas; // para experimentos gral. (secuencia de pruebas)
        int num_prueba = 1;
        String ruta_archivo_experimento;
        String edad_paciente, sexo_paciente, escolaridad_paciente;

        String Tipo_vision, Es_Diestro, Desorden_neuronal, Crisis_ansiedad,Tipo_medicamentos;


        //sistema de recompensa//agregado el 2 de octubre
        int puntos_recompensa; 
        bool activar_recompensa;

        //tiempo para cada ensayo//agregado el 27 de octubre
        int tiempo_ensayo = 0; 
        bool activar_tiempo_ensayo = false;

        //más configuraciones sobre imágenes: 29 ago 2020
        bool imagen_centrada;
        bool imagenes_aleatorias;
        int index_imagen = 0;
        List<int> listaAleatoria = new List<int>();


        //el usuario podrá visializar este mensaje cuando el experimento termine.
        String mensaje_final;

     
        /// CON imágenes (individual)
        public frmPanelExperimento(string puerto, string num_repeticiones, string nombre, string prueba, string xmin, string xmax, string ymin, string ymax, 
            string descripcion, string retardo, string direc_imagenes, string instrucciones, string mensaje_fin_experimento, 
            string delay_imagen, String delayTarget, String im_alto, String im_largo, String edad, String sexo, String escolaridad, 
            String delayMostrarTarget, String puntosRecompensa, bool activarRecompensa, String tiempoEnsayo, bool activarTiempoEnsayo, 
            bool img_centrada, bool img_aleatoria)
        {
            num_puerto = puerto;
            num_repeticiones_inicio = num_repeticiones;
            cont = Int32.Parse(num_repeticiones);
            nombre_paciente = nombre;
            tipo_prueba = prueba;

            puntos_recompensa = Convert.ToInt32(puntosRecompensa);
            activar_recompensa = activarRecompensa;
            //this.lblRecompensa.Visible = activar_recompensa;

            //Tiempo por cada ensayo (27 de oct de 2019) 
            float aux = 10 * (float.Parse(tiempoEnsayo));
            tiempo_ensayo = Int32.Parse(aux.ToString());

            activar_tiempo_ensayo = activarTiempoEnsayo;


            //Más configuraciones imágenes: 29 ago 2020
            imagen_centrada = img_centrada;
            imagenes_aleatorias = img_aleatoria;


            if (tipo_prueba == "PROBE")
            {
                es_probe = true;
                no_feedback = true;
            }
            else if (tipo_prueba == "PROPIOCEPCIÓN") {
                es_propiocepcion = true;
                no_feedback = true;
            }

            xmi = Int32.Parse(xmin);
            xma = Int32.Parse(xmax);
            ymi = Int32.Parse(ymin);
            yma = Int32.Parse(ymax);
            altura = Int32.Parse(im_alto);
            largo = Int32.Parse(im_largo);

            //preprocesamiento del tiempo de visualización del "feedback"
            aux = 1000 * (float.Parse(retardo));
            delay = Int32.Parse(aux.ToString());

            //tiempo para mostrar las imágenes
            aux = 1000 * (float.Parse(delay_imagen));
            delay_presentar_imagen = Int32.Parse(aux.ToString());
            
            //tiempo para mostrar el "target" (recien agregado)
            aux = 1000 * (float.Parse(delayTarget));
            delay_target = Int32.Parse(aux.ToString());

            //tiempo de retraso antes de mostrar el "target" (recien agregado)
            aux = 1000 * (float.Parse(delayMostrarTarget));
            delay_mostrar_target = Int32.Parse(aux.ToString());

            //tra = new TimeSpan (0,0,0,0,delay); //creo que esto no se usa!

            dir_imagenes = direc_imagenes;
            DateTime inicio = DateTime.Now;
            InitializeComponent();
            
            datos.Add(",,Nombre del sujeto ,"+ nombre_paciente.Replace("\r\n", "").Replace("\n", "").Replace("\r", ""));
            datos.Add(",,Edad ,"+ edad);
            datos.Add(",,Sexo ,"+ sexo);
            datos.Add(",,Escolaridad ,"+ escolaridad);
            datos.Add(",,Hora de inicio ,"+inicio);
            datos.Add(",,Tipo de prueba ," + tipo_prueba);
            datos.Add(",,No. de repeticiones ," + num_repeticiones);
            datos.Add(",,Puntos recompensa ," + puntos_recompensa);
            datos.Add(",,Tiempo ensayo ," + tiempo_ensayo);
            datos.Add(",,Imagenes centradas ," + imagen_centrada); //agregadas 29 ago 2020
            datos.Add(",,Imagenes Aleatorias ," + imagenes_aleatorias); //agregadas 29 ago 2020
            datos.Add(",,Area de prueba ,x min,x max,y min,y max");
            datos.Add(",,," + xmin+","+xmax+","+ymin+","+ymax);
            datos.Add(",,");

            //preprocesamiento de la cadena de texto para evitar errores en CSV
            String descripcion_preprocesada = descripcion.Replace("\r\n", "_"); //no enters
            descripcion_preprocesada = descripcion_preprocesada.Replace(",", "_"); //no comas
            Regex a = new Regex("[á|à|ä|â]", RegexOptions.Compiled); //no acentos
            Regex e = new Regex("[é|è|ë|ê]", RegexOptions.Compiled);
            Regex i = new Regex("[í|ì|ï|î]", RegexOptions.Compiled);
            Regex o = new Regex("[ó|ò|ö|ô]", RegexOptions.Compiled);
            Regex u = new Regex("[ú|ù|ü|û]", RegexOptions.Compiled);
            Regex n = new Regex("[ñ|Ñ]", RegexOptions.Compiled);
            descripcion_preprocesada = a.Replace(descripcion_preprocesada, "a");
            descripcion_preprocesada = e.Replace(descripcion_preprocesada, "e");
            descripcion_preprocesada = i.Replace(descripcion_preprocesada, "i");
            descripcion_preprocesada = o.Replace(descripcion_preprocesada, "o");
            descripcion_preprocesada = u.Replace(descripcion_preprocesada, "u");
            descripcion_preprocesada = n.Replace(descripcion_preprocesada, "n");

            datos.Add("Descripcion,," + descripcion_preprocesada);

            datos.Add(",");
            datos.Add(",");
            datos.Add(",Datos recolectados en prueba");
            datos.Add("Target,,touch,,tiempo presionando el spacebar,tiempo presiono spacebar,tiempo dejo de presionar spacebar,error X,error Y, tiempo del spacebar a la pantalla, tiempo total del ensayo, Puntos recompensa, distancia, lado");
            datos.Add("x,y,x,y");
            this.listBox1.DataSource = this.datos;
            this.lblInstrucciones.Text = instrucciones;
            mensaje_final = mensaje_fin_experimento; //almacenamos el mensaje en la variable para usarlo hasta el final

        }

        //SIN imágenes (individual)
        public frmPanelExperimento(string puerto, string num_repeticiones, string nombre, string prueba, 
            string xmin, string xmax, string ymin, string ymax,
            string descripcion, string restardo, string instrucciones, string mensaje_fin_experimento, 
            String delayTarget, String im_alto, String im_largo, String edad, String sexo, String escolaridad, 
            String delayMostrarTarget, String puntosRecompensa, bool activarRecompensa, String tiempoEnsayo, bool activarTiempoEnsayo)
        {
            num_puerto = puerto;
            num_repeticiones_inicio = num_repeticiones;
            cont = Int32.Parse(num_repeticiones);
            nombre_paciente = nombre;
            tipo_prueba = prueba;

            puntos_recompensa = Convert.ToInt32(puntosRecompensa);
            activar_recompensa = activarRecompensa;
            //this.lblRecompensVisible = activar_recompensa;

            //Tiempo por cada ensayo (27 de oct de 2019)
            
            float aux = 10 * (float.Parse(tiempoEnsayo));
            tiempo_ensayo = Int32.Parse(aux.ToString());
            

            activar_tiempo_ensayo = activarTiempoEnsayo;


            if (tipo_prueba == "PROBE")
            {
                es_probe = true;
                no_feedback = true;
            }
            else if (tipo_prueba == "PROPIOCEPCIÓN")
            {
                es_propiocepcion = true; //comportamiento similar, por eso se recicla la bandera
                no_feedback = true;
            }

            xmi = Int32.Parse(xmin);
            xma = Int32.Parse(xmax);
            ymi = Int32.Parse(ymin);
            yma = Int32.Parse(ymax);

            //preprocesamiento del tiempo de visualización del "feedback"
            aux = 1000 * float.Parse(restardo);
            delay = Int32.Parse(aux.ToString());

            //tiempo para mostrar el "target" (recien agregado)
            aux = 1000 * (float.Parse(delayTarget));
            delay_target = Int32.Parse(aux.ToString());

            //tiempo de retraso antes de mostrar el "target" (recien agregado)
            aux = 1000 * (float.Parse(delayMostrarTarget));
            delay_mostrar_target = Int32.Parse(aux.ToString());

            //tra = new TimeSpan(0, 0, 0, 0, delay);//creo que esto no se usa!

            dir_imagenes = "";
            DateTime inicio = DateTime.Now;
            InitializeComponent();

            datos.Add(",,Nombre del sujeto ," + nombre_paciente.Replace("\r\n", "").Replace("\n", "").Replace("\r", ""));
            datos.Add(",,Edad ," + edad);
            datos.Add(",,Sexo ," + sexo);
            datos.Add(",,Escolaridad ," + escolaridad);
            datos.Add(",,Hora de inicio ," + inicio);
            datos.Add(",,Tipo de prueba ," + tipo_prueba);
            datos.Add(",,No. de repeticiones ," + num_repeticiones);
            datos.Add(",,Puntos recompensa ," + puntos_recompensa);
            datos.Add(",,Tiempo ensayo ," + tiempo_ensayo);
            datos.Add(",,Imagenes centradas ," + imagen_centrada); //agregadas 29 ago 2020
            datos.Add(",,Imagenes Aleatorias ," + imagenes_aleatorias); //agregadas 29 ago 2020
            datos.Add(",,Area de prueba ,x min,x max,y min,y max");
            datos.Add(",,," + xmin + "," + xmax + "," + ymin + "," + ymax);
            datos.Add(",,");

            //preprocesamiento de la cadena de texto para evitar errores en CSV
            String descripcion_preprocesada = descripcion.Replace("\r\n", "_"); //no enters
            descripcion_preprocesada = descripcion_preprocesada.Replace(",", "_"); //no comas
            Regex a = new Regex("[á|à|ä|â]", RegexOptions.Compiled); //no acentos
            Regex e = new Regex("[é|è|ë|ê]", RegexOptions.Compiled);
            Regex i = new Regex("[í|ì|ï|î]", RegexOptions.Compiled);
            Regex o = new Regex("[ó|ò|ö|ô]", RegexOptions.Compiled);
            Regex u = new Regex("[ú|ù|ü|û]", RegexOptions.Compiled);
            Regex n = new Regex("[ñ|Ñ]", RegexOptions.Compiled);
            descripcion_preprocesada = a.Replace(descripcion_preprocesada, "a");
            descripcion_preprocesada = e.Replace(descripcion_preprocesada, "e");
            descripcion_preprocesada = i.Replace(descripcion_preprocesada, "i");
            descripcion_preprocesada = o.Replace(descripcion_preprocesada, "o");
            descripcion_preprocesada = u.Replace(descripcion_preprocesada, "u");
            descripcion_preprocesada = n.Replace(descripcion_preprocesada, "n");

            datos.Add("Descripcion,," + descripcion_preprocesada);

            datos.Add(",");
            datos.Add(",");
            datos.Add(",Datos recolectados en prueba");
            datos.Add("Target,,touch,,tiempo presionando el spacebar,tiempo presiono spacebar,tiempo dejo de presionar spacebar,error X,error Y, tiempo del spacebar a la pantalla, tiempo total del ensayo, Puntos recompensa, distancia, lado");
            datos.Add("x,y,x,y");

            this.listBox1.DataSource = this.datos;
            this.lblInstrucciones.Text = instrucciones;
            mensaje_final = mensaje_fin_experimento; //almacenamos el mensaje en la variable para usarlo hasta el final; si está vacío no aparece nada al final
        }


        //Método sobrecargado para EXPERIMENTOS GRALES. (agregado el 4/sep/2019) 
        public frmPanelExperimento(String dir_experimento_gral, String nombre_paciente_exp_gral, String descripcion_exp_gral,
                                    String edad, String sexo, String escolaridad, String puerto_conexion, 
                                    String TipoDeVision, String Diestro, String DesordenNeuronal, String CrisisAnsiedad, String TipoMedicamentos) {


            //cargar archivo y llenar todas las variables
            try
            {
                num_puerto = puerto_conexion; //el puerto de conexión debe viajar como un String, para que lo reconozca el experimento
                InitializeComponent(); //<-------

                //almacenando estos valores grales.
                ruta_archivo_experimento = dir_experimento_gral;

                es_experimento_gral = true;

                String archivo = "";
                using (StreamReader sr = new StreamReader(ruta_archivo_experimento))
                {
                    archivo = sr.ReadToEnd();
                }

                //En el ejemplo convertimos el string a un string[], es decir, de una cadena de caracteres a un array de cadenas de caracteres, luego convertimos el texto del string[] a List usando como cambio de elemento del List el carácter \n que representa "Nueva línea".
                List<string> configuraciones = archivo.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();

                //obteniendo el orden de ejecución
                String OrdenEjecucion = configuraciones[4].Split('|')[1];
                
                Char[] splitchar = { '>' };
                Pruebas = OrdenEjecucion.Split(splitchar);

                //la inicializo cuando es exp. gral. para detener la secuencia
                iniciar_prueba = true;

                for (int i = num_prueba; i <= Pruebas.Length - 1; i++)
                {
                    if (iniciar_prueba == true)
                    {
                        //recorriendo cada una de las pruebas.
                        switch (Pruebas[i])
                        {
                            case "Propiocepción":
                                es_probe = false;
                                es_propiocepcion = true;
                                iniciar_prueba = false;
                                no_feedback = true;
                                LlenarComponentes(configuraciones[0].Split('|')[1], nombre_paciente_exp_gral, descripcion_exp_gral, edad, sexo, escolaridad, TipoDeVision,Diestro, DesordenNeuronal,CrisisAnsiedad, TipoMedicamentos);
                                break;
                            case "Pre-prueba":
                                es_probe = false;
                                es_propiocepcion = false;
                                iniciar_prueba = false;
                                no_feedback = false;
                                LlenarComponentes(configuraciones[1].Split('|')[1], nombre_paciente_exp_gral, descripcion_exp_gral, edad, sexo, escolaridad, TipoDeVision, Diestro, DesordenNeuronal, CrisisAnsiedad, TipoMedicamentos);
                                break;
                            case "Prismas-prueba":
                                es_probe = false;
                                es_propiocepcion = false;
                                iniciar_prueba = false;
                                no_feedback = false;
                                LlenarComponentes(configuraciones[2].Split('|')[1], nombre_paciente_exp_gral, descripcion_exp_gral, edad, sexo, escolaridad, TipoDeVision, Diestro, DesordenNeuronal, CrisisAnsiedad, TipoMedicamentos);
                                break;
                            case "Post-prueba":
                                es_probe = false;
                                es_propiocepcion = false;
                                iniciar_prueba = false;
                                no_feedback = false;
                                LlenarComponentes(configuraciones[3].Split('|')[1], nombre_paciente_exp_gral, descripcion_exp_gral, edad, sexo, escolaridad, TipoDeVision, Diestro, DesordenNeuronal, CrisisAnsiedad, TipoMedicamentos);
                                break;
                            case "Probe":
                                es_probe = true;
                                es_propiocepcion = false;
                                iniciar_prueba = false;
                                no_feedback = true;
                                LlenarComponentes(configuraciones[5].Split('|')[1], nombre_paciente_exp_gral, descripcion_exp_gral, edad, sexo, escolaridad, TipoDeVision, Diestro, DesordenNeuronal, CrisisAnsiedad, TipoMedicamentos);
                                break;
                        }
                    }

                    // hasta que haya hecho todas las pruebas se debe cerrar
                    /*if (i == Pruebas.Length) {

                        this.Close();
                    }*/

                }
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
            }
        }

        //Método para llenar variables, de las rutas c/configuración de las pruebas (exp. generales)
        public void LlenarComponentes(string filePath, String nombre_paciente_exp_gral, String descripcion_exp_gral, 
                                        String edad, String sexo, String escolaridad, 
                                        String TipoDeVision, String Diestro, String DesordenNeuronal, String CrisisAnsiedad, String TipoMedicamentos)
        {
            try
            {

                //MessageBox.Show("Cambio de prueba");

                //if (iniciar_condicion)
                //{

                    String aux = "";
                    if (filePath.Length > 2)
                    {
                        using (StreamReader sr = new StreamReader(filePath.Replace("\r\n", "").Replace("\n", "").Replace("\r", "")))
                        {
                            aux = sr.ReadToEnd();
                        }
                    
                        //En el ejemplo convertimos el string a un string[], es decir, de una cadena de caracteres a un array de cadenas de caracteres, luego convertimos el texto del string[] a List usando como cambio de elemento del List el carácter \n que representa "Nueva línea".
                        List<string> configuraciones = aux.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();

                        nombre_paciente = nombre_paciente_exp_gral; // pendiente, porque es de cada uno
                        edad_paciente = edad;
                        sexo_paciente = sexo;
                        escolaridad_paciente = escolaridad;

                        //agregados 14 de nov 2019
                        Tipo_vision = TipoDeVision;
                        Es_Diestro = Diestro;
                        Desorden_neuronal = DesordenNeuronal;
                        Crisis_ansiedad = CrisisAnsiedad;
                        Tipo_medicamentos = TipoMedicamentos;

                        cont = Int32.Parse(configuraciones[1].Split('|')[1]); //número de repeticiones
                        num_repeticiones_inicio = configuraciones[1].Split('|')[1]; //numero total de ejecuciones de la prueba

                        switch (configuraciones[2].Split('|')[1])
                        {
                            case "1":
                                tipo_prueba = "PRE_PRUEBA";
                                break;
                            case "0":
                                tipo_prueba = "POST_PRUEBA";
                                break;
                            case "2":
                                tipo_prueba = "PRUEBA_PRISMAS";
                                break;
                            case "3":
                                tipo_prueba = "PROPIOCEPCION";
                                break;
                            case "4":
                                tipo_prueba = "PROBE";
                                break;
                        }


                        //num_puerto = configuraciones[4].Split('|')[1]; //el numero de puerto es de tipo String
                        xmi = Int32.Parse(configuraciones[5].Split('|')[1]);
                        xma = Int32.Parse(configuraciones[6].Split('|')[1]);
                        ymi = Int32.Parse(configuraciones[7].Split('|')[1]);
                        yma = Int32.Parse(configuraciones[8].Split('|')[1]);

                        //preprocesamiento de los mensajes
                        if (configuraciones[9].Length > 0 && configuraciones[10].Length > 0)
                        {
                            //String borrarme = configuraciones[9].Split('|')[1].Replace("_", "\r\n");
                            this.lblInstrucciones.Text = configuraciones[9].Split('|')[1].Replace("_", "\r\n");
                            mensaje_final = configuraciones[10].Split('|')[1].Replace("_", "\r\n");
                        }

                        //////////////////////Imágenes////////////////////////////////////////
                        dir_imagenes = configuraciones[12].Split('|')[1].Replace("\r\n", "").Replace("\n", "").Replace("\r", "");

                        if (dir_imagenes.Length > 0)
                        {
                            try
                            {
                                DirectoryInfo d = new DirectoryInfo(dir_imagenes);//Assuming Test is your Folder
                                FileInfo[] Files = d.GetFiles("*.jpg"); //Getting Text files
                                                                        //string str = "";
                                foreach (FileInfo file in Files)
                                {
                                    //str = str + ", " + file.Name;
                                    img.Add(dir_imagenes + @"\" + file.Name);
                                }

                                this.listaImagenes.DataSource = this.img;

                            }
                            catch
                            {
                                MessageBox.Show("No se encontraron imágenes.", "Error en imágenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                            }
                        }
                        ////////////////////////////////////////////////////////////////////////////////////////

                        //preprocesamiento del tiempo de visualización del "feedback" (punto amarillo)
                        float tiempo_aux = 1000 * (float.Parse(configuraciones[13].Split('|')[1]));
                        delay = Int32.Parse(tiempo_aux.ToString());

                        //tiempo para mostrar las imágenes 
                        tiempo_aux = 1000 * (float.Parse(configuraciones[14].Split('|')[1]));
                        delay_presentar_imagen = Int32.Parse(tiempo_aux.ToString());

                        //preprocesamiento del tiempo de visualización del "target"
                        tiempo_aux = 1000 * (float.Parse(configuraciones[15].Split('|')[1]));
                        delay_target = Int32.Parse(tiempo_aux.ToString());

                        //preprocesamiento para el tiempo "antes" de mostrar el "Target" 
                        tiempo_aux = 1000 * (float.Parse(configuraciones[18].Split('|')[1]));
                        delay_mostrar_target = Int32.Parse(tiempo_aux.ToString());

                        //imágenes
                        altura = Int32.Parse(configuraciones[16].Split('|')[1]);
                        largo = Int32.Parse(configuraciones[17].Split('|')[1]);

                        //Sistema de recompensas 2/oct/2019
                        if (configuraciones[19].Split('|')[1].Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Equals("Checked"))
                        {
                            puntos_recompensa = puntos_recompensa + Int32.Parse(configuraciones[20].Split('|')[1]);
                            this.lblRecompensa.Text = (puntos_recompensa).ToString();
                            this.lblRecompensa.Visible = true;
                            activar_recompensa = true;

                        }
                        else
                        {
                            this.lblRecompensa.Visible = false;
                            activar_recompensa = false;
                        }

                        //Tiempo por cada ensayo (27 de oct de 2019) 
                        if (configuraciones[21].Split('|')[1].Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Equals("Checked"))
                        {
                            tiempo_aux = 10 * (float.Parse(configuraciones[22].Split('|')[1]));
                            tiempo_ensayo = Int32.Parse(tiempo_aux.ToString());

                            activar_tiempo_ensayo = true;

                        }
                        else
                        {

                            activar_tiempo_ensayo = false;
                            timer.Stop();
                            tiempo_ensayo = 0;

                        }


                        //Imágenes centradas: 8 sep 2020 
                        if (configuraciones[23].Split('|')[1].Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Equals("Checked"))
                        {

                            imagen_centrada = true;

                        }
                        else
                        {
                            imagen_centrada = false;
                        }

                        //imágenes aleatorias: 8 sep 2020
                        if (configuraciones[24].Split('|')[1].Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Equals("Checked"))
                        {

                            imagenes_aleatorias = true;

                        }
                        else
                        {

                            imagenes_aleatorias = false;
                        }

                        // es necesario reiniciar el contador, para que en cada prueba se reinicien las imágenes
                        index_imagen = 0;


                    //Guardando en el CSV

                    DateTime inicio = DateTime.Now;

                        datos.Add(",");
                        datos.Add(",");
                        datos.Add(",");
                        datos.Add(",,Nombre del sujeto ," + nombre_paciente);
                        datos.Add(",,Edad ," + edad);
                        datos.Add(",,Sexo ," + sexo);
                        datos.Add(",,Escolaridad ," + escolaridad);
                        datos.Add(",,Tipo de Vision ," + TipoDeVision);
                        datos.Add(",,Diestro ," + Es_Diestro);
                        datos.Add(",,Desorden Neuronal ," + Desorden_neuronal);
                        datos.Add(",,Crisis Ansiedad ," + Crisis_ansiedad);
                        datos.Add(",,Medicamentos ," + Tipo_medicamentos);
                        datos.Add(",,Hora de inicio ," + inicio);
                        datos.Add(",,Tipo de prueba ," + tipo_prueba);
                        datos.Add(",,No. de repeticiones ," + cont);
                        datos.Add(",,Puntos recompensa ," + puntos_recompensa);
                        datos.Add(",,Tiempo ensayo ," + tiempo_ensayo);
                        datos.Add(",,Imagenes centradas ," + imagen_centrada); //agregadas 29 ago 2020
                        datos.Add(",,Imagenes Aleatorias ," + imagenes_aleatorias); //agregadas 29 ago 2020
                        datos.Add(",,Area de prueba ,x min,x max,y min,y max");
                        datos.Add(",,," + xmi + "," + xma + "," + ymi + "," + yma);
                        datos.Add(",,");

                        //preprocesamiento de la cadena de texto para evitar errores en CSV
                        String descripcion_preprocesada = descripcion_exp_gral.Replace("\r\n", "_"); //no enters
                        descripcion_preprocesada = descripcion_preprocesada.Replace(",", "_"); //no comas
                        Regex a = new Regex("[á|à|ä|â]", RegexOptions.Compiled); //no acentos
                        Regex e = new Regex("[é|è|ë|ê]", RegexOptions.Compiled);
                        Regex i = new Regex("[í|ì|ï|î]", RegexOptions.Compiled);
                        Regex o = new Regex("[ó|ò|ö|ô]", RegexOptions.Compiled);
                        Regex u = new Regex("[ú|ù|ü|û]", RegexOptions.Compiled);
                        Regex n = new Regex("[ñ|Ñ]", RegexOptions.Compiled);
                        descripcion_preprocesada = a.Replace(descripcion_preprocesada, "a");
                        descripcion_preprocesada = e.Replace(descripcion_preprocesada, "e");
                        descripcion_preprocesada = i.Replace(descripcion_preprocesada, "i");
                        descripcion_preprocesada = o.Replace(descripcion_preprocesada, "o");
                        descripcion_preprocesada = u.Replace(descripcion_preprocesada, "u");
                        descripcion_preprocesada = n.Replace(descripcion_preprocesada, "n");

                        datos.Add("Descripcion,," + descripcion_preprocesada);

                        datos.Add(",,");
                        datos.Add(",,");
                        datos.Add(",Datos recolectados en prueba");
                        datos.Add("Target,,touch,,tiempo presionando el spacebar,tiempo presiono spacebar,tiempo dejo de presionar spacebar,error X,error Y, tiempo del spacebar a la pantalla, tiempo total del ensayo, Puntos recompensa, distancia, lado");
                        datos.Add("x,y,x,y");
                        this.listBox1.DataSource = this.datos;
                    
                }
                else
                {

                    MessageBox.Show("Parece que hay Pruebas/Condiciones que se encuentran en el experimento, pero no cuentan con la ruta al archivo de configuración,verifique.", "Error en imágenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();

                }


            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
            }

        }


        ///----------------------------------------------------------------------------------------------------------------------------------
        /// 
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = num_puerto;
                serialPort1.BaudRate = 9600;
                serialPort1.DataBits = 8;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Handshake = Handshake.None;
                serialPort1.Encoding = System.Text.Encoding.Default;
                serialPort1.ReadTimeout = 500;
                serialPort1.WriteTimeout = 500;
                this.serialPort1.Open();
                this.serialPort1.WriteLine("0"); //abriendo los lentes, para que pueda ver los mensajes
                numero_repeticiones = cont; // es necesario guardar el numero de repeticiones totales, ya que la variable "cont" va decreciendo

                this.lblRecompensa.Text = puntos_recompensa.ToString();
                this.lblRecompensa.Visible = activar_recompensa;
            }
            catch {

                MessageBox.Show("No se detecta un puerto de conexión", "Error de puertos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            try
            {
                DirectoryInfo d = new DirectoryInfo(dir_imagenes);//Assuming Test is your Folder
                FileInfo[] Files = d.GetFiles("*.jpg"); //Getting Text files
                                                        //string str = "";
                foreach (FileInfo file in Files)
                {
                    //str = str + ", " + file.Name;
                    img.Add(dir_imagenes + @"\" + file.Name);
                }
                this.listaImagenes.DataSource = this.img;


                //if (imagenes_aleatorias)//agregado el 29 de ago 2020
                //{
                    for (int k = 1; k <= listaImagenes.Items.Count; k++)
                    {
                        while (true)
                        {
                            Random rnd = new Random();

                            int valor = rnd.Next(0, listaImagenes.Items.Count);

                            if (!listaAleatoria.Contains(valor))
                            {

                                listaAleatoria.Add(valor);

                                break; //aqui se sale del while

                            }

                        }

                    }

                //}//fin imágenes aleatorias

            }
            catch
            {
                //MessageBox.Show("No se encontraron imágenes.", "Error en imágenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //this.Close();
            }
        }

        //Método para dibujar en donde dio click el usuario
        Graphics g;
        Pen lapiz; //, cuadro_target, punto_inicio; //estos ya no se usan, pero aquí se declararon!
        bool dio_click = false;

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (inicio_experimento == true && se_mostro_target) //bandera para evitar que se de click a la pantalla, desde antes que empiece el experimento
            {
                
                // si da click, se reinicia el reloj (26 de octubre)
                if (activar_tiempo_ensayo)
                {
                    dio_click = true;
                    timer.Stop();
                    this.lblTiempo.Text = "0";
                }


                tiempo_click_feedback = DateTime.Now; //tiempo en el que dio click

                tiempo_click_menos_spacebarUp = tiempo_spacebar_up - tiempo_click_feedback; //tiempo del spacebar hasta que dio click

                tiempo_total_ensayo = tiempo_spacebar_down - tiempo_click_feedback; //de presionar el spacebar a dar click

                //los lentes se quedan cerrados si es Probe, no se muestra feedback, solo hasta que presione la spacebar
                if (!es_probe)
                {
                    this.serialPort1.WriteLine("0"); //abrir los lentes
                }

                //Feedback - amarillo; cuando es la prueba "Probe" no se va a dar feedback; en "Propiocepcion" sí
                if (cont >= 0 && !no_feedback)
                {
                    g = this.CreateGraphics();

                    //para que dibuje en donde dió click el usuario
                    lapiz = new Pen(Color.Yellow, 20);

                    g.DrawRectangle(lapiz, new Rectangle(e.X, e.Y, 3, 3));

                }

                // bandera para evitar que de click, antes de presionar el "spacebar"
                this.inicio_experimento = false;

                //funcion para registrar el click del usuario
                if (touch(e) == 0 && !es_probe)
                {
                    // Retardo para que todo desaparezca el click del fusuario "feedback"
                    Thread.Sleep(delay);

                    // mostrar las IAPS, sobre donde dio click el usuario, si es que tiene una ruta
                    if (dir_imagenes.Length > 0)
                    {//mostrar imagen, ahora es posible pasarle como parámetros el tamaño de la imagen

                        if (imagenes_aleatorias) //agregado el 29 ago 2020
                        {
                            /*if (imagen_centrada)
                                g.DrawImage(randomforimage(),  500, 200, altura, largo);
                            else
                                g.DrawImage(randomforimage(), xtouch - 150, ytouch - 150, altura, largo);*/

                            if (index_imagen >= listaImagenes.Items.Count) //validación cuando son menos las imágenes que los ensayos
                            {
                                index_imagen = 0;
                            }

                            if (imagen_centrada)
                            {
                               
                                Image imagen = new Bitmap(listaImagenes.Items[listaAleatoria[index_imagen]].ToString());
                                g.DrawImage(imagen, 500, 200, altura, largo);
         
                            }
                            else // controlando que la imagen no salgo del margen, para que pueda ser visualizado correctamente. 9-9-20
                            {

                                if (ytouch < 70)
                                {
                                    if (xtouch > 1000)
                                    {
                                        Image imagen = new Bitmap(listaImagenes.Items[listaAleatoria[index_imagen]].ToString());
                                        g.DrawImage(imagen, xtouch - largo, ytouch, altura, largo);

                                    }
                                    else
                                    {
                                        Image imagen = new Bitmap(listaImagenes.Items[listaAleatoria[index_imagen]].ToString());
                                        g.DrawImage(imagen, xtouch, ytouch, altura, largo);
                                    }
                                }
                                else if (ytouch > 400)
                                {

                                    if (xtouch > 1000) 
                                    {
                                        Image imagen = new Bitmap(listaImagenes.Items[listaAleatoria[index_imagen]].ToString());
                                        g.DrawImage(imagen, xtouch - largo, ytouch - altura, altura, largo);

                                    }
                                    else
                                    {
                                        Image imagen = new Bitmap(listaImagenes.Items[listaAleatoria[index_imagen]].ToString());
                                        g.DrawImage(imagen, xtouch, ytouch - altura, altura, largo);
                                    }

                                }
                                else { //para cualquier otra parte de la pantalla que no sea el centro.

                                    if (xtouch > 1000)
                                    {
                                        Image imagen = new Bitmap(listaImagenes.Items[listaAleatoria[index_imagen]].ToString());
                                        g.DrawImage(imagen, xtouch - largo, ytouch, altura, largo);

                                    }
                                    else
                                    {
                                        Image imagen = new Bitmap(listaImagenes.Items[listaAleatoria[index_imagen]].ToString());
                                        g.DrawImage(imagen, xtouch, ytouch, altura, largo);
                                    }

                                }
                            }

                        }
                        else { //imágenes seriadas

                            if (index_imagen >= listaImagenes.Items.Count) //validación cuando son menos las imágenes que los ensayos
                            {
                                index_imagen = 0;
                            }

                            if (imagen_centrada) {

                                Image imagen = new Bitmap(listaImagenes.Items[index_imagen].ToString());
                                g.DrawImage(imagen, 500, 200, altura, largo);
                               

                            }
                            else  // controlando que la imagen no salgo del margen, para que pueda ser visualizado correctamente. 9-9-20
                            {
                                if (ytouch < 70)
                                {
                                    if (xtouch > 1000)
                                    {
                                        Image imagen = new Bitmap(listaImagenes.Items[index_imagen].ToString());
                                        g.DrawImage(imagen, xtouch - largo, ytouch, altura, largo);

                                    }
                                    else
                                    {
                                        Image imagen = new Bitmap(listaImagenes.Items[index_imagen].ToString());
                                        g.DrawImage(imagen, xtouch, ytouch, altura, largo);
                                    }
                                }
                                else if (ytouch > 400)
                                {

                                    if (xtouch > 1000)
                                    {
                                        Image imagen = new Bitmap(listaImagenes.Items[index_imagen].ToString());
                                        g.DrawImage(imagen, xtouch - largo, ytouch - altura, altura, largo);

                                    }
                                    else
                                    {
                                        Image imagen = new Bitmap(listaImagenes.Items[index_imagen].ToString());
                                        g.DrawImage(imagen, xtouch, ytouch - altura, altura, largo);
                                    }

                                }
                                else
                                { //para cualquier otra parte de la pantalla que no sea el centro.

                                    if (xtouch > 1000)
                                    {
                                        Image imagen = new Bitmap(listaImagenes.Items[index_imagen].ToString());
                                        g.DrawImage(imagen, xtouch - largo, ytouch, altura, largo);

                                    }
                                    else
                                    {
                                        Image imagen = new Bitmap(listaImagenes.Items[index_imagen].ToString());
                                        g.DrawImage(imagen, xtouch, ytouch, altura, largo);
                                    }

                                }

                            }
                        }

                        //tiempo de visualización de la imagen
                        Thread.Sleep(delay_presentar_imagen);

                        index_imagen++;
                    }
                }

                g.Clear(Color.DimGray); //se limpia la pantalla y se convierte de color gris

                //ocultando el punto
                this.btnTarget.Visible = false;


                //Mostrando un INIDICADOR al inicio de cada Ensayo, y lo borro después de 1 segundo 
                this.serialPort1.WriteLine("0"); //abrir los lentes (15 nov 19)

                try
                {
                    //imagen de la barra espaciadora, para iniciar experimento!! (27-11-19)
                    // Create image.
                    Image newImage = Image.FromFile("barra_espaciadora.png");

                    // Create coordinates for upper-left corner of image.
                    float x_image_spacebar = 550.0F;
                    float y_image_spacebar = 300.0F;

                    // Create rectangle for source image.
                    RectangleF srcRect = new RectangleF(10.0F, 10.0F, 350.0F, 150.0F);
                    GraphicsUnit units = GraphicsUnit.Pixel;

                    // Draw image to screen.
                    g.DrawImage(newImage, x_image_spacebar, y_image_spacebar, srcRect, units);

                    Thread.Sleep(300);
                    g.Clear(Color.DimGray); //se limpia la pantalla y se convierte de color gris */

                }
                catch {//si no encuentra la imagen, entonces voy dibujar un spacebar!

                    
                    /*punto_inicio = new Pen(Color.White, 20);
                    g.DrawEllipse(punto_inicio, 650, 350, 3, 3); //X = 750 y Y = 350*/

                    g = this.CreateGraphics();
                    Pen pen = new Pen(Color.White, 10);

                    // una raya
                    Point[] points =
                             {
                                 new Point(500, 350),
                                 new Point(500, 300)
                             };

                    // otra raya
                    Point[] points2 =
                             {
                                 new Point(750, 350),
                                 new Point(750, 300)
                             };

                    // otra raya vertical
                    Point[] points3 =
                             {
                                 new Point(500, 300),
                                 new Point(750, 300)
                             };

                    // otra raya vertical
                    Point[] points4 =
                             {
                                 new Point(500, 350),
                                 new Point(750, 350)
                             };

                    //Draw lines to screen.
                    g.DrawLines(pen, points);
                    g.DrawLines(pen, points2);
                    g.DrawLines(pen, points3);
                    g.DrawLines(pen, points4);

                    // Leyenda de spacebar
                    System.Drawing.Graphics formGraphics = this.CreateGraphics();
                    string drawString = "Spacebar";
                    System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 16);
                    System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                    float x = 570.0F;
                    float y = 310.0F;
                    System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
                    formGraphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
                    drawFont.Dispose();
                    drawBrush.Dispose();
                    formGraphics.Dispose();

                    Thread.Sleep(300);
                    g.Clear(Color.DimGray); //se limpia la pantalla y se convierte de color gris
                }

                this.serialPort1.WriteLine("1"); //cierro los lentes (15 nov 19)

               

                // solo se van a mostrar las instrucciones al principio del experimento 
                if (cont == Int32.Parse(num_repeticiones_inicio)) {
                        this.lblInstrucciones.Visible = true;
                }
                
                spacebar_presionado = false;
                

            }

            //cont = num de repeticiones
            // el "cont" no se pone en 0's hasta que hace la última prueba en exp. grales. y en pruebas individuales.
            if (cont == 0)
            {
                if (es_experimento_gral && this.iniciar_condicion)
                {
                    this.iniciar_condicion = false;
                    guardarCSV();
                }
                else if (!es_experimento_gral)
                {

                    guardarCSV();
                }
            }

            //dio_click = false;
            se_mostro_target = false;

        }

        //método sobrecargado, para cuando se activa el "Tiempo por ensayo"
        bool centrar_imagen_por_no_dar_clic = false;
        private void Form2_MouseDown()
        {
            if (!dio_click)
            {

                //dio_click = false;
                if (inicio_experimento == true && se_mostro_target) //bandera para evitar que se de click a la pantalla, desde antes que empiece el experimento
                {
                    tiempo_click_feedback = DateTime.Now; //tiempo en el que dio click

                    tiempo_click_menos_spacebarUp = tiempo_spacebar_up - tiempo_click_feedback; //tiempo del spacebar hasta que dio click

                    tiempo_total_ensayo = tiempo_spacebar_down - tiempo_click_feedback; //de presionar el spacebar a dar click

                    //los lentes se quedan cerrados si es Probe, no se muestra feedback, solo hasta que presione la spacebar; método Touch() resta 1 a "cont"
                    if (touch() == 0 && !es_probe)
                    {
                        this.serialPort1.WriteLine("0"); //abrir los lentes
                    }
                    
                    // bandera para evitar que de click, antes de presionar el "spacebar"
                    this.inicio_experimento = false;

                    //para que el usuario vea su error, y luego se van a cerrar, cuando aparezca el círculo de inicio
                    this.serialPort1.WriteLine("0"); //abrir los lentes (15 nov 19) --C O R R E C T O--

                    //if (cont >= 0 && !no_feedback)
                    if (cont >= 0)
                    {
                        
                        // Mensaje cuando se agota el "tiempo de respuesta"
                        System.Drawing.Graphics formGraphics = this.CreateGraphics();
                        string drawString = "¡ MUY LENTO !";
                        System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 16);
                        System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                        float x = 570.0F;
                        float y = 250.0F;
                        System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
                        formGraphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
                        drawFont.Dispose();
                        drawBrush.Dispose();
                        formGraphics.Dispose();


                        // 30-ago- 2020: Cuando el sujeto no le da click, y aparece el mensaje de "muy lento", si tiene imagen va al centro

                        if (!imagen_centrada) {
                            centrar_imagen_por_no_dar_clic = true;
                        }


                        //Feedback rojo, cuando no dio click; cuando es la prueba "Probe" no se va a dar feedback; en "Propiocepcion" sí
                        //dibuja unas lineas rojas, porque ¡NO dio click! 
                        /*g = this.CreateGraphics();
                        Pen pen = new Pen(Color.Red, 10);

                        // una raya
                        Point[] points =
                                 {
                                 new Point(650, 350),
                                 new Point(600, 300)
                             };

                        // otra raya
                        Point[] points2 =
                                 {
                                 new Point(600, 350),
                                 new Point(650, 300)
                             };

                        //Draw lines to screen.
                        g.DrawLines(pen, points);
                        g.DrawLines(pen, points2);*/

                    }

                    //imagenes IAPS
                    if (!es_probe)//funcion para registrar el click del usuario
                    {
                        // Retardo para que todo desaparezca el click del usuario "feedback" de "no  dio click"
                        Thread.Sleep(delay);

                        // mostrar las IAPS, sobre donde dio click el usuario
                        if (dir_imagenes.Length > 0)
                        {
                            //mostrar imagen, ahora es posible pasarle como parámetros el tamaño de la imagen
                            //g.DrawImage(randomforimage(), 500, 200, altura, largo);

                            //tiempo de visualización de la imagen
                            //Thread.Sleep(delay_presentar_imagen);

                            if (imagenes_aleatorias) //agregado el 29 ago 2020
                            {
                                

                                if (index_imagen >= listaImagenes.Items.Count) //validación cuando son menos las imágenes que los ensayos
                                {
                                    index_imagen = 0;
                                }

                                if (imagen_centrada)
                                {

                                    Image imagen = new Bitmap(listaImagenes.Items[listaAleatoria[index_imagen]].ToString());
                                    g.DrawImage(imagen, 500, 200, altura, largo);

                                }
                                else
                                {
                                    if (centrar_imagen_por_no_dar_clic)
                                    {
                                        Image imagen = new Bitmap(listaImagenes.Items[listaAleatoria[index_imagen]].ToString());
                                        g.DrawImage(imagen, 500, 200, altura, largo);
                                        centrar_imagen_por_no_dar_clic = false;
                                    }
                                    else {

                                        Image imagen = new Bitmap(listaImagenes.Items[listaAleatoria[index_imagen]].ToString());
                                        g.DrawImage(imagen, xtouch - 150, ytouch - 150, altura, largo);
                                        
                                    }
                                    
                                }


                            }
                            else //imagenes presentadas de forma seriada!
                            {
                                if (index_imagen >= listaImagenes.Items.Count) //validación cuando son menos las imágenes que los ensayos
                                {
                                    index_imagen = 0;
                                }

                                if (imagen_centrada)
                                {

                                    Image imagen = new Bitmap(listaImagenes.Items[index_imagen].ToString());
                                    g.DrawImage(imagen, 500, 200, altura, largo);
                                    

                                }
                                else
                                {
                                    if (centrar_imagen_por_no_dar_clic)
                                    {
                                        Image imagen = new Bitmap(listaImagenes.Items[index_imagen].ToString());
                                        g.DrawImage(imagen, 500, 200, altura, largo);
                                        centrar_imagen_por_no_dar_clic = false;
                                    }
                                    else
                                    {

                                        Image imagen = new Bitmap(listaImagenes.Items[index_imagen].ToString());
                                        g.DrawImage(imagen, xtouch - 150, ytouch - 150, altura, largo);

                                    }

                                }

                                
                            }

                            //tiempo de visualización de la imagen
                            Thread.Sleep(delay_presentar_imagen);

                            index_imagen++;
                        }
                    }


                    Thread.Sleep(1000); 
                    g.Clear(Color.DimGray); //se limpia la pantalla y se convierte de color gris

                    //ocultando el punto
                    this.btnTarget.Visible = false;

                    //Mostrando un punto al inicio de cada Ensayo, y lo borro después de 1 segundo (anterior)
                    /*punto_inicio = new Pen(Color.White, 20);
                    g.DrawEllipse(punto_inicio, 650, 350, 3, 3);
                    Thread.Sleep(1000);
                    g.Clear(Color.DimGray); //se limpia la pantalla y se convierte de color gris*/

                    //Mostrando un INIDICADOR al inicio de cada Ensayo, y lo borro después de 1 segundo  (nuevo: 27 nov 2019)
                    try
                    {

                        //imagen de la barra espaciadora, para iniciar experimento!! (27-11-19)
                        // Create image.
                        Image newImage = Image.FromFile("barra_espaciadora.png");

                        // Create coordinates for upper-left corner of image.
                        float x_image_spacebar = 550.0F;
                        float y_image_spacebar = 300.0F;

                        // Create rectangle for source image.
                        RectangleF srcRect = new RectangleF(10.0F, 10.0F, 350.0F, 150.0F);
                        GraphicsUnit units = GraphicsUnit.Pixel;

                        // Draw image to screen.
                        g.DrawImage(newImage, x_image_spacebar, y_image_spacebar, srcRect, units);

                        Thread.Sleep(1000);
                        g.Clear(Color.DimGray); //se limpia la pantalla y se convierte de color gris */
                    }
                    catch //si no encuentra la imagen, entonces voy dibujar un spacebar!
                    {
                        
                        /*punto_inicio = new Pen(Color.White, 20);
                        g.DrawEllipse(punto_inicio, 650, 350, 3, 3); //X = 750 y Y = 350*/

                        g = this.CreateGraphics();
                        Pen pen = new Pen(Color.White, 10);

                        // una raya
                        Point[] points =
                                 {
                                 new Point(500, 350),
                                 new Point(500, 300)
                             };

                        // otra raya
                        Point[] points2 =
                                 {
                                 new Point(750, 350),
                                 new Point(750, 300)
                             };

                        // otra raya vertical
                        Point[] points3 =
                                 {
                                 new Point(500, 300),
                                 new Point(750, 300)
                             };

                        // otra raya vertical
                        Point[] points4 =
                                 {
                                 new Point(500, 350),
                                 new Point(750, 350)
                             };

                        //Draw lines to screen.
                        g.DrawLines(pen, points);
                        g.DrawLines(pen, points2);
                        g.DrawLines(pen, points3);
                        g.DrawLines(pen, points4);

                        // Leyenda de spacebar
                        System.Drawing.Graphics formGraphics = this.CreateGraphics();
                        string drawString = "Spacebar";
                        System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 16);
                        System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                        float x = 570.0F;
                        float y = 310.0F;
                        System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
                        formGraphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
                        drawFont.Dispose();
                        drawBrush.Dispose();
                        formGraphics.Dispose();

                        Thread.Sleep(1000);
                        g.Clear(Color.DimGray); //se limpia la pantalla y se convierte de color gris

                    }

                    this.serialPort1.WriteLine("1"); //cerrar los lentes (15 nov 19)


                    // solo se van a mostrar las instrucciones al principio del experimento 
                    if (cont == Int32.Parse(num_repeticiones_inicio))
                    {
                        this.lblInstrucciones.Visible = true;
                    }

                    spacebar_presionado = false;

                }

                //cont = num de repeticiones
                // el "cont" no se pone en 0's hasta que hace la última prueba en exp. grales. y en pruebas individuales.
                if (cont == 0)
                {
                    if (es_experimento_gral && this.iniciar_condicion)
                    {
                        this.iniciar_condicion = false;
                        guardarCSV();
                    }
                    else if (!es_experimento_gral)
                    {

                        guardarCSV();
                    }
                }

                // bandera para evitar que de click, antes de presionar el "spacebar"
                this.inicio_experimento = false;

                se_mostro_target = false;
            }

        }

        public int touch(MouseEventArgs e)
        {

            if (cont > 0) { //el numero de repeticiones se va decreciendo en cada intento, por eso se pregunta si aún hay oportunidad de dar click

                xtouch = e.X;
                ytouch = e.Y;

                ////
                if (!es_propiocepcion)
                {
                    x1 = this.btnTarget.Left + 10;
                    y1 = this.btnTarget.Top + 10;

                }
                else { // centro de la pantalla, para la prueba de Propiocepción
                    y1 = 350;
                    x1 = 650;
                }

                //Recompensa: -1 si >5°; 0 puntos si <=5°
                //midiendo distancia
                distancia = Math.Sqrt(Math.Pow(xtouch - x1, 2) + Math.Pow(ytouch - y1, 2));


                if (distancia > 139.716) // 5° de distancia con respecto al target, en pixeles
                {
                    if (this.lblRecompensa.Visible)
                    {
                        puntos_recompensa = puntos_recompensa - 1;
                        this.lblRecompensa.Text = (puntos_recompensa).ToString();
                    }
                }

                String lado;

                if ((xtouch - x1) > 0)
                {
                    lado = "derecha";
                }
                else
                {
                    lado = "izquierda";
                    distancia = distancia * -1;
                }

                string clik_coordenadas = x1.ToString() + "," + y1.ToString() + "," + xtouch.ToString() + "," + ytouch.ToString()+ 
                                          "," + tiempo_spacebar + "," + tiempo_presiono_spacebar + "," + tiempo_despresiono_spacebar + 
                                          "," + (x1 - xtouch).ToString() + "," + (y1 - ytouch).ToString() + "," + tiempo_click_menos_spacebarUp 
                                          + "," + tiempo_total_ensayo + "," + puntos_recompensa + "," + distancia + "," + lado;
                datos.Add(clik_coordenadas);
                this.listBox1.DataSource = null;
                this.listBox1.DataSource = this.datos;
                //this.btnTarget.Visible = true;
                cont--;
                return 0;
            }
            else //seguirá recorriendo las pruebas cuando es un exp.gral.
            {
                if (es_experimento_gral == true && this.iniciar_condicion) { //<----

                    //si el mensaje está vacío, no se mostrará nada; además que no se haya activado el límite de tiempo por ensayo.
                    if (this.mensaje_final.Length > 0 && !activar_tiempo_ensayo)
                    {
                        MessageBox.Show(this.mensaje_final, "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                    String archivo = "";

                    using (StreamReader sr = new StreamReader(ruta_archivo_experimento))
                    {
                        archivo = sr.ReadToEnd();
                    }

                    //En el ejemplo convertimos el string a un string[], es decir, de una cadena de caracteres a un array de cadenas de caracteres, luego convertimos el texto del string[] a List usando como cambio de elemento del List el carácter \n que representa "Nueva línea".
                    List<string> configuraciones = archivo.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();

                    //obteniendo el orden de ejecución
                    String OrdenEjecucion = configuraciones[4].Split('|')[1].Replace("\r\n", "").Replace("\n", "").Replace("\r", ""); //+ ">fin"; //<-----

                    Char[] splitchar = { '>' };
                    Pruebas = OrdenEjecucion.Split(splitchar);

                    //la inicializo cuando es exp. gral. para detener la secuencia
                    iniciar_prueba = true;

                    for (int i = num_prueba; i <= Pruebas.Length - 1; i++)
                    {

                        if (iniciar_prueba == true)
                        {
                            //recorriendo cada una de las pruebas.
                            switch (Pruebas[i])
                            {
                                case "Propiocepción":
                                    es_probe = false;
                                    es_propiocepcion = true;
                                    no_feedback = true;
                                    iniciar_prueba = false;
                                    LlenarComponentes(configuraciones[0].Split('|')[1], nombre_paciente, this.lblInstrucciones.Text, edad_paciente, sexo_paciente, escolaridad_paciente, Tipo_vision, Es_Diestro, Desorden_neuronal, Crisis_ansiedad, Tipo_medicamentos);
                                    break;
                                case "Pre-prueba":
                                    es_probe = false;
                                    es_propiocepcion = false;
                                    no_feedback = false;
                                    iniciar_prueba = false;
                                    LlenarComponentes(configuraciones[1].Split('|')[1], nombre_paciente, this.lblInstrucciones.Text, edad_paciente, sexo_paciente, escolaridad_paciente, Tipo_vision, Es_Diestro, Desorden_neuronal, Crisis_ansiedad, Tipo_medicamentos);
                                    break;
                                case "Prismas-prueba":
                                    es_probe = false;
                                    es_propiocepcion = false;
                                    no_feedback = false;
                                    iniciar_prueba = false;
                                    LlenarComponentes(configuraciones[2].Split('|')[1], nombre_paciente, this.lblInstrucciones.Text, edad_paciente, sexo_paciente, escolaridad_paciente, Tipo_vision, Es_Diestro, Desorden_neuronal, Crisis_ansiedad, Tipo_medicamentos);
                                    break;
                                case "Post-prueba":
                                    es_probe = false;
                                    es_propiocepcion = false;
                                    no_feedback = false;
                                    iniciar_prueba = false;
                                    LlenarComponentes(configuraciones[3].Split('|')[1], nombre_paciente, this.lblInstrucciones.Text, edad_paciente, sexo_paciente, escolaridad_paciente, Tipo_vision, Es_Diestro, Desorden_neuronal, Crisis_ansiedad, Tipo_medicamentos);
                                    break;
                                case "Probe": //probe
                                    es_probe = true;
                                    es_propiocepcion = false;
                                    no_feedback = true;
                                    iniciar_prueba = false;
                                    LlenarComponentes(configuraciones[5].Split('|')[1], nombre_paciente, this.lblInstrucciones.Text, edad_paciente, sexo_paciente, escolaridad_paciente, Tipo_vision, Es_Diestro, Desorden_neuronal, Crisis_ansiedad, Tipo_medicamentos);
                                    break;
                            }
                        }
                    }

                    return 1; // es cuando ya se terminaron los ensayos de la condición
                    
                }
            }

            return 0; // cuando aún quedan ensayos de la condición, por hacer!
        }

        //método sobrecargado, cuando hay que restar la recompensa, pero no se da click y exite un "tiempo" en el ensayo (27/oct/19)
        public int touch()
        {

            if (cont > 0)
            { //el numero de repeticiones se va decreciendo en cada intento, por eso se pregunta si aún hay oportunidad de dar click

                //van en cero, porque el paciente no dio click!
                xtouch = 0;
                ytouch = 0;

                ////
                if (!es_propiocepcion)
                {
                    x1 = this.btnTarget.Left + 10;
                    y1 = this.btnTarget.Top + 10;

                }
                else
                { // centro de la pantalla, para la prueba de Propiocepción
                    y1 = 350;
                    x1 = 650;
                }

                //como no dio click, se debe poner en cero la distancia (27-11-2019)
                distancia = 0;
                String distancia_nula = "NaN";

                //Recompensa siempre se quita
                if (activar_recompensa) { 
                   puntos_recompensa = puntos_recompensa - 1;
                   this.lblRecompensa.Text = (puntos_recompensa).ToString();
                }

                string clik_coordenadas = x1.ToString() + "," + y1.ToString() + "," + xtouch.ToString() + "," + ytouch.ToString() +
                                          "," + tiempo_spacebar + "," + tiempo_presiono_spacebar + "," + tiempo_despresiono_spacebar +
                                          "," + (x1 - xtouch).ToString() + "," + (y1 - ytouch).ToString() + "," + tiempo_click_menos_spacebarUp
                                          + "," + tiempo_total_ensayo + "," + puntos_recompensa + "," + distancia_nula + "," + "no dio click";
                datos.Add(clik_coordenadas);
                this.listBox1.DataSource = null;
                this.listBox1.DataSource = this.datos;
                cont--; //restando los ensayos
                return 0;
            }
            else //seguirá recorriendo las pruebas cuando es un exp.gral.
            {
                if (es_experimento_gral == true && this.iniciar_condicion) //<----
                {
                    
                    if (this.mensaje_final.Length > 0 && !activar_tiempo_ensayo)
                    {
                        MessageBox.Show(this.mensaje_final, "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    String archivo = "";

                    using (StreamReader sr = new StreamReader(ruta_archivo_experimento))
                    {
                        archivo = sr.ReadToEnd();
                    }

                    //En el ejemplo convertimos el string a un string[], es decir, de una cadena de caracteres a un array de cadenas de caracteres, luego convertimos el texto del string[] a List usando como cambio de elemento del List el carácter \n que representa "Nueva línea".
                    List<string> configuraciones = archivo.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();

                    //obteniendo el orden de ejecución
                    String OrdenEjecucion = configuraciones[4].Split('|')[1].Replace("\r\n", "").Replace("\n", "").Replace("\r", ""); //+ ">fin"; //<-----

                    Char[] splitchar = { '>' };
                    Pruebas = OrdenEjecucion.Split(splitchar);

                    //la inicializo cuando es exp. gral. para detener la secuencia
                    iniciar_prueba = true;

                    for (int i = num_prueba; i <= Pruebas.Length - 1; i++)
                    {

                        if (iniciar_prueba == true)
                        {
                            //recorriendo cada una de las pruebas.
                            switch (Pruebas[i])
                            {
                                case "Propiocepción":
                                    es_probe = false;
                                    es_propiocepcion = true;
                                    no_feedback = true;
                                    iniciar_prueba = false;
                                    LlenarComponentes(configuraciones[0].Split('|')[1], nombre_paciente, this.lblInstrucciones.Text, edad_paciente, sexo_paciente, escolaridad_paciente, Tipo_vision, Es_Diestro, Desorden_neuronal, Crisis_ansiedad, Tipo_medicamentos);
                                    break;
                                case "Pre-prueba":
                                    es_probe = false;
                                    es_propiocepcion = false;
                                    no_feedback = false;
                                    iniciar_prueba = false;
                                    this.timer.Stop();
                                    LlenarComponentes(configuraciones[1].Split('|')[1], nombre_paciente, this.lblInstrucciones.Text, edad_paciente, sexo_paciente, escolaridad_paciente, Tipo_vision, Es_Diestro, Desorden_neuronal, Crisis_ansiedad, Tipo_medicamentos);
                                    break;
                                case "Prismas-prueba":
                                    es_probe = false;
                                    es_propiocepcion = false;
                                    no_feedback = false;
                                    iniciar_prueba = false;
                                    this.timer.Stop();
                                    LlenarComponentes(configuraciones[2].Split('|')[1], nombre_paciente, this.lblInstrucciones.Text, edad_paciente, sexo_paciente, escolaridad_paciente, Tipo_vision, Es_Diestro, Desorden_neuronal, Crisis_ansiedad, Tipo_medicamentos);
                                    break;
                                case "Post-prueba":
                                    es_probe = false;
                                    es_propiocepcion = false;
                                    no_feedback = false;
                                    iniciar_prueba = false;
                                    this.timer.Stop();
                                    LlenarComponentes(configuraciones[3].Split('|')[1], nombre_paciente, this.lblInstrucciones.Text, edad_paciente, sexo_paciente, escolaridad_paciente, Tipo_vision, Es_Diestro, Desorden_neuronal, Crisis_ansiedad, Tipo_medicamentos);
                                    break;
                                case "Probe": //probe
                                    es_probe = true;
                                    es_propiocepcion = false;
                                    no_feedback = true;
                                    iniciar_prueba = false;
                                    this.timer.Stop();
                                    LlenarComponentes(configuraciones[5].Split('|')[1], nombre_paciente, this.lblInstrucciones.Text, edad_paciente, sexo_paciente, escolaridad_paciente, Tipo_vision, Es_Diestro, Desorden_neuronal, Crisis_ansiedad, Tipo_medicamentos);
                                    break;
                            }
                        }
                    }

                    return 1;
                    
                }
            }

            return 0;
        }

        public void guardarCSV()
        {
            //necesario para el timer, para que no se cicle
            timer.Stop();

            try
            {
                if (es_experimento_gral)
                {
                    //if (no_repeticiones == 0)
                    if (Pruebas.Length == num_prueba)// aquí podría cambiarlo por el numero de prueba en la que voy, "si es igual al límite!" 
                    {
                        //enviando mensaje final
                        MessageBox.Show("¡FIN DE EXPERIMENTO!", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.serialPort1.WriteLine("0"); //se abren los lentes

                        // Iniciar guardado en base de datos tipo CSV
                        DateTime date = DateTime.Now;
                        //string data2 = data.ToString("dd_MM_yyyy");
                        //string data3 = data.ToString("HH_mm_ss");

                        // Mostrando ventana de navegación para guardar los registros del experimento
                        SaveFileDialog dlg = new SaveFileDialog();

                        dlg.FileName = "RES_" + nombre_paciente.Replace("\r\n", "").Replace("\n", "").Replace("\r", "") + "_fecha " + date.ToString("dd_MM_yyyy") + "_hora " + date.ToString("HH_mm_ss") + ".csv";

                        //dlg.Filter = "csv files (*.csv) |.csv | All files(*.*) | *.* ";

                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter save = new StreamWriter(dlg.FileName);
                            for (int i = 0; i < listBox1.Items.Count; i++)
                            {
                                save.WriteLine((string)listBox1.Items[i]);
                            }
                            save.Close();
                            MessageBox.Show("¡Resultados del EXPERIMENTO guardados con éxito!", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        //cerrando
                        dlg.Dispose();
                        this.serialPort1.WriteLine("1");
                        serialPort1.Close();
                        this.Close(); //<-- que no se cierre el "Panel de Experimentos"

                    }
                    else //para experimentos grales. en donde se tiene una secuencia de pruebas
                    {
                        iniciar_prueba = true; //posiblemente esta variable pueda ser eliminada
                        num_prueba++; //aumento para que continue leyendo el arreglo con la secuencia de pruebas
                    }
                }
                else // esto se tiene que activar cuando se una PRUEBA INDIVIDUAL
                {

                    //if (no_repeticiones == 0)

                    //enviando mensaje final
                    if (this.mensaje_final.Length > 0)
                    {
                        MessageBox.Show(this.mensaje_final, "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        timer.Stop(); //parando el cronómetro, para se pueda cerrar el programa.
                    }

                    // Iniciar guardado en base de datos tipo CSV
                    this.serialPort1.WriteLine("0");
                    DateTime date = DateTime.Now;
                    //string data2 = data.ToString("dd_MM_yyyy");
                    //string data3 = data.ToString("HH_mm_ss");

                    // Mostrando ventana de navegación para guardar los registros del experimento
                    SaveFileDialog dlg = new SaveFileDialog();

                    dlg.FileName = nombre_paciente.Replace("\r\n", "").Replace("\n", "").Replace("\r", "") + "_" + tipo_prueba + "_" + num_repeticiones_inicio + " targets_fecha " + date.ToString("dd_MM_yyyy") + "_hora " + date.ToString("HH_mm_ss") + ".csv";
                   
                    //dlg.Filter = "csv files (*.csv) |.csv | All files(*.*) | *.* ";

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter save = new StreamWriter(dlg.FileName);
                        for (int i = 0; i < listBox1.Items.Count; i++)
                        {
                            save.WriteLine((string)listBox1.Items[i]);
                        }
                        save.Close();
                        MessageBox.Show("¡Resultados de la PRUEBA/CONDICIÓN guardados con éxito!", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //cerrando
                    dlg.Dispose();
                    this.serialPort1.WriteLine("1");
                    serialPort1.Close();
                    this.Close(); //<-- que no se cierre el "Panel de Experimentos"
                    
                }

            }catch {
                MessageBox.Show("¡No se pudo guardar la información!", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.serialPort1.WriteLine("1");
                serialPort1.Close();
                this.Close();
            }
            
        }

        bool se_mostro_target = false; //variable para impedir que aparezca el feedback, antes del target (6 dic 2019)

        // esta funcion es la que muestra el target, segun las coordenadas
        public void MuestraTarget()
        {

            g = this.CreateGraphics(); //Creará los gráficos, y se inicializa en esta función

            /*
           //para que dibuje el target (codigo anterior, cuando era un cuadrado)
           cuadro_target = new Pen(Color.Black, 20);

           // cuando es PROPIOCEPCION, no se muestra el "target"
           if (!es_propiocepcion)
           {
               g.DrawRectangle(cuadro_target, new Rectangle(x - 10, y - 10, 3, 3));
           }

           //x = random.Next(xmi, xma);
           //y = random.Next(ymi, yma);
           */

            ///se cambió el target por algo dibujado, en lugar de un botón, pero se conserva, para guardar las coordenadas.
            x = random.Next(xmi, xma);
            y = random.Next(ymi, yma);

            this.btnTarget.Left = x-10;
            this.btnTarget.Top = y-10;
            //this.btnTarget.Visible = true; //codigo anterior, target cuadrado
            

            if (!es_propiocepcion) //dibujando un punto negro
            {
                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                System.Drawing.Graphics formGraphics;
                formGraphics = this.CreateGraphics();
                formGraphics.FillEllipse(myBrush, new Rectangle(x - 10, y - 10, 20, 20));
                myBrush.Dispose();
                formGraphics.Dispose();
            }

            //this.inicio_experimento = true;
        }

        private void LblTiempo_Click(object sender, EventArgs e)
        {

        }

        // variable para la ejecución de manera aleatoria de las imágenes IAPS de una carpeta
        //Random random2 = new Random();
        /*public Image randomforimage()
        {
            int numero, numero2 = 0;
            Image imagen;
            for (int i = 0; i < listaImagenes.Items.Count; i++)
            {
                numero2++;
            }

            numero = random.Next(0, numero2);
            imagen = new Bitmap(listaImagenes.Items[numero].ToString());
            return imagen;
        }*/


        int i;
        private void Timer_Tick(object sender, EventArgs e)
        {
            
            i++;
            this.lblTiempo.Text = i.ToString();

            if (i > this.tiempo_ensayo)
            {
                if (!dio_click && cont >= 0)
                {
                    this.lblTiempo.Text = "SE TERMINÓ EL TIEMPO";
                    this.Form2_MouseDown();
                }
                else if (dio_click && cont >= 0)
                {

                    this.lblTiempo.Text = "SÍ";
                    dio_click = false;
                }
            }
        }

        private void LblRecompensa_Click(object sender, EventArgs e)
        {

        }

        //Método para detectar cuando se presiona la "spacebar"
        //int contado = 0;//banderas lógicas?
        //int contador2 = 0;
        bool spacebar_presionado = false; //para evitar que presionen muchas veces el "spacebar"; cuando está activado el tiempo, evita que reinicie el reloj
        String tiempo_presiono_spacebar, tiempo_despresiono_spacebar;

        bool iniciar_condicion = true;

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                
                //if (contador2 == 0 && e.KeyCode == Keys.Space && contado == 0)
                if (spacebar_presionado == false && e.KeyCode == Keys.Space && iniciar_condicion && cont > 0)
                {
                    tiempo_spacebar_down = DateTime.Now;  //momento en que se presiona el "spacebar"

                    //bandera para evitar que se de click a la pantalla, desde antes que empiece el experimento
                    inicio_experimento = true;

                    //ocultando las instrucciones, cuando ya comenzó el experimento
                    this.lblInstrucciones.Visible = false;

                    this.serialPort1.WriteLine("0"); //abriendo lentes para ver los mensajes

                    if (!es_propiocepcion)
                    {
                        Thread.Sleep(delay_mostrar_target); //retardo en mostrar el "Target" de un segundo
                        MuestraTarget();
                    }
                    else
                    { // en Propiocepcion, no hay delay para mostrar el target, ya que se abren los lentes
                        MuestraTarget();
                    }

                    


                    //bandera para que no puede presionar muchas veces el spacebar, en un target
                    spacebar_presionado = true;

                    tiempo_presiono_spacebar = tiempo_spacebar_down.Hour.ToString() + ":" + tiempo_spacebar_down.Minute.ToString() + ":"
                            + tiempo_spacebar_down.Second.ToString() + ":" + tiempo_spacebar_down.Millisecond.ToString();

                    //ahora el target solo va a estar por determinado tiempo
                    Thread.Sleep(delay_target);
                    g.Clear(Color.DimGray);

                    se_mostro_target = true;

                    //Activación del tiempo para este ensayo
                    if (activar_tiempo_ensayo)
                    {
                        i = 0;
                        timer.Start();
                    }
                }
                //}
                //else {

                if (cont == 0 && !iniciar_condicion)
                {
                    //MessageBox.Show("Presiona S, para continuar");
                    this.lblInstrucciones.Visible = true;
                    this.lblInstrucciones.Text = "" +
                        "Presiona la tecla S, para continuar.";
                    this.iniciar_prueba = false;

                    if (e.KeyCode == Keys.S)
                    {
                        this.iniciar_condicion = true;
                        this.spacebar_presionado = false;
                        this.iniciar_prueba = true;
                        touch(); //llamar a este método para que se recorra la siguiente prueba y el contador de ensayos 

                    }
                }
                else if (cont == 0 && iniciar_condicion)
                {

                    if (Pruebas.Length == num_prueba)
                    {
                        guardarCSV();
                    }


                }


            }
            catch
            {
                MessageBox.Show("Error en ejecución.", "Prismas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        

        //variables para controlar los tiempos de visualizacion
        DateTime tiempo_spacebar_down; //tiempo en que se presionó el "spacebar"
        DateTime tiempo_spacebar_up; //hora en el que dejó de presionar "spacebar"
        DateTime tiempo_click_feedback; //hora en el que dejó de presionar "spacebar"
        TimeSpan tiempo_spacebar; //tiempo que estuvo presionado el spacebar
        TimeSpan tiempo_click_menos_spacebarUp; //tiempo de dejar de presionar spacebar - click donde vio el target
        TimeSpan tiempo_total_ensayo; //tiempo cuando presionó spacebar - click donde vio el target

        //TimeSpan tra;//variable para realizar la resta ???? (creo que esta variable no se usa!)
        //int con = 0; // como se usa esta variable????

        // Método para detectar cuando se suelta el "spacebar"
        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {

             //if (e.KeyCode == Keys.Space && con==0)
             if (e.KeyCode == Keys.Space)
             {
                this.serialPort1.WriteLine("1"); //cerrando los lentes
                this.btnTarget.Visible = false;
                //contado = 0;
                tiempo_spacebar_up = DateTime.Now; //hora en el que dejó de presionar "spacebar"

                tiempo_despresiono_spacebar = tiempo_spacebar_up.Hour.ToString() + ":" + tiempo_spacebar_up.Minute.ToString() + ":"
                            + tiempo_spacebar_up.Second.ToString() + ":" + tiempo_spacebar_up.Millisecond.ToString();

                tiempo_spacebar = tiempo_spacebar_up - tiempo_spacebar_down; //tiempo de visualización del "target"
                //con++;
             }
             else
             {
                //MessageBox.Show("Solo es permitido presionar -barra espaciadora-, verifique.", "Error en el teclado", MessageBoxButtons.OK, MessageBoxIcon.Error);

             }
        }
    }
}
