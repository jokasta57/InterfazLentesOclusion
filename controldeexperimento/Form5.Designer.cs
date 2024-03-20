namespace controldeexperimento
{
    partial class frmDatosPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosPaciente));
            this.btnIniciarExperimento = new System.Windows.Forms.Button();
            this.btnCancelarExperimento = new System.Windows.Forms.Button();
            this.txtRutaExperimento = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMedicamentos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTipoDeVision = new System.Windows.Forms.ComboBox();
            this.txtCrisisAnsiedad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDesordenNeuronal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbDiestro = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEscolaridad = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEdad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEscolaridad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciarExperimento
            // 
            this.btnIniciarExperimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarExperimento.Location = new System.Drawing.Point(378, 368);
            this.btnIniciarExperimento.Name = "btnIniciarExperimento";
            this.btnIniciarExperimento.Size = new System.Drawing.Size(84, 52);
            this.btnIniciarExperimento.TabIndex = 6;
            this.btnIniciarExperimento.Text = "&Iniciar";
            this.btnIniciarExperimento.UseVisualStyleBackColor = true;
            this.btnIniciarExperimento.Click += new System.EventHandler(this.BtnIniciarExperimento_Click);
            // 
            // btnCancelarExperimento
            // 
            this.btnCancelarExperimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarExperimento.Location = new System.Drawing.Point(288, 368);
            this.btnCancelarExperimento.Name = "btnCancelarExperimento";
            this.btnCancelarExperimento.Size = new System.Drawing.Size(84, 52);
            this.btnCancelarExperimento.TabIndex = 7;
            this.btnCancelarExperimento.Text = "Can&celar";
            this.btnCancelarExperimento.UseVisualStyleBackColor = true;
            this.btnCancelarExperimento.Click += new System.EventHandler(this.BtnCancelarExperimento_Click);
            // 
            // txtRutaExperimento
            // 
            this.txtRutaExperimento.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtRutaExperimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRutaExperimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaExperimento.Location = new System.Drawing.Point(13, 426);
            this.txtRutaExperimento.Multiline = true;
            this.txtRutaExperimento.Name = "txtRutaExperimento";
            this.txtRutaExperimento.Size = new System.Drawing.Size(461, 27);
            this.txtRutaExperimento.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMedicamentos);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbTipoDeVision);
            this.groupBox1.Controls.Add(this.txtCrisisAnsiedad);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDesordenNeuronal);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbDiestro);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbEscolaridad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbSexo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbEdad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 353);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INSTRUCCIONES: Introduzca la información solicitada ( *  campos obligatorios):";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 15);
            this.label6.TabIndex = 52;
            this.label6.Text = "Tipo de visión:";
            // 
            // txtMedicamentos
            // 
            this.txtMedicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicamentos.Location = new System.Drawing.Point(134, 310);
            this.txtMedicamentos.Multiline = true;
            this.txtMedicamentos.Name = "txtMedicamentos";
            this.txtMedicamentos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMedicamentos.Size = new System.Drawing.Size(298, 34);
            this.txtMedicamentos.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 24);
            this.label10.TabIndex = 50;
            this.label10.Text = "Medicamentos:";
            this.label10.UseCompatibleTextRendering = true;
            // 
            // cmbTipoDeVision
            // 
            this.cmbTipoDeVision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDeVision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoDeVision.FormattingEnabled = true;
            this.cmbTipoDeVision.Items.AddRange(new object[] {
            "Normal",
            "Corregida"});
            this.cmbTipoDeVision.Location = new System.Drawing.Point(133, 198);
            this.cmbTipoDeVision.Name = "cmbTipoDeVision";
            this.cmbTipoDeVision.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbTipoDeVision.Size = new System.Drawing.Size(132, 23);
            this.cmbTipoDeVision.TabIndex = 6;
            // 
            // txtCrisisAnsiedad
            // 
            this.txtCrisisAnsiedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrisisAnsiedad.Location = new System.Drawing.Point(134, 272);
            this.txtCrisisAnsiedad.Multiline = true;
            this.txtCrisisAnsiedad.Name = "txtCrisisAnsiedad";
            this.txtCrisisAnsiedad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCrisisAnsiedad.Size = new System.Drawing.Size(298, 34);
            this.txtCrisisAnsiedad.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 24);
            this.label9.TabIndex = 47;
            this.label9.Text = "Crisis de ansiedad:";
            this.label9.UseCompatibleTextRendering = true;
            // 
            // txtDesordenNeuronal
            // 
            this.txtDesordenNeuronal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesordenNeuronal.Location = new System.Drawing.Point(134, 232);
            this.txtDesordenNeuronal.Multiline = true;
            this.txtDesordenNeuronal.Name = "txtDesordenNeuronal";
            this.txtDesordenNeuronal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesordenNeuronal.Size = new System.Drawing.Size(298, 34);
            this.txtDesordenNeuronal.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Desorden neuronal:";
            this.label8.UseCompatibleTextRendering = true;
            // 
            // cmbDiestro
            // 
            this.cmbDiestro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiestro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDiestro.FormattingEnabled = true;
            this.cmbDiestro.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cmbDiestro.Location = new System.Drawing.Point(368, 197);
            this.cmbDiestro.Name = "cmbDiestro";
            this.cmbDiestro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbDiestro.Size = new System.Drawing.Size(63, 23);
            this.cmbDiestro.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(294, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 44;
            this.label7.Text = "Diestro:";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // cmbEscolaridad
            // 
            this.cmbEscolaridad.DecimalPlaces = 1;
            this.cmbEscolaridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEscolaridad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.cmbEscolaridad.Location = new System.Drawing.Point(356, 64);
            this.cmbEscolaridad.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.cmbEscolaridad.Name = "cmbEscolaridad";
            this.cmbEscolaridad.Size = new System.Drawing.Size(75, 22);
            this.cmbEscolaridad.TabIndex = 3;
            this.cmbEscolaridad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(199, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "* Escolaridad (años):";
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "MUJER",
            "HOMBRE"});
            this.cmbSexo.Location = new System.Drawing.Point(133, 98);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbSexo.Size = new System.Drawing.Size(299, 23);
            this.cmbSexo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "* Sexo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "* Edad:";
            // 
            // cmbEdad
            // 
            this.cmbEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEdad.Location = new System.Drawing.Point(133, 64);
            this.cmbEdad.Name = "cmbEdad";
            this.cmbEdad.Size = new System.Drawing.Size(55, 22);
            this.cmbEdad.TabIndex = 2;
            this.cmbEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbEdad.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "* Observaciones:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(133, 131);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(298, 53);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(133, 32);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "* Nombre:";
            // 
            // frmDatosPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRutaExperimento);
            this.Controls.Add(this.btnCancelarExperimento);
            this.Controls.Add(this.btnIniciarExperimento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDatosPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Participante";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEscolaridad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIniciarExperimento;
        private System.Windows.Forms.Button btnCancelarExperimento;
        private System.Windows.Forms.TextBox txtRutaExperimento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown cmbEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown cmbEscolaridad;
        private System.Windows.Forms.ComboBox cmbDiestro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDesordenNeuronal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCrisisAnsiedad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbTipoDeVision;
        private System.Windows.Forms.TextBox txtMedicamentos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
    }
}