﻿using Aula2TrilhaDotNet.DTO.SerraCircular.AdicionarSerraCircular;
using Aula2TrilhaDotNet.DTO.SerraCircular.AtualizaSerraCircular;
using Aula2TrilhaDotNet.DTO.SerraCircular.RemoverSerraCircular;
using Aula2TrilhaDotNet.Entities;
using Aula2TrilhaDotNet.Services;
using Aula2TrilhaDotNet.UseCase;
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
        private readonly IAdicionarSerraCircularUseCase _adicionarSerraCircularUseCase;
        private readonly IRemoverSerraCircularUseCase _removerSerraCircularUseCase;
        private readonly IAtulaizarSerraCircularUseCase _atulaizarSerraCircularUseCase;

        public SerraCircularController(
            ILogger<SerraCircularController> logger,
            ISerraCircularService serraCircular,
            IAdicionarSerraCircularUseCase adicionarSerraCircularUseCase,
            IRemoverSerraCircularUseCase removerSerraCircularUseCase,
            IAtulaizarSerraCircularUseCase atulaizarSerraCircularUseCase) {

            _logger = logger;
            _serraCircular = serraCircular;
            _adicionarSerraCircularUseCase = adicionarSerraCircularUseCase;
            _removerSerraCircularUseCase = removerSerraCircularUseCase;
            _atulaizarSerraCircularUseCase = atulaizarSerraCircularUseCase;
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
        public IActionResult serraCircuarAdd([FromBody] AdicionarSerraCircularRequest novaSerraCircular) {
            return Ok(_adicionarSerraCircularUseCase.Executar(novaSerraCircular));
        }

        [HttpPut]
        public IActionResult serraCircularUpdate([FromBody] AtualizarSerraCircularRequest novaSerraCircular) {
            return Ok(_atulaizarSerraCircularUseCase.Executar(novaSerraCircular));
        }

        [HttpDelete("{id}")]
        public IActionResult serraCircularDelete(int id) {
            var request = new RemoverSerraCircularRequest();
            request.id = id;
            return Ok(_removerSerraCircularUseCase.Executar(request));
        }

    }
}
