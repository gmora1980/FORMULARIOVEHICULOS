using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using Connection;

namespace FORMULARIOVEHICULOS
{
    public partial class frmDetails : Form
    {
  
        public frmDetails()
        {
            InitializeComponent();
            
        }
        public void Visualice(string placa)
        {
            try
            {
                string connect = "select Placa, Clase, Tipo_Vehiculo, Motor, Combustible, Marca, Modelo, Transmision, Anio, " +
                                "Pasajeros, Equipamiento, Audio, Seguridad, Video, Imagen_URL, Precio from VEHICULOS where Placa=@Placa";
                DataSet set = Connect.Execute(connect.Replace("@Placa", $"'{placa}'"));
                if (set.Tables[0].Rows.Count > 0)
                {

                    DataRow row = set.Tables[0].Rows[0];
                    txtPlaca.Text = row["Placa"].ToString();
                    txtClase.Text = row["Clase"].ToString();
                    txtTipo.Text = row["Tipo_Vehiculo"].ToString();
                    txtMotor.Text = row["Motor"].ToString();
                    txtCombustible.Text = row["Combustible"].ToString();
                    txtMarca.Text = row["Marca"].ToString();
                    txtModelo.Text = row["Modelo"].ToString();
                    txtTransmision.Text = row["Transmision"].ToString();
                    txtAnio.Text = row["Anio"].ToString();
                    txtPasajeros.Text = row["Pasajeros"].ToString();
                    txtEquipamiento.Text = row["Equipamiento"].ToString();
                    txtAudio.Text = row["Audio"].ToString();
                    txtSeguridad.Text = row["Seguridad"].ToString();
                    txtVideo.Text = row["Video"].ToString();
                    txtPrecio.Text = row["Precio"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontraron detalles para la placa especificada.");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: 002: " + ex.Message);
            }
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

