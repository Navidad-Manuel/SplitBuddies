// Archivo: Views/frmLogin.cs
using SplitBuddies.App.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SplitBuddies.App.Views
{
    public partial class frmLogin : Form
    {
        private readonly DataService _dataService;

        public frmLogin()
        {
            InitializeComponent();
            _dataService = DataService.Instance;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtLoginUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Por favor, ingrese nombre de usuario y contraseña.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            var user = _dataService.Users.FirstOrDefault(u => u.Username.Equals(txtLoginUsername.Text, StringComparison.OrdinalIgnoreCase));

            if (user != null)
            {
                var enteredPasswordHash = SecurityService.HashPassword(txtPassword.Text);
                if (user.PasswordHash == enteredPasswordHash)
                {
                    MessageBox.Show($"¡Bienvenido, {user.Name}!", "Login Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmMain mainForm = new frmMain();
                    mainForm.FormClosed += (s, args) => this.Close();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se encontró ningún usuario con ese nombre de usuario.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (var registerForm = new frmUsers())
            {
                registerForm.ShowDialog();
            }
        }
    }
}