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
			this.txtDescCourse = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.btnOpenAddCourse = new System.Windows.Forms.Button();
			this.Id_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Des_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Usu_registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fec_reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Usu_Ult_Mod = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fec_Ult_Mod = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Est_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dtgCourses)).BeginInit();
			this.SuspendLayout();
			// 
			// dtgCourses
			// 
			this.dtgCourses.AllowUserToAddRows = false;
			this.dtgCourses.AllowUserToDeleteRows = false;
			this.dtgCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtgCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_curso,
            this.Des_curso,
            this.Usu_registro,
            this.Fec_reg,
            this.Usu_Ult_Mod,
            this.Fec_Ult_Mod,
            this.Est_curso});
			this.dtgCourses.Location = new System.Drawing.Point(11, 74);
			this.dtgCourses.Name = "dtgCourses";
			this.dtgCourses.Size = new System.Drawing.Size(996, 350);
			this.dtgCourses.TabIndex = 0;
			// 
			// txtDescCourse
			// 
			this.txtDescCourse.Location = new System.Drawing.Point(133, 29);
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
			this.label1.Size = new System.Drawing.Size(114, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Busqueda por nombre:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(908, 449);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Registros:";
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(968, 449);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(0, 13);
			this.lblTotal.TabIndex = 4;
			// 
			// btnOpenAddCourse
			// 
			this.btnOpenAddCourse.Location = new System.Drawing.Point(805, 444);
			this.btnOpenAddCourse.Name = "btnOpenAddCourse";
			this.btnOpenAddCourse.Size = new System.Drawing.Size(75, 23);
			this.btnOpenAddCourse.TabIndex = 5;
			this.btnOpenAddCourse.Text = "Agregar";
			this.btnOpenAddCourse.UseVisualStyleBackColor = true;
			this.btnOpenAddCourse.Click += new System.EventHandler(this.btnOpenAddCourse_Click);
			// 
			// Id_curso
			// 
			this.Id_curso.DataPropertyName = "Id_curso";
			this.Id_curso.HeaderText = "ID";
			this.Id_curso.Name = "Id_curso";
			// 
			// Des_curso
			// 
			this.Des_curso.DataPropertyName = "Des_curso";
			this.Des_curso.HeaderText = "Descripción";
			this.Des_curso.Name = "Des_curso";
			// 
			// Usu_registro
			// 
			this.Usu_registro.DataPropertyName = "Usu_registro";
			this.Usu_registro.HeaderText = "Usuario Registro";
			this.Usu_registro.Name = "Usu_registro";
			// 
			// Fec_reg
			// 
			this.Fec_reg.DataPropertyName = "Fec_reg";
			this.Fec_reg.HeaderText = "Fecha de registro";
			this.Fec_reg.Name = "Fec_reg";
			// 
			// Usu_Ult_Mod
			// 
			this.Usu_Ult_Mod.DataPropertyName = "Usu_Ult_Mod";
			this.Usu_Ult_Mod.HeaderText = "Usuario Modificacion";
			this.Usu_Ult_Mod.Name = "Usu_Ult_Mod";
			// 
			// Fec_Ult_Mod
			// 
			this.Fec_Ult_Mod.DataPropertyName = "Fec_Ult_Mod";
			this.Fec_Ult_Mod.HeaderText = "Fecha Modificacion";
			this.Fec_Ult_Mod.Name = "Fec_Ult_Mod";
			// 
			// Est_curso
			// 
			this.Est_curso.DataPropertyName = "Est_curso";
			this.Est_curso.HeaderText = "Estado curso";
			this.Est_curso.Name = "Est_curso";
			// 
			// CursoMan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1019, 484);
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
		private System.Windows.Forms.DataGridViewTextBoxColumn Id_curso;
		private System.Windows.Forms.DataGridViewTextBoxColumn Des_curso;
		private System.Windows.Forms.DataGridViewTextBoxColumn Usu_registro;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fec_reg;
		private System.Windows.Forms.DataGridViewTextBoxColumn Usu_Ult_Mod;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fec_Ult_Mod;
		private System.Windows.Forms.DataGridViewTextBoxColumn Est_curso;
	}
}