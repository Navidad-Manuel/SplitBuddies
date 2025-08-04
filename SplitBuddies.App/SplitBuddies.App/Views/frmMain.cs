
using SplitBuddies.App.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SplitBuddies.App.Views
{
    public partial class frmMain : Form
    {
        

        private readonly DataService _dataService;

        public frmMain()
        {
            InitializeComponent();
            _dataService = DataService.Instance;
        }
        private void RefreshBalances()
        {
            try
            {
                var balances = _dataService.Users.Select(user => new
                {
                    Usuario = user.Name,
                    Balance = BalanceService.GetUserBalance(user.Id, _dataService.Expenses)
                }).ToList();
                dgvBalances.DataSource = null;
                dgvBalances.DataSource = balances;
                if (dgvBalances.Columns.Contains("Balance"))
                    dgvBalances.Columns["Balance"].DefaultCellStyle.Format = "c";
                dgvBalances.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar balances: {ex.Message}");
            }
        }
        private void frmMain_Load_1(object sender, EventArgs e)
        {
       
            RefreshBalances();
    }
        private void btnManageUsers_Click_1(object sender, EventArgs e)
        {
            using (var form = new frmUsers()) { form.ShowDialog(); }
            RefreshBalances();
        }
 
        private void btnManageGroups_Click_1(object sender, EventArgs e)
        {
            using (var form = new frmGroups()) { form.ShowDialog(); }
        }
  
        private void btnManageExpenses_Click_1(object sender, EventArgs e)
        {
            using (var form = new frmExpenses()) { form.ShowDialog(); }
            RefreshBalances();
        }
       
        private void btnViewReports_Click_1(object sender, EventArgs e)
        {
            using (var form = new frmReports()) { form.ShowDialog(); }
        }
       
        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            RefreshBalances();
        }
    }
}