namespace AndreAirLines2._0Passagem.Utils
{
    public interface IPassagemDatabaseSettings
    {
        string PassagemCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
