namespace UI.Desktop
{
    partial class EstadoAcademico
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
            this.dgvEstadoAcademico = new System.Windows.Forms.DataGridView();
            this.IDInscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoAcademico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstadoAcademico
            // 
            this.dgvEstadoAcademico.AllowUserToAddRows = false;
            this.dgvEstadoAcademico.AllowUserToDeleteRows = false;
            this.dgvEstadoAcademico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadoAcademico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDInscripcion,
            this.Curso,
            this.Materia,
            this.Condicion,
            this.Nota});
            this.dgvEstadoAcademico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstadoAcademico.Location = new System.Drawing.Point(0, 0);
            this.dgvEstadoAcademico.Name = "dgvEstadoAcademico";
            this.dgvEstadoAcademico.ReadOnly = true;
            this.dgvEstadoAcademico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstadoAcademico.Size = new System.Drawing.Size(543, 286);
            this.dgvEstadoAcademico.TabIndex = 0;
            // 
            // IDInscripcion
            // 
            this.IDInscripcion.DataPropertyName = "id_inscripcion";
            this.IDInscripcion.HeaderText = "ID Inscripcion";
            this.IDInscripcion.Name = "IDInscripcion";
            this.IDInscripcion.ReadOnly = true;
            // 
            // Curso
            // 
            this.Curso.DataPropertyName = "descripcion";
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            // 
            // Materia
            // 
            this.Materia.DataPropertyName = "desc_materia";
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            // 
            // Condicion
            // 
            this.Condicion.DataPropertyName = "condicion";
            this.Condicion.HeaderText = "Condicion";
            this.Condicion.Name = "Condicion";
            this.Condicion.ReadOnly = true;
            // 
            // Nota
            // 
            this.Nota.DataPropertyName = "nota";
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            this.Nota.ReadOnly = true;
            // 
            // EstadoAcademico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 286);
            this.Controls.Add(this.dgvEstadoAcademico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EstadoAcademico";
            this.Text = "EstadoAcademico";
            this.Load += new System.EventHandler(this.EstadoAcademico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoAcademico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstadoAcademico;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDInscripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
    }
}