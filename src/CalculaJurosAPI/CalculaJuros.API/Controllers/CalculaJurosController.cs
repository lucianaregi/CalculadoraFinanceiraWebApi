using CalculaJuros.API.Extensions;
using CalculaJuros.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace CalculaJuros.API.Controllers
{
    [Route("api/v1/calculajuros")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private readonly CalculaJurosService _calculaJurosService;

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="calculaJurosService"></param>
        public CalculaJurosController(CalculaJurosService calculaJurosService) => _calculaJurosService = calculaJurosService;

        /// <summary>
        /// Método responsável para retornar o cálculo do juros
        /// </summary>
        /// <param name="valorInicial"></param>
        /// <param name="meses"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] decimal valorInicial, [FromQuery] int meses)
        {
            try
            {
                var valorFinal = await _calculaJurosService.CalcularJurosAsync(valorInicial, meses);
                
                return Ok(valorFinal);
            }
            catch (Exception ex)
            {
                return BadRequest("Ocorreu um erro na sua requisição" + ex.Message);
            }
          
        }

    }
}
