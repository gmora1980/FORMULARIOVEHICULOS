
namespace FORMULARIOVEHICULOS
{
    partial class frmCitas
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
            this.grbContacto = new System.Windows.Forms.GroupBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbContacto = new System.Windows.Forms.ComboBox();
            this.cmbTipoID = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblPreferencia = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipoID = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.grbContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbContacto
            // 
            this.grbContacto.Controls.Add(this.btnAtras);
            this.grbContacto.Controls.Add(this.btnAceptar);
            this.grbContacto.Controls.Add(this.cmbContacto);
            this.grbContacto.Controls.Add(this.cmbTipoID);
            this.grbContacto.Controls.Add(this.txtTelefono);
            this.grbContacto.Controls.Add(this.txtMail);
            this.grbContacto.Controls.Add(this.txtApellido2);
            this.grbContacto.Controls.Add(this.txtApellido1);
            this.grbContacto.Controls.Add(this.txtNombre);
            this.grbContacto.Controls.Add(this.txtCedula);
            this.grbContacto.Controls.Add(this.txtConsulta);
            this.grbContacto.Controls.Add(this.lblConsulta);
            this.grbContacto.Controls.Add(this.lblTelefono);
            this.grbContacto.Controls.Add(this.lblPreferencia);
            this.grbContacto.Controls.Add(this.lblMail);
            this.grbContacto.Controls.Add(this.lblApellido2);
            this.grbContacto.Controls.Add(this.lblApellido1);
            this.grbContacto.Controls.Add(this.lblNombre);
            this.grbContacto.Controls.Add(this.lblTipoID);
            this.grbContacto.Controls.Add(this.lblCedula);
            this.grbContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbContacto.Location = new System.Drawing.Point(21, 9);
            this.grbContacto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbContacto.Name = "grbContacto";
            this.grbContacto.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbContacto.Size = new System.Drawing.Size(1152, 646);
            this.grbContacto.TabIndex = 1;
            this.grbContacto.TabStop = false;
            this.grbContacto.Text = "Forma de Contacto";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(322, 505);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(237, 64);
            this.btnAtras.TabIndex = 19;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(15, 505);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(237, 64);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cmbContacto
            // 
            this.cmbContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContacto.FormattingEnabled = true;
            this.cmbContacto.Items.AddRange(new object[] {
            "Telefono",
            "Mail",
            "Ambos"});
            this.cmbContacto.Location = new System.Drawing.Point(322, 326);
            this.cmbContacto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbContacto.Name = "cmbContacto";
            this.cmbContacto.Size = new System.Drawing.Size(232, 37);
            this.cmbContacto.TabIndex = 17;
            this.cmbContacto.SelectedIndexChanged += new System.EventHandler(this.cmbContacto_SelectedIndexChanged);
            // 
            // cmbTipoID
            // 
            this.cmbTipoID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoID.FormattingEnabled = true;
            this.cmbTipoID.Items.AddRange(new object[] {
            "Nacional",
            "Extranjero (DIMEX, Pasaporte...)"});
            this.cmbTipoID.Location = new System.Drawing.Point(138, 98);
            this.cmbTipoID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTipoID.Name = "cmbTipoID";
            this.cmbTipoID.Size = new System.Drawing.Size(416, 37);
            this.cmbTipoID.TabIndex = 16;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(153, 430);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(232, 35);
            this.txtTelefono.TabIndex = 15;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(118, 380);
            this.txtMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(317, 35);
            this.txtMail.TabIndex = 14;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(137, 271);
            this.txtApellido2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(232, 35);
            this.txtApellido2.TabIndex = 13;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(138, 215);
            this.txtApellido1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(232, 35);
            this.txtApellido1.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(138, 158);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(232, 35);
            this.txtNombre.TabIndex = 11;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(138, 45);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(232, 35);
            this.txtCedula.TabIndex = 10;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(681, 45);
            this.txtConsulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(464, 523);
            this.txtConsulta.TabIndex = 9;
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Location = new System.Drawing.Point(564, 49);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(115, 29);
            this.lblConsulta.TabIndex = 8;
            this.lblConsulta.Text = "Consulta";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(7, 434);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(118, 29);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblPreferencia
            // 
            this.lblPreferencia.AutoSize = true;
            this.lblPreferencia.Location = new System.Drawing.Point(9, 330);
            this.lblPreferencia.Name = "lblPreferencia";
            this.lblPreferencia.Size = new System.Drawing.Size(295, 29);
            this.lblPreferencia.TabIndex = 6;
            this.lblPreferencia.Text = "Preferencia de Contacto";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(9, 380);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(62, 29);
            this.lblMail.TabIndex = 5;
            this.lblMail.Text = "Mail";
            // 
            // lblApellido2
            // 
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Location = new System.Drawing.Point(9, 271);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(131, 29);
            this.lblApellido2.TabIndex = 4;
            this.lblApellido2.Text = "Apellido 2";
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Location = new System.Drawing.Point(9, 215);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(131, 29);
            this.lblApellido1.TabIndex = 3;
            this.lblApellido1.Text = "Apellido 1";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 161);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 29);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTipoID
            // 
            this.lblTipoID.AutoSize = true;
            this.lblTipoID.Location = new System.Drawing.Point(9, 108);
            this.lblTipoID.Name = "lblTipoID";
            this.lblTipoID.Size = new System.Drawing.Size(99, 29);
            this.lblTipoID.TabIndex = 1;
            this.lblTipoID.Text = "Tipo ID";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(9, 49);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(96, 29);
            this.lblCedula.TabIndex = 0;
            this.lblCedula.Text = "Cedula";
            // 
            // frmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 826);
            this.ControlBox = false;
            this.Controls.Add(this.grbContacto);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCitas";
            this.Text = "Citas";
            this.grbContacto.ResumeLayout(false);
            this.grbContacto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbContacto;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipoID;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbContacto;
        private System.Windows.Forms.ComboBox cmbTipoID;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblPreferencia;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.Button btnAtras;
    }
}