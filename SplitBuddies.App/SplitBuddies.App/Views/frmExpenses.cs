// Archivo: Views/frmExpenses.cs
using SplitBuddies.App.Models;
using SplitBuddies.App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SplitBuddies.App.Views
{
    public partial class frmExpenses : Form
    {
        private readonly DataService _dataService;

        public frmExpenses()
        {
            InitializeComponent();
            _dataService = DataService.Instance;
        }
        private void PopulateGroupsComboBox()
        {
            cmbExpenseGroup.DataSource = null;
            cmbExpenseGroup.DataSource = _dataService.Groups.ToList();
            cmbExpenseGroup.DisplayMember = "Name";
        }
        private void RefreshExpensesGrid()
        {
            dgvExpenses.DataSource = null;
            var expenseData = _dataService.Expenses.Select(ex => new
            {
                Grupo = _dataService.Groups.FirstOrDefault(g => g.Id == ex.GroupId)?.Name,
                Gasto = ex.Name,
                Monto = ex.Amount,
                Fecha = ex.Date.ToShortDateString(),
                PagadoPor = _dataService.Users.FirstOrDefault(u => u.Id == ex.PayerId)?.Name
            }).OrderByDescending(e => e.Fecha).ToList();

            dgvExpenses.DataSource = expenseData;
            if (dgvExpenses.Columns.Contains("Monto"))
                dgvExpenses.Columns["Monto"].DefaultCellStyle.Format = "c";
            dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    
        private void frmExpenses_Load_1(object sender, EventArgs e)
        {
            PopulateGroupsComboBox();
            RefreshExpensesGrid();
        }
        private void cmbExpenseGroup_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbExpenseGroup.SelectedItem is Group selectedGroup)
            {
                var members = _dataService.Users.Where(u => selectedGroup.MemberIds.Contains(u.Id)).ToList();
                cmbExpensePayer.DataSource = null;
                cmbExpensePayer.DataSource = new List<User>(members);
                cmbExpensePayer.DisplayMember = "Name";

                clbExpenseParticipants.DataSource = null;
                clbExpenseParticipants.DataSource = new List<User>(members);
                clbExpenseParticipants.DisplayMember = "Name";
            }
        }
        private void btnAddExpense_Click_1(object sender, EventArgs e)
        {
            if (cmbExpenseGroup.SelectedItem == null || cmbExpensePayer.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtExpenseName.Text) || numExpenseAmount.Value <= 0 ||
                clbExpenseParticipants.CheckedItems.Count == 0)
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var newExpense = new Expense
                {
                    Id = (_dataService.Expenses.Any() ? _dataService.Expenses.Max(ex => ex.Id) : 0) + 1,
                    GroupId = ((Group)cmbExpenseGroup.SelectedItem).Id,
                    Name = txtExpenseName.Text,
                    Description = txtExpenseDescription.Text,
                    Amount = numExpenseAmount.Value,
                    Date = dtpExpenseDate.Value,
                    PayerId = ((User)cmbExpensePayer.SelectedItem).Id,
                    ParticipantIds = clbExpenseParticipants.CheckedItems.OfType<User>().Select(u => u.Id).ToList(),
                    Link = txtExpenseLink.Text
                };

                _dataService.Expenses.Add(newExpense);
                _dataService.SaveChanges();
                MessageBox.Show("Gasto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshExpensesGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al agregar el gasto: {ex.Message}", "Error");
            }
        }
    }
}