
using System.Net.Http;
﻿using CalculaJuros.API.Extensions;
using System;
using System.Threading.Tasks;


namespace CalculaJuros.API.Services
{
    public class CalculaJurosService
    {
        public async Task<string> CalcularJurosAsync(decimal valorInicial, int meses)
        {
            string mensagem = string.Empty;
            try 
            { 
                if(valorInicial > 0 && meses > 0 && meses <= 12)
                {
                    var taxaJuros = await ObterTaxaDeJurosAsync();
                    var potencia = (decimal)Math.Pow(1 + ((double)taxaJuros), meses);
                    var valorCalculado = Convert.ToDecimal(valorInicial * potencia);
                    var valorFinal = Math.Round(valorCalculado, 2);

                    return valorFinal.ToDecimal();
                }
                else
                {
                    mensagem = "Certifique-se que os valores sejam válidos.";
                    return mensagem;
                }
            } 
            catch (Exception) 
            {
                mensagem = "Ocorreu um erro.";
                return mensagem;
            }
            
        }

        public  async Task<decimal> ObterTaxaDeJurosAsync()
        {
            HttpClient httpClient = new HttpClient();
            string url = "http://localhost:8001/api/v1/taxaJuros";
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
