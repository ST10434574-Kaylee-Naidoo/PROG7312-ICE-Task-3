using FactoryMachine.API;
using System.Reflection.PortableExecutable;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


//2d arrau containing registered machines 
string[,] machines =
{
    {"M001", "Cutting Machine", "Factory Floor A" },
     {"M002", "Drilling Machine", "Factory Floor B" },
      {"M003", "Packaging Machine", "Factory Floor C" }
};

//List to store generated readings
List<MachineReading> readings = new List<MachineReading>();

app.MapGet("/api/readings", () =>
{
    readings = GenerateReadings(machines);
    return Results.Ok(readings);
});

//Endpoint to get anomalies 
app.MapGet("/api/anomalies", () =>
{
    readings = GenerateReadings(machines);
    List<Anomaly> anomalies = DetectAnomalies(readings);
    int totalAnomalies = CountAnomaliesRecursive(anomalies, 0);

    return Results.Ok(new
    {
        TotalAnomalies = totalAnomalies,
        Anomalies = anomalies
    });
});

app.MapGet("/api/dashboard", () =>
{
    readings = GenerateReadings(machines);

    List<Anomaly> anomalies = DetectAnomalies(readings);

    int totalAnomalies = CountAnomaliesRecursive(anomalies, 0);

    MachineReading hottestMachine = FindHottestMachine(readings, 0);

    return Results.Ok(new
    {
        Readings = readings,
        Anomalies = anomalies,
        TotalAnomalies = totalAnomalies,
        HottestMachine = hottestMachine.MachineName
    });
});

app.Run();

app.Run();
 
//Generate random values for machines 
List<MachineReading> GenerateReadings(string[,] machines)
{
    Random random = new Random();

    List<MachineReading> readings = new List<MachineReading>();

    for(int i = 0; i< machines.GetLength(0); i++)
    {
        MachineReading reading = new MachineReading
        {
            MachineId = machines[i, 0],
            MachineName = machines[i, 1],
            Location = machines[i, 2],

            Temperature = new TelemetryReading<double>
            (
                "Temperature",
                Math.Round(random.NextDouble() * 40 + 60, 2)
            ),
                RotationSpeed = new TelemetryReading<int>(
                    "Rotation Speed",
                    random.Next(3000, 5501)
                ),

                OperationalState = new TelemetryReading<bool>(
                    "Operational State",
                    random.Next(0, 2) == 1
                ),

                ReadingTime = DateTime.UtcNow
        };
        readings.Add(reading);
    }
    return readings;
}


// Detect anomalies in the readings
List<Anomaly> DetectAnomalies(List<MachineReading> readings)
{
    List<Anomaly> anomalies = new List<Anomaly>();

    foreach (MachineReading reading in readings)
    {
        if (reading.Temperature.Value > 85)
        {
            anomalies.Add(new Anomaly
            {
                MachineId = reading.MachineId,
                MachineName = reading.MachineName,
                Message = "Temperature above 85°C",
                DetectedAt = DateTime.Now
            });
        }

        if (reading.RotationSpeed.Value > 4500)
        {
            anomalies.Add(new Anomaly
            {
                MachineId = reading.MachineId,
                MachineName = reading.MachineName,
                Message = "Rotation speed above 4500 RPM",
                DetectedAt = DateTime.Now
            });
        }

        if (reading.OperationalState.Value == false)
        {
            anomalies.Add(new Anomaly
            {
                MachineId = reading.MachineId,
                MachineName = reading.MachineName,
                Message = "Machine is not operational",
                DetectedAt = DateTime.Now
            });
        }
    }

    return anomalies;
}


int CountAnomaliesRecursive(List<Anomaly>anomalies, int index)
{
    if(index>= anomalies.Count)
    {
        return  0;
    }

    return 1 + CountAnomaliesRecursive(anomalies, index + 1);
}

MachineReading FindHottestMachine(List<MachineReading> readings, int index)
{
    if (index == readings.Count - 1)
    {
        return readings[index];
    }

    MachineReading hottest = FindHottestMachine(readings, index + 1);

    if (readings[index] > hottest)
    {
        return readings[index];

    }
    return hottest;
}

