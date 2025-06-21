using SistemaRefugiadosApp.DAO;
using SistemaRefugiadosApp.Models;

namespace SistemaRefugiados.GUI
{
    public partial class FrmRefugiados : Form
    {
        private int idSeleccionado = -1;
        public FrmRefugiados()
        {
            InitializeComponent();
        }

        private void FrmRefugiados_Load(object sender, EventArgs e)
        {
            //Se agregan las opciones disponibles en los ComboBox
            // ComboBox:  Tipo de documento de identidad
            cboTipoDeDocumento.Items.AddRange(new[] { "CC", "CE", "TI", "PASAPORTE", "OTRO" });
            cboTipoDeDocumento.SelectedIndex = 0;
            // ComboBox: Estado civil
            cboEstadoCivil.Items.AddRange(new[] { "Soltero/a", "Casado/a", "Divorciado/a", "Viudo/a", "Unión libre" });
            cboEstadoCivil.SelectedIndex = 0;
            // ComboBox:  Genero
            cboGenero.Items.AddRange(new[] { "Masculino", "Femenino", "No sabe", "No quiere decir" });
            cboGenero.SelectedIndex = 0;

            //Funciones
            CargarRefugiados();
            //MostrarEstaditicaPorPais();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void Documento_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertar(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MessageBox.Show("Por favor completa todos los campos obligatorios.");
                return;
            }
            var dto = new RefugiadoDTO
            {
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                TipoDocumento = cboTipoDeDocumento.SelectedItem?.ToString(),
                DocumentoIdentidad = txtDocumento.Text,
                EstadoCivil = cboEstadoCivil.SelectedItem?.ToString(),
                Genero = cboGenero.SelectedItem?.ToString()
            };
            var dao = new RefugiadoDAO();
            dao.Insertar(dto);
            MessageBox.Show("Refugiado creado correctamente");
            // Limpiar campos
            LimpiarFormulario();
            // Lena la grilla con los datos de los refugiados
            CargarRefugiados();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LimpiarGrilla();
            CargarRefugiados();
        }

        private void btnDeleteEnd_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Selecciona el refugiado a eliminar");
                return;
            }
            var confirmar = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
                            "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmar == DialogResult.Yes)
            {
                var dao = new RefugiadoDAO();
                bool eliminado = dao.EliminarRefugiado(idSeleccionado);
                if (eliminado)
                {
                    MessageBox.Show("Refugiado Eliminado");
                    CargarRefugiados();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("❌ No se pudo eliminar el registro.");
                }
            }
        }

        private void txtGenero_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dvgRefugiados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dvgRefugiados.Rows[e.RowIndex];
                txtNombres.Text = fila.Cells["Nombres"].Value?.ToString();
                txtApellidos.Text = fila.Cells["Apellidos"].Value?.ToString();
                cboTipoDeDocumento.SelectedItem = fila.Cells["TipoDocumento"].Value?.ToString();
                txtDocumento.Text = fila.Cells["DocumentoIdentidad"].Value?.ToString();
                cboEstadoCivil.SelectedItem = fila.Cells["EstadoCivil"].Value?.ToString();
                cboGenero.SelectedItem = fila.Cells["Genero"].Value?.ToString();

                // Guardamos el ID en una variable del formulario
                idSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Por favor, seleccione un registro para modificar");
                return;
            }

            //Se validan los campos 
            if (string.IsNullOrWhiteSpace(txtNombres.Text) ||
               string.IsNullOrWhiteSpace(txtApellidos.Text) ||
               string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }

            //Se llenan los datos en el objeto dto
            var dto = new RefugiadoDTO
            {
                Id = idSeleccionado,
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                TipoDocumento = cboTipoDeDocumento.SelectedItem?.ToString(),
                DocumentoIdentidad = txtDocumento.Text,
                EstadoCivil = cboEstadoCivil.SelectedItem?.ToString()
            };

            var dao = new RefugiadoDAO();
            dao.ActualizarRefugiadoCompleto(dto);
            MessageBox.Show("Registro actualizado correctamente");
            CargarRefugiados();
            LimpiarFormulario();
        }

        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            try
            {
                var dao = new RefugiadoDAO();
                var estadisticas = dao.ObtenerEstadisticasPorPais();
                dvgRefugiados.DataSource = null;
                dvgRefugiados.DataSource = estadisticas;

            }
            catch (Exception ex)
            { 
                MessageBox.Show("Error al obtener las estadisticas: "+ ex.Message);
            }

        }

        //metodo que lee (READ) los datos de los refugiados de la base de datos y la muestra en la grilla
        private void CargarRefugiados()
        {
            var dao = new RefugiadoDAO();
            var refugiados = dao.ProyeccionRefugiados();
            dvgRefugiados.DataSource = refugiados;
        }

        //Método que limpia los datos de los texbox en el formulario
        private void LimpiarFormulario()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDocumento.Clear();
            cboEstadoCivil.SelectedIndex = 0;
            cboTipoDeDocumento.SelectedIndex = 0;
            idSeleccionado = -1;
        }
        //Metodo que limpia la grilla que muetra los resultados
        private void LimpiarGrilla()
        {
            dvgRefugiados.DataSource = null;
        }
    }
}
