namespace MetodosDeTransporte
{
    partial class FormGenerarTabla
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCM = new System.Windows.Forms.RadioButton();
            this.radioENO = new System.Windows.Forms.RadioButton();
            this.btnOptimizar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCostoTotal = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labeltotalAsignaciones = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCM);
            this.groupBox1.Controls.Add(this.radioENO);
            this.groupBox1.Location = new System.Drawing.Point(12, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Método de Solución";
            // 
            // radioCM
            // 
            this.radioCM.AutoSize = true;
            this.radioCM.Location = new System.Drawing.Point(6, 42);
            this.radioCM.Name = "radioCM";
            this.radioCM.Size = new System.Drawing.Size(129, 17);
            this.radioCM.TabIndex = 1;
            this.radioCM.Text = "Método Costo Mínimo";
            this.radioCM.UseVisualStyleBackColor = true;
            this.radioCM.CheckedChanged += new System.EventHandler(this.radioCM_CheckedChanged);
            // 
            // radioENO
            // 
            this.radioENO.AutoSize = true;
            this.radioENO.Checked = true;
            this.radioENO.Location = new System.Drawing.Point(6, 19);
            this.radioENO.Name = "radioENO";
            this.radioENO.Size = new System.Drawing.Size(150, 17);
            this.radioENO.TabIndex = 0;
            this.radioENO.TabStop = true;
            this.radioENO.Text = "Método Esquina NorOeste";
            this.radioENO.UseVisualStyleBackColor = true;
            this.radioENO.CheckedChanged += new System.EventHandler(this.radioENO_CheckedChanged);
            // 
            // btnOptimizar
            // 
            this.btnOptimizar.Location = new System.Drawing.Point(700, 437);
            this.btnOptimizar.Name = "btnOptimizar";
            this.btnOptimizar.Size = new System.Drawing.Size(75, 40);
            this.btnOptimizar.TabIndex = 20;
            this.btnOptimizar.Text = "Optimizar";
            this.btnOptimizar.UseVisualStyleBackColor = true;
            this.btnOptimizar.Click += new System.EventHandler(this.btnOptimizar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(781, 437);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 40);
            this.btnRegresar.TabIndex = 21;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Total Costo:";
            // 
            // labelCostoTotal
            // 
            this.labelCostoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCostoTotal.Location = new System.Drawing.Point(280, 457);
            this.labelCostoTotal.Name = "labelCostoTotal";
            this.labelCostoTotal.Size = new System.Drawing.Size(333, 26);
            this.labelCostoTotal.TabIndex = 24;
            this.labelCostoTotal.Text = "C1(X) + C2(X) + C3(X) + C4(X) = Z";
            this.labelCostoTotal.Click += new System.EventHandler(this.labelCostoTotal_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(619, 437);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 40);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Tabla
            // 
            this.Tabla.AllowUserToAddRows = false;
            this.Tabla.AllowUserToDeleteRows = false;
            this.Tabla.AllowUserToResizeRows = false;
            this.Tabla.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Tabla.DefaultCellStyle = dataGridViewCellStyle2;
            this.Tabla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Tabla.Location = new System.Drawing.Point(12, 12);
            this.Tabla.MultiSelect = false;
            this.Tabla.Name = "Tabla";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Tabla.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Tabla.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Tabla.ShowCellErrors = false;
            this.Tabla.ShowCellToolTips = false;
            this.Tabla.ShowEditingIcon = false;
            this.Tabla.ShowRowErrors = false;
            this.Tabla.Size = new System.Drawing.Size(846, 400);
            this.Tabla.TabIndex = 26;
            this.Tabla.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Total Asignaciones: ";
            // 
            // labeltotalAsignaciones
            // 
            this.labeltotalAsignaciones.Location = new System.Drawing.Point(327, 437);
            this.labeltotalAsignaciones.Name = "labeltotalAsignaciones";
            this.labeltotalAsignaciones.Size = new System.Drawing.Size(286, 15);
            this.labeltotalAsignaciones.TabIndex = 28;
            this.labeltotalAsignaciones.Text = "X asignaciones";
            // 
            // FormGenerarTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 500);
            this.Controls.Add(this.labeltotalAsignaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tabla);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.labelCostoTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnOptimizar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormGenerarTabla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tabla de Costos de Envío";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioCM;
        private System.Windows.Forms.RadioButton radioENO;
        private System.Windows.Forms.Button btnOptimizar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCostoTotal;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeltotalAsignaciones;
    }
}