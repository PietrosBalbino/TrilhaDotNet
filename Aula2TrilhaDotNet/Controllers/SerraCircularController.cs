using Aula2TrilhaDotNet.Entities;
using Aula2TrilhaDotNet.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2TrilhaDotNet.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class SerraCircularController : ControllerBase {

        private readonly ILogger<SerraCircularController> _logger;
        private readonly ISerraCircularService _serraCircular;

        public SerraCircularController(ILogger<SerraCircularController> logger, ISerraCircularService serraCircular) {
            _logger = logger;
            _serraCircular = serraCircular;
        }

        [HttpGet]
        public IActionResult TodasSerrasCircular() {
            return Ok(_serraCircular.RetonarListaSerraCircular());
        }

        [HttpGet("{id}")]
        public IActionResult serraCircular(int id) {
            return Ok(_serraCircular.RetornarSerraCircularPorId(id));
        }

        [HttpPost]
        public IActionResult serraCircuarAdd([FromBody] SerraCircular novaSerraCircular) {
            return Ok(_serraCircular.AdicionarSerraCircular(novaSerraCircular));
        }

        [HttpPut]
        public IActionResult serraCircularUpdate([FromBody] SerraCircular novaSerraCircular) {
            return Ok(_serraCircular.AtualizarSerraCircular(novaSerraCircular));
        }

        [HttpDelete("{id}")]
        public IActionResult serraCircularDelete(int id) {
            return Ok(_serraCircular.DeletarSerraCircular(id));
        }

    }
}
