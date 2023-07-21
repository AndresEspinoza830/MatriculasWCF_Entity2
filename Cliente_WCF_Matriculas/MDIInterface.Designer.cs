namespace Cliente_WCF_Matriculas
{
    partial class MDIInterface
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCuotasPendientesAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarMatriculadosFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarVacantesBloquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAlumnosCarreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1058, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.profesoresToolStripMenuItem,
            this.cursosToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.profesoresToolStripMenuItem.Text = "Profesores";
            this.profesoresToolStripMenuItem.Click += new System.EventHandler(this.profesoresToolStripMenuItem_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.cursosToolStripMenuItem.Text = "Cursos";
            this.cursosToolStripMenuItem.Click += new System.EventHandler(this.cursosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarCuotasPendientesAlumnosToolStripMenuItem,
            this.listarMatriculadosFechasToolStripMenuItem,
            this.listarVacantesBloquesToolStripMenuItem,
            this.listarAlumnosCarreraToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // listarCuotasPendientesAlumnosToolStripMenuItem
            // 
            this.listarCuotasPendientesAlumnosToolStripMenuItem.Name = "listarCuotasPendientesAlumnosToolStripMenuItem";
            this.listarCuotasPendientesAlumnosToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.listarCuotasPendientesAlumnosToolStripMenuItem.Text = "ListarCuotasPendientesAlumnos";
            this.listarCuotasPendientesAlumnosToolStripMenuItem.Click += new System.EventHandler(this.listarCuotasPendientesAlumnosToolStripMenuItem_Click);
            // 
            // listarMatriculadosFechasToolStripMenuItem
            // 
            this.listarMatriculadosFechasToolStripMenuItem.Name = "listarMatriculadosFechasToolStripMenuItem";
            this.listarMatriculadosFechasToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.listarMatriculadosFechasToolStripMenuItem.Text = "ListarMatriculadosFechas";
            this.listarMatriculadosFechasToolStripMenuItem.Click += new System.EventHandler(this.listarMatriculadosFechasToolStripMenuItem_Click);
            // 
            // listarVacantesBloquesToolStripMenuItem
            // 
            this.listarVacantesBloquesToolStripMenuItem.Name = "listarVacantesBloquesToolStripMenuItem";
            this.listarVacantesBloquesToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.listarVacantesBloquesToolStripMenuItem.Text = "ListarVacantesBloques";
            this.listarVacantesBloquesToolStripMenuItem.Click += new System.EventHandler(this.listarVacantesBloquesToolStripMenuItem_Click);
            // 
            // listarAlumnosCarreraToolStripMenuItem
            // 
            this.listarAlumnosCarreraToolStripMenuItem.Name = "listarAlumnosCarreraToolStripMenuItem";
            this.listarAlumnosCarreraToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.listarAlumnosCarreraToolStripMenuItem.Text = "ListarAlumnosCarrera";
            this.listarAlumnosCarreraToolStripMenuItem.Click += new System.EventHandler(this.listarAlumnosCarreraToolStripMenuItem_Click);
            // 
            // MDIInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 660);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interface principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCuotasPendientesAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarMatriculadosFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarVacantesBloquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarAlumnosCarreraToolStripMenuItem;
    }
}