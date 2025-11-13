using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using Connection;
namespace FORMULARIOVEHICULOS
{
        public partial class frmCotizar : Form
    {
        public DataSet datos;
        string numServ;
        decimal CostVehicule;
        string PlacaV;
        public frmCotizar()
        {
            InitializeComponent();
        }
        public void Cotice(string placa)
        {
            try
            {
                PlacaV = placa;
                string conn = string.Format("select Marca, Modelo, Precio from VEHICULOS where Placa=@Placa");
                datos = Connect.Execute(conn.Replace("@Placa", $"'{placa}'"));
                if (datos.Tables[0].Rows.Count > 0)
                {
                    DataRow row = datos.Tables[0].Rows[0];
                    txtMarca.Text = row["Marca"].ToString();
                    txtModelo.Text = row["Modelo"].ToString();
                }
                    CostVehicule = Convert.ToDecimal(datos.Tables[0].Rows[0]["Precio"]);
                txtOriginalPrice.Text = CostVehicule.ToString("C");
                decimal initialIVA = CostVehicule * 0.13M;
                decimal initialTotal = CostVehicule + initialIVA;
                txtCosto.Text = CostVehicule.ToString("C");
                txtIVA.Text = initialIVA.ToString("C");
                txtTotal.Text = initialTotal.ToString("C");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: 005: " + ex.Message);
            }
        }

        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProforma.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvProforma.SelectedRows)
                    {
                        if (!row.IsNewRow) // Ensure it's not a new row placeholder
                        {
                            dgvProforma.Rows.Remove(row);
                        }
                    }
                    CalcularService();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un servicio para eliminar");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error al eliminar el servicio: " + ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCotizar_Load(object sender, EventArgs e)
        {
            try
            {
                dgvProforma.Columns.Add("Descripcion", "Descripción");
                dgvProforma.Columns.Add("Costo", "Costo");
                dgvProforma.Columns.Add("ID_Servicio", "ID Servicio");
                dgvProforma.AutoGenerateColumns = false;
                dgvProforma.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvProforma.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                string carga = "select Descripcion from SERVICIO_ADICIONAL";
                datos = Connect.Execute(carga);
                cmbServiciosAdicionales.DataSource = datos.Tables[0].DefaultView;
                cmbServiciosAdicionales.ValueMember = "Descripcion";
                cmbServiciosAdicionales.SelectedItem = null;
            }catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: 004: " + ex.Message);
            }
        }

        private void cmbServiciosAdicionales_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string carga = string.Format("select ID_Servicio from SERVICIO_ADICIONAL where Descripcion = '{0}'", cmbServiciosAdicionales.Text);
                datos = Connect.Execute(carga);
                numServ = datos.Tables[0].Rows[0]["ID_Servicio"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: 003: " + ex.Message);
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbServiciosAdicionales.SelectedItem != null)
                {
                    string Descrip = cmbServiciosAdicionales.Text;
                    string conn = string.Format("select Costo, ID_Servicio from SERVICIO_ADICIONAL where Descripcion='{0}'", Descrip);
                    datos = Connect.Execute(conn);
                    decimal PriceServ = Convert.ToDecimal(datos.Tables[0].Rows[0]["Costo"]);
                    string ID_Serv = datos.Tables[0].Rows[0]["ID_Servicio"].ToString();
                    dgvProforma.Rows.Add(Descrip, PriceServ.ToString("C"), ID_Serv);
                    CalcularService();
                }
                else
                {
                    MessageBox.Show("Seleccione un Servicio Adicional");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: 006: " + ex.Message);
            }
        }
        private void CalcularService()
        {
            try
            {
                decimal total=0;
                foreach (DataGridViewRow row in dgvProforma.Rows)
                {
                    total += decimal.Parse(row.Cells[1].Value.ToString(), NumberStyles.Currency);
                }
                decimal totalPrevio = CostVehicule + total;
                decimal IVA = totalPrevio * 0.13M;
                decimal FinalCost = totalPrevio + IVA;

                txtCosto.Text = totalPrevio.ToString("C");
                txtIVA.Text = IVA.ToString("C");
                txtTotal.Text = FinalCost.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error para el calculo del total: " + ex.Message);
            }

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvProforma.Rows)
                {
                    string ID_Servicio = row.Cells[2].Value.ToString();

                    // Correct the SQL query, ensure the table name is correct
                    string consulta = string.Format("insert into VEHICULO_SERVICIO (Placa, ID_Servicio) values ('{0}', '{1}')", PlacaV, ID_Servicio);

                    // Execute the query
                    Connect.Execute(consulta);
                }

                MessageBox.Show("Cotización aceptada. Detalles guardados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: 007: " + ex.Message);
            }
        }
    }
}
