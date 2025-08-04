
using SplitBuddies.App.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SplitBuddies.App.Views
{
    public partial class frmReports : Form
    {
        private readonly DataService _dataService;

        public frmReports()
        {
            InitializeComponent();
            _dataService = DataService.Instance;
        }
        private void frmReports_Load_1(object sender, EventArgs e)
        {
            dtpReportStart.Value = DateTime.Now.AddMonths(-1);
            dtpReportEnd.Value = DateTime.Now;
        }
        private void btnGenerateReport_Click_1(object sender, EventArgs e)
        {
            try
            {
                var startDate = dtpReportStart.Value.Date;
                var endDate = dtpReportEnd.Value.Date;
                var reportData = _dataService.Expenses
                    .Where(ex => ex.Date.Date >= startDate && ex.Date.Date <= endDate)
                    .Select(ex => new
                    {
                        Fecha = ex.Date.ToShortDateString(),
                        Grupo = _dataService.Groups.FirstOrDefault(g => g.Id == ex.GroupId)?.Name,
                        Gasto = ex.Name,
                        Monto = ex.Amount,
                        PagadoPor = _dataService.Users.FirstOrDefault(u => u.Id == ex.PayerId)?.Name
                    })
                    .OrderBy(r => r.Fecha) 
                    .ToList();
                dgvReportResults.DataSource = null;
                dgvReportResults.DataSource = reportData;
                if (dgvReportResults.Columns.Contains("Monto"))
                    dgvReportResults.Columns["Monto"].DefaultCellStyle.Format = "c";
                dgvReportResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al generar el reporte: {ex.Message}", "Error");
            }
        }
    }
}