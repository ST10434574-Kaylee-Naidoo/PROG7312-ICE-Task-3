using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMachine.Win.Models
{
    public class DashboardData
    {
        public List<MachineReading> Readings { get; set; }
        public List<Anomaly> Anomalies { get; set; }
        public int TotalAnomalies { get; set; }
        public string HottestMachine { get; set; }
    }
}
