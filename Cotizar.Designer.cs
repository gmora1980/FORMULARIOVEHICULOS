
namespace FORMULARIOVEHICULOS
{
    partial class frmCotizar
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
            this.lblPrecioOriginal = new System.Windows.Forms.Label();
            this.txtOriginalPrice = new System.Windows.Forms.TextBox();
            this.lblServicioAdicional = new System.Windows.Forms.Label();
            this.cmbServiciosAdicionales = new System.Windows.Forms.ComboBox();
            this.btnAddService = new System.Windows.Forms.Button();
            this.grbProforma = new System.Windows.Forms.GroupBox();
            this.dgvProforma = new System.Windows.Forms.DataGridView();
            this.btnEliminarServicio = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.grbProforma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProforma)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrecioOriginal
            // 
            this.lblPrecioOriginal.AutoSize = true;
            this.lblPrecioOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioOriginal.Location = new System.Drawing.Point(12, 11);
            this.lblPrecioOriginal.Name = "lblPrecioOriginal";
            this.lblPrecioOriginal.Size = new System.Drawing.Size(154, 25);
            this.lblPrecioOriginal.TabIndex = 0;
            this.lblPrecioOriginal.Text = "Precio Original";
            // 
            // txtOriginalPrice
            // 
            this.txtOriginalPrice.Enabled = false;
            this.txtOriginalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginalPrice.Location = new System.Drawing.Point(172, 14);
            this.txtOriginalPrice.Name = "txtOriginalPrice";
            this.txtOriginalPrice.Size = new System.Drawing.Size(213, 30);
            this.txtOriginalPrice.TabIndex = 1;
            // 
            // lblServicioAdicional
            // 
            this.lblServicioAdicional.AutoSize = true;
            this.lblServicioAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicioAdicional.Location = new System.Drawing.Point(12, 78);
            this.lblServicioAdicional.Name = "lblServicioAdicional";
            this.lblServicioAdicional.Size = new System.Drawing.Size(219, 25);
            this.lblServicioAdicional.TabIndex = 2;
            this.lblServicioAdicional.Text = "Servicios Adicionales";
            // 
            // cmbServiciosAdicionales
            // 
            this.cmbServiciosAdicionales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServiciosAdicionales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServiciosAdicionales.FormattingEnabled = true;
            this.cmbServiciosAdicionales.Location = new System.Drawing.Point(259, 73);
            this.cmbServiciosAdicionales.Name = "cmbServiciosAdicionales";
            this.cmbServiciosAdicionales.Size = new System.Drawing.Size(324, 33);
            this.cmbServiciosAdicionales.TabIndex = 3;
            this.cmbServiciosAdicionales.SelectionChangeCommitted += new System.EventHandler(this.cmbServiciosAdicionales_SelectionChangeCommitted);
            // 
            // btnAddService
            // 
            this.btnAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddService.Location = new System.Drawing.Point(12, 125);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(184, 45);
            this.btnAddService.TabIndex = 4;
            this.btnAddService.Text = "Agregar Servicio";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // grbProforma
            // 
            this.grbProforma.Controls.Add(this.dgvProforma);
            this.grbProforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProforma.Location = new System.Drawing.Point(19, 176);
            this.grbProforma.Name = "grbProforma";
            this.grbProforma.Size = new System.Drawing.Size(1055, 301);
            this.grbProforma.TabIndex = 5;
            this.grbProforma.TabStop = false;
            this.grbProforma.Text = "Proforma";
            // 
            // dgvProforma
            // 
            this.dgvProforma.AllowUserToAddRows = false;
            this.dgvProforma.AllowUserToDeleteRows = false;
            this.dgvProforma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProforma.Location = new System.Drawing.Point(9, 94);
            this.dgvProforma.Name = "dgvProforma";
            this.dgvProforma.ReadOnly = true;
            this.dgvProforma.RowHeadersWidth = 51;
            this.dgvProforma.RowTemplate.Height = 24;
            this.dgvProforma.Size = new System.Drawing.Size(1016, 231);
            this.dgvProforma.TabIndex = 0;
            // 
            // btnEliminarServicio
            // 
            this.btnEliminarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarServicio.Location = new System.Drawing.Point(248, 125);
            this.btnEliminarServicio.Name = "btnEliminarServicio";
            this.btnEliminarServicio.Size = new System.Drawing.Size(184, 45);
            this.btnEliminarServicio.TabIndex = 6;
            this.btnEliminarServicio.Text = "Eliminar Servicio";
            this.btnEliminarServicio.UseVisualStyleBackColor = true;
            this.btnEliminarServicio.Click += new System.EventHandler(this.btnEliminarServicio_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(748, 125);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(184, 45);
            this.btnAtras.TabIndex = 7;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(29, 521);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(69, 25);
            this.lblCosto.TabIndex = 8;
            this.lblCosto.Text = "Costo";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.Location = new System.Drawing.Point(355, 521);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(48, 25);
            this.lblIVA.TabIndex = 9;
            this.lblIVA.Text = "IVA";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(630, 521);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(61, 25);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total";
            // 
            // txtCosto
            // 
            this.txtCosto.Enabled = false;
            this.txtCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(104, 518);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(213, 30);
            this.txtCosto.TabIndex = 11;
            // 
            // txtIVA
            // 
            this.txtIVA.Enabled = false;
            this.txtIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIVA.Location = new System.Drawing.Point(409, 518);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(213, 30);
            this.txtIVA.TabIndex = 12;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(716, 516);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(213, 30);
            this.txtTotal.TabIndex = 13;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(480, 125);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(230, 45);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar Proforma";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(429, 17);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(72, 25);
            this.lblMarca.TabIndex = 15;
            this.lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(507, 17);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(213, 30);
            this.txtMarca.TabIndex = 16;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(743, 22);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(83, 25);
            this.lblModelo.TabIndex = 17;
            this.lblModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(831, 19);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(213, 30);
            this.txtModelo.TabIndex = 18;
            // 
            // frmCotizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 604);
            this.ControlBox = false;
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnEliminarServicio);
            this.Controls.Add(this.grbProforma);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.cmbServiciosAdicionales);
            this.Controls.Add(this.lblServicioAdicional);
            this.Controls.Add(this.txtOriginalPrice);
            this.Controls.Add(this.lblPrecioOriginal);
            this.Name = "frmCotizar";
            this.Text = "Cotizar";
            this.Load += new System.EventHandler(this.frmCotizar_Load);
            this.grbProforma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProforma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrecioOriginal;
        private System.Windows.Forms.TextBox txtOriginalPrice;
        private System.Windows.Forms.Label lblServicioAdicional;
        private System.Windows.Forms.ComboBox cmbServiciosAdicionales;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.GroupBox grbProforma;
        private System.Windows.Forms.DataGridView dgvProforma;
        private System.Windows.Forms.Button btnEliminarServicio;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
    }
}