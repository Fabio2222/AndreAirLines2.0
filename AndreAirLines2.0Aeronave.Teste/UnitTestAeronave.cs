using System;
using AndreAirLinesAPI2._0Aeronave.Services;
using Xunit;

namespace AndreAirLines2._0Aeronave.Teste
{
    public class UnitTestAeronave
    {
        private AeronaveService InitializeDataBase()
        {
            var settings = new AndreAirLinesAPI2._0Usuario.Utils.AeronaveDatabaseSettings();
            AeronaveService aeronaveService = new(settings);
            return aeronaveService;
        }


        [Fact]
        public void GetAll()
        {
            var aeronaveService = InitializeDataBase();
            var aeronaves = aeronaveService.Get();

            var status = aeronaves.Count > 0;
            Assert.Equal(true, status);
        }
    }
}
