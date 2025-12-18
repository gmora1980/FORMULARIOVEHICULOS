
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCotizar));
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
            this.lblPrecioOriginal.Location = new System.Drawing.Point(14, 14);
            this.lblPrecioOriginal.Name = "lblPrecioOriginal";
            this.lblPrecioOriginal.Size = new System.Drawing.Size(189, 29);
            this.lblPrecioOriginal.TabIndex = 0;
            this.lblPrecioOriginal.Text = "Precio Original";
            // 
            // txtOriginalPrice
            // 
            this.txtOriginalPrice.Enabled = false;
            this.txtOriginalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginalPrice.Location = new System.Drawing.Point(194, 18);
            this.txtOriginalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOriginalPrice.Name = "txtOriginalPrice";
            this.txtOriginalPrice.Size = new System.Drawing.Size(239, 35);
            this.txtOriginalPrice.TabIndex = 1;
            // 
            // lblServicioAdicional
            // 
            this.lblServicioAdicional.AutoSize = true;
            this.lblServicioAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicioAdicional.Location = new System.Drawing.Point(14, 98);
            this.lblServicioAdicional.Name = "lblServicioAdicional";
            this.lblServicioAdicional.Size = new System.Drawing.Size(264, 29);
            this.lblServicioAdicional.TabIndex = 2;
            this.lblServicioAdicional.Text = "Servicios Adicionales";
            // 
            // cmbServiciosAdicionales
            // 
            this.cmbServiciosAdicionales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServiciosAdicionales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServiciosAdicionales.FormattingEnabled = true;
            this.cmbServiciosAdicionales.Location = new System.Drawing.Point(291, 91);
            this.cmbServiciosAdicionales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbServiciosAdicionales.Name = "cmbServiciosAdicionales";
            this.cmbServiciosAdicionales.Size = new System.Drawing.Size(364, 37);
            this.cmbServiciosAdicionales.TabIndex = 3;
            this.cmbServiciosAdicionales.SelectionChangeCommitted += new System.EventHandler(this.cmbServiciosAdicionales_SelectionChangeCommitted);
            // 
            // btnAddService
            // 
            this.btnAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddService.Image = ((System.Drawing.Image)(resources.GetObject("btnAddService.Image")));
            this.btnAddService.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddService.Location = new System.Drawing.Point(12, 146);
            this.btnAddService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(164, 109);
            this.btnAddService.TabIndex = 4;
            this.btnAddService.Text = "Agregar Servicio";
            this.btnAddService.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // grbProforma
            // 
            this.grbProforma.Controls.Add(this.dgvProforma);
            this.grbProforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProforma.Location = new System.Drawing.Point(21, 263);
            this.grbProforma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbProforma.Name = "grbProforma";
            this.grbProforma.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbProforma.Size = new System.Drawing.Size(1187, 333);
            this.grbProforma.TabIndex = 5;
            this.grbProforma.TabStop = false;
            this.grbProforma.Text = "Proforma";
            // 
            // dgvProforma
            // 
            this.dgvProforma.AllowUserToAddRows = false;
            this.dgvProforma.AllowUserToDeleteRows = false;
            this.dgvProforma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProforma.Location = new System.Drawing.Point(10, 118);
            this.dgvProforma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProforma.Name = "dgvProforma";
            this.dgvProforma.ReadOnly = true;
            this.dgvProforma.RowHeadersWidth = 51;
            this.dgvProforma.RowTemplate.Height = 24;
            this.dgvProforma.Size = new System.Drawing.Size(1143, 289);
            this.dgvProforma.TabIndex = 0;
            // 
            // btnEliminarServicio
            // 
            this.btnEliminarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarServicio.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarServicio.Image")));
            this.btnEliminarServicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarServicio.Location = new System.Drawing.Point(205, 146);
            this.btnEliminarServicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminarServicio.Name = "btnEliminarServicio";
            this.btnEliminarServicio.Size = new System.Drawing.Size(131, 111);
            this.btnEliminarServicio.TabIndex = 6;
            this.btnEliminarServicio.Text = "Eliminar Servicio";
            this.btnEliminarServicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarServicio.UseVisualStyleBackColor = true;
            this.btnEliminarServicio.Click += new System.EventHandler(this.btnEliminarServicio_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAtras.Location = new System.Drawing.Point(535, 156);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(101, 86);
            this.btnAtras.TabIndex = 7;
            this.btnAtras.Text = "Atras";
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(33, 651);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(81, 29);
            this.lblCosto.TabIndex = 8;
            this.lblCosto.Text = "Costo";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.Location = new System.Drawing.Point(399, 651);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(52, 29);
            this.lblIVA.TabIndex = 9;
            this.lblIVA.Text = "IVA";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(709, 651);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(73, 29);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total";
            // 
            // txtCosto
            // 
            this.txtCosto.Enabled = false;
            this.txtCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(117, 648);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(239, 35);
            this.txtCosto.TabIndex = 11;
            // 
            // txtIVA
            // 
            this.txtIVA.Enabled = false;
            this.txtIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIVA.Location = new System.Drawing.Point(460, 648);
            this.txtIVA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(239, 35);
            this.txtIVA.TabIndex = 12;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(806, 645);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(239, 35);
            this.txtTotal.TabIndex = 13;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.Location = new System.Drawing.Point(370, 145);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(144, 110);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar Proforma";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(483, 21);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(84, 29);
            this.lblMarca.TabIndex = 15;
            this.lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(570, 21);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(239, 35);
            this.txtMarca.TabIndex = 16;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(836, 28);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(101, 29);
            this.lblModelo.TabIndex = 17;
            this.lblModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(935, 24);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(239, 35);
            this.txtModelo.TabIndex = 18;
            // 
            // frmCotizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 755);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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