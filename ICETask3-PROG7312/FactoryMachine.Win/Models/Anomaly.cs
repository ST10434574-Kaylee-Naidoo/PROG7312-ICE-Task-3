using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMachine.Win.Models
{
    public class Anomaly
    {
        public string MachineId { get; set; }
        public string MachineName { get; set; }
        public string Message { get; set; }
        public DateTime DetectedAt { get; set; }
    }
}
