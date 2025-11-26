using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Activitat_1_DataGridView_mauro
{
    public partial class FrmPaciente : Form
    {
        string cadena = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        private Paciente pacienteActual;
        private IngresosHospitalarios frmPrincipal;
        public FrmPaciente(Paciente pacienteSelec, IngresosHospitalarios frmPrincipal)
        {
            InitializeComponent();

            this.frmPrincipal = frmPrincipal;
            this.pacienteActual = pacienteSelec;

            if (pacienteSelec != null)
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();

                    // Se genera la consulta para obtener los datos del paciente seleccionado
                    string sql = "SeLECT * FROM Paciente WHERE id=@id";

                    // Se crea el comando SQL
                    SqlCommand cmd = new SqlCommand(sql, conexion);

                    // Se añade el id del paciente seleccionado como parámetro
                    cmd.Parameters.AddWithValue("@id", pacienteSelec.Id);

                    //Crea el lector para leer los datos
                    SqlDataReader lector = cmd.ExecuteReader();

                    if (lector.Read())
                    {
                        // Crea un nuevo objeto Paciente con los datos leídos
                        pacienteSelec = new Paciente
                        {
                            Id = (int)lector["Id"],
                            Nombre = (string)lector["Nombre"],
                            Apellidos = (string)lector["Apellido"],
                            Edad = (int)lector["Edad"]
                        };
                    }


                }

                // Con el pacienteActual ya cargado, se muestran los datos en los TextBox
                txtNombre.Text = pacienteSelec.Nombre; // Muestra en el TextBox el nombre del paciente seleccionado
                txtApellido.Text = pacienteSelec.Apellidos;
                txtEdad.Text = pacienteSelec.Edad.ToString();

                btnAgregar.Visible = false; // Oculta el botón de agregar
                btnAgregar.Enabled = false; // Deshabilita el botón de agregar
                btnEditar.Visible = true; // Muestra el botón de editar
                btnEditar.Enabled = true; // Habilita el botón de editar

                RefrescarDatos();

            }
            else
            {
                RefrescarDatos();
            }


        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarPaciente();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            BorrarPaciente();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripAGREGAR_Click(object sender, EventArgs e)
        {
            // Limpiar los campos de texto antes de la validación
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";

            // Habilitar botones
            btnAgregar.Visible = true; // Muestra el botón de agregar
            btnAgregar.Enabled = true; // Habilita el botón de agregar
            btnEditar.Visible = false; // Oculta el botón de editar
            btnEditar.Enabled = false; // Deshabilita el botón de editar
        }

        private void toolStripEDITAR_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Carga los datos del paciente seleccionado en los TextBox
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                txtEdad.Text = dataGridView1.CurrentRow.Cells["Edad"].Value.ToString();
                // Habilitar botones
                btnAgregar.Visible = false; // Oculta el botón de agregar
                btnAgregar.Enabled = false; // Deshabilita el botón de agregar
                btnEditar.Visible = true; // Muestra el botón de editar
                btnEditar.Enabled = true; // Habilita el botón de editar
            }
            else
            {
                MessageBox.Show("Seleccione un paciente para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirIngresos();
            //frmPrincipal.Actualizar(listPacientes);
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VolverAlMenu();
            //frmPrincipal.Actualizar(listPacientes);
        }

        private void AbrirIngresos()
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataRowView row = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;

                if (row != null)
                {
                    int pacienteId = (int)dataGridView1.CurrentRow.Cells[0].Value;

                    Paciente pacienteSelec = new Paciente { Id = pacienteId };

                    var frm = new FrmIngresos(pacienteSelec, null);
                    frm.ShowDialog();

                    RefrescarDatos();

                }
            }
            else
            {
                MessageBox.Show("Seleccione un paciente para ver sus ingresos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VolverAlMenu()
        {
            this.Close();
        }

        private void AgregarPaciente()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtEdad.Text))

            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                string nom = txtNombre.Text;
                string apell = txtApellido.Text;
                int edad;
                if (!int.TryParse(txtEdad.Text, out edad) || edad < 0)
                {
                    MessageBox.Show("Por favor, ingrese una edad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using (SqlConnection conn = new SqlConnection(cadena))
                {
                    conn.Open();

                    string sql = "INSERT INTO Paciente (nombre,apellido,edad) VALUES (@Nombre,@Apellido,@Edad)";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
                    cmd.Parameters.AddWithValue("@Nombre", nom);
                    cmd.Parameters.AddWithValue("@Apellido", apell);
                    cmd.Parameters.AddWithValue("@Edad", edad);

                    cmd.ExecuteNonQuery();

                    RefrescarDatos();
                }

                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEdad.Text = "";
            }
        }

        private void BorrarPaciente()
        {
            if (dataGridView1.CurrentRow != null)
            {
                // "CurrentRow" es la fila seleccionada por el usuario.
                // "DataBoundItem" es el objeto original que está enlazado a esa fila.
                int pacienteId = (int)dataGridView1.CurrentRow.Cells[0].Value;

                Paciente pacienteSelec = new Paciente { Id = pacienteId };
                if (pacienteSelec != null)
                {
                    var confirmResult = MessageBox.Show($"¿Estás seguro de que deseas borrar al paciente {pacienteSelec.Nombre} {pacienteSelec.Apellidos}?",
                                                         "Confirmar borrado",
                                                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        using (SqlConnection conexion = new SqlConnection(cadena))
                        {
                            conexion.Open();
                            // Genera una consulta para eliminar el paciente seleccionado
                            SqlCommand cmd = new SqlCommand("DELETE FROM Paciente WHERE Id = @Id", conexion);
                            // Cogue el Id del paciente seleccionado
                            cmd.Parameters.AddWithValue("@Id", pacienteSelec.Id);
                            // Ejecuta el comando
                            cmd.ExecuteNonQuery();
                        }

                        RefrescarDatos();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un paciente para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarPaciente();
        }

        private void EditarPaciente()
        {
            string nom = txtNombre.Text;
            string apell = txtApellido.Text;
            int edad;
            if (!int.TryParse(txtEdad.Text, out edad) || edad < 0)
            {
                MessageBox.Show("Por favor, ingrese una edad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conn = new SqlConnection(cadena))
            {
                conn.Open();

                string sql = "UPDATE Paciente SET Nombre=@Nombre, Apellido=@Apellido, Edad=@Edad WHERE ID=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", pacienteActual.Id);
                cmd.Parameters.AddWithValue("@Nombre", nom);
                cmd.Parameters.AddWithValue("@Apellido", apell);
                cmd.Parameters.AddWithValue("@Edad", edad);

                cmd.ExecuteNonQuery();

                RefrescarDatos();
            }

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
        }



        private void FrmPaciente_Load(object sender, EventArgs e)
        {

        }

        private void RefrescarDatos()
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                // Se genera la consulta para obtener los datos de la tabla Pacientes
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Paciente", conexion);
                // Se genera el comando para actualizar los datos
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                // Se crea el DataTable para almacenar los datos
                DataTable dt = new DataTable();

                dt.Clear();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
    }
}
