namespace UI.Desktop
{
    partial class UsuarioDesktop
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.MaskedTextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.cmbTipoPersona = new System.Windows.Forms.ComboBox();
            this.lblTipoPersona = new System.Windows.Forms.Label();
            this.txtFecNac = new System.Windows.Forms.MaskedTextBox();
            this.lblFecNac = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 211);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.Controls.Add(this.lblNombre, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtNombre, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblLegajo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblApellido, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblEmail, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtApellido, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtEmail, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtUsuario, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDireccion, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtDireccion, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(265, 207);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Location = new System.Drawing.Point(2, 30);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(88, 28);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombre.Location = new System.Drawing.Point(94, 32);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLegajo.Location = new System.Drawing.Point(47, 0);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(42, 30);
            this.lblLegajo.TabIndex = 6;
            this.lblLegajo.Text = "Legajo:";
            this.lblLegajo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblApellido.Location = new System.Drawing.Point(42, 58);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 28);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblEmail.Location = new System.Drawing.Point(54, 86);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 29);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(95, 61);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(167, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(95, 89);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(167, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(95, 3);
            this.txtUsuario.Mask = "9999999";
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(167, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDireccion.Location = new System.Drawing.Point(34, 115);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 27);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Direccion:";
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(95, 118);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(167, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel3.Controls.Add(this.chkHabilitado, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cmbTipoPersona, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblTipoPersona, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtFecNac, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblFecNac, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnAceptar, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.btnCancelar, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.lblTelefono, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtTelefono, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(271, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(266, 207);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkHabilitado.Location = new System.Drawing.Point(2, 2);
            this.chkHabilitado.Margin = new System.Windows.Forms.Padding(2);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(89, 27);
            this.chkHabilitado.TabIndex = 6;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // cmbTipoPersona
            // 
            this.cmbTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPersona.FormattingEnabled = true;
            this.cmbTipoPersona.Items.AddRange(new object[] {
            "Administrador",
            "Alumno",
            "Docente"});
            this.cmbTipoPersona.Location = new System.Drawing.Point(96, 34);
            this.cmbTipoPersona.Name = "cmbTipoPersona";
            this.cmbTipoPersona.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoPersona.TabIndex = 7;
            // 
            // lblTipoPersona
            // 
            this.lblTipoPersona.AutoSize = true;
            this.lblTipoPersona.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTipoPersona.Location = new System.Drawing.Point(34, 31);
            this.lblTipoPersona.Name = "lblTipoPersona";
            this.lblTipoPersona.Size = new System.Drawing.Size(56, 28);
            this.lblTipoPersona.TabIndex = 9;
            this.lblTipoPersona.Text = "Tipo de P:";
            this.lblTipoPersona.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFecNac
            // 
            this.txtFecNac.Location = new System.Drawing.Point(96, 62);
            this.txtFecNac.Mask = "00/00/0000";
            this.txtFecNac.Name = "txtFecNac";
            this.txtFecNac.Size = new System.Drawing.Size(121, 20);
            this.txtFecNac.TabIndex = 8;
            this.txtFecNac.ValidatingType = typeof(System.DateTime);
            // 
            // lblFecNac
            // 
            this.lblFecNac.AutoSize = true;
            this.lblFecNac.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFecNac.Location = new System.Drawing.Point(27, 59);
            this.lblFecNac.Name = "lblFecNac";
            this.lblFecNac.Size = new System.Drawing.Size(63, 27);
            this.lblFecNac.TabIndex = 11;
            this.lblFecNac.Text = "Fecha Nac:";
            this.lblFecNac.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(2, 163);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(56, 22);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(95, 163);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(62, 22);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTelefono.Location = new System.Drawing.Point(38, 86);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 30);
            this.lblTelefono.TabIndex = 12;
            this.lblTelefono.Text = "Telefono:";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(96, 89);
            this.txtTelefono.Mask = "9999999999";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(121, 20);
            this.txtTelefono.TabIndex = 9;
            // 
            // UsuarioDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 211);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UsuarioDesktop";
            this.Text = "UsuarioDesktop";
            this.Load += new System.EventHandler(this.UsuarioDesktop_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbTipoPersona;
        private System.Windows.Forms.Label lblTipoPersona;
        private System.Windows.Forms.MaskedTextBox txtUsuario;
        private System.Windows.Forms.MaskedTextBox txtFecNac;
        private System.Windows.Forms.Label lblFecNac;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
    }
}