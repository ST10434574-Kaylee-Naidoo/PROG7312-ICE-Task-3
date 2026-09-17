namespace FactoryMachine.API
{
    public class Anomaly
    {
        public string MachineId { get; set; }
        public string MachineName { get; set; }
        public string Message { get; set; }
        public DateTime DetectedAt { get; set; }

    }
}
