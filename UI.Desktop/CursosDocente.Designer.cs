namespace UI.Desktop
{
    partial class CursosDocente
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
            this.dgvCursosDocente = new System.Windows.Forms.DataGridView();
            this.IDCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDDictado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosDocente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCursosDocente
            // 
            this.dgvCursosDocente.AllowUserToAddRows = false;
            this.dgvCursosDocente.AllowUserToDeleteRows = false;
            this.dgvCursosDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursosDocente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCurso,
            this.IDDocente,
            this.IDDictado,
            this.Cargo});
            this.dgvCursosDocente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCursosDocente.Location = new System.Drawing.Point(0, 0);
            this.dgvCursosDocente.Name = "dgvCursosDocente";
            this.dgvCursosDocente.ReadOnly = true;
            this.dgvCursosDocente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursosDocente.Size = new System.Drawing.Size(443, 225);
            this.dgvCursosDocente.TabIndex = 0;
            // 
            // IDCurso
            // 
            this.IDCurso.DataPropertyName = "id_curso";
            this.IDCurso.HeaderText = "ID Curso";
            this.IDCurso.Name = "IDCurso";
            this.IDCurso.ReadOnly = true;
            // 
            // IDDocente
            // 
            this.IDDocente.DataPropertyName = "id_docente";
            this.IDDocente.HeaderText = "ID Docente";
            this.IDDocente.Name = "IDDocente";
            this.IDDocente.ReadOnly = true;
            // 
            // IDDictado
            // 
            this.IDDictado.DataPropertyName = "id_dictado";
            this.IDDictado.HeaderText = "IDDictado";
            this.IDDictado.Name = "IDDictado";
            this.IDDictado.ReadOnly = true;
            // 
            // Cargo
            // 
            this.Cargo.DataPropertyName = "cargo";
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            // 
            // CursosDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 225);
            this.Controls.Add(this.dgvCursosDocente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CursosDocente";
            this.Text = "Cursos del docente";
            this.Load += new System.EventHandler(this.CursosDocente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosDocente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursosDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDictado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
    }
}