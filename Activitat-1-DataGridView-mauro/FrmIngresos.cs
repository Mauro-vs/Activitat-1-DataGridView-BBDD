using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Activitat_1_DataGridView_mauro
{
    public partial class FrmIngresos : Form
    {
        string cadena = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        private Paciente pacienteActual;

        public FrmIngresos(Paciente paciente, Ingreso ingresos)
        {
            InitializeComponent();

            pacienteActual = paciente;

            dtpAlta.Enabled = false;

            RefrescarDatosIngresos();
        }

        private void FrmIngresos_Load(object sender, EventArgs e)
        {
            RefrescarDatosIngresos();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarIngreso();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            BorrarIngreso();
        }

        private void toolStripAGREGAR_Click(object sender, EventArgs e)
        {
            AgregarIngreso();
        }

        private void toolStripBORRAR_Click(object sender, EventArgs e)
        {
            BorrarIngreso();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VolverMenuPrincipal();
        }


        private void VolverMenuPrincipal()
        {
            this.Close();
        }

        private void BorrarIngreso()
        {
            if (dataGridView1.CurrentRow == null)
                return;

            int ingresoId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

            var confirmResult = MessageBox.Show($"¿Estás seguro de que deseas borrar el ingreso?", "Confirmar borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    string sql = "DELETE FROM Ingresos WHERE id = @id";

                    SqlCommand cmd = new SqlCommand(sql, conexion);
                    cmd.Parameters.AddWithValue("@id", ingresoId);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            RefrescarDatosIngresos();
        }

        private void AgregarIngreso()
        {
            if (string.IsNullOrEmpty(txtMotivo.Text) ||
                string.IsNullOrEmpty(txtEspecialidad.Text) ||
                string.IsNullOrEmpty(txtHabitacion.Text)) // Validar campos obligatorios, el metodo string.IsNullOrEmpty verifica si una cadena es null o está vacía
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                conexion.Open();
                if (checkBoxAlta.Checked)
                {
                    string sql = "INSERT INTO Ingresos (fecha_ingreso, fecha_alta, motivo, especialidad, habitacion, id_paciente) " +
                             "VALUES (@ingreso, @alta, @motivo, @esp, @hab, @id)";

                    SqlCommand cmd = new SqlCommand(sql, conexion);
                    cmd.Parameters.AddWithValue("@ingreso", dtpIngreso.Value);
                    cmd.Parameters.AddWithValue("@alta", dtpAlta.Value);
                    cmd.Parameters.AddWithValue("@motivo", txtMotivo.Text);
                    cmd.Parameters.AddWithValue("@esp", txtEspecialidad.Text);
                    cmd.Parameters.AddWithValue("@hab", txtHabitacion.Text);
                    cmd.Parameters.AddWithValue("@id", pacienteActual.Id);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string sql = "INSERT INTO Ingresos (fecha_ingreso, motivo, especialidad, habitacion, id_paciente) " +
                             "VALUES (@ingreso, @motivo, @esp, @hab, @id)";

                    SqlCommand cmd = new SqlCommand(sql, conexion);
                    cmd.Parameters.AddWithValue("@ingreso", dtpIngreso.Value);
                    cmd.Parameters.AddWithValue("@motivo", txtMotivo.Text);
                    cmd.Parameters.AddWithValue("@esp", txtEspecialidad.Text);
                    cmd.Parameters.AddWithValue("@hab", txtHabitacion.Text);
                    cmd.Parameters.AddWithValue("@id", pacienteActual.Id);
                    cmd.ExecuteNonQuery();
                }
            }

            LimpiarCampos();
            RefrescarDatosIngresos();
        }

        private void EditarIngreso()
        {
            btnAgregar.Visible = false;
            btnAgregar.Enabled = false;
            btnEditar.Visible = true;
            btnEditar.Enabled = true;
            dtpAlta.Enabled = true;
            checkBoxAlta.Visible = false;
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string sql = "UPDATE Ingresos SET fecha_ingreso=@ing, fecha_alta=@alta, motivo=@motivo, " +
                             "especialidad=@esp, habitacion=@hab WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conexion);

                cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells["id"].Value);
                cmd.Parameters.AddWithValue("@ing", dtpIngreso.Value);
                cmd.Parameters.AddWithValue("@alta", dtpAlta.Value);
                cmd.Parameters.AddWithValue("@motivo", txtMotivo.Text);
                cmd.Parameters.AddWithValue("@esp", txtEspecialidad.Text);
                cmd.Parameters.AddWithValue("@hab", txtHabitacion.Text);



                conexion.Open();
                cmd.ExecuteNonQuery();
            }

            LimpiarCampos();
            RefrescarDatosIngresos();

            btnAgregar.Visible = true;
            btnAgregar.Enabled = true;
            btnEditar.Visible = false;
            btnEditar.Enabled = false;
            dtpAlta.Enabled = false;
            checkBoxAlta.Visible = true;
        }

        private void toolStripEDITAR_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {

                txtMotivo.Text = dataGridView1.CurrentRow.Cells["motivo"].Value.ToString();
                txtEspecialidad.Text = dataGridView1.CurrentRow.Cells["especialidad"].Value.ToString();
                txtHabitacion.Text = dataGridView1.CurrentRow.Cells["habitacion"].Value.ToString();
                dtpIngreso.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["fecha_ingreso"].Value);
                if (dataGridView1.CurrentRow.Cells["fecha_alta"].Value != DBNull.Value)
                {
                    checkBoxAlta.Checked = true;
                    dtpAlta.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["fecha_alta"].Value);
                }
                else
                {
                    checkBoxAlta.Checked = false;
                }
                btnAgregar.Visible = false; // Oculta el botón de agregar
                btnAgregar.Enabled = false; // Deshabilita el botón de agregar
                btnEditar.Visible = true; // Muestra el botón de editar
                btnEditar.Enabled = true; // Habilita el botón de editar
            }
            else
            {
                MessageBox.Show("Seleccione un ingreso para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarIngreso();
            RefrescarDatosIngresos();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dtpAlta_ValueChanged(object sender, EventArgs e)
        {
            if (checkBoxAlta.Checked)
            {
                dtpAlta.Enabled = true;
            }
            else
            {
                dtpAlta.Enabled = false;
            }
        }

        private void checkBoxAlta_CheckedChanged(object sender, EventArgs e)
        {
            dtpAlta.Enabled = checkBoxAlta.Checked;
        }

        private void RefrescarDatosIngresos()
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string sql = "SELECT * FROM Ingresos WHERE id_Paciente = @id";

                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@id", pacienteActual.Id);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void LimpiarCampos()
        {
            txtMotivo.Text = "";
            txtEspecialidad.Text = "";
            txtHabitacion.Text = "";
            dtpIngreso.Value = DateTime.Now;
            dtpAlta.Value = DateTime.Now;
            checkBoxAlta.Checked = false;
        }
    }
}
