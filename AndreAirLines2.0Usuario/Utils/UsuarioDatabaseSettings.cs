namespace AndreAirLines2._0Usuario.Utils
{
    public class UsuarioDatabaseSettings : IUsuarioDatabaseSettings
    {
        public string UsuarioCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
