﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TaxaJuros.API.Extensions;
using TaxaJuros.API.Service;

namespace TaxaJuros.API.Controllers
{
    [Route("api/v1/taxaJuros")]
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
                var juros = Math.Round(taxaJuros, 2);
                return Ok(juros.ToDecimal());
            }
            catch (Exception)
            {
                return BadRequest("Ocorreu um erro na sua requisição");
            }

        }
    }
}
