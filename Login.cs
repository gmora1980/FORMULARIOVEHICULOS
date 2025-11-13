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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Clean()
        {
            txtUsuario.Clear();
            txtPass.Clear();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int idUsuario;
                if (!int.TryParse(txtUsuario.Text.Trim(), out idUsuario))
                {
                    MessageBox.Show("El ID de usuario debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string pass;
                string Password;
                pass = Connect.To_Code(txtPass.Text);
                Password = Connect.Decode(pass);
                string cm = string.Format($"select * from USUARIO where ID_Usuario ={idUsuario} and Contrasenia ='{Password}'");
                DataSet dat = Connect.Execute(cm);
                if(dat.Tables.Count>0 && dat.Tables[0].Rows.Count > 0)
                {
                    string usser = dat.Tables[0].Rows[0]["ID_Usuario"].ToString();
                    string clave = dat.Tables[0].Rows[0]["Contrasenia"].ToString();
                    string rol = dat.Tables[0].Rows[0]["Rol"].ToString();
                    int cedula = int.Parse(dat.Tables[0].Rows[0]["Identificacion"].ToString());

                    if (usser == txtUsuario.Text.Trim() && clave == Password)
                    {
                        frmPrincipal principal = new frmPrincipal(rol,cedula);

                        principal.cerrarSesionToolStripMenuItem.Visible = true;
                        this.Hide();
                        principal.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrecto. Favor verifique.", "Ingreso al Sistema");
                        Clean();
                    }
                }
            }             
            catch (Exception ex)
            {

                ex.ToString();
                MessageBox.Show("Usuario o contraseña incorrecto. Favor verifique.", "Ingreso al Sistema");
                Clean();
            }
        }


    }
}
