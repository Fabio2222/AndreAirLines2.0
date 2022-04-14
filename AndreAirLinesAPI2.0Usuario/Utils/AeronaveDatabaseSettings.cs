using AndreAirLinesAPI2._0Aeronave.Utils;

namespace AndreAirLinesAPI2._0Usuario.Utils
{
    public class AeronaveDatabaseSettings : IAeronaveDatabaseSettings
    {
        public string AeronaveCollectionName { get; set; } = "Aeronave";
        public string ConnectionString { get; set; } = "mongodb://localhost:27017";
        public string DatabaseName { get; set; } = "dbandreairlines20aeronave";
    }
}
