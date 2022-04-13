namespace AndreAirLines2._0Passagem.Utils
{
    public class PassagemDataBaseSettings : IPassagemDatabaseSettings
    {
        public string PassagemCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
