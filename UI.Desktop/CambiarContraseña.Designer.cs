namespace UI.Desktop
{
    partial class CambiarContraseña
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContraseñaVieja = new System.Windows.Forms.TextBox();
            this.txtContraseñaNueva = new System.Windows.Forms.TextBox();
            this.txtContraseñaRepetida = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btmAceptar = new System.Windows.Forms.Button();
            this.btmCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtContraseñaVieja, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtContraseñaNueva, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtContraseñaRepetida, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(387, 170);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese contraseña anterior:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese nueva contraseña:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(21, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repita nueva contraseña:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtContraseñaVieja
            // 
            this.txtContraseñaVieja.Location = new System.Drawing.Point(157, 29);
            this.txtContraseñaVieja.Name = "txtContraseñaVieja";
            this.txtContraseñaVieja.PasswordChar = '*';
            this.txtContraseñaVieja.Size = new System.Drawing.Size(191, 20);
            this.txtContraseñaVieja.TabIndex = 3;
            // 
            // txtContraseñaNueva
            // 
            this.txtContraseñaNueva.Location = new System.Drawing.Point(157, 55);
            this.txtContraseñaNueva.Name = "txtContraseñaNueva";
            this.txtContraseñaNueva.PasswordChar = '*';
            this.txtContraseñaNueva.Size = new System.Drawing.Size(191, 20);
            this.txtContraseñaNueva.TabIndex = 4;
            // 
            // txtContraseñaRepetida
            // 
            this.txtContraseñaRepetida.Location = new System.Drawing.Point(157, 81);
            this.txtContraseñaRepetida.Name = "txtContraseñaRepetida";
            this.txtContraseñaRepetida.PasswordChar = '*';
            this.txtContraseñaRepetida.Size = new System.Drawing.Size(191, 20);
            this.txtContraseñaRepetida.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btmAceptar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btmCancelar, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(157, 107);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(227, 60);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // btmAceptar
            // 
            this.btmAceptar.Location = new System.Drawing.Point(3, 3);
            this.btmAceptar.Name = "btmAceptar";
            this.btmAceptar.Size = new System.Drawing.Size(75, 23);
            this.btmAceptar.TabIndex = 0;
            this.btmAceptar.Text = "Aceptar";
            this.btmAceptar.UseVisualStyleBackColor = true;
            this.btmAceptar.Click += new System.EventHandler(this.btmAceptar_Click);
            // 
            // btmCancelar
            // 
            this.btmCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btmCancelar.Location = new System.Drawing.Point(116, 3);
            this.btmCancelar.Name = "btmCancelar";
            this.btmCancelar.Size = new System.Drawing.Size(75, 23);
            this.btmCancelar.TabIndex = 1;
            this.btmCancelar.Text = "Cancelar";
            this.btmCancelar.UseVisualStyleBackColor = true;
            this.btmCancelar.Click += new System.EventHandler(this.btmCancelar_Click);
            // 
            // CambiarContraseña
            // 
            this.AcceptButton = this.btmAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btmCancelar;
            this.ClientSize = new System.Drawing.Size(387, 170);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CambiarContraseña";
            this.Text = "CambiarContraseña";
            this.Load += new System.EventHandler(this.CambiarContraseña_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContraseñaVieja;
        private System.Windows.Forms.TextBox txtContraseñaNueva;
        private System.Windows.Forms.TextBox txtContraseñaRepetida;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btmAceptar;
        private System.Windows.Forms.Button btmCancelar;
    }
}