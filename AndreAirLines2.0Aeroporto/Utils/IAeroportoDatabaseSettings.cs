namespace AndreAirLines2._0Aeroporto.Utils
{
    public interface IAeroportoDatabaseSettings
    {
        string AeroportoCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
