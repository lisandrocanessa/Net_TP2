namespace UI.Desktop
{
    partial class MenuPadre
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
            this.mstPadre = new System.Windows.Forms.MenuStrip();
            this.tsmiArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdministrador = new System.Windows.Forms.ToolStripMenuItem();
            this.verDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesYMateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comisionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.planesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mejoresPromediosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planDeEstudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDocente = new System.Windows.Forms.ToolStripMenuItem();
            this.inscribirACursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.mstPadre.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstPadre
            // 
            this.mstPadre.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiArchivo,
            this.tsmiAdministrador,
            this.tsmiReportes,
            this.tsmiAlumno,
            this.tsmiDocente});
            this.mstPadre.Location = new System.Drawing.Point(0, 0);
            this.mstPadre.Name = "mstPadre";
            this.mstPadre.Size = new System.Drawing.Size(657, 24);
            this.mstPadre.TabIndex = 0;
            this.mstPadre.Text = "menuStrip1";
            // 
            // tsmiArchivo
            // 
            this.tsmiArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarContraseñaToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.tsmiArchivo.Name = "tsmiArchivo";
            this.tsmiArchivo.Size = new System.Drawing.Size(60, 20);
            this.tsmiArchivo.Text = "Archivo";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tsmiAdministrador
            // 
            this.tsmiAdministrador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verDocentesToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.especialidadesToolStripMenuItem,
            this.profesoresToolStripMenuItem,
            this.planesYMateriasToolStripMenuItem,
            this.comisionesToolStripMenuItem,
            this.cursosToolStripMenuItem});
            this.tsmiAdministrador.Name = "tsmiAdministrador";
            this.tsmiAdministrador.Size = new System.Drawing.Size(95, 20);
            this.tsmiAdministrador.Text = "Administrador";
            // 
            // verDocentesToolStripMenuItem
            // 
            this.verDocentesToolStripMenuItem.Name = "verDocentesToolStripMenuItem";
            this.verDocentesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.verDocentesToolStripMenuItem.Text = "Usuarios";
            this.verDocentesToolStripMenuItem.Click += new System.EventHandler(this.verDocentesToolStripMenuItem_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // especialidadesToolStripMenuItem
            // 
            this.especialidadesToolStripMenuItem.Name = "especialidadesToolStripMenuItem";
            this.especialidadesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.especialidadesToolStripMenuItem.Text = "Especialidades";
            this.especialidadesToolStripMenuItem.Click += new System.EventHandler(this.especialidadesToolStripMenuItem_Click);
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.profesoresToolStripMenuItem.Text = "Profesores";
            // 
            // planesYMateriasToolStripMenuItem
            // 
            this.planesYMateriasToolStripMenuItem.Name = "planesYMateriasToolStripMenuItem";
            this.planesYMateriasToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.planesYMateriasToolStripMenuItem.Text = "Planes y materias";
            this.planesYMateriasToolStripMenuItem.Click += new System.EventHandler(this.planesYMateriasToolStripMenuItem_Click);
            // 
            // comisionesToolStripMenuItem
            // 
            this.comisionesToolStripMenuItem.Name = "comisionesToolStripMenuItem";
            this.comisionesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.comisionesToolStripMenuItem.Text = "Comisiones";
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.cursosToolStripMenuItem.Text = "Cursos";
            // 
            // tsmiReportes
            // 
            this.tsmiReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursosToolStripMenuItem1,
            this.planesToolStripMenuItem,
            this.mejoresPromediosToolStripMenuItem});
            this.tsmiReportes.Name = "tsmiReportes";
            this.tsmiReportes.Size = new System.Drawing.Size(65, 20);
            this.tsmiReportes.Text = "Reportes";
            // 
            // cursosToolStripMenuItem1
            // 
            this.cursosToolStripMenuItem1.Name = "cursosToolStripMenuItem1";
            this.cursosToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.cursosToolStripMenuItem1.Text = "Cursos";
            // 
            // planesToolStripMenuItem
            // 
            this.planesToolStripMenuItem.Name = "planesToolStripMenuItem";
            this.planesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.planesToolStripMenuItem.Text = "Planes";
            // 
            // mejoresPromediosToolStripMenuItem
            // 
            this.mejoresPromediosToolStripMenuItem.Name = "mejoresPromediosToolStripMenuItem";
            this.mejoresPromediosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.mejoresPromediosToolStripMenuItem.Text = "Mejores promedios";
            // 
            // tsmiAlumno
            // 
            this.tsmiAlumno.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materiaToolStripMenuItem,
            this.notasToolStripMenuItem,
            this.planDeEstudioToolStripMenuItem});
            this.tsmiAlumno.Name = "tsmiAlumno";
            this.tsmiAlumno.Size = new System.Drawing.Size(62, 20);
            this.tsmiAlumno.Text = "Alumno";
            // 
            // materiaToolStripMenuItem
            // 
            this.materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
            this.materiaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.materiaToolStripMenuItem.Text = "Inscribir a materia";
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.notasToolStripMenuItem.Text = "Estado académico";
            // 
            // planDeEstudioToolStripMenuItem
            // 
            this.planDeEstudioToolStripMenuItem.Name = "planDeEstudioToolStripMenuItem";
            this.planDeEstudioToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.planDeEstudioToolStripMenuItem.Text = "Plan de estudio";
            // 
            // tsmiDocente
            // 
            this.tsmiDocente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscribirACursoToolStripMenuItem,
            this.calificacionesToolStripMenuItem});
            this.tsmiDocente.Name = "tsmiDocente";
            this.tsmiDocente.Size = new System.Drawing.Size(63, 20);
            this.tsmiDocente.Text = "Docente";
            // 
            // inscribirACursoToolStripMenuItem
            // 
            this.inscribirACursoToolStripMenuItem.Name = "inscribirACursoToolStripMenuItem";
            this.inscribirACursoToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.inscribirACursoToolStripMenuItem.Text = "Cursos";
            // 
            // calificacionesToolStripMenuItem
            // 
            this.calificacionesToolStripMenuItem.Name = "calificacionesToolStripMenuItem";
            this.calificacionesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.calificacionesToolStripMenuItem.Text = "Calificaciones";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 13);
            this.lblNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(71, 34);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(0, 13);
            this.lblApellido.TabIndex = 2;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(569, 34);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(0, 13);
            this.lblTipo.TabIndex = 3;
            // 
            // MenuPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 497);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.mstPadre);
            this.MainMenuStrip = this.mstPadre;
            this.MaximizeBox = false;
            this.Name = "MenuPadre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPadre_Load);
            this.mstPadre.ResumeLayout(false);
            this.mstPadre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstPadre;
        private System.Windows.Forms.ToolStripMenuItem tsmiArchivo;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdministrador;
        private System.Windows.Forms.ToolStripMenuItem verDocentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesYMateriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comisionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiReportes;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem planesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mejoresPromediosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAlumno;
        private System.Windows.Forms.ToolStripMenuItem materiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planDeEstudioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDocente;
        private System.Windows.Forms.ToolStripMenuItem inscribirACursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calificacionesToolStripMenuItem;
        public System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.Label lblApellido;
        public System.Windows.Forms.Label lblTipo;
    }
}