namespace controldeexperimento
{
    partial class frmPanelExperimento
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPanelExperimento));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnTarget = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.listaImagenes = new System.Windows.Forms.ListBox();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.lblRecompensa = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTiempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(367, 602);
            this.listBox1.TabIndex = 1;
            this.listBox1.Visible = false;
            // 
            // btnTarget
            // 
            this.btnTarget.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnTarget.BackColor = System.Drawing.Color.Black;
            this.btnTarget.Enabled = false;
            this.btnTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarget.Location = new System.Drawing.Point(819, 67);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(20, 20);
            this.btnTarget.TabIndex = 3;
            this.btnTarget.UseVisualStyleBackColor = false;
            this.btnTarget.Visible = false;
            // 
            // listaImagenes
            // 
            this.listaImagenes.Enabled = false;
            this.listaImagenes.FormattingEnabled = true;
            this.listaImagenes.Location = new System.Drawing.Point(385, 12);
            this.listaImagenes.Name = "listaImagenes";
            this.listaImagenes.Size = new System.Drawing.Size(361, 602);
            this.listaImagenes.Sorted = true;
            this.listaImagenes.TabIndex = 6;
            this.listaImagenes.Visible = false;
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AllowDrop = true;
            this.lblInstrucciones.BackColor = System.Drawing.Color.DimGray;
            this.lblInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucciones.ForeColor = System.Drawing.SystemColors.Info;
            this.lblInstrucciones.Location = new System.Drawing.Point(370, 226);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(655, 290);
            this.lblInstrucciones.TabIndex = 7;
            this.lblInstrucciones.Text = "¡Las instrucciones se mostrarán aquí!";
            this.lblInstrucciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecompensa
            // 
            this.lblRecompensa.AllowDrop = true;
            this.lblRecompensa.BackColor = System.Drawing.Color.DimGray;
            this.lblRecompensa.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecompensa.ForeColor = System.Drawing.SystemColors.Info;
            this.lblRecompensa.Location = new System.Drawing.Point(539, 516);
            this.lblRecompensa.Name = "lblRecompensa";
            this.lblRecompensa.Size = new System.Drawing.Size(234, 57);
            this.lblRecompensa.TabIndex = 8;
            this.lblRecompensa.Text = "PUNTOS";
            this.lblRecompensa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblRecompensa.Click += new System.EventHandler(this.LblRecompensa_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AllowDrop = true;
            this.lblTiempo.BackColor = System.Drawing.Color.DimGray;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTiempo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTiempo.Location = new System.Drawing.Point(797, 129);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(332, 57);
            this.lblTiempo.TabIndex = 9;
            this.lblTiempo.Text = "tiempo";
            this.lblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTiempo.Visible = false;
            this.lblTiempo.Click += new System.EventHandler(this.LblTiempo_Click);
            // 
            // frmPanelExperimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1284, 741);
            this.Controls.Add(this.lblRecompensa);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblInstrucciones);
            this.Controls.Add(this.listaImagenes);
            this.Controls.Add(this.btnTarget);
            this.Controls.Add(this.listBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPanelExperimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Experimento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnTarget;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox listaImagenes;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.Label lblRecompensa;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTiempo;
    }
}