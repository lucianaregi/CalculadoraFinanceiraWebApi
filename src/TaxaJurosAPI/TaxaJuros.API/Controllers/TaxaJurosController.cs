using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TaxaJuros.API.Extensions;
using TaxaJuros.API.Service;

namespace TaxaJuros.API.Controllers
{
    [Route("api/taxaJuros")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        private readonly TaxaJurosService _taxaJurosService;

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="taxaJurosService"></param>
        public TaxaJurosController(TaxaJurosService taxaJurosService) => _taxaJurosService = taxaJurosService;

        /// <summary>
        /// Método responsável para retornar a taxa de juros
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var taxaJuros = await _taxaJurosService.GetTaxaJuros();

                return Ok(taxaJuros.ToDecimal());
            }
            catch (Exception ex)
            {
                return BadRequest("Ocorreu um erro na sua requisição" + ex.Message);
            }

        }
    }
}
