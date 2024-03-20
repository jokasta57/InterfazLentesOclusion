namespace controldeexperimento
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConfiguraciones = new System.Windows.Forms.Button();
            this.btnExperimentoIndividual = new System.Windows.Forms.Button();
            this.btnExperimentoGral = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConfiguraciones);
            this.groupBox1.Controls.Add(this.btnExperimentoIndividual);
            this.groupBox1.Controls.Add(this.btnExperimentoGral);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 475);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones:";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // btnConfiguraciones
            // 
            this.btnConfiguraciones.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnConfiguraciones.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguraciones.Location = new System.Drawing.Point(9, 182);
            this.btnConfiguraciones.Name = "btnConfiguraciones";
            this.btnConfiguraciones.Size = new System.Drawing.Size(141, 113);
            this.btnConfiguraciones.TabIndex = 2;
            this.btnConfiguraciones.Text = "Configurar condiciones";
            this.btnConfiguraciones.UseVisualStyleBackColor = false;
            this.btnConfiguraciones.Click += new System.EventHandler(this.BtnConfiguraciones_Click);
            // 
            // btnExperimentoIndividual
            // 
            this.btnExperimentoIndividual.BackColor = System.Drawing.SystemColors.Info;
            this.btnExperimentoIndividual.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExperimentoIndividual.Location = new System.Drawing.Point(9, 315);
            this.btnExperimentoIndividual.Name = "btnExperimentoIndividual";
            this.btnExperimentoIndividual.Size = new System.Drawing.Size(141, 113);
            this.btnExperimentoIndividual.TabIndex = 3;
            this.btnExperimentoIndividual.Text = "Ejecutar condición individual";
            this.btnExperimentoIndividual.UseVisualStyleBackColor = false;
            this.btnExperimentoIndividual.Click += new System.EventHandler(this.BtnExperimentoIndividuak_Click);
            // 
            // btnExperimentoGral
            // 
            this.btnExperimentoGral.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExperimentoGral.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExperimentoGral.Location = new System.Drawing.Point(9, 51);
            this.btnExperimentoGral.Name = "btnExperimentoGral";
            this.btnExperimentoGral.Size = new System.Drawing.Size(141, 113);
            this.btnExperimentoGral.TabIndex = 1;
            this.btnExperimentoGral.Text = "Experimento";
            this.btnExperimentoGral.UseVisualStyleBackColor = false;
            this.btnExperimentoGral.Click += new System.EventHandler(this.BtnExperimentoGral_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Lavender;
            this.panelContenedor.BackgroundImage = global::controldeexperimento.Properties.Resources.unam_logo;
            this.panelContenedor.Location = new System.Drawing.Point(180, 12);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(968, 617);
            this.panelContenedor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 632);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = " © Laboratorio de Neurociencias Cognitivas - Universidad Nacional Autónoma de Méx" +
    "ico";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 652);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prismas v5.0";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExperimentoIndividual;
        private System.Windows.Forms.Button btnExperimentoGral;
        private System.Windows.Forms.Button btnConfiguraciones;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label label1;
    }
}