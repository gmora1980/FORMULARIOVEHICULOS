
namespace FORMULARIOVEHICULOS
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eMPLEADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEditarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEditarVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recepcionistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONTACTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANUALDEUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aCERCADEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.cajeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTESToolStripMenuItem1,
            this.eMPLEADOSToolStripMenuItem,
            this.SALIRToolStripMenuItem,
            this.cONTACTOToolStripMenuItem,
            this.mANUALDEUSUARIOToolStripMenuItem,
            this.aCERCADEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1240, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eMPLEADOSToolStripMenuItem
            // 
            this.eMPLEADOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesionToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem,
            this.administradorToolStripMenuItem,
            this.recepcionistaToolStripMenuItem,
            this.agenteToolStripMenuItem,
            this.cajeroToolStripMenuItem});
            this.eMPLEADOSToolStripMenuItem.Name = "eMPLEADOSToolStripMenuItem";
            this.eMPLEADOSToolStripMenuItem.Size = new System.Drawing.Size(129, 29);
            this.eMPLEADOSToolStripMenuItem.Text = "EMPLEADOS";
            this.eMPLEADOSToolStripMenuItem.Click += new System.EventHandler(this.eMPLEADOSToolStripMenuItem_Click);
            // 
            // iniciarSesionToolStripMenuItem
            // 
            this.iniciarSesionToolStripMenuItem.Name = "iniciarSesionToolStripMenuItem";
            this.iniciarSesionToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.iniciarSesionToolStripMenuItem.Text = "Iniciar Sesion";
            this.iniciarSesionToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesionToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEditarEmpleadoToolStripMenuItem,
            this.agregarEditarVehiculosToolStripMenuItem});
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // agregarEditarEmpleadoToolStripMenuItem
            // 
            this.agregarEditarEmpleadoToolStripMenuItem.Name = "agregarEditarEmpleadoToolStripMenuItem";
            this.agregarEditarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(325, 34);
            this.agregarEditarEmpleadoToolStripMenuItem.Text = "Agregar / Editar Empleado";
            this.agregarEditarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.agregarEditarEmpleadoToolStripMenuItem_Click);
            // 
            // agregarEditarVehiculosToolStripMenuItem
            // 
            this.agregarEditarVehiculosToolStripMenuItem.Name = "agregarEditarVehiculosToolStripMenuItem";
            this.agregarEditarVehiculosToolStripMenuItem.Size = new System.Drawing.Size(325, 34);
            this.agregarEditarVehiculosToolStripMenuItem.Text = "Agregar / Editar Vehiculos";
            this.agregarEditarVehiculosToolStripMenuItem.Click += new System.EventHandler(this.agregarEditarVehiculosToolStripMenuItem_Click);
            // 
            // recepcionistaToolStripMenuItem
            // 
            this.recepcionistaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarCitasToolStripMenuItem});
            this.recepcionistaToolStripMenuItem.Name = "recepcionistaToolStripMenuItem";
            this.recepcionistaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.recepcionistaToolStripMenuItem.Text = "Recepcionista";
            // 
            // gestionarCitasToolStripMenuItem
            // 
            this.gestionarCitasToolStripMenuItem.Name = "gestionarCitasToolStripMenuItem";
            this.gestionarCitasToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.gestionarCitasToolStripMenuItem.Text = "Gestionar Citas";
            this.gestionarCitasToolStripMenuItem.Click += new System.EventHandler(this.gestionarCitasToolStripMenuItem_Click);
            // 
            // agenteToolStripMenuItem
            // 
            this.agenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroCitasToolStripMenuItem});
            this.agenteToolStripMenuItem.Name = "agenteToolStripMenuItem";
            this.agenteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.agenteToolStripMenuItem.Text = "Agente";
            // 
            // registroCitasToolStripMenuItem
            // 
            this.registroCitasToolStripMenuItem.Name = "registroCitasToolStripMenuItem";
            this.registroCitasToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.registroCitasToolStripMenuItem.Text = "Registro Citas";
            this.registroCitasToolStripMenuItem.Click += new System.EventHandler(this.registroCitasToolStripMenuItem_Click);
            // 
            // SALIRToolStripMenuItem
            // 
            this.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem";
            this.SALIRToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.SALIRToolStripMenuItem.Text = "SALIR";
            this.SALIRToolStripMenuItem.Click += new System.EventHandler(this.SALIRToolStripMenuItem_Click);
            // 
            // cONTACTOToolStripMenuItem
            // 
            this.cONTACTOToolStripMenuItem.Name = "cONTACTOToolStripMenuItem";
            this.cONTACTOToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.cONTACTOToolStripMenuItem.Text = "CONTACTO";
            this.cONTACTOToolStripMenuItem.Click += new System.EventHandler(this.cONTACTOToolStripMenuItem_Click);
            // 
            // mANUALDEUSUARIOToolStripMenuItem
            // 
            this.mANUALDEUSUARIOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.empleadosToolStripMenuItem1});
            this.mANUALDEUSUARIOToolStripMenuItem.Name = "mANUALDEUSUARIOToolStripMenuItem";
            this.mANUALDEUSUARIOToolStripMenuItem.Size = new System.Drawing.Size(209, 29);
            this.mANUALDEUSUARIOToolStripMenuItem.Text = "MANUAL DE USUARIO";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem1
            // 
            this.empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
            this.empleadosToolStripMenuItem1.Size = new System.Drawing.Size(202, 34);
            this.empleadosToolStripMenuItem1.Text = "Empleados";
            this.empleadosToolStripMenuItem1.Click += new System.EventHandler(this.empleadosToolStripMenuItem1_Click);
            // 
            // aCERCADEToolStripMenuItem
            // 
            this.aCERCADEToolStripMenuItem.Name = "aCERCADEToolStripMenuItem";
            this.aCERCADEToolStripMenuItem.Size = new System.Drawing.Size(133, 29);
            this.aCERCADEToolStripMenuItem.Text = "ACERCA DE...";
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.AllowUserToAddRows = false;
            this.dgvVehiculos.AllowUserToDeleteRows = false;
            this.dgvVehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVehiculos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Location = new System.Drawing.Point(0, 41);
            this.dgvVehiculos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.ReadOnly = true;
            this.dgvVehiculos.RowHeadersWidth = 51;
            this.dgvVehiculos.RowTemplate.Height = 24;
            this.dgvVehiculos.Size = new System.Drawing.Size(1226, 550);
            this.dgvVehiculos.TabIndex = 2;
            this.dgvVehiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculos_CellClick);
            // 
            // cajeroToolStripMenuItem
            // 
            this.cajeroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturacionToolStripMenuItem});
            this.cajeroToolStripMenuItem.Name = "cajeroToolStripMenuItem";
            this.cajeroToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.cajeroToolStripMenuItem.Text = "Cajero";
            // 
            // cLIENTESToolStripMenuItem1
            // 
            this.cLIENTESToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesionToolStripMenuItem1,
            this.cerrarSesionToolStripMenuItem1});
            this.cLIENTESToolStripMenuItem1.Name = "cLIENTESToolStripMenuItem1";
            this.cLIENTESToolStripMenuItem1.Size = new System.Drawing.Size(102, 29);
            this.cLIENTESToolStripMenuItem1.Text = "CLIENTES";
            // 
            // iniciarSesionToolStripMenuItem1
            // 
            this.iniciarSesionToolStripMenuItem1.Name = "iniciarSesionToolStripMenuItem1";
            this.iniciarSesionToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.iniciarSesionToolStripMenuItem1.Text = "Iniciar Sesion";
            // 
            // cerrarSesionToolStripMenuItem1
            // 
            this.cerrarSesionToolStripMenuItem1.Name = "cerrarSesionToolStripMenuItem1";
            this.cerrarSesionToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.cerrarSesionToolStripMenuItem1.Text = "Cerrar Sesion";
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 604);
            this.ControlBox = false;
            this.Controls.Add(this.dgvVehiculos);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPrincipal";
            this.Text = "Venta Vehiculos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eMPLEADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANUALDEUSUARIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aCERCADEToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.ToolStripMenuItem cONTACTOToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem recepcionistaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem agregarEditarEmpleadoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem agregarEditarVehiculosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem gestionarCitasToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem agenteToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem registroCitasToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
    }
}

