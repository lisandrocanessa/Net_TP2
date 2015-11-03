namespace UI.Desktop
{
    partial class CursosComisiones
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
            this.IDCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AñoCalendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbComision = new System.Windows.Forms.ComboBox();
            this.btnAdmComision = new System.Windows.Forms.Button();
            this.btnAddCurso = new System.Windows.Forms.Button();
            this.btnEliminarCurso = new System.Windows.Forms.Button();
            this.btnModificarCurso = new System.Windows.Forms.Button();
            this.cmbPlanes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCurso,
            this.AñoCalendario,
            this.Cupo,
            this.Descripcion,
            this.IDComision,
            this.IDMateria});
            this.dgvCursos.Location = new System.Drawing.Point(1, 40);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(645, 296);
            this.dgvCursos.TabIndex = 0;
            // 
            // IDCurso
            // 
            this.IDCurso.DataPropertyName = "id_curso";
            this.IDCurso.HeaderText = "ID";
            this.IDCurso.Name = "IDCurso";
            this.IDCurso.ReadOnly = true;
            // 
            // AñoCalendario
            // 
            this.AñoCalendario.DataPropertyName = "anio_calendario";
            this.AñoCalendario.HeaderText = "Año Calendario";
            this.AñoCalendario.Name = "AñoCalendario";
            this.AñoCalendario.ReadOnly = true;
            // 
            // Cupo
            // 
            this.Cupo.DataPropertyName = "cupo";
            this.Cupo.HeaderText = "Cupo";
            this.Cupo.Name = "Cupo";
            this.Cupo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // IDComision
            // 
            this.IDComision.DataPropertyName = "id_comision";
            this.IDComision.HeaderText = "ID Comision";
            this.IDComision.Name = "IDComision";
            this.IDComision.ReadOnly = true;
            // 
            // IDMateria
            // 
            this.IDMateria.DataPropertyName = "id_materia";
            this.IDMateria.HeaderText = "ID Materia";
            this.IDMateria.Name = "IDMateria";
            this.IDMateria.ReadOnly = true;
            // 
            // cmbComision
            // 
            this.cmbComision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComision.FormattingEnabled = true;
            this.cmbComision.Location = new System.Drawing.Point(141, 13);
            this.cmbComision.Name = "cmbComision";
            this.cmbComision.Size = new System.Drawing.Size(121, 21);
            this.cmbComision.TabIndex = 1;
            this.cmbComision.SelectionChangeCommitted += new System.EventHandler(this.cmbComision_SelectionChangeCommitted);
            // 
            // btnAdmComision
            // 
            this.btnAdmComision.Location = new System.Drawing.Point(268, 11);
            this.btnAdmComision.Name = "btnAdmComision";
            this.btnAdmComision.Size = new System.Drawing.Size(146, 23);
            this.btnAdmComision.TabIndex = 2;
            this.btnAdmComision.Text = "Administrar Comisiones";
            this.btnAdmComision.UseVisualStyleBackColor = true;
            this.btnAdmComision.Click += new System.EventHandler(this.btnAdmComision_Click);
            // 
            // btnAddCurso
            // 
            this.btnAddCurso.Location = new System.Drawing.Point(662, 40);
            this.btnAddCurso.Name = "btnAddCurso";
            this.btnAddCurso.Size = new System.Drawing.Size(108, 23);
            this.btnAddCurso.TabIndex = 3;
            this.btnAddCurso.Text = "Agregar Curso";
            this.btnAddCurso.UseVisualStyleBackColor = true;
            this.btnAddCurso.Click += new System.EventHandler(this.btnAddCurso_Click);
            // 
            // btnEliminarCurso
            // 
            this.btnEliminarCurso.Location = new System.Drawing.Point(662, 98);
            this.btnEliminarCurso.Name = "btnEliminarCurso";
            this.btnEliminarCurso.Size = new System.Drawing.Size(108, 23);
            this.btnEliminarCurso.TabIndex = 4;
            this.btnEliminarCurso.Text = "Eliminar Curso";
            this.btnEliminarCurso.UseVisualStyleBackColor = true;
            // 
            // btnModificarCurso
            // 
            this.btnModificarCurso.Location = new System.Drawing.Point(662, 69);
            this.btnModificarCurso.Name = "btnModificarCurso";
            this.btnModificarCurso.Size = new System.Drawing.Size(108, 23);
            this.btnModificarCurso.TabIndex = 5;
            this.btnModificarCurso.Text = "Modificar Curso";
            this.btnModificarCurso.UseVisualStyleBackColor = true;
            // 
            // cmbPlanes
            // 
            this.cmbPlanes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanes.FormattingEnabled = true;
            this.cmbPlanes.Location = new System.Drawing.Point(12, 13);
            this.cmbPlanes.Name = "cmbPlanes";
            this.cmbPlanes.Size = new System.Drawing.Size(121, 21);
            this.cmbPlanes.TabIndex = 6;
            this.cmbPlanes.SelectionChangeCommitted += new System.EventHandler(this.cmbPlanes_SelectionChangeCommitted);
            // 
            // CursosComisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 336);
            this.Controls.Add(this.cmbPlanes);
            this.Controls.Add(this.btnModificarCurso);
            this.Controls.Add(this.btnEliminarCurso);
            this.Controls.Add(this.btnAddCurso);
            this.Controls.Add(this.btnAdmComision);
            this.Controls.Add(this.cmbComision);
            this.Controls.Add(this.dgvCursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CursosComisiones";
            this.Text = "Cursos y Comisiones";
            this.Load += new System.EventHandler(this.CursosComisiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.ComboBox cmbComision;
        private System.Windows.Forms.Button btnAdmComision;
        private System.Windows.Forms.Button btnAddCurso;
        private System.Windows.Forms.Button btnEliminarCurso;
        private System.Windows.Forms.Button btnModificarCurso;
        private System.Windows.Forms.ComboBox cmbPlanes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn AñoCalendario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMateria;
    }
}