namespace Cliente_WCF_Matriculas
{
	partial class CursoMan
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
            this.dtgCourses = new System.Windows.Forms.DataGridView();
            this.Id_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Des_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescCourse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnOpenAddCourse = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCerrarModal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCourses
            // 
            this.dtgCourses.AllowUserToAddRows = false;
            this.dtgCourses.AllowUserToDeleteRows = false;
            this.dtgCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_curso,
            this.Des_curso,
            this.Fec_reg,
            this.Estado});
            this.dtgCourses.Location = new System.Drawing.Point(11, 74);
            this.dtgCourses.Name = "dtgCourses";
            this.dtgCourses.ReadOnly = true;
            this.dtgCourses.RowHeadersVisible = false;
            this.dtgCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCourses.Size = new System.Drawing.Size(1030, 364);
            this.dtgCourses.TabIndex = 0;
            // 
            // Id_curso
            // 
            this.Id_curso.DataPropertyName = "Id_curso";
            this.Id_curso.HeaderText = "ID";
            this.Id_curso.Name = "Id_curso";
            this.Id_curso.ReadOnly = true;
            // 
            // Des_curso
            // 
            this.Des_curso.DataPropertyName = "Des_curso";
            this.Des_curso.HeaderText = "Descripción";
            this.Des_curso.Name = "Des_curso";
            this.Des_curso.ReadOnly = true;
            // 
            // Fec_reg
            // 
            this.Fec_reg.DataPropertyName = "Fec_reg";
            this.Fec_reg.HeaderText = "Fecha de registro";
            this.Fec_reg.Name = "Fec_reg";
            this.Fec_reg.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // txtDescCourse
            // 
            this.txtDescCourse.Location = new System.Drawing.Point(201, 29);
            this.txtDescCourse.Name = "txtDescCourse";
            this.txtDescCourse.Size = new System.Drawing.Size(239, 20);
            this.txtDescCourse.TabIndex = 1;
            this.txtDescCourse.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Busqueda por Descripcion Curso:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(898, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Registros:";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(958, 450);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(73, 24);
            this.lblTotal.TabIndex = 4;
            // 
            // btnOpenAddCourse
            // 
            this.btnOpenAddCourse.Location = new System.Drawing.Point(795, 504);
            this.btnOpenAddCourse.Name = "btnOpenAddCourse";
            this.btnOpenAddCourse.Size = new System.Drawing.Size(75, 23);
            this.btnOpenAddCourse.TabIndex = 5;
            this.btnOpenAddCourse.Text = "Agregar";
            this.btnOpenAddCourse.UseVisualStyleBackColor = true;
            this.btnOpenAddCourse.Click += new System.EventHandler(this.btnOpenAddCourse_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(888, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCerrarModal
            // 
            this.btnCerrarModal.Location = new System.Drawing.Point(966, 504);
            this.btnCerrarModal.Name = "btnCerrarModal";
            this.btnCerrarModal.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarModal.TabIndex = 7;
            this.btnCerrarModal.Text = "Cerrar";
            this.btnCerrarModal.UseVisualStyleBackColor = true;
            this.btnCerrarModal.Click += new System.EventHandler(this.btnCerrarModal_Click);
            // 
            // CursoMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 555);
            this.Controls.Add(this.btnCerrarModal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOpenAddCourse);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescCourse);
            this.Controls.Add(this.dtgCourses);
            this.Name = "CursoMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de curso";
            this.Load += new System.EventHandler(this.CursoMan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dtgCourses;
		private System.Windows.Forms.TextBox txtDescCourse;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Button btnOpenAddCourse;
        private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnCerrarModal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Des_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_reg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}