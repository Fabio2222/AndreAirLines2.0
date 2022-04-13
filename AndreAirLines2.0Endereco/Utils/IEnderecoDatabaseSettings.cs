namespace AndreAirLines2._0Endereco.Utils
{
    public interface IEnderecoDatabaseSettings
    {
        string EnderecoCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
