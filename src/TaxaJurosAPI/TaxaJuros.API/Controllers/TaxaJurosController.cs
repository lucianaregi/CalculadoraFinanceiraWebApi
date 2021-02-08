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
      
        public TaxaJurosController(TaxaJurosService taxaJurosService) => _taxaJurosService = taxaJurosService;

       
        public async Task<IActionResult> Get()
        {
            try
            {
                var taxaJuros = await _taxaJurosService.GetTaxaJuros();

                return Ok(taxaJuros.ToDecimal());
            }
            catch (Exception ex)
            {
                return BadRequest("Ocorreu um erro na sua requisição");
            }

        }
    }
}
