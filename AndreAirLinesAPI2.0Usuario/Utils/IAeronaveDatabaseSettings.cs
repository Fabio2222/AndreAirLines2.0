namespace AndreAirLinesAPI2._0Aeronave.Utils
{
    public interface IAeronaveDatabaseSettings
    {
        string AeronaveCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
