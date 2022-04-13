using System.Collections.Generic;
using AndreAirLines2._0Endereco.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace AndreAirLines2._0Endereco.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecosController : ControllerBase
    {
        private readonly EnderecoService _enderecoService;

        public EnderecosController(EnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpGet]
        public ActionResult<List<Endereco>> Get() =>
            _enderecoService.Get();


        [HttpGet("{id:length(24)}", Name = "Getendereco")]
        public ActionResult<Endereco> Get(string id)
        {
            var endereco = _enderecoService.Get(id);

            if (endereco == null)
            {
                return NotFound();
            }

            return endereco;
        }

        [HttpPost]
        public ActionResult<Endereco> Create(Endereco endereco)
        {
            _enderecoService.Create(endereco);

            return CreatedAtRoute("GetAeroporto", new { id = endereco.Id.ToString() }, endereco);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Endereco enderecoIn)
        {
            var endereco = _enderecoService.Get(id);

            if (endereco == null)
            {
                return NotFound();
            }

            _enderecoService.Update(id, enderecoIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var endereco = _enderecoService.Get(id);

            if (endereco == null)
            {
                return NotFound();
            }

            _enderecoService.Remove(endereco.Id);

            return NoContent();
        }
    }
}
