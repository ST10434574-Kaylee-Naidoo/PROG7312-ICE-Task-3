namespace FactoryMachine.API
{
    public class TelemetryReading <T>
    {
        public string SensorType { get; set; }
        public T Value { get; set; }

        public TelemetryReading(string sensorType, T value)
        {
            SensorType = sensorType;
            Value = value; 
        }
    }
}
