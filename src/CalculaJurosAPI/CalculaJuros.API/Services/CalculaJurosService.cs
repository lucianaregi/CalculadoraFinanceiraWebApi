using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxaJuros.API.Extensions;

namespace CalculaJuros.API.Services
{
    public class CalculaJurosService
    {
        public async Task<decimal> CalcularJurosAsync(decimal valorInicial, int meses)
        {
            //var taxaJuros = await _api1Service.ObterTaxaDeJurosAsync();
            var taxaJuros = 0.01m;
            var potencia = (decimal)Math.Pow(1 + ((double)taxaJuros), meses);
            var valorCalculado = Convert.ToDecimal(valorInicial * potencia);
            var valorFinal = Math.Round(valorCalculado, 2);
            return valorFinal;


        }
    }
}
