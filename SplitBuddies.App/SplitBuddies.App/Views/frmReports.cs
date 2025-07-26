// Archivo: Views/frmReports.cs
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

        // --- EVENTOS ---

        // Al cargar el formulario, establece un rango de fechas por defecto (el último mes).
        private void frmReports_Load_1(object sender, EventArgs e)
        {
            dtpReportStart.Value = DateTime.Now.AddMonths(-1);
            dtpReportEnd.Value = DateTime.Now;
        }
        // Al hacer clic en "Generar Reporte".
        private void btnGenerateReport_Click_1(object sender, EventArgs e)
        {
            try
            {
                // 1. Obtener las fechas de los controles.
                var startDate = dtpReportStart.Value.Date;
                var endDate = dtpReportEnd.Value.Date;

                // 2. Filtrar los gastos que están dentro de ese rango de fechas.
                var reportData = _dataService.Expenses
                    .Where(ex => ex.Date.Date >= startDate && ex.Date.Date <= endDate)
                    .Select(ex => new
                    {
                        // 3. Crear un objeto anónimo para mostrar los datos de forma legible.
                        Fecha = ex.Date.ToShortDateString(),
                        Grupo = _dataService.Groups.FirstOrDefault(g => g.Id == ex.GroupId)?.Name,
                        Gasto = ex.Name,
                        Monto = ex.Amount,
                        PagadoPor = _dataService.Users.FirstOrDefault(u => u.Id == ex.PayerId)?.Name
                    })
                    .OrderBy(r => r.Fecha) // Ordenar por fecha
                    .ToList();

                // 4. Mostrar los resultados en la tabla.
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