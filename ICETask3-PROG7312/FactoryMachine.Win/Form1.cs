using FactoryMachine.Win.Models;
using System.Net.Http.Json;

namespace FactoryMachine.Win
{
    public partial class Form1 : Form
    {
        private readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            DashboardData data =
                await client.GetFromJsonAsync<DashboardData>(
                    "https://localhost:7104/api/dashboard"
                );

            dvgReadings.DataSource = data.Readings.Select(r => new
            {
                ID = r.MachineId,
                Machine = r.MachineName,
                Location = r.Location,
                Temperature = r.Temperature.Value,
                RPM = r.RotationSpeed.Value,
                Operational = r.OperationalState.Value,
                Time = r.ReadingTime
            }).ToList();
            dgvAnomalies.DataSource = data.Anomalies;

            lblTotalAnomalies.Text =
                "Total Anomalies: " + data.TotalAnomalies;

            lblHottestMachine.Text =
                "Hottest Machine: " + data.HottestMachine;
        }
    }
}
