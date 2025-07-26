// Archivo: Views/frmGroups.cs
using SplitBuddies.App.Models;
using SplitBuddies.App.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SplitBuddies.App.Views
{
    public partial class frmGroups : Form
    {
        private readonly DataService _dataService;

        public frmGroups()
        {
            InitializeComponent();
            _dataService = DataService.Instance;
        }

        // --- FUNCIONES AUXILIARES ---

        // Carga todos los usuarios en el CheckedListBox para poder seleccionarlos.
        private void PopulateUserSelectionList()
        {
            clbGroupMembers.DataSource = null;
            clbGroupMembers.DataSource = _dataService.Users.ToList();
            clbGroupMembers.DisplayMember = "Name"; // Muestra el nombre del usuario en la lista.
        }

        // Refresca la tabla de grupos.
        private void RefreshGroupsGrid()
        {
            dgvGroups.DataSource = null;
            // Creamos un objeto anónimo para mostrar los nombres de los miembros en lugar de los IDs.
            var groupData = _dataService.Groups.Select(g => new
            {
                Nombre = g.Name,
                Miembros = string.Join(", ", g.MemberIds.Select(id => _dataService.Users.FirstOrDefault(u => u.Id == id)?.Name ?? "N/A"))
            }).ToList();
            dgvGroups.DataSource = groupData;
            dgvGroups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        // --- EVENTOS ---

        // Al cargar el formulario, llena la lista de usuarios para seleccionar y la tabla de grupos.
        private void frmGroups_Load_1(object sender, EventArgs e)
        {
            PopulateUserSelectionList();
            RefreshGroupsGrid();
        }
        // Al hacer clic en el botón "Crear Grupo".
        private void btnCreateGroup_Click_1(object sender, EventArgs e)
        {
            // 1. Validaciones
            if (string.IsNullOrWhiteSpace(txtGroupName.Text))
            {
                MessageBox.Show("El nombre del grupo es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (clbGroupMembers.CheckedItems.Count < 2)
            {
                MessageBox.Show("Un grupo debe tener al menos 2 miembros.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Crear el nuevo objeto Grupo.
                var newGroup = new Group
                {
                    Id = (_dataService.Groups.Any() ? _dataService.Groups.Max(g => g.Id) : 0) + 1,
                    Name = txtGroupName.Text,
                    ImagePath = txtGroupImagePath.Text,
                    // Obtiene los IDs de los usuarios marcados en el CheckedListBox.
                    MemberIds = clbGroupMembers.CheckedItems.OfType<User>().Select(u => u.Id).ToList()
                };

                // 3. Añadir, guardar y notificar.
                _dataService.Groups.Add(newGroup);
                _dataService.SaveChanges();
                MessageBox.Show("Grupo creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 4. Limpiar los campos para un nuevo ingreso.
                txtGroupName.Clear();
                txtGroupImagePath.Clear();
                for (int i = 0; i < clbGroupMembers.Items.Count; i++)
                {
                    clbGroupMembers.SetItemChecked(i, false);
                }
                RefreshGroupsGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al crear el grupo: {ex.Message}", "Error");
            }
        }
    }
}
