namespace FactoryMachine.API
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
