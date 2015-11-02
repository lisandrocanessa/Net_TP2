namespace UI.Desktop
{
    partial class AsignacionDocenteCurso
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
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AñoCalendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCursosInscriptos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion,
            this.IDMateria,
            this.AñoCalendario});
            this.dgvCursos.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvCursos.Location = new System.Drawing.Point(0, 0);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(444, 308);
            this.dgvCursos.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_curso";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // IDMateria
            // 
            this.IDMateria.DataPropertyName = "id_materia";
            this.IDMateria.HeaderText = "ID Materia";
            this.IDMateria.Name = "IDMateria";
            this.IDMateria.ReadOnly = true;
            // 
            // AñoCalendario
            // 
            this.AñoCalendario.DataPropertyName = "anio_calendario";
            this.AñoCalendario.HeaderText = "Año Calendario";
            this.AñoCalendario.Name = "AñoCalendario";
            this.AñoCalendario.ReadOnly = true;
            // 
            // btnInscribir
            // 
            this.btnInscribir.Location = new System.Drawing.Point(450, 30);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(111, 34);
            this.btnInscribir.TabIndex = 1;
            this.btnInscribir.Text = "Inscribir";
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(449, 260);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 36);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCursosInscriptos
            // 
            this.btnCursosInscriptos.Location = new System.Drawing.Point(450, 79);
            this.btnCursosInscriptos.Name = "btnCursosInscriptos";
            this.btnCursosInscriptos.Size = new System.Drawing.Size(111, 34);
            this.btnCursosInscriptos.TabIndex = 3;
            this.btnCursosInscriptos.Text = "Cursos Inscriptos";
            this.btnCursosInscriptos.UseVisualStyleBackColor = true;
            this.btnCursosInscriptos.Click += new System.EventHandler(this.btnCursosInscriptos_Click);
            // 
            // AsignacionDocenteCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 308);
            this.Controls.Add(this.btnCursosInscriptos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInscribir);
            this.Controls.Add(this.dgvCursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AsignacionDocenteCurso";
            this.Text = "AsignacionDocenteCurso";
            this.Load += new System.EventHandler(this.AsignacionDocenteCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn AñoCalendario;
        private System.Windows.Forms.Button btnCursosInscriptos;
    }
}