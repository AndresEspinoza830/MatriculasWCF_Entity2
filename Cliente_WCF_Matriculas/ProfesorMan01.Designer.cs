namespace Cliente_WCF_Matriculas
{
    partial class ProfesorMan01
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
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dtgProfe = new System.Windows.Forms.DataGridView();
            this.Id_profe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto_profe = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nom_profe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ape_profe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel_profe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_profe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblRegistros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el filtro por apellido:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(250, 39);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(287, 20);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // dtgProfe
            // 
            this.dtgProfe.AllowUserToAddRows = false;
            this.dtgProfe.AllowUserToDeleteRows = false;
            this.dtgProfe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProfe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProfe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_profe,
            this.Foto_profe,
            this.Nom_profe,
            this.Ape_profe,
            this.Tel_profe,
            this.Email_profe,
            this.Estado,
            this.Distrito});
            this.dtgProfe.Location = new System.Drawing.Point(26, 79);
            this.dtgProfe.Name = "dtgProfe";
            this.dtgProfe.ReadOnly = true;
            this.dtgProfe.RowHeadersVisible = false;
            this.dtgProfe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProfe.Size = new System.Drawing.Size(1063, 282);
            this.dtgProfe.TabIndex = 2;
            // 
            // Id_profe
            // 
            this.Id_profe.DataPropertyName = "Id_profe";
            this.Id_profe.HeaderText = "ID";
            this.Id_profe.Name = "Id_profe";
            this.Id_profe.ReadOnly = true;
            // 
            // Foto_profe
            // 
            this.Foto_profe.DataPropertyName = "Foto_profe";
            this.Foto_profe.HeaderText = "Foto";
            this.Foto_profe.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Foto_profe.Name = "Foto_profe";
            this.Foto_profe.ReadOnly = true;
            // 
            // Nom_profe
            // 
            this.Nom_profe.DataPropertyName = "Nom_profe";
            this.Nom_profe.HeaderText = "Nombre";
            this.Nom_profe.Name = "Nom_profe";
            this.Nom_profe.ReadOnly = true;
            // 
            // Ape_profe
            // 
            this.Ape_profe.DataPropertyName = "Ape_profe";
            this.Ape_profe.HeaderText = "Apellido";
            this.Ape_profe.Name = "Ape_profe";
            this.Ape_profe.ReadOnly = true;
            // 
            // Tel_profe
            // 
            this.Tel_profe.DataPropertyName = "Tel_profe";
            this.Tel_profe.HeaderText = "Telefono";
            this.Tel_profe.Name = "Tel_profe";
            this.Tel_profe.ReadOnly = true;
            // 
            // Email_profe
            // 
            this.Email_profe.DataPropertyName = "Email_profe";
            this.Email_profe.HeaderText = "Email";
            this.Email_profe.Name = "Email_profe";
            this.Email_profe.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Distrito
            // 
            this.Distrito.DataPropertyName = "Distrito";
            this.Distrito.HeaderText = "Distrito";
            this.Distrito.Name = "Distrito";
            this.Distrito.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(906, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Registros:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(770, 435);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(885, 435);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(1002, 435);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // lblRegistros
            // 
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(977, 384);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(100, 23);
            this.lblRegistros.TabIndex = 8;
            // 
            // ProfesorMan01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 480);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgProfe);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfesorMan01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de profesores";
            this.Load += new System.EventHandler(this.ProfesorMan01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dtgProfe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_profe;
        private System.Windows.Forms.DataGridViewImageColumn Foto_profe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_profe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ape_profe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel_profe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_profe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distrito;
    }
}