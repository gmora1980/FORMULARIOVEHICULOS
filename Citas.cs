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
    public partial class frmCitas : Form
    {
        string insertar;
        DataSet comm;
        
        public DataSet set;
        public frmCitas()
        {
            InitializeComponent();
            txtCedula.Focus();
            cmbContacto.SelectedIndexChanged += cmbContacto_SelectedIndexChanged;
        }


        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtCedula.Text.Trim(), out int cedula))
                {
                    MessageBox.Show("La cédula debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string TypeID = cmbTipoID.SelectedItem?.ToString();
                string nombre = txtNombre.Text.Trim();
                string apellido1 = txtApellido1.Text.Trim();
                string apellido2 = txtApellido2.Text.Trim();
                string mail = txtMail.Text.Trim();
                string phone = txtTelefono.Text.Trim();
                string contact = cmbContacto.SelectedItem?.ToString();
                string consulta = txtConsulta.Text.Trim();
                if(string.IsNullOrWhiteSpace(txtCedula.Text)|| string.IsNullOrWhiteSpace(nombre)|| string.IsNullOrWhiteSpace(apellido1)|| string.IsNullOrWhiteSpace(apellido2)|| string.IsNullOrWhiteSpace(consulta))
                {
                    MessageBox.Show("No puede quedar ningun espacio en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (string.IsNullOrEmpty(TypeID))
                {
                    MessageBox.Show("Debe seleccionar el tipo de ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (string.IsNullOrEmpty(contact))
                {
                    MessageBox.Show("Debe seleccionar como desea ser contactado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (contact == "Ambos")
                {
                    if (string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(phone))
                    {
                        MessageBox.Show("Debe poner ambos datos de contacto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        insertar = $"insert into CLIENTES (Cedula, Tipo_ID, Nombre, Primer_Apellido, Segundo_Apellido, Mail, Telefono, Preferencia_Contacto, Consultas) values ({cedula},'{TypeID}','{nombre}','{apellido1}','{apellido2}','{mail}','{phone}','{contact}','{consulta}')";
                        comm = Connect.Execute(insertar);
                        MessageBox.Show("Su consulta fue agregada correctamente");
                        Clean();
                    }
                } else if (contact == "Mail")   
                {
                    
                    if (string.IsNullOrEmpty(mail))
                    {
                        MessageBox.Show("Debe poner el mail de preferencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        insertar = $"insert into CLIENTES (Cedula, Tipo_ID, Nombre, Primer_Apellido, Segundo_Apellido, Mail, Preferencia_Contacto, Consultas) values ({cedula},'{TypeID}','{nombre}','{apellido1}','{apellido2}','{mail}','{contact}','{consulta}')";
                        comm = Connect.Execute(insertar);
                        MessageBox.Show("Su consulta fue agregada correctamente");
                        Clean();
                    }
                }
                else if (contact == "Telefono")
                {
                    
                    if (string.IsNullOrEmpty(phone))
                    {
                        MessageBox.Show("Debe poner el telefono de preferencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        insertar = $"insert into CLIENTES (Cedula, Tipo_ID, Nombre, Primer_Apellido, Segundo_Apellido, Telefono, Preferencia_Contacto, Consultas) values ({cedula},'{TypeID}','{nombre}','{apellido1}','{apellido2}','{phone}','{contact}','{consulta}')";
                        comm = Connect.Execute(insertar);
                        MessageBox.Show("Su consulta fue agregada correctamente");
                        Clean();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void cmbContacto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string contact = cmbContacto.SelectedItem?.ToString();

            // Deshabilitar ambos TextBox inicialmente
            txtMail.Enabled = false;
            txtTelefono.Enabled = false;

            // Habilitar el TextBox correspondiente según la selección
            if (contact == "Mail")
            {
                txtMail.Enabled = true;
            }
            else if (contact == "Telefono")
            {
                txtTelefono.Enabled = true;
            }
            else if (contact == "Ambos")
            {
                txtMail.Enabled = true;
                txtTelefono.Enabled = true;
            }
        }
        private void Clean()
        {
            txtCedula.Text = string.Empty;
            cmbTipoID.SelectedIndex = -1; 
            txtNombre.Text = string.Empty;
            txtApellido1.Text = string.Empty;
            txtApellido2.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            cmbContacto.SelectedIndex = -1; 
            txtConsulta.Text = string.Empty;


            txtCedula.Focus();

        }
    }
}
