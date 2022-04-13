using AndreAirLinesAPI2._0Aeronave.Utils;

namespace AndreAirLinesAPI2._0Usuario.Utils
{
    public class AeronaveDatabaseSettings : IAeronaveDatabaseSettings
    {
        public string AeronaveCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
