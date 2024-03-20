namespace controldeexperimento
{
    partial class frmConfiguracion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracion));
            this.cmbNumRepeticiones = new System.Windows.Forms.NumericUpDown();
            this.cmbPuertos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuracionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaConfiguraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarConfiguraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarConfiguraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cmbTipoPruebas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbYMax = new System.Windows.Forms.NumericUpDown();
            this.cmbYMin = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbXMax = new System.Windows.Forms.NumericUpDown();
            this.cmbXMin = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbEscolaridad = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.cmbEdad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkImagenAleatorias = new System.Windows.Forms.CheckBox();
            this.chkImagenCentrada = new System.Windows.Forms.CheckBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.cmbImagenLargo = new System.Windows.Forms.NumericUpDown();
            this.cmbImagenAlto = new System.Windows.Forms.NumericUpDown();
            this.rdbImagenesNo = new System.Windows.Forms.RadioButton();
            this.rdbImagenesSi = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRutaImagenes = new System.Windows.Forms.TextBox();
            this.btnBuscarImagenes = new System.Windows.Forms.Button();
            this.dlCarpeta = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label35 = new System.Windows.Forms.Label();
            this.cmbRetrasoMostrarTarget = new System.Windows.Forms.NumericUpDown();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbTiempoVisualizacionTarget = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbTiempoPresentarImagen = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbTiempoVisualizacionFeedback = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtInstrucciones = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtMensajeFinExperimento = new System.Windows.Forms.TextBox();
            this.lblArchivoConfiguracion = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.chkRecompensa = new System.Windows.Forms.CheckBox();
            this.label36 = new System.Windows.Forms.Label();
            this.cmbPuntosRecompensa = new System.Windows.Forms.NumericUpDown();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label38 = new System.Windows.Forms.Label();
            this.chkEnsayo = new System.Windows.Forms.CheckBox();
            this.label37 = new System.Windows.Forms.Label();
            this.cmbTiempoEnsayo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNumRepeticiones)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYMin)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbXMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbXMin)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEscolaridad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEdad)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagenLargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagenAlto)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRetrasoMostrarTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTiempoVisualizacionTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTiempoPresentarImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTiempoVisualizacionFeedback)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPuntosRecompensa)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTiempoEnsayo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNumRepeticiones
            // 
            this.cmbNumRepeticiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNumRepeticiones.Location = new System.Drawing.Point(182, 37);
            this.cmbNumRepeticiones.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.cmbNumRepeticiones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cmbNumRepeticiones.Name = "cmbNumRepeticiones";
            this.cmbNumRepeticiones.Size = new System.Drawing.Size(121, 24);
            this.cmbNumRepeticiones.TabIndex = 2;
            this.cmbNumRepeticiones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbNumRepeticiones.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // cmbPuertos
            // 
            this.cmbPuertos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPuertos.FormattingEnabled = true;
            this.cmbPuertos.Location = new System.Drawing.Point(24, 21);
            this.cmbPuertos.Name = "cmbPuertos";
            this.cmbPuertos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbPuertos.Size = new System.Drawing.Size(202, 26);
            this.cmbPuertos.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Repeticiones/ensayos:";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Green;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIniciar.Location = new System.Drawing.Point(702, 456);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(142, 89);
            this.btnIniciar.TabIndex = 13;
            this.btnIniciar.Text = "Iniciar prueba";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(875, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuracionesToolStripMenuItem
            // 
            this.configuracionesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.configuracionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaConfiguraciónToolStripMenuItem,
            this.cargarConfiguraciónToolStripMenuItem,
            this.guardarConfiguraciónToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.configuracionesToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuracionesToolStripMenuItem.Name = "configuracionesToolStripMenuItem";
            this.configuracionesToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.configuracionesToolStripMenuItem.Text = "Menú";
            this.configuracionesToolStripMenuItem.Click += new System.EventHandler(this.ConfiguracionesToolStripMenuItem_Click);
            // 
            // nuevaConfiguraciónToolStripMenuItem
            // 
            this.nuevaConfiguraciónToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.nuevaConfiguraciónToolStripMenuItem.Name = "nuevaConfiguraciónToolStripMenuItem";
            this.nuevaConfiguraciónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevaConfiguraciónToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.nuevaConfiguraciónToolStripMenuItem.Text = "Nueva configuración";
            this.nuevaConfiguraciónToolStripMenuItem.Click += new System.EventHandler(this.NuevaConfiguraciónToolStripMenuItem_Click);
            // 
            // cargarConfiguraciónToolStripMenuItem
            // 
            this.cargarConfiguraciónToolStripMenuItem.Name = "cargarConfiguraciónToolStripMenuItem";
            this.cargarConfiguraciónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.cargarConfiguraciónToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.cargarConfiguraciónToolStripMenuItem.Text = "Abrir configuración";
            this.cargarConfiguraciónToolStripMenuItem.Click += new System.EventHandler(this.CargarConfiguraciónToolStripMenuItem_Click);
            // 
            // guardarConfiguraciónToolStripMenuItem
            // 
            this.guardarConfiguraciónToolStripMenuItem.Name = "guardarConfiguraciónToolStripMenuItem";
            this.guardarConfiguraciónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarConfiguraciónToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.guardarConfiguraciónToolStripMenuItem.Text = "Guardar configuración";
            this.guardarConfiguraciónToolStripMenuItem.Click += new System.EventHandler(this.GuardarConfiguraciónToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.AccessibleName = "guardarComo";
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar configuración como";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.GuardarComoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(272, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.SalirToolStripMenuItem1_Click);
            // 
            // cmbTipoPruebas
            // 
            this.cmbTipoPruebas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPruebas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoPruebas.FormattingEnabled = true;
            this.cmbTipoPruebas.Items.AddRange(new object[] {
            "POST",
            "PRE",
            "PRISMA",
            "PROPIOCEPCIÓN",
            "PROBE"});
            this.cmbTipoPruebas.Location = new System.Drawing.Point(182, 67);
            this.cmbTipoPruebas.Name = "cmbTipoPruebas";
            this.cmbTipoPruebas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbTipoPruebas.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoPruebas.TabIndex = 2;
            this.cmbTipoPruebas.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Condición:";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(71, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = "Actualizar Puerto";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(335, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Se recomienda elegir dentro del rango de 60 a 1330 para X,";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(316, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 222);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elija el área dónde aparecerá el \"target\"";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(317, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "El área total es de (0 a1378) en X y de (0 a 780) en Y.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cmbYMax);
            this.groupBox3.Controls.Add(this.cmbYMin);
            this.groupBox3.Location = new System.Drawing.Point(170, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 93);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rango en Y";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 18);
            this.label12.TabIndex = 29;
            this.label12.Text = "Máximo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 18);
            this.label11.TabIndex = 28;
            this.label11.Text = "Mínimo";
            // 
            // cmbYMax
            // 
            this.cmbYMax.Location = new System.Drawing.Point(75, 61);
            this.cmbYMax.Maximum = new decimal(new int[] {
            730,
            0,
            0,
            0});
            this.cmbYMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cmbYMax.Name = "cmbYMax";
            this.cmbYMax.Size = new System.Drawing.Size(62, 24);
            this.cmbYMax.TabIndex = 12;
            this.cmbYMax.Value = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.cmbYMax.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // cmbYMin
            // 
            this.cmbYMin.Location = new System.Drawing.Point(75, 30);
            this.cmbYMin.Maximum = new decimal(new int[] {
            730,
            0,
            0,
            0});
            this.cmbYMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cmbYMin.Name = "cmbYMin";
            this.cmbYMin.Size = new System.Drawing.Size(62, 24);
            this.cmbYMin.TabIndex = 11;
            this.cmbYMin.Value = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.cmbYMin.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmbXMax);
            this.groupBox2.Controls.Add(this.cmbXMin);
            this.groupBox2.Location = new System.Drawing.Point(11, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 94);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rango en X";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 18);
            this.label10.TabIndex = 29;
            this.label10.Text = "Máximo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 18);
            this.label9.TabIndex = 28;
            this.label9.Text = "Mínimo";
            // 
            // cmbXMax
            // 
            this.cmbXMax.Location = new System.Drawing.Point(75, 61);
            this.cmbXMax.Maximum = new decimal(new int[] {
            1378,
            0,
            0,
            0});
            this.cmbXMax.Name = "cmbXMax";
            this.cmbXMax.Size = new System.Drawing.Size(62, 24);
            this.cmbXMax.TabIndex = 10;
            this.cmbXMax.Value = new decimal(new int[] {
            650,
            0,
            0,
            0});
            this.cmbXMax.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // cmbXMin
            // 
            this.cmbXMin.Location = new System.Drawing.Point(75, 30);
            this.cmbXMin.Maximum = new decimal(new int[] {
            1378,
            0,
            0,
            0});
            this.cmbXMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cmbXMin.Name = "cmbXMin";
            this.cmbXMin.Size = new System.Drawing.Size(62, 24);
            this.cmbXMin.TabIndex = 9;
            this.cmbXMin.Value = new decimal(new int[] {
            650,
            0,
            0,
            0});
            this.cmbXMin.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "y de 60 a 730 para Y.";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbPuertos);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(631, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 113);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Puerto de Conexión (lentes)";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(79, 55);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(205, 54);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbEscolaridad);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.cmbSexo);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.cmbEdad);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txtNombre);
            this.groupBox5.Controls.Add(this.txtDescripcion);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 303);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(290, 190);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Descripción del paciente";
            this.groupBox5.Enter += new System.EventHandler(this.GroupBox5_Enter);
            // 
            // cmbEscolaridad
            // 
            this.cmbEscolaridad.DecimalPlaces = 1;
            this.cmbEscolaridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEscolaridad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.cmbEscolaridad.Location = new System.Drawing.Point(197, 159);
            this.cmbEscolaridad.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.cmbEscolaridad.Name = "cmbEscolaridad";
            this.cmbEscolaridad.Size = new System.Drawing.Size(87, 21);
            this.cmbEscolaridad.TabIndex = 5;
            this.cmbEscolaridad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(7, 55);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(52, 18);
            this.label26.TabIndex = 46;
            this.label26.Text = "Desc:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 159);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(156, 18);
            this.label20.TabIndex = 45;
            this.label20.Text = "Escolaridad (años):";
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "MUJER",
            "HOMBRE"});
            this.cmbSexo.Location = new System.Drawing.Point(205, 127);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbSexo.Size = new System.Drawing.Size(79, 23);
            this.cmbSexo.TabIndex = 4;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(148, 128);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(51, 18);
            this.label24.TabIndex = 44;
            this.label24.Text = "Sexo:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(7, 127);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(51, 18);
            this.label25.TabIndex = 43;
            this.label25.Text = "Edad:";
            // 
            // cmbEdad
            // 
            this.cmbEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEdad.Location = new System.Drawing.Point(69, 127);
            this.cmbEdad.Name = "cmbEdad";
            this.cmbEdad.Size = new System.Drawing.Size(63, 21);
            this.cmbEdad.TabIndex = 3;
            this.cmbEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbEdad.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(79, 27);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(205, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkImagenAleatorias);
            this.groupBox6.Controls.Add(this.chkImagenCentrada);
            this.groupBox6.Controls.Add(this.label32);
            this.groupBox6.Controls.Add(this.label31);
            this.groupBox6.Controls.Add(this.label28);
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Controls.Add(this.cmbImagenLargo);
            this.groupBox6.Controls.Add(this.cmbImagenAlto);
            this.groupBox6.Controls.Add(this.rdbImagenesNo);
            this.groupBox6.Controls.Add(this.rdbImagenesSi);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.txtRutaImagenes);
            this.groupBox6.Controls.Add(this.btnBuscarImagenes);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(313, 33);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(312, 181);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Imágenes";
            // 
            // chkImagenAleatorias
            // 
            this.chkImagenAleatorias.AutoSize = true;
            this.chkImagenAleatorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImagenAleatorias.Location = new System.Drawing.Point(112, 152);
            this.chkImagenAleatorias.Name = "chkImagenAleatorias";
            this.chkImagenAleatorias.Size = new System.Drawing.Size(126, 19);
            this.chkImagenAleatorias.TabIndex = 30;
            this.chkImagenAleatorias.Text = "Orden Aleatorio";
            this.chkImagenAleatorias.UseVisualStyleBackColor = true;
            // 
            // chkImagenCentrada
            // 
            this.chkImagenCentrada.AutoSize = true;
            this.chkImagenCentrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImagenCentrada.Location = new System.Drawing.Point(12, 152);
            this.chkImagenCentrada.Name = "chkImagenCentrada";
            this.chkImagenCentrada.Size = new System.Drawing.Size(73, 19);
            this.chkImagenCentrada.TabIndex = 29;
            this.chkImagenCentrada.Text = "Centrar";
            this.chkImagenCentrada.UseVisualStyleBackColor = true;
            this.chkImagenCentrada.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(239, 133);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(35, 15);
            this.label32.TabIndex = 28;
            this.label32.Text = "largo";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(152, 134);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(38, 15);
            this.label31.TabIndex = 27;
            this.label31.Text = "altura";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(209, 108);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(16, 20);
            this.label28.TabIndex = 24;
            this.label28.Text = "x";
            // 
            // label27
            // 
            this.label27.AllowDrop = true;
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(33, 110);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(101, 15);
            this.label27.TabIndex = 23;
            this.label27.Text = "Tamaño imagen:";
            // 
            // cmbImagenLargo
            // 
            this.cmbImagenLargo.Location = new System.Drawing.Point(228, 106);
            this.cmbImagenLargo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cmbImagenLargo.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cmbImagenLargo.Name = "cmbImagenLargo";
            this.cmbImagenLargo.Size = new System.Drawing.Size(61, 24);
            this.cmbImagenLargo.TabIndex = 6;
            this.cmbImagenLargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbImagenLargo.Value = new decimal(new int[] {
            320,
            0,
            0,
            0});
            // 
            // cmbImagenAlto
            // 
            this.cmbImagenAlto.Location = new System.Drawing.Point(145, 106);
            this.cmbImagenAlto.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cmbImagenAlto.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cmbImagenAlto.Name = "cmbImagenAlto";
            this.cmbImagenAlto.Size = new System.Drawing.Size(60, 24);
            this.cmbImagenAlto.TabIndex = 5;
            this.cmbImagenAlto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbImagenAlto.Value = new decimal(new int[] {
            320,
            0,
            0,
            0});
            // 
            // rdbImagenesNo
            // 
            this.rdbImagenesNo.AutoSize = true;
            this.rdbImagenesNo.Checked = true;
            this.rdbImagenesNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbImagenesNo.Location = new System.Drawing.Point(228, 24);
            this.rdbImagenesNo.Name = "rdbImagenesNo";
            this.rdbImagenesNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbImagenesNo.Size = new System.Drawing.Size(44, 20);
            this.rdbImagenesNo.TabIndex = 2;
            this.rdbImagenesNo.TabStop = true;
            this.rdbImagenesNo.Text = "No";
            this.rdbImagenesNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbImagenesNo.UseVisualStyleBackColor = true;
            this.rdbImagenesNo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdbImagenesSi
            // 
            this.rdbImagenesSi.AutoSize = true;
            this.rdbImagenesSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbImagenesSi.Location = new System.Drawing.Point(163, 24);
            this.rdbImagenesSi.Name = "rdbImagenesSi";
            this.rdbImagenesSi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbImagenesSi.Size = new System.Drawing.Size(38, 20);
            this.rdbImagenesSi.TabIndex = 1;
            this.rdbImagenesSi.Text = "Sí";
            this.rdbImagenesSi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbImagenesSi.UseVisualStyleBackColor = true;
            this.rdbImagenesSi.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(155, 15);
            this.label16.TabIndex = 3;
            this.label16.Text = "¿Quiere utilizar imágenes?";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(11, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "*Solo formato JPG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Elija la carpeta contenedora";
            // 
            // txtRutaImagenes
            // 
            this.txtRutaImagenes.BackColor = System.Drawing.SystemColors.Info;
            this.txtRutaImagenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaImagenes.Location = new System.Drawing.Point(6, 80);
            this.txtRutaImagenes.Name = "txtRutaImagenes";
            this.txtRutaImagenes.ReadOnly = true;
            this.txtRutaImagenes.Size = new System.Drawing.Size(246, 21);
            this.txtRutaImagenes.TabIndex = 4;
            // 
            // btnBuscarImagenes
            // 
            this.btnBuscarImagenes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarImagenes.Enabled = false;
            this.btnBuscarImagenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarImagenes.Location = new System.Drawing.Point(261, 78);
            this.btnBuscarImagenes.Name = "btnBuscarImagenes";
            this.btnBuscarImagenes.Size = new System.Drawing.Size(41, 23);
            this.btnBuscarImagenes.TabIndex = 3;
            this.btnBuscarImagenes.Text = "...";
            this.btnBuscarImagenes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarImagenes.UseVisualStyleBackColor = true;
            this.btnBuscarImagenes.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label35);
            this.groupBox7.Controls.Add(this.cmbRetrasoMostrarTarget);
            this.groupBox7.Controls.Add(this.label34);
            this.groupBox7.Controls.Add(this.label33);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.cmbTiempoVisualizacionTarget);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.cmbTiempoPresentarImagen);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.cmbTiempoVisualizacionFeedback);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(674, 156);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(190, 294);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Retardos";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(138, 67);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(40, 18);
            this.label35.TabIndex = 29;
            this.label35.Text = "seg.";
            // 
            // cmbRetrasoMostrarTarget
            // 
            this.cmbRetrasoMostrarTarget.DecimalPlaces = 2;
            this.cmbRetrasoMostrarTarget.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.cmbRetrasoMostrarTarget.Location = new System.Drawing.Point(58, 61);
            this.cmbRetrasoMostrarTarget.Name = "cmbRetrasoMostrarTarget";
            this.cmbRetrasoMostrarTarget.Size = new System.Drawing.Size(73, 24);
            this.cmbRetrasoMostrarTarget.TabIndex = 1;
            this.cmbRetrasoMostrarTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbRetrasoMostrarTarget.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // label34
            // 
            this.label34.AllowDrop = true;
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(15, 43);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(62, 15);
            this.label34.TabIndex = 27;
            this.label34.Text = "el \"target\":";
            // 
            // label33
            // 
            this.label33.AllowDrop = true;
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(14, 28);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(133, 15);
            this.label33.TabIndex = 26;
            this.label33.Text = "Retraso para presentar";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(137, 131);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 18);
            this.label18.TabIndex = 25;
            this.label18.Text = "seg.";
            // 
            // cmbTiempoVisualizacionTarget
            // 
            this.cmbTiempoVisualizacionTarget.DecimalPlaces = 2;
            this.cmbTiempoVisualizacionTarget.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.cmbTiempoVisualizacionTarget.Location = new System.Drawing.Point(58, 129);
            this.cmbTiempoVisualizacionTarget.Name = "cmbTiempoVisualizacionTarget";
            this.cmbTiempoVisualizacionTarget.Size = new System.Drawing.Size(73, 24);
            this.cmbTiempoVisualizacionTarget.TabIndex = 2;
            this.cmbTiempoVisualizacionTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbTiempoVisualizacionTarget.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "del cuadro de \"target\":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 15);
            this.label14.TabIndex = 22;
            this.label14.Text = "Tiempo de visualización ";
            // 
            // label23
            // 
            this.label23.AllowDrop = true;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(15, 240);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(82, 15);
            this.label23.TabIndex = 21;
            this.label23.Text = "de la imagen:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(16, 172);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(146, 15);
            this.label22.TabIndex = 20;
            this.label22.Text = "del cuadro de \"feedback\":";
            // 
            // label21
            // 
            this.label21.AllowDrop = true;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(12, 225);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(139, 15);
            this.label21.TabIndex = 19;
            this.label21.Text = "Tiempo de visualización";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(138, 259);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 18);
            this.label19.TabIndex = 18;
            this.label19.Text = "seg.";
            // 
            // cmbTiempoPresentarImagen
            // 
            this.cmbTiempoPresentarImagen.DecimalPlaces = 2;
            this.cmbTiempoPresentarImagen.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.cmbTiempoPresentarImagen.Location = new System.Drawing.Point(58, 257);
            this.cmbTiempoPresentarImagen.Name = "cmbTiempoPresentarImagen";
            this.cmbTiempoPresentarImagen.Size = new System.Drawing.Size(73, 24);
            this.cmbTiempoPresentarImagen.TabIndex = 4;
            this.cmbTiempoPresentarImagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbTiempoPresentarImagen.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(138, 192);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 18);
            this.label15.TabIndex = 4;
            this.label15.Text = "seg.";
            // 
            // cmbTiempoVisualizacionFeedback
            // 
            this.cmbTiempoVisualizacionFeedback.DecimalPlaces = 2;
            this.cmbTiempoVisualizacionFeedback.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.cmbTiempoVisualizacionFeedback.Location = new System.Drawing.Point(58, 190);
            this.cmbTiempoVisualizacionFeedback.Name = "cmbTiempoVisualizacionFeedback";
            this.cmbTiempoVisualizacionFeedback.Size = new System.Drawing.Size(73, 24);
            this.cmbTiempoVisualizacionFeedback.TabIndex = 3;
            this.cmbTiempoVisualizacionFeedback.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbTiempoVisualizacionFeedback.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tiempo de visualización ";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtInstrucciones);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(12, 105);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(288, 98);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Instrucciones p/ el usuario";
            // 
            // txtInstrucciones
            // 
            this.txtInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstrucciones.Location = new System.Drawing.Point(6, 19);
            this.txtInstrucciones.Multiline = true;
            this.txtInstrucciones.Name = "txtInstrucciones";
            this.txtInstrucciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInstrucciones.Size = new System.Drawing.Size(276, 60);
            this.txtInstrucciones.TabIndex = 3;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtMensajeFinExperimento);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(11, 209);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(288, 85);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Mensaje al final de la condición";
            // 
            // txtMensajeFinExperimento
            // 
            this.txtMensajeFinExperimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensajeFinExperimento.Location = new System.Drawing.Point(6, 19);
            this.txtMensajeFinExperimento.Multiline = true;
            this.txtMensajeFinExperimento.Name = "txtMensajeFinExperimento";
            this.txtMensajeFinExperimento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMensajeFinExperimento.Size = new System.Drawing.Size(276, 50);
            this.txtMensajeFinExperimento.TabIndex = 4;
            // 
            // lblArchivoConfiguracion
            // 
            this.lblArchivoConfiguracion.AutoSize = true;
            this.lblArchivoConfiguracion.Location = new System.Drawing.Point(11, 565);
            this.lblArchivoConfiguracion.Name = "lblArchivoConfiguracion";
            this.lblArchivoConfiguracion.Size = new System.Drawing.Size(78, 13);
            this.lblArchivoConfiguracion.TabIndex = 22;
            this.lblArchivoConfiguracion.Text = "Archivo actual:";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.chkRecompensa);
            this.groupBox10.Controls.Add(this.label36);
            this.groupBox10.Controls.Add(this.cmbPuntosRecompensa);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(316, 217);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(309, 56);
            this.groupBox10.TabIndex = 23;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Recompensa";
            // 
            // chkRecompensa
            // 
            this.chkRecompensa.AutoSize = true;
            this.chkRecompensa.Location = new System.Drawing.Point(233, 23);
            this.chkRecompensa.Name = "chkRecompensa";
            this.chkRecompensa.Size = new System.Drawing.Size(66, 17);
            this.chkRecompensa.TabIndex = 25;
            this.chkRecompensa.Text = "Activar";
            this.chkRecompensa.UseVisualStyleBackColor = true;
            this.chkRecompensa.CheckedChanged += new System.EventHandler(this.ChkRecompensa_CheckedChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(13, 24);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(93, 15);
            this.label36.TabIndex = 24;
            this.label36.Text = "Puntos al inicio:";
            // 
            // cmbPuntosRecompensa
            // 
            this.cmbPuntosRecompensa.Location = new System.Drawing.Point(112, 22);
            this.cmbPuntosRecompensa.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cmbPuntosRecompensa.Name = "cmbPuntosRecompensa";
            this.cmbPuntosRecompensa.Size = new System.Drawing.Size(97, 20);
            this.cmbPuntosRecompensa.TabIndex = 6;
            this.cmbPuntosRecompensa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbPuntosRecompensa.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label38);
            this.groupBox11.Controls.Add(this.chkEnsayo);
            this.groupBox11.Controls.Add(this.label37);
            this.groupBox11.Controls.Add(this.cmbTiempoEnsayo);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.Location = new System.Drawing.Point(316, 279);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(309, 56);
            this.groupBox11.TabIndex = 24;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Tiempo por c/Ensayo";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(150, 25);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(31, 13);
            this.label38.TabIndex = 26;
            this.label38.Text = "seg.";
            // 
            // chkEnsayo
            // 
            this.chkEnsayo.AutoSize = true;
            this.chkEnsayo.Location = new System.Drawing.Point(232, 25);
            this.chkEnsayo.Name = "chkEnsayo";
            this.chkEnsayo.Size = new System.Drawing.Size(66, 17);
            this.chkEnsayo.TabIndex = 25;
            this.chkEnsayo.Text = "Activar";
            this.chkEnsayo.UseVisualStyleBackColor = true;
            this.chkEnsayo.CheckedChanged += new System.EventHandler(this.ChkEnsayo_CheckedChanged);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(13, 24);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(52, 15);
            this.label37.TabIndex = 24;
            this.label37.Text = "Tiempo:";
            // 
            // cmbTiempoEnsayo
            // 
            this.cmbTiempoEnsayo.DecimalPlaces = 2;
            this.cmbTiempoEnsayo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.cmbTiempoEnsayo.Location = new System.Drawing.Point(73, 22);
            this.cmbTiempoEnsayo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cmbTiempoEnsayo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.cmbTiempoEnsayo.Name = "cmbTiempoEnsayo";
            this.cmbTiempoEnsayo.Size = new System.Drawing.Size(75, 20);
            this.cmbTiempoEnsayo.TabIndex = 6;
            this.cmbTiempoEnsayo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbTiempoEnsayo.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(875, 597);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.lblArchivoConfiguracion);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbNumRepeticiones);
            this.Controls.Add(this.cmbTipoPruebas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prismas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbNumRepeticiones)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYMin)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbXMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbXMin)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEscolaridad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEdad)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagenLargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagenAlto)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRetrasoMostrarTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTiempoVisualizacionTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTiempoPresentarImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTiempoVisualizacionFeedback)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPuntosRecompensa)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTiempoEnsayo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown cmbNumRepeticiones;
        private System.Windows.Forms.ComboBox cmbPuertos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cmbTipoPruebas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown cmbYMax;
        private System.Windows.Forms.NumericUpDown cmbYMin;
        private System.Windows.Forms.NumericUpDown cmbXMax;
        private System.Windows.Forms.NumericUpDown cmbXMin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtRutaImagenes;
        private System.Windows.Forms.Button btnBuscarImagenes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FolderBrowserDialog dlCarpeta;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown cmbTiempoVisualizacionFeedback;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rdbImagenesNo;
        private System.Windows.Forms.RadioButton rdbImagenesSi;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ToolStripMenuItem configuracionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarConfiguraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarConfiguraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtInstrucciones;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txtMensajeFinExperimento;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown cmbTiempoPresentarImagen;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.Label lblArchivoConfiguracion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ToolStripMenuItem nuevaConfiguraciónToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown cmbTiempoVisualizacionTarget;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown cmbEdad;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown cmbImagenLargo;
        private System.Windows.Forms.NumericUpDown cmbImagenAlto;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.NumericUpDown cmbEscolaridad;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.NumericUpDown cmbRetrasoMostrarTarget;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.NumericUpDown cmbPuntosRecompensa;
        private System.Windows.Forms.CheckBox chkRecompensa;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.CheckBox chkEnsayo;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.NumericUpDown cmbTiempoEnsayo;
        protected internal System.Windows.Forms.Label label27;
        private System.Windows.Forms.CheckBox chkImagenAleatorias;
        private System.Windows.Forms.CheckBox chkImagenCentrada;
    }
}

