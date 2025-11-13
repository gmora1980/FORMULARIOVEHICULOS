using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connection;
using System.Net.Http;
using System.IO;
using System.Diagnostics;
namespace FORMULARIOVEHICULOS
{
    public partial class frmPrincipal : Form
    {
        public DataSet data;
        public string RolUsuario { get; private set; }
        public int Cedula { get; private set; }
        public frmPrincipal()
        {
            InitializeComponent();
 

        }
        public frmPrincipal(string rol, int id):this()
        {
            RolUsuario = rol;
            Cedula = id;
            iniciarSesionToolStripMenuItem.Visible = false;


        }
        private void agregarEditarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmAgrega_Editar_Empleado add_edit = new frmAgrega_Editar_Empleado())
            {
                add_edit.ShowDialog();
                frmPrincipal_Load(sender, e);
            }
                
        }

        private void agregarEditarVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmAgregar_EditarVehiculos add_edit = new frmAgregar_EditarVehiculos())
            {
                // Suscribirse al evento VehiculoModificado
                add_edit.VehiculoModificado += (s, ev) => Recargar();

                add_edit.ShowDialog(); // Mostrar el formulario de manera modal
            }
        }
        private void Recargar()
        {
            string info = "select Placa, Clase, Transmision, Anio, Imagen_URL, Precio from VEHICULOS";
            DataSet data = Connect.Execute(info);
            DataTable tabla = data.Tables[0];

            // Agregar la columna de imagen al DataTable
            DataColumn imageColumn = new DataColumn("Imagen", typeof(Image));
            tabla.Columns.Add(imageColumn);

            // Descargar e insertar imágenes
            using (HttpClient httpClient = new HttpClient())
            {
                foreach (DataRow row in tabla.Rows)
                {
                    string imageUrl = row["Imagen_URL"].ToString();

                    try
                    {
                        // Descargar imagen de manera sincrónica
                        byte[] imageData = httpClient.GetByteArrayAsync(imageUrl).Result;

                        // Convertir datos a imagen
                        using (MemoryStream memoryStream = new MemoryStream(imageData))
                        {
                            Image vehiculoImage = Image.FromStream(memoryStream);
                            row["Imagen"] = vehiculoImage; // Insertar la imagen en el DataTable
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejar errores específicos de la descarga de imágenes
                        MessageBox.Show($"Error al descargar imagen de {imageUrl}: {ex.Message}");
                        row["Imagen"] = null; // En caso de error, establecer el valor como null
                    }
                }
            }

            // Eliminar la columna de URL de la imagen
            tabla.Columns.Remove("Imagen_URL");

            // Configurar columnas del DataGridView
            dgvVehiculos.Columns.Clear(); // Limpiar columnas existentes

            dgvVehiculos.AutoGenerateColumns = false;

            // Configurar columna de imagen
            DataGridViewImageColumn imageCol = new DataGridViewImageColumn
            {
                HeaderText = "Vehiculo",
                Name = "Vehiculo",
                DataPropertyName = "Imagen", // Nombre de la columna en el DataTable
                ImageLayout = DataGridViewImageCellLayout.Zoom // Ajustar el tamaño de la imagen
            };
            dgvVehiculos.Columns.Add(imageCol);

            // Crear y agregar manualmente las columnas
            string[] columnas = { "Placa", "Clase", "Transmision", "Anio", "Precio" };
            foreach (string columna in columnas)
            {
                dgvVehiculos.Columns.Add(columna, columna);
                dgvVehiculos.Columns[columna].DataPropertyName = columna; // Asegura que se enlaza con los datos correctos
            }

            DataGridViewButtonColumn btnDetalles = new DataGridViewButtonColumn
            {
                HeaderText = "Acciones",
                Name = "btnDetalles",
                Text = "Detalles",
                UseColumnTextForButtonValue = true,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.Green,
                    SelectionBackColor = Color.Green
                }
            };
            dgvVehiculos.Columns.Add(btnDetalles);

            DataGridViewButtonColumn btnCotizar = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "btnCotizar",
                Text = "Cotizar",
                UseColumnTextForButtonValue = true,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.Yellow,
                    SelectionBackColor = Color.Yellow
                }
            };
            dgvVehiculos.Columns.Add(btnCotizar);


            // Ajustar tamaño de la columna de imagen
            dgvVehiculos.Columns["Vehiculo"].Width = 100; // Establece el ancho de la columna de imagen
            dgvVehiculos.RowTemplate.Height = 100; // Establece la altura de las filas

            // Ajustar columnas y filas al tamaño de la pantalla
            dgvVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVehiculos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Asignar el DataTable al DataGridView
            dgvVehiculos.DataSource = tabla;
            dgvVehiculos.Dock = DockStyle.Fill;
            dgvVehiculos.Refresh();
        }
        private void gestionarCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarCitas citas = new frmRegistrarCitas();
            citas.Show();
        }

        private void registroCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RolUsuario == "Agente")
            {
                frmRegistroCitasAgente registroCitasAgente = new frmRegistroCitasAgente(Cedula);
                registroCitasAgente.Show();
            }

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\step2\OneDrive\Desktop\Universidad\2 cuatrimestre 2024\Sistemas Computacionales C#\Proyecto\Manuales\manual cliente.pdf");
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\step2\OneDrive\Desktop\Universidad\2 cuatrimestre 2024\Sistemas Computacionales C#\Proyecto\Manuales\manual empleado.pdf");
        }

        private void SALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            dgvVehiculos.Refresh();
            try
            {
                administradorToolStripMenuItem.Visible = RolUsuario=="Administrador";
                agenteToolStripMenuItem.Visible = RolUsuario =="Agente";
                recepcionistaToolStripMenuItem.Visible = RolUsuario == "Recepcionista";
                cerrarSesionToolStripMenuItem.Visible = RolUsuario !=null;
                if (RolUsuario == "Administrador" || RolUsuario == "Agente" || RolUsuario == "Recepcionista")
                {
                    empleadosToolStripMenuItem1.Visible = true;
                    clientesToolStripMenuItem.Visible = false;
                }
                else
                {
                    clientesToolStripMenuItem.Visible = true;
                    empleadosToolStripMenuItem1.Visible = false;
                }

                TableLayoutPanel layout = new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    ColumnCount = 1,
                    RowCount = 2
                };

                // Definir las proporciones de las filas: 10% para Label y 90% para DataGridView
                layout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
                layout.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
                this.Controls.Add(layout);

                // Crear y agregar Label como título
                Label lblTitulo = new Label
                {
                    Text = "Listado de Vehículos",
                    AutoSize = true,
                    Font = new Font("Arial", 16, FontStyle.Bold), // Establecer la fuente y tamaño del título
                    ForeColor = Color.Red,
                    TextAlign = ContentAlignment.MiddleCenter, // Centrar el texto
                    Dock = DockStyle.Fill
                };
                layout.Controls.Add(lblTitulo, 0, 0); // Añadir el Label en la primera fila

                layout.Controls.Add(dgvVehiculos, 0, 1);
                // Consulta de datos
                Recargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: 001: " + ex.Message);
            }
        }

        private void dgvVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dgv = sender as DataGridView;
                DataRowView rowView = dgv.Rows[e.RowIndex].DataBoundItem as DataRowView;
                if (rowView == null) return;
                string placa = rowView["Placa"].ToString();
                if (dgv.Columns[e.ColumnIndex].Name == "btnDetalles")
                {
                    frmDetails details = new frmDetails();
                    details.Visualice(placa);
                    details.Show();
                }else if (dgv.Columns[e.ColumnIndex].Name == "btnCotizar")
                {
                    frmCotizar cotizar = new frmCotizar();
                    cotizar.Cotice(placa);
                    cotizar.Show();
                }
            }
        }


        private void cONTACTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCitas cita = new frmCitas();
            cita.Show();
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            administradorToolStripMenuItem.Visible = false;
            agenteToolStripMenuItem.Visible = false;
            recepcionistaToolStripMenuItem.Visible = false;
            cerrarSesionToolStripMenuItem.Visible = false;
            iniciarSesionToolStripMenuItem.Visible = true;
        }
    }
}


