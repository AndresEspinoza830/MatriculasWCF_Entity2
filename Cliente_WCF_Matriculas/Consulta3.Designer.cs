namespace Cliente_WCF_Matriculas
{
    partial class Consulta3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtVacantes = new System.Windows.Forms.TextBox();
            this.dtgResultados = new System.Windows.Forms.DataGridView();
            this.Id_bloque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip_Bloque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vacantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_matriculados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la cantidad minima de vacantes:";
            // 
            // txtVacantes
            // 
            this.txtVacantes.Location = new System.Drawing.Point(296, 39);
            this.txtVacantes.MaxLength = 2;
            this.txtVacantes.Name = "txtVacantes";
            this.txtVacantes.Size = new System.Drawing.Size(100, 20);
            this.txtVacantes.TabIndex = 1;
            this.txtVacantes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVacantes_KeyPress);
            // 
            // dtgResultados
            // 
            this.dtgResultados.AllowUserToAddRows = false;
            this.dtgResultados.AllowUserToDeleteRows = false;
            this.dtgResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgResultados.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtgResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_bloque,
            this.Descripcion_Curso,
            this.Nombre_Profesor,
            this.Horario,
            this.Tip_Bloque,
            this.Vacantes,
            this.Total_matriculados,
            this.Estado});
            this.dtgResultados.Location = new System.Drawing.Point(47, 89);
            this.dtgResultados.Name = "dtgResultados";
            this.dtgResultados.ReadOnly = true;
            this.dtgResultados.RowHeadersVisible = false;
            this.dtgResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgResultados.Size = new System.Drawing.Size(947, 327);
            this.dtgResultados.TabIndex = 2;
            // 
            // Id_bloque
            // 
            this.Id_bloque.DataPropertyName = "Id_bloque";
            this.Id_bloque.HeaderText = "ID";
            this.Id_bloque.Name = "Id_bloque";
            this.Id_bloque.ReadOnly = true;
            // 
            // Descripcion_Curso
            // 
            this.Descripcion_Curso.DataPropertyName = "Descripcion";
            this.Descripcion_Curso.HeaderText = "Descripcion";
            this.Descripcion_Curso.Name = "Descripcion_Curso";
            this.Descripcion_Curso.ReadOnly = true;
            // 
            // Nombre_Profesor
            // 
            this.Nombre_Profesor.DataPropertyName = "Nombre_Profesor";
            this.Nombre_Profesor.HeaderText = "Nombre profe";
            this.Nombre_Profesor.Name = "Nombre_Profesor";
            this.Nombre_Profesor.ReadOnly = true;
            // 
            // Horario
            // 
            this.Horario.DataPropertyName = "Horario";
            this.Horario.HeaderText = "Horario";
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            // 
            // Tip_Bloque
            // 
            this.Tip_Bloque.DataPropertyName = "Tip_Bloque";
            this.Tip_Bloque.HeaderText = "Tipo Bloque";
            this.Tip_Bloque.Name = "Tip_Bloque";
            this.Tip_Bloque.ReadOnly = true;
            // 
            // Vacantes
            // 
            this.Vacantes.DataPropertyName = "Vacantes";
            this.Vacantes.HeaderText = "Vacantes";
            this.Vacantes.Name = "Vacantes";
            this.Vacantes.ReadOnly = true;
            // 
            // Total_matriculados
            // 
            this.Total_matriculados.DataPropertyName = "Total_matriculados";
            this.Total_matriculados.HeaderText = "Total matriculas";
            this.Total_matriculados.Name = "Total_matriculados";
            this.Total_matriculados.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(839, 36);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(101, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(909, 432);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Consulta3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 479);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dtgResultados);
            this.Controls.Add(this.txtVacantes);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Consulta3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarVacantesBloques";
            this.Load += new System.EventHandler(this.Consulta3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVacantes;
        private System.Windows.Forms.DataGridView dtgResultados;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_bloque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip_Bloque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vacantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_matriculados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}