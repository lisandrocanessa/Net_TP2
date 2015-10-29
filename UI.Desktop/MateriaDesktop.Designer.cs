namespace UI.Desktop
{
    partial class MateriaDesktop
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblIdPlan = new System.Windows.Forms.Label();
            this.lblDescMateria = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHorasTotales = new System.Windows.Forms.Label();
            this.txtDescMateria = new System.Windows.Forms.TextBox();
            this.txtHsSem = new System.Windows.Forms.MaskedTextBox();
            this.txtHsTot = new System.Windows.Forms.MaskedTextBox();
            this.cmbPlanes = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblIdPlan, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDescMateria, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblHorasTotales, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDescMateria, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtHsSem, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtHsTot, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbPlanes, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(352, 177);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAceptar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancelar, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(108, 119);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(241, 55);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(3, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(123, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblIdPlan
            // 
            this.lblIdPlan.AutoSize = true;
            this.lblIdPlan.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblIdPlan.Location = new System.Drawing.Point(57, 0);
            this.lblIdPlan.Name = "lblIdPlan";
            this.lblIdPlan.Size = new System.Drawing.Size(45, 29);
            this.lblIdPlan.TabIndex = 1;
            this.lblIdPlan.Text = "ID Plan:";
            this.lblIdPlan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescMateria
            // 
            this.lblDescMateria.AutoSize = true;
            this.lblDescMateria.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDescMateria.Location = new System.Drawing.Point(36, 29);
            this.lblDescMateria.Name = "lblDescMateria";
            this.lblDescMateria.Size = new System.Drawing.Size(66, 29);
            this.lblDescMateria.TabIndex = 2;
            this.lblDescMateria.Text = "Descripcion:";
            this.lblDescMateria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Horas Semanales:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHorasTotales
            // 
            this.lblHorasTotales.AutoSize = true;
            this.lblHorasTotales.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHorasTotales.Location = new System.Drawing.Point(26, 87);
            this.lblHorasTotales.Name = "lblHorasTotales";
            this.lblHorasTotales.Size = new System.Drawing.Size(76, 29);
            this.lblHorasTotales.TabIndex = 4;
            this.lblHorasTotales.Text = "Horas Totales:";
            this.lblHorasTotales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescMateria
            // 
            this.txtDescMateria.Location = new System.Drawing.Point(108, 32);
            this.txtDescMateria.Name = "txtDescMateria";
            this.txtDescMateria.Size = new System.Drawing.Size(159, 20);
            this.txtDescMateria.TabIndex = 6;
            // 
            // txtHsSem
            // 
            this.txtHsSem.Location = new System.Drawing.Point(108, 61);
            this.txtHsSem.Mask = "99";
            this.txtHsSem.Name = "txtHsSem";
            this.txtHsSem.Size = new System.Drawing.Size(43, 20);
            this.txtHsSem.TabIndex = 7;
            // 
            // txtHsTot
            // 
            this.txtHsTot.Location = new System.Drawing.Point(108, 90);
            this.txtHsTot.Mask = "999";
            this.txtHsTot.Name = "txtHsTot";
            this.txtHsTot.Size = new System.Drawing.Size(43, 20);
            this.txtHsTot.TabIndex = 8;
            // 
            // cmbPlanes
            // 
            this.cmbPlanes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanes.FormattingEnabled = true;
            this.cmbPlanes.Location = new System.Drawing.Point(108, 3);
            this.cmbPlanes.Name = "cmbPlanes";
            this.cmbPlanes.Size = new System.Drawing.Size(159, 21);
            this.cmbPlanes.TabIndex = 9;
            // 
            // MateriaDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 177);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MateriaDesktop";
            this.Text = "MateriaDesktop";
            this.Load += new System.EventHandler(this.MateriaDesktop_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblIdPlan;
        private System.Windows.Forms.Label lblDescMateria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHorasTotales;
        private System.Windows.Forms.TextBox txtDescMateria;
        private System.Windows.Forms.MaskedTextBox txtHsSem;
        private System.Windows.Forms.MaskedTextBox txtHsTot;
        private System.Windows.Forms.ComboBox cmbPlanes;
    }
}