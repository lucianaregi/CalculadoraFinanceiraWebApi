<<<<<<< Updated upstream
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
=======
﻿using CalculaJuros.API.Extensions;
using System;
>>>>>>> Stashed changes
using System.Threading.Tasks;


namespace CalculaJuros.API.Services
{
    public class CalculaJurosService
    {
        public async Task<string> CalcularJurosAsync(decimal valorInicial, int meses)
        {
<<<<<<< Updated upstream
            var taxaJuros = await ObterTaxaDeJurosAsync();
            //var taxaJuros = 0.01m;
            var potencia = (decimal)Math.Pow(1 + ((double)taxaJuros), meses);
=======
            
            //var taxaJuros = await _api1Service.ObterTaxaDeJurosAsync();
            var juros = decimal.Parse("0,01");
            //var taxaJuros = 0.01m;
            var potencia = (decimal)Math.Pow(1 + ((double)juros), meses);
>>>>>>> Stashed changes
            var valorCalculado = Convert.ToDecimal(valorInicial * potencia);
            var valorFinal = Math.Round(valorCalculado, 2);
            return valorFinal.ToDecimal();
        }

        public  async Task<decimal> ObterTaxaDeJurosAsync()
        {
            HttpClient httpClient = new HttpClient();
            string url = "http://localhost:8000/api/taxaJuros";
            string resultado = string.Empty;
                
            try
            {
                Uri _url = new Uri(url);
                var response = await httpClient.GetAsync(_url);

                if (response.IsSuccessStatusCode)
                {
                    resultado = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    resultado = response.StatusCode.ToString();
                }
            }
            catch (Exception ex)
            {
                var mensagem = ex.Message;
                return 0;
            }

            return decimal.Parse(resultado);
        }
    }
}
