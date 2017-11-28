namespace MetodosDeTransporte
{
    partial class FormMenu
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
            this.btnCrearMatriz = new System.Windows.Forms.Button();
            this.gbDatosMatriz = new System.Windows.Forms.GroupBox();
            this.txtNumeroDestinos = new System.Windows.Forms.TextBox();
            this.lblNumeroDestinos = new System.Windows.Forms.Label();
            this.txtNumeroOrigenes = new System.Windows.Forms.TextBox();
            this.lblNumeroOrigenes = new System.Windows.Forms.Label();
            this.gbDatosMatriz.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrearMatriz
            // 
            this.btnCrearMatriz.Location = new System.Drawing.Point(237, 232);
            this.btnCrearMatriz.Name = "btnCrearMatriz";
            this.btnCrearMatriz.Size = new System.Drawing.Size(75, 23);
            this.btnCrearMatriz.TabIndex = 0;
            this.btnCrearMatriz.TabStop = false;
            this.btnCrearMatriz.Text = "Crear Tabla";
            this.btnCrearMatriz.UseVisualStyleBackColor = true;
            this.btnCrearMatriz.Click += new System.EventHandler(this.btnCrearMatriz_Click);
            // 
            // gbDatosMatriz
            // 
            this.gbDatosMatriz.Controls.Add(this.txtNumeroDestinos);
            this.gbDatosMatriz.Controls.Add(this.lblNumeroDestinos);
            this.gbDatosMatriz.Controls.Add(this.txtNumeroOrigenes);
            this.gbDatosMatriz.Controls.Add(this.lblNumeroOrigenes);
            this.gbDatosMatriz.Location = new System.Drawing.Point(12, 155);
            this.gbDatosMatriz.Name = "gbDatosMatriz";
            this.gbDatosMatriz.Size = new System.Drawing.Size(300, 71);
            this.gbDatosMatriz.TabIndex = 2;
            this.gbDatosMatriz.TabStop = false;
            this.gbDatosMatriz.Text = "Datos de tabla";
            // 
            // txtNumeroDestinos
            // 
            this.txtNumeroDestinos.Location = new System.Drawing.Point(146, 45);
            this.txtNumeroDestinos.Name = "txtNumeroDestinos";
            this.txtNumeroDestinos.Size = new System.Drawing.Size(148, 20);
            this.txtNumeroDestinos.TabIndex = 4;
            // 
            // lblNumeroDestinos
            // 
            this.lblNumeroDestinos.AutoSize = true;
            this.lblNumeroDestinos.Location = new System.Drawing.Point(34, 45);
            this.lblNumeroDestinos.Name = "lblNumeroDestinos";
            this.lblNumeroDestinos.Size = new System.Drawing.Size(106, 13);
            this.lblNumeroDestinos.TabIndex = 3;
            this.lblNumeroDestinos.Text = "Número de Destinos:";
            // 
            // txtNumeroOrigenes
            // 
            this.txtNumeroOrigenes.Location = new System.Drawing.Point(146, 19);
            this.txtNumeroOrigenes.Name = "txtNumeroOrigenes";
            this.txtNumeroOrigenes.Size = new System.Drawing.Size(148, 20);
            this.txtNumeroOrigenes.TabIndex = 2;
            // 
            // lblNumeroOrigenes
            // 
            this.lblNumeroOrigenes.AutoSize = true;
            this.lblNumeroOrigenes.Location = new System.Drawing.Point(31, 22);
            this.lblNumeroOrigenes.Name = "lblNumeroOrigenes";
            this.lblNumeroOrigenes.Size = new System.Drawing.Size(109, 13);
            this.lblNumeroOrigenes.TabIndex = 0;
            this.lblNumeroOrigenes.Text = "Número de Orígenes:";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 267);
            this.Controls.Add(this.gbDatosMatriz);
            this.Controls.Add(this.btnCrearMatriz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Métodos de Transporte";
            this.gbDatosMatriz.ResumeLayout(false);
            this.gbDatosMatriz.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearMatriz;
        private System.Windows.Forms.GroupBox gbDatosMatriz;
        private System.Windows.Forms.TextBox txtNumeroDestinos;
        private System.Windows.Forms.Label lblNumeroDestinos;
        private System.Windows.Forms.TextBox txtNumeroOrigenes;
        private System.Windows.Forms.Label lblNumeroOrigenes;
    }
}

