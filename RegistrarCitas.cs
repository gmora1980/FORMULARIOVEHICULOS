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
    public partial class frmRegistrarCitas : Form
    {
        public frmRegistrarCitas()
        {
            InitializeComponent();
            LoadClientes();
            LoadAgentes();
        }
        private void LoadClientes()
        {
            try
            {
                string conn = "select Cedula, Nombre, Preferencia_Contacto, Mail, Telefono from CLIENTES";
                DataSet dataS = Connect.Execute(conn);
                cmbClientes.DataSource = dataS.Tables[0];
                cmbClientes.DisplayMember = "Nombre";
                cmbClientes.ValueMember = "Cedula";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado: " + ex.Message);
            }

        }
        private void LoadAgentes()
        {
            try
            {
                string conn = "select e.Nombre, e.Identificacion from EMPLEADOS e join USUARIO u on e.Identificacion=u.Identificacion where u.Rol='Agente'";
                DataSet dataS = Connect.Execute(conn);
                cmbAgentes.DataSource = dataS.Tables[0];
                cmbAgentes.DisplayMember = "Nombre";
                cmbAgentes.ValueMember = "Identificacion";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado: " + ex.Message);
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(cmbClientes.SelectedIndex==-1 || cmbClientes.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtID_Cita.Text))
            {
                MessageBox.Show("Debe seleccionar un cliente y un agente por favor");
            }
            try
            {
                int ID_Cita = int.Parse(txtID_Cita.Text);
                int ID_Cliente = int.Parse(cmbClientes.SelectedValue.ToString());
                int ID_Agente = int.Parse(cmbAgentes.SelectedValue.ToString());
                DateTime fecha = dtpFecha.Value.Date;
                DateTime time = dtpHora.Value;

                string cita = $@"insert into CITAS (ID_Cita, Fecha, Hora, ID_Cliente, Identificacion) values ({ID_Cita},'{fecha.ToString("yyyy-MM-dd")}','{time.ToString("HH:mm:ss")}',
    {ID_Cliente},{ID_Agente})";
                Connect.Execute(cita);
                string conn2 = $@"
                INSERT INTO RESERVA_CITA (ID_Reserva, ID_Cita, Identificacion) 
                VALUES ({ID_Cita}, {ID_Cita}, {ID_Agente})";

                Connect.Execute(conn2);
                MessageBox.Show("La cita fue registrada exitosamente");
                Clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado: " + ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCedula.Enabled = false;
            txtMail.Enabled = false;
            txtPreferencia.Enabled = false;
            txtTelefono.Enabled = false;
            try
            {
                DataRowView row = (DataRowView)cmbClientes.SelectedItem;
                txtCedula.Text = row["Cedula"].ToString();
                txtPreferencia.Text = row["Preferencia_Contacto"].ToString();
                if (txtPreferencia.Text == "Ambos")
                {
                    txtTelefono.Text = row["Telefono"].ToString();
                    txtMail.Text = row["Mail"].ToString();
                }else if (txtPreferencia.Text == "Mail")
                {
                    txtMail.Text = row["Mail"].ToString();
                }
                else
                {
                    txtTelefono.Text = row["Telefono"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado: " + ex.Message);
            }
        }
        private void Clean()
        {
            txtCedula.Clear();
            txtMail.Clear();
            txtPreferencia.Clear();
            txtTelefono.Clear();
            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;

        }
    }
}
