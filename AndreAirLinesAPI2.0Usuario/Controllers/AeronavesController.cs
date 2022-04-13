using System.Collections.Generic;
using AndreAirLinesAPI2._0Aeronave.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace AndreAirLinesAPI2._0Aeronave.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AeronavesController : ControllerBase
    {
        private readonly AeronaveService _aeronaveService;

        public AeronavesController(AeronaveService aeronaveService)
        {
            _aeronaveService = aeronaveService;
        }

        [HttpGet]
        public ActionResult<List<Aeronave>> Get() =>
            _aeronaveService.Get();


        [HttpGet("{id:length(24)}", Name = "GetCliente")]
        public ActionResult<Aeronave> Get(string id)
        {
            var cliente = _aeronaveService.Get(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return cliente;
        }

        [HttpPost]
        public ActionResult<Aeronave> Create(Aeronave cliente)
        {
            _aeronaveService.Create(cliente);

            return CreatedAtRoute("GetCliente", new { id = cliente.Id.ToString() }, cliente);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Aeronave aeronaveIn)
        {
            var aeronave = _aeronaveService.Get(id);

            if (aeronave == null)
            {
                return NotFound();
            }

            _aeronaveService.Update(id, aeronaveIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var aeronave = _aeronaveService.Get(id);

            if (aeronave == null)
            {
                return NotFound();
            }

            _aeronaveService.Remove(aeronave.Id);

            return NoContent();
        }


    }
}
