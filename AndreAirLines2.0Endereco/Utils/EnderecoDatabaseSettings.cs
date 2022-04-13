namespace AndreAirLines2._0Endereco.Utils
{
    public class EnderecoDatabaseSettings : IEnderecoDatabaseSettings
    {
        public string EnderecoCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
