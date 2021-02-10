using CalculaJuros.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculaJuros.API.Controllers
{
    [Route("calculajuros")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private readonly CalculaJurosService _calculaJurosService;

        public CalculaJurosController(CalculaJurosService calculaJurosService) => _calculaJurosService = calculaJurosService;

        [HttpGet]
        public async Task<decimal> Get([FromQuery] decimal valorInicial, [FromQuery] int meses)
        {
            return await _calculaJurosService.CalcularJurosAsync(valorInicial, meses);
        }

    }
}
