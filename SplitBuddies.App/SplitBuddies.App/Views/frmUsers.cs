// Archivo: Views/frmUsers.cs
using SplitBuddies.App.Models;
using SplitBuddies.App.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SplitBuddies.App.Views
{
    public partial class frmUsers : Form
    {
        private readonly DataService _dataService;

        public frmUsers()
        {
            InitializeComponent();
            _dataService = DataService.Instance;
        }

        // --- EVENTOS ---

        // Se ejecuta cuando el formulario se carga por primera vez.
        private void frmUsers_Load(object sender, EventArgs e)
        {
            RefreshUsersGrid();
        }

        
       

        // --- FUNCIONES AUXILIARES ---

        // Refresca el contenido del DataGridView con la lista actual de usuarios.
        // Refresca el contenido del DataGridView con la lista actual de usuarios.
        private void RefreshUsersGrid()
        {
            try
            {
                // 1. Desvincula la fuente de datos completamente.
                dgvUsers.DataSource = null;

                // 2. Vuelve a asignar la fuente de datos.
                // Usar .ToList() crea una NUEVA copia de la lista, lo que a menudo ayuda
                // a que el DataGridView detecte el cambio y se actualice correctamente.
                dgvUsers.DataSource = _dataService.Users.ToList();

                // 3. Oculta la columna de Email si no quieres que se vea (opcional, pero mejora la vista).
                if (dgvUsers.Columns.Contains("Email"))
                {
                    dgvUsers.Columns["Email"].Visible = false;
                }

                // 4. Ajusta el ancho de las columnas para que se vea bien.
                if (dgvUsers.Columns.Contains("Id"))
                {
                    dgvUsers.Columns["Id"].Width = 40;
                }
                dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al refrescar la lista de usuarios: {ex.Message}");
            }
        }

        private void frmUsers_Load_1(object sender, EventArgs e)
        {

        }
        // Se ejecuta al hacer clic en el botón "Agregar Usuario".
        private void btnAddUser_Click_1(object sender, EventArgs e)
        {
            // 1. Validar que los campos no estén vacíos.
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtUserEmail.Text))
            {
                MessageBox.Show("El nombre y el email son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Crear un nuevo objeto User.
                var newUser = new User
                {
                    // Genera un nuevo ID basado en el máximo existente + 1.
                    Id = (_dataService.Users.Any() ? _dataService.Users.Max(u => u.Id) : 0) + 1,
                    Name = txtUserName.Text,
                    Email = txtUserEmail.Text
                };

                // 3. Añadir el usuario a la lista en memoria.
                _dataService.Users.Add(newUser);

                // 4. ¡CRÍTICO! Guardar los cambios en el archivo users.json.
                _dataService.SaveChanges();

                MessageBox.Show("Usuario agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 5. Limpiar los campos y actualizar la tabla.
                txtUserName.Clear();
                txtUserEmail.Clear();
                RefreshUsersGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar el usuario: {ex.Message}", "Error");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUserEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}