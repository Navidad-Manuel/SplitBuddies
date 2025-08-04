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

        private void frmUsers_Load(object sender, EventArgs e)
        {
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) ||
                string.IsNullOrWhiteSpace(txtLoginUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Nombre completo, nombre de usuario y contraseña son obligatorios.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_dataService.Users.Any(u => u.Username.Equals(txtLoginUsername.Text, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Ese nombre de usuario ya está en uso. Por favor, elija otro.", "Usuario Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var newUser = new User
                {
                    Id = (_dataService.Users.Any() ? _dataService.Users.Max(u => u.Id) : 0) + 1,
                    Name = txtUserName.Text,
                    Username = txtLoginUsername.Text,
                    PasswordHash = SecurityService.HashPassword(txtPassword.Text)
                };

                _dataService.Users.Add(newUser);
                _dataService.SaveChanges();
                MessageBox.Show("¡Registro exitoso! Ahora puede iniciar sesión con sus nuevas credenciales.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado durante el registro: {ex.Message}", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}