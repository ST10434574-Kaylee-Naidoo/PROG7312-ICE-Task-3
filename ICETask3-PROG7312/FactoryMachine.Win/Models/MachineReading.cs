using FactoryMachine.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMachine.Win.Models
{
    public class MachineReading
    {
        public string MachineId { get; set; }
        public string MachineName { get; set; }
        public string Location { get; set; }

        public TelemetryReading<double> Temperature { get; set; }
        public TelemetryReading<int> RotationSpeed { get; set; }
        public TelemetryReading<bool> OperationalState { get; set; }

        public DateTime ReadingTime { get; set; }
    }
}
