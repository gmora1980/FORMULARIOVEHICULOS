using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connection;
namespace FORMULARIOVEHICULOS
{
    public partial class frmAgregar_EditarVehiculos : Form
    {

        public event EventHandler VehiculoModificado;
        public frmAgregar_EditarVehiculos()
        {
            InitializeComponent();
            CargarVehiculos();
        }
        public void CargarVehiculos()
        {
            try
            {
                string conn = "select Placa, Marca, Modelo, Anio, Precio from VEHICULOS";
                DataSet dataS = Connect.Execute(conn);
                dgvVehiculos.DataSource = dataS.Tables[0];
                dgvVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvVehiculos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            }catch(Exception ex)
            {
                MessageBox.Show("Error al cargar los vehiculos: " + ex.Message);
            }
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlaca.Text) ||
       string.IsNullOrWhiteSpace(txtClase.Text) ||
       string.IsNullOrWhiteSpace(txtTipo_Vehiculo.Text) ||
       string.IsNullOrWhiteSpace(txtMotor.Text) ||
       string.IsNullOrWhiteSpace(txtCombustible.Text) ||
       string.IsNullOrWhiteSpace(txtMarca.Text) ||
       string.IsNullOrWhiteSpace(txtModelo.Text) ||
       string.IsNullOrWhiteSpace(txtTransmision.Text) ||
       string.IsNullOrWhiteSpace(txtPasajeros.Text) ||
       string.IsNullOrWhiteSpace(txtEquipamiento.Text) ||
       string.IsNullOrWhiteSpace(txtAudio.Text) ||
       string.IsNullOrWhiteSpace(txtSeguridad.Text) ||
       string.IsNullOrWhiteSpace(txtVideo.Text) ||
       string.IsNullOrWhiteSpace(txtImagen_URL.Text) ||
       string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            string ImagenUr = txtImagen_URL.Text;
            try
            {
                string conn = $@"insert into VEHICULOS (Placa, Clase, Tipo_Vehiculo, Motor, Combustible, Marca, Modelo, Transmision, Anio, Pasajeros, 
Equipamiento, Audio, Seguridad, Video, Imagen_URL, Precio)
values ('{txtPlaca.Text}','{txtClase.Text}','{txtTipo_Vehiculo.Text}','{txtMotor.Text}','{txtCombustible.Text}','{txtMarca.Text}','{txtModelo.Text}',
'{txtTransmision.Text}','{dtpCreacion.Value.ToString("yyyy-MM-dd")}',{txtPasajeros.Text},'{txtEquipamiento.Text}','{txtAudio.Text}','{txtSeguridad.Text}','{txtVideo.Text}',
'{ImagenUr}',{txtPrecio.Text})";
                DataSet dataS = Connect.Execute(conn);
                VehiculoModificado?.Invoke(this, EventArgs.Empty);
                CargarVehiculos();
                MessageBox.Show("El vehículo se ingreso de forma exitosa.");
                Clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error inesperado: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string Precio = txtPrecio.Text.Replace(",", ".");
            if (string.IsNullOrWhiteSpace(txtPlaca.Text) ||
                string.IsNullOrWhiteSpace(txtClase.Text) ||
                string.IsNullOrWhiteSpace(txtTipo_Vehiculo.Text) ||
                string.IsNullOrWhiteSpace(txtMotor.Text) ||
                string.IsNullOrWhiteSpace(txtCombustible.Text) ||
                string.IsNullOrWhiteSpace(txtMarca.Text) ||
                string.IsNullOrWhiteSpace(txtModelo.Text) ||
                string.IsNullOrWhiteSpace(txtTransmision.Text) ||
                string.IsNullOrWhiteSpace(txtPasajeros.Text) ||
                string.IsNullOrWhiteSpace(txtEquipamiento.Text) ||
                string.IsNullOrWhiteSpace(txtAudio.Text) ||
                string.IsNullOrWhiteSpace(txtSeguridad.Text) ||
                string.IsNullOrWhiteSpace(txtVideo.Text) ||
                string.IsNullOrWhiteSpace(txtImagen_URL.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");

            }
            try
            {
                string conn = $@"update VEHICULOS set Clase='{txtClase.Text}', Tipo_Vehiculo='{txtTipo_Vehiculo.Text}', Motor='{txtMotor.Text}', Combustible='{txtCombustible.Text}',
Marca='{txtMarca.Text}', Modelo='{txtModelo.Text}', Transmision='{txtTransmision.Text}', Anio='{dtpCreacion.Value.ToString("yyyy-MM-dd")}', Pasajeros={txtPasajeros.Text}, 
Equipamiento='{txtEquipamiento.Text}', Audio='{txtAudio.Text}', Seguridad='{txtSeguridad.Text}', Video='{txtVideo.Text}', Imagen_URL='{txtImagen_URL.Text}', Precio={Precio} where Placa='{txtPlaca.Text}'";
                DataSet dataS = Connect.Execute(conn);
                VehiculoModificado?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("El vehículo se actualizo de forma exitosa.");
                CargarVehiculos();
                Clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error inesperado: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlaca.Text))
            {
                MessageBox.Show("Por favor, seleccione un vehículo para eliminar.");
            }
            DialogResult result = MessageBox.Show("Esta seguro de eliminar este empleado?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string conn = $"delete from VEHICULO_SERVICIO where Placa= (select Placa from VEHICULOS where Placa='{txtPlaca.Text}')";
                    Connect.Execute(conn);
                    string conn2 = $"delete from VEHICULOS where Placa='{txtPlaca.Text}'";
                    Connect.Execute(conn2);
                    VehiculoModificado?.Invoke(this, EventArgs.Empty);
                    CargarVehiculos();
                    MessageBox.Show("El vehículo se ha eliminado de forma exitosa.");
                    Clean();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error inesperado: " + ex.Message);
                }
            }
        }

        private void dgvVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPlaca.Enabled = false;
            DataGridViewRow seleccion = dgvVehiculos.Rows[e.RowIndex];
            string placa = seleccion.Cells["Placa"].Value.ToString();
            try
            {
                string conn = $@"select Placa, Clase, Tipo_Vehiculo, Motor, Combustible, Marca, Modelo, Transmision, Anio, Pasajeros, Equipamiento, Audio, Seguridad, Video, Imagen_URL, Precio from VEHICULOS where Placa='{placa}'";
                DataSet dataS = Connect.Execute(conn);
                if (dataS.Tables[0].Rows.Count > 0)
                {
                    DataRow row = dataS.Tables[0].Rows[0];
                    txtPlaca.Text=row["Placa"].ToString();
                    txtClase.Text = row["Clase"].ToString();
                    txtTipo_Vehiculo.Text = row["Tipo_Vehiculo"].ToString();
                    txtMotor.Text = row["Motor"].ToString();
                    txtCombustible.Text = row["Combustible"].ToString();
                    txtMarca.Text = row["Marca"].ToString();
                    txtModelo.Text=row["Modelo"].ToString();
                    txtTransmision.Text = row["Transmision"].ToString();
                    dtpCreacion.Value = Convert.ToDateTime(row["Anio"]);
                    txtPasajeros.Text=row["Pasajeros"].ToString();
                    txtEquipamiento.Text = row["Equipamiento"].ToString();
                    txtAudio.Text=row["Audio"].ToString();
                    txtSeguridad.Text=row["Seguridad"].ToString();
                    txtVideo.Text = row["Video"].ToString();
                    txtImagen_URL.Text = row["Imagen_URL"].ToString();
                    txtPrecio.Text=row["Precio"].ToString();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error inesperado: " + ex.Message);
            }
        }
        public void Clean()
        {
            txtPlaca.Clear();
            txtModelo.Clear();
            txtMotor.Clear();
            txtImagen_URL.Clear();
            txtMarca.Clear();
            dtpCreacion.Value = DateTime.Now;
            txtCombustible.Clear();
            txtClase.Clear();
            txtPasajeros.Clear();
            txtAudio.Clear();
            txtSeguridad.Clear();
            txtPrecio.Clear();
            txtVideo.Clear();
            txtTipo_Vehiculo.Clear();
            txtTransmision.Clear();
            txtEquipamiento.Clear();
            txtPlaca.Enabled = true;
        }
    }
}
