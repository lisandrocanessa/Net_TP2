namespace UI.Desktop
{
    partial class PlanMaterias
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
            this.btmAdministrarPlanes = new System.Windows.Forms.Button();
            this.cmbPlanes = new System.Windows.Forms.ComboBox();
            this.btmSalir = new System.Windows.Forms.Button();
            this.btmEliminar = new System.Windows.Forms.Button();
            this.btmModificar = new System.Windows.Forms.Button();
            this.btmAgregar = new System.Windows.Forms.Button();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.id_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hs_semanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hs_totales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // btmAdministrarPlanes
            // 
            this.btmAdministrarPlanes.Location = new System.Drawing.Point(220, 10);
            this.btmAdministrarPlanes.Name = "btmAdministrarPlanes";
            this.btmAdministrarPlanes.Size = new System.Drawing.Size(165, 23);
            this.btmAdministrarPlanes.TabIndex = 7;
            this.btmAdministrarPlanes.Text = "Administrar Planes";
            this.btmAdministrarPlanes.UseVisualStyleBackColor = true;
            this.btmAdministrarPlanes.Click += new System.EventHandler(this.btmAdministrarPlanes_Click);
            // 
            // cmbPlanes
            // 
            this.cmbPlanes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanes.FormattingEnabled = true;
            this.cmbPlanes.Location = new System.Drawing.Point(12, 12);
            this.cmbPlanes.Name = "cmbPlanes";
            this.cmbPlanes.Size = new System.Drawing.Size(202, 21);
            this.cmbPlanes.TabIndex = 6;
            this.cmbPlanes.SelectionChangeCommitted += new System.EventHandler(this.cmbPlanes_SelectionChangeCommitted);
            // 
            // btmSalir
            // 
            this.btmSalir.Location = new System.Drawing.Point(470, 322);
            this.btmSalir.Name = "btmSalir";
            this.btmSalir.Size = new System.Drawing.Size(131, 23);
            this.btmSalir.TabIndex = 4;
            this.btmSalir.Text = "Salir";
            this.btmSalir.UseVisualStyleBackColor = true;
            this.btmSalir.Click += new System.EventHandler(this.btmSalir_Click);
            // 
            // btmEliminar
            // 
            this.btmEliminar.Location = new System.Drawing.Point(470, 112);
            this.btmEliminar.Name = "btmEliminar";
            this.btmEliminar.Size = new System.Drawing.Size(131, 23);
            this.btmEliminar.TabIndex = 3;
            this.btmEliminar.Text = "Eliminar Materia";
            this.btmEliminar.UseVisualStyleBackColor = true;
            this.btmEliminar.Click += new System.EventHandler(this.btmEliminar_Click);
            // 
            // btmModificar
            // 
            this.btmModificar.Location = new System.Drawing.Point(470, 82);
            this.btmModificar.Name = "btmModificar";
            this.btmModificar.Size = new System.Drawing.Size(131, 23);
            this.btmModificar.TabIndex = 2;
            this.btmModificar.Text = "Modificar Materia";
            this.btmModificar.UseVisualStyleBackColor = true;
            this.btmModificar.Click += new System.EventHandler(this.btmModificar_Click);
            // 
            // btmAgregar
            // 
            this.btmAgregar.Location = new System.Drawing.Point(470, 52);
            this.btmAgregar.Name = "btmAgregar";
            this.btmAgregar.Size = new System.Drawing.Size(131, 23);
            this.btmAgregar.TabIndex = 1;
            this.btmAgregar.Text = "Agregar Materia";
            this.btmAgregar.UseVisualStyleBackColor = true;
            this.btmAgregar.Click += new System.EventHandler(this.btmAgregar_Click);
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_materia,
            this.desc_materia,
            this.hs_semanales,
            this.hs_totales});
            this.dgvMaterias.Location = new System.Drawing.Point(12, 43);
            this.dgvMaterias.MultiSelect = false;
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(452, 302);
            this.dgvMaterias.TabIndex = 0;
            // 
            // id_materia
            // 
            this.id_materia.DataPropertyName = "id_materia";
            this.id_materia.HeaderText = "ID";
            this.id_materia.Name = "id_materia";
            this.id_materia.ReadOnly = true;
            // 
            // desc_materia
            // 
            this.desc_materia.DataPropertyName = "desc_materia";
            this.desc_materia.HeaderText = "Descripcion";
            this.desc_materia.Name = "desc_materia";
            this.desc_materia.ReadOnly = true;
            // 
            // hs_semanales
            // 
            this.hs_semanales.DataPropertyName = "hs_semanales";
            this.hs_semanales.HeaderText = "Horas Semanales";
            this.hs_semanales.Name = "hs_semanales";
            this.hs_semanales.ReadOnly = true;
            // 
            // hs_totales
            // 
            this.hs_totales.DataPropertyName = "hs_totales";
            this.hs_totales.HeaderText = "Horas Totales";
            this.hs_totales.Name = "hs_totales";
            this.hs_totales.ReadOnly = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(470, 184);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(131, 23);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // PlanMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 359);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btmAdministrarPlanes);
            this.Controls.Add(this.cmbPlanes);
            this.Controls.Add(this.btmSalir);
            this.Controls.Add(this.btmEliminar);
            this.Controls.Add(this.btmModificar);
            this.Controls.Add(this.btmAgregar);
            this.Controls.Add(this.dgvMaterias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PlanMaterias";
            this.Text = "Planes y Materias";
            this.Load += new System.EventHandler(this.Planes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.Button btmAgregar;
        private System.Windows.Forms.Button btmModificar;
        private System.Windows.Forms.Button btmEliminar;
        private System.Windows.Forms.Button btmSalir;
        private System.Windows.Forms.ComboBox cmbPlanes;
        private System.Windows.Forms.Button btmAdministrarPlanes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn hs_semanales;
        private System.Windows.Forms.DataGridViewTextBoxColumn hs_totales;
        private System.Windows.Forms.Button btnActualizar;


    }
}