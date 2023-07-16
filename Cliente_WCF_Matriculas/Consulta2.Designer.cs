namespace Cliente_WCF_Matriculas
{
    partial class Consulta2
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
            this.dtpFecInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgResultados = new System.Windows.Forms.DataGridView();
            this.Nom_alum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ape_Alum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni_alum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_alum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Des_semestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel_alum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_alum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecInicio
            // 
            this.dtpFecInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecInicio.Location = new System.Drawing.Point(152, 31);
            this.dtpFecInicio.Name = "dtpFecInicio";
            this.dtpFecInicio.Size = new System.Drawing.Size(104, 20);
            this.dtpFecInicio.TabIndex = 0;
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecFin.Location = new System.Drawing.Point(426, 32);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(98, 20);
            this.dtpFecFin.TabIndex = 1;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(1030, 33);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Fin:";
            // 
            // dtgResultados
            // 
            this.dtgResultados.AllowUserToAddRows = false;
            this.dtgResultados.AllowUserToDeleteRows = false;
            this.dtgResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom_alum,
            this.Ape_Alum,
            this.Dni_alum,
            this.Email_alum,
            this.Estado,
            this.Nom_carrera,
            this.Des_semestre,
            this.Tel_alum,
            this.Dir_alum});
            this.dtgResultados.Location = new System.Drawing.Point(57, 74);
            this.dtgResultados.Name = "dtgResultados";
            this.dtgResultados.ReadOnly = true;
            this.dtgResultados.RowHeadersVisible = false;
            this.dtgResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgResultados.Size = new System.Drawing.Size(1162, 394);
            this.dtgResultados.TabIndex = 5;
            // 
            // Nom_alum
            // 
            this.Nom_alum.DataPropertyName = "Nom_alum";
            this.Nom_alum.HeaderText = "Nombre";
            this.Nom_alum.Name = "Nom_alum";
            this.Nom_alum.ReadOnly = true;
            // 
            // Ape_Alum
            // 
            this.Ape_Alum.DataPropertyName = "Ape_Alum";
            this.Ape_Alum.HeaderText = "Apellido";
            this.Ape_Alum.Name = "Ape_Alum";
            this.Ape_Alum.ReadOnly = true;
            // 
            // Dni_alum
            // 
            this.Dni_alum.DataPropertyName = "Dni_alum";
            this.Dni_alum.HeaderText = "DNI";
            this.Dni_alum.Name = "Dni_alum";
            this.Dni_alum.ReadOnly = true;
            // 
            // Email_alum
            // 
            this.Email_alum.DataPropertyName = "Email_alum";
            this.Email_alum.HeaderText = "Email";
            this.Email_alum.Name = "Email_alum";
            this.Email_alum.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Nom_carrera
            // 
            this.Nom_carrera.DataPropertyName = "Nom_carrera";
            this.Nom_carrera.HeaderText = "Carrera";
            this.Nom_carrera.Name = "Nom_carrera";
            this.Nom_carrera.ReadOnly = true;
            // 
            // Des_semestre
            // 
            this.Des_semestre.DataPropertyName = "Des_semestre";
            this.Des_semestre.HeaderText = "Semestre";
            this.Des_semestre.Name = "Des_semestre";
            this.Des_semestre.ReadOnly = true;
            // 
            // Tel_alum
            // 
            this.Tel_alum.DataPropertyName = "Tel_alum";
            this.Tel_alum.HeaderText = "Telefono";
            this.Tel_alum.Name = "Tel_alum";
            this.Tel_alum.ReadOnly = true;
            // 
            // Dir_alum
            // 
            this.Dir_alum.DataPropertyName = "Dir_alum";
            this.Dir_alum.HeaderText = "Direccion";
            this.Dir_alum.Name = "Dir_alum";
            this.Dir_alum.ReadOnly = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1128, 491);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Consulta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 543);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtgResultados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dtpFecFin);
            this.Controls.Add(this.dtpFecInicio);
            this.Name = "Consulta2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarMatriculadosFechas";
            this.Load += new System.EventHandler(this.Consulta2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecInicio;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_alum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ape_Alum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni_alum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_alum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Des_semestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel_alum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_alum;
        private System.Windows.Forms.Button btnCancelar;
    }
}