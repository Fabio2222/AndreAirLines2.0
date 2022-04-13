namespace AndreAirLines2._0Aeroporto.Utils
{
    public class AeroportoDatabaseSettings : IAeroportoDatabaseSettings
    {
        public string AeroportoCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
