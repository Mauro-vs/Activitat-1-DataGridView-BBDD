using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Activitat_1_DataGridView_mauro
{
    public partial class IngresosHospitalarios : Form
    {
        string cadena = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        private void IngresosHospitalarios_Load(object sender, EventArgs e)
        {
        }

        public IngresosHospitalarios()
        {
            InitializeComponent();

            RefrescarDatos();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPaciente();
            //Actualizar(Pacientes);
        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirIngresos();
            //Actualizar(Pacientes);
        }

        private void toolStripAGREGAR_Click(object sender, EventArgs e)
        {
            AbrirPaciente();
            //Actualizar(Pacientes);
        }

        private void toolStripBORRAR_Click(object sender, EventArgs e)
        {
            BorrarPaciente();
            //Actualizar(Pacientes);
        }

        private void toolStripEDITAR_Click(object sender, EventArgs e)
        {
            AbrirPacienteEditar();
            //Actualizar(Pacientes);
        }

        private void toolStripLISTAR_Click(object sender, EventArgs e)
        {
            AbrirIngresos();
            //Actualizar(Pacientes);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirPaciente();
            //Actualizar(Pacientes);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            BorrarPaciente();
            //Actualizar(Pacientes);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            AbrirIngresos();
            //Actualizar(Pacientes);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AbrirPacienteEditar();
            //Actualizar(Pacientes);
        }

        private void AbrirPaciente()
        {
            FrmPaciente frm = new FrmPaciente(null, this);
            frm.ShowDialog();
        }

        private void AbrirPacienteEditar()
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataRowView row = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;

                if (row != null)
                {
                    int pacienteId = (int)row["id"];
                    
                    Paciente pacienteSelec = new Paciente { Id = pacienteId };

                    FrmPaciente frm = new FrmPaciente(pacienteSelec, this);
                    frm.ShowDialog();

                    RefrescarDatos();
                                      
                }
            }
            else
            {
                MessageBox.Show("Seleccione un paciente para editar", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AbrirIngresos()
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un paciente para ver sus ingresos.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el ID del paciente seleccionado
            int pacienteId = (int)dataGridView1.CurrentRow.Cells["id"].Value;

            // Solo envías el ID
            Paciente pacienteSelec = new Paciente { Id = pacienteId };

            FrmIngresos frm = new FrmIngresos(pacienteSelec, null);
            frm.ShowDialog();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
            }
            else
            {
                MessageBox.Show("Seleccione un paciente para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void IngresosHospitalarios_Activated(object sender, EventArgs e)
        {
            RefrescarDatos();
        }
    }
}
