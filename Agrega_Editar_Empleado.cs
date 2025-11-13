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
	public partial class frmAgrega_Editar_Empleado : Form
	{
				
		public frmAgrega_Editar_Empleado()
		{
			InitializeComponent();
			CargaEmpleados();
		}
		private void CargaEmpleados()
		{
			try
			{
				string conn = "select Tipo_ID, Identificacion, Nombre, Primer_Apellido, Segundo_Apellido, Pais, Ubicacion, Provincia, Distrito, Canton from EMPLEADOS";
				DataSet dat = Connect.Execute(conn);
				dgvEmpleados.DataSource = dat.Tables[0];
				dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				dgvEmpleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error al cargar los empleados: " + ex.Message);
			}
		}
		private void btnAtras_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
			{
				
				if (string.IsNullOrWhiteSpace(txtIdentificacion.Text) ||
					string.IsNullOrWhiteSpace(txtTipoID.Text) ||
					string.IsNullOrWhiteSpace(txtNombre.Text) ||
					string.IsNullOrWhiteSpace(txtApellido1.Text) ||
					string.IsNullOrWhiteSpace(txtApellido2.Text) ||
					string.IsNullOrWhiteSpace(txtCorreoEmpre.Text) ||
					string.IsNullOrWhiteSpace(txtTelefono.Text) ||
					string.IsNullOrWhiteSpace(txtUbicacion.Text) ||
					string.IsNullOrWhiteSpace(txtProvincia.Text) ||
					string.IsNullOrWhiteSpace(txtRol.Text) ||
					string.IsNullOrWhiteSpace(txtDistrito.Text) ||
					string.IsNullOrWhiteSpace(txtCanton.Text) ||
					string.IsNullOrWhiteSpace(txtPais.Text) ||
					string.IsNullOrWhiteSpace(txtEdad.Text))
				{
				MessageBox.Show("Por favor, complete todos los campos.");
				}
            try
            {
				if (!int.TryParse(txtUsuario.Text.Trim(), out int id))
				{
					MessageBox.Show("El ID de usuario debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (!long.TryParse(txtIdentificacion.Text.Trim(), out long idUsuario))
				{
					MessageBox.Show("El numero de cedula debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				string pass = Connect.To_Code(txtClave.Text);
				string password = Connect.Decode(pass);
				string query1 = $@"
            insert into EMPLEADOS 
            (Identificacion, Tipo_ID, Nombre, Primer_Apellido, Segundo_Apellido, Fecha_Nacimiento, Edad, Fecha_Vencimiento_ID, Mail, Telefono, Ubicacion, Provincia, Canton, Distrito, Pais) 
            VALUES 
            ('{idUsuario}', '{txtTipoID.Text}', '{txtNombre.Text}', '{txtApellido1.Text}', '{txtApellido2.Text}', '{dtpFechaNac.Value.ToString("yyyy-MM-dd")}', {txtEdad.Text}, '{dtpFechaVenci.Value.ToString("yyyy-MM-dd")}', '{txtCorreoPersonal.Text}', '{txtTelefono.Text}', '{txtUbicacion.Text}', '{txtProvincia.Text}', '{txtCanton.Text}', '{txtDistrito.Text}', '{txtPais.Text}')";

				string query2 = $@"
            insert into USUARIO 
            (ID_Usuario, Contrasenia, CorreoElectronico, Rol, Identificacion) 
            VALUES 
            ('{id}', '{password}', '{txtCorreoEmpre.Text}', '{txtRol.Text}', '{idUsuario}')";

				// Ejecutar las consultas
				Connect.Execute(query1);
				Connect.Execute(query2);
				CargaEmpleados();
				MessageBox.Show("El empleado se agrego de forma exitosa");
				Clean();

            }
            catch (Exception ex)
            {
				MessageBox.Show("Ocurrio un error inesperado: " + ex.Message);
            }
			
			
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			
			if (string.IsNullOrWhiteSpace(txtIdentificacion.Text) ||
					string.IsNullOrWhiteSpace(txtTipoID.Text) ||
					string.IsNullOrWhiteSpace(txtNombre.Text) ||
					string.IsNullOrWhiteSpace(txtApellido1.Text) ||
					string.IsNullOrWhiteSpace(txtApellido2.Text) ||
					string.IsNullOrWhiteSpace(txtCorreoEmpre.Text) ||
					string.IsNullOrWhiteSpace(txtTelefono.Text) ||
					string.IsNullOrWhiteSpace(txtUbicacion.Text) ||
					string.IsNullOrWhiteSpace(txtProvincia.Text) ||
					string.IsNullOrWhiteSpace(txtRol.Text) ||
					string.IsNullOrWhiteSpace(txtDistrito.Text) ||
					string.IsNullOrWhiteSpace(txtCanton.Text) ||
					string.IsNullOrWhiteSpace(txtPais.Text) ||
					string.IsNullOrWhiteSpace(txtEdad.Text))
			{
				MessageBox.Show("Por favor, complete todos los campos.");
			}
			try
			{
				if (!int.TryParse(txtUsuario.Text.Trim(), out int id))
				{
					MessageBox.Show("El ID de usuario debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (!long.TryParse(txtIdentificacion.Text.Trim(), out long idUsuario))
				{
					MessageBox.Show("El numero de cedula debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				string pass = Connect.To_Code(txtClave.Text);
				string password = Connect.Decode(pass);
				string conn = $@"
				update EMPLEADOS set Tipo_ID='{txtTipoID.Text}',Nombre='{txtNombre.Text}', Primer_Apellido='{txtApellido1.Text}',Segundo_Apellido= '{txtApellido2.Text}', 
Fecha_Nacimiento='{dtpFechaNac.Value.ToString("yyyy-MM-dd")}', Edad={txtEdad.Text}, Fecha_Vencimiento_ID='{dtpFechaVenci.Value.ToString("yyyy-MM-dd")}', 
Mail='{txtCorreoPersonal.Text}', Telefono='{txtTelefono.Text}', Ubicacion='{txtUbicacion.Text}', Provincia='{txtProvincia.Text}', Canton='{txtCanton.Text}', Distrito='{txtDistrito.Text}', Pais='{txtPais.Text}'
where Identificacion={idUsuario}";

				string conn2 = $@"
            UPDATE USUARIO
            SET Contrasenia = '{password}', CorreoElectronico = '{txtCorreoEmpre.Text}', Rol = '{txtRol.Text}'
            WHERE ID_Usuario = {id}";

				Connect.Execute(conn);
				Connect.Execute(conn2);
				CargaEmpleados();
				MessageBox.Show("El empleado se modifico de forma exitosa");
				Clean();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocurrio un error inesperado: " + ex.Message);
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (!int.TryParse(txtUsuario.Text.Trim(), out int id))
			{
				MessageBox.Show("El ID de usuario debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!long.TryParse(txtIdentificacion.Text.Trim(), out long idUsuario))
			{
				MessageBox.Show("El numero de cedula debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrWhiteSpace(txtIdentificacion.Text) || string.IsNullOrWhiteSpace(txtUsuario.Text))
			{
				MessageBox.Show("Por favor, seleccione un empleado para eliminar.");
			}
			DialogResult respuesta = MessageBox.Show("Esta seguro de eliminar este empleado?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                try
                {
					string conn2 = $"delete from USUARIO where ID_Usuario='{id}'";
					Connect.Execute(conn2);
					string conn = $"delete from EMPLEADOS where Identificacion='{idUsuario}'";
					Connect.Execute(conn);
					CargaEmpleados();
					MessageBox.Show("El empleado se elimino de forma exitosa");
					Clean();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Ocurrio un error inesperado: " + ex.Message);
				}
			}
		}

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			txtUsuario.Enabled = false;
			txtIdentificacion.Enabled = false;
			DataGridViewRow seleccion = dgvEmpleados.Rows[e.RowIndex];
			string id = seleccion.Cells["Identificacion"].Value.ToString();
			try
			{
				string consulta = $@"select e.Identificacion, e.Tipo_ID, e.Nombre, e.Primer_Apellido, e.Segundo_Apellido, e.Fecha_Nacimiento, e.Edad, e.Fecha_Vencimiento_ID, e.Mail, e.Telefono, e.Ubicacion, e.Provincia, e.Distrito, e.Canton, e.Pais, u.ID_Usuario, u.Rol, u.Contrasenia, u.CorreoElectronico from EMPLEADOS e join USUARIO u on e.Identificacion=u.Identificacion where e.Identificacion='{id}'";
				DataSet dataS = Connect.Execute(consulta);
				if (dataS.Tables[0].Rows.Count > 0)
                {
					DataRow row = dataS.Tables[0].Rows[0];
					txtIdentificacion.Text = row["Identificacion"].ToString();
					txtTipoID.Text = row["Tipo_ID"].ToString();
					txtNombre.Text = row["Nombre"].ToString();
					txtApellido1.Text = row["Primer_Apellido"].ToString();
					txtApellido2.Text = row["Segundo_Apellido"].ToString();
					dtpFechaNac.Value = Convert.ToDateTime(row["Fecha_Nacimiento"]);
					txtEdad.Text = row["Edad"].ToString();
					dtpFechaVenci.Value = Convert.ToDateTime(row["Fecha_Vencimiento_ID"]);
					txtCorreoPersonal.Text = row["Mail"].ToString();
					txtCorreoEmpre.Text = row["CorreoElectronico"].ToString();
					txtTelefono.Text = row["Telefono"].ToString();
					txtUbicacion.Text = row["Ubicacion"].ToString();
					txtProvincia.Text = row["Provincia"].ToString();
					txtDistrito.Text = row["Distrito"].ToString();
					txtCanton.Text = row["Canton"].ToString();
					txtPais.Text = row["Pais"].ToString();
					txtUsuario.Text = row["ID_Usuario"].ToString();
					txtRol.Text = row["Rol"].ToString();
					txtClave.Text = Connect.To_Code(row["Contrasenia"].ToString());

				}
            }
            catch (Exception ex)
            {
				MessageBox.Show("Ocurrio un error inesperado: " + ex.Message);
			}

        }
		public void Clean()
        {
			txtIdentificacion.Clear();
			txtTipoID.Clear();
			txtNombre.Clear();
			txtApellido1.Clear();
			txtApellido2.Clear();
			dtpFechaNac.Value = DateTime.Now;
			txtEdad.Clear();
			dtpFechaVenci.Value = DateTime.Now;
			txtCorreoPersonal.Clear();
			txtCorreoEmpre.Clear();
			txtTelefono.Clear();
			txtUbicacion.Clear();
			txtProvincia.Clear();
			txtDistrito.Clear();
			txtCanton.Clear();
			txtPais.Clear();
			txtUsuario.Clear();
			txtRol.Clear();
			txtClave.Clear();
			txtUsuario.Enabled = true;
			txtIdentificacion.Enabled = true;
		}
    }
}
