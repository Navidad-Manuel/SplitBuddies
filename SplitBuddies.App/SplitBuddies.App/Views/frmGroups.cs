
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

        private void PopulateUserSelectionList()
        {
            clbGroupMembers.DataSource = null;
            clbGroupMembers.DataSource = _dataService.Users.ToList();
            clbGroupMembers.DisplayMember = "Name"; 
        }
        private void RefreshGroupsGrid()
        {
            dgvGroups.DataSource = null;
            
            var groupData = _dataService.Groups.Select(g => new
            {
                Nombre = g.Name,
                Miembros = string.Join(", ", g.MemberIds.Select(id => _dataService.Users.FirstOrDefault(u => u.Id == id)?.Name ?? "N/A"))
            }).ToList();
            dgvGroups.DataSource = groupData;
            dgvGroups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnCreateGroup_Click_1(object sender, EventArgs e)
        {
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
                var newGroup = new Group
                {
                    Id = (_dataService.Groups.Any() ? _dataService.Groups.Max(g => g.Id) : 0) + 1,
                    Name = txtGroupName.Text,
                    ImagePath = txtGroupImagePath.Text,
                    MemberIds = clbGroupMembers.CheckedItems.OfType<User>().Select(u => u.Id).ToList()
                };
                _dataService.Groups.Add(newGroup);
                _dataService.SaveChanges();
                MessageBox.Show("Grupo creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void frmGroups_Load_1(object sender, EventArgs e)
        {
            PopulateUserSelectionList();
            RefreshGroupsGrid();
        }

        private void dgvGroups_SelectionChanged_1(object sender, EventArgs e)
        {
            {
                lbGroupBalances.Items.Clear();
                if (dgvGroups.CurrentRow != null && dgvGroups.CurrentRow.DataBoundItem != null)
                {
                    string groupName = (string)dgvGroups.CurrentRow.Cells["Nombre"].Value;
                    var selectedGroup = _dataService.Groups.FirstOrDefault(g => g.Name == groupName);
                    if (selectedGroup != null)
                    {
                        var balanceDetails = BalanceService.CalculateGroupBalances(selectedGroup, _dataService.Users, _dataService.Expenses);
                        foreach (var detail in balanceDetails)
                        {
                            lbGroupBalances.Items.Add(detail);
                        }
                    }
                }
            }
        }
    }
}

      