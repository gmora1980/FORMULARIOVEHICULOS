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
    public partial class frmRegistroCitasAgente : Form
    {
        private int Cedula;

        public frmRegistroCitasAgente(int agenteID)
        {
            InitializeComponent();
            this.Cedula = agenteID;
            CargarCitas();
        }
        private void CargarCitas()
        {
            try
            {
                // Consulta SQL para obtener las citas del agente
                string consulta = $@"
        select c.ID_Cita, cl.Nombre, cl.Primer_Apellido, cl.Segundo_Apellido,cl.Consultas, cl.Cedula, cl.Preferencia_Contacto, cl.Mail, cl.Telefono, c.Fecha, c.Hora
        from CITAS c
        join CLIENTES cl ON c.ID_Cliente = cl.Cedula
        where c.Identificacion = '{Cedula}'";

                DataSet dataSet = Connect.Execute(consulta);
                DataTable dataTable = dataSet.Tables[0];

                // Configurar columnas basadas en la preferencia de contacto
                foreach (DataRow row in dataTable.Rows)
                {
                    string preferencia = row["Preferencia_Contacto"].ToString();
                    if (preferencia == "Mail")
                    {
                        row["Telefono"] = DBNull.Value; // Eliminar el teléfono si la preferencia es solo Mail
                    }
                    else if (preferencia == "Telefono")
                    {
                        row["Mail"] = DBNull.Value; // Eliminar el correo si la preferencia es solo Teléfono
                    }
                }

                dgvCitas.DataSource = dataTable;

                // Configuración adicional del DataGridView
                dgvCitas.Columns["ID_Cita"].Visible = false;
                dgvCitas.Columns["Cedula"].Visible = false;

                dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCitas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al cargar las citas: " + ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
