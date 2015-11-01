namespace UI.Desktop
{
    partial class PlanEstudio
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
            this.dgvPlanEstudio = new System.Windows.Forms.DataGridView();
            this.IDMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSSemanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanEstudio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlanEstudio
            // 
            this.dgvPlanEstudio.AllowUserToAddRows = false;
            this.dgvPlanEstudio.AllowUserToDeleteRows = false;
            this.dgvPlanEstudio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanEstudio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMateria,
            this.Materia,
            this.HSTotales,
            this.HSSemanales});
            this.dgvPlanEstudio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlanEstudio.Location = new System.Drawing.Point(0, 0);
            this.dgvPlanEstudio.Name = "dgvPlanEstudio";
            this.dgvPlanEstudio.ReadOnly = true;
            this.dgvPlanEstudio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanEstudio.Size = new System.Drawing.Size(443, 247);
            this.dgvPlanEstudio.TabIndex = 0;
            // 
            // IDMateria
            // 
            this.IDMateria.DataPropertyName = "id_materia";
            this.IDMateria.HeaderText = "ID Materia";
            this.IDMateria.Name = "IDMateria";
            this.IDMateria.ReadOnly = true;
            // 
            // Materia
            // 
            this.Materia.DataPropertyName = "desc_materia";
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            // 
            // HSTotales
            // 
            this.HSTotales.DataPropertyName = "hs_totales";
            this.HSTotales.HeaderText = "Horas Total";
            this.HSTotales.Name = "HSTotales";
            this.HSTotales.ReadOnly = true;
            // 
            // HSSemanales
            // 
            this.HSSemanales.DataPropertyName = "hs_semanales";
            this.HSSemanales.HeaderText = "Horas Semanales";
            this.HSSemanales.Name = "HSSemanales";
            this.HSSemanales.ReadOnly = true;
            // 
            // PlanEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 247);
            this.Controls.Add(this.dgvPlanEstudio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PlanEstudio";
            this.Text = "PlanEstudio";
            this.Load += new System.EventHandler(this.PlanEstudio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanEstudio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlanEstudio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSTotales;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSSemanales;
    }
}