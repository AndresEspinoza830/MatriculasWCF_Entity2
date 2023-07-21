namespace Cliente_WCF_Matriculas
{
    partial class Consulta4
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.dtgResultados = new System.Windows.Forms.DataGridView();
            this.Id_alum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto_alum = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nom_alum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ape_alum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_alum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la carrera";
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
            // cmbCarrera
            // 
            this.cmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(230, 41);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(167, 21);
            this.cmbCarrera.TabIndex = 9;
            // 
            // dtgResultados
            // 
            this.dtgResultados.AllowUserToAddRows = false;
            this.dtgResultados.AllowUserToDeleteRows = false;
            this.dtgResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_alum,
            this.Carrera,
            this.Semestre,
            this.Foto_alum,
            this.Nom_alum,
            this.Ape_alum,
            this.Distrito,
            this.Email_alum,
            this.Estado});
            this.dtgResultados.Location = new System.Drawing.Point(34, 88);
            this.dtgResultados.Name = "dtgResultados";
            this.dtgResultados.ReadOnly = true;
            this.dtgResultados.RowHeadersVisible = false;
            this.dtgResultados.RowTemplate.Height = 25;
            this.dtgResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgResultados.Size = new System.Drawing.Size(980, 320);
            this.dtgResultados.TabIndex = 10;
            // 
            // Id_alum
            // 
            this.Id_alum.DataPropertyName = "Id_alum";
            this.Id_alum.HeaderText = "ID";
            this.Id_alum.Name = "Id_alum";
            this.Id_alum.ReadOnly = true;
            this.Id_alum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id_alum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Carrera
            // 
            this.Carrera.DataPropertyName = "Nom_carrera";
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            this.Carrera.ReadOnly = true;
            // 
            // Semestre
            // 
            this.Semestre.DataPropertyName = "Des_semestre";
            this.Semestre.HeaderText = "Semestre";
            this.Semestre.Name = "Semestre";
            this.Semestre.ReadOnly = true;
            // 
            // Foto_alum
            // 
            this.Foto_alum.DataPropertyName = "Foto_alum";
            this.Foto_alum.HeaderText = "Foto";
            this.Foto_alum.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Foto_alum.Name = "Foto_alum";
            this.Foto_alum.ReadOnly = true;
            this.Foto_alum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Foto_alum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Nom_alum
            // 
            this.Nom_alum.DataPropertyName = "Nom_alum";
            this.Nom_alum.HeaderText = "Nombre";
            this.Nom_alum.Name = "Nom_alum";
            this.Nom_alum.ReadOnly = true;
            // 
            // Ape_alum
            // 
            this.Ape_alum.DataPropertyName = "Ape_alum";
            this.Ape_alum.HeaderText = "Apellido";
            this.Ape_alum.Name = "Ape_alum";
            this.Ape_alum.ReadOnly = true;
            // 
            // Distrito
            // 
            this.Distrito.DataPropertyName = "Distrito";
            this.Distrito.HeaderText = "Distrito";
            this.Distrito.Name = "Distrito";
            this.Distrito.ReadOnly = true;
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
            // Consulta4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 479);
            this.Controls.Add(this.dtgResultados);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Consulta4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarVacantesBloques";
            this.Load += new System.EventHandler(this.Consulta4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.DataGridView dtgResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_alum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semestre;
        private System.Windows.Forms.DataGridViewImageColumn Foto_alum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_alum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ape_alum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_alum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}