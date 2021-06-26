using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace APICalculaJuros.Models
{
    /// <summary>
    /// Classe responsável por fazer a integração com a API taxaJuros
    /// </summary>
    public class IntegraAPITaxaJuros : IIntegraAPITaxaJuros
    {
        /// <summary>
        /// Obtém a taxa de juros da API taxaJuros
        /// </summary>
        /// <returns>Taxa de juros</returns>
        public double ObtenhaTaxaJuros()
        {            
            var httpClient = new HttpClient();
            
            httpClient.BaseAddress = new Uri("https://localhost:5001/");
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = httpClient.GetAsync("api/taxaJuros").Result;
            var juros = string.Empty;

            if (response.IsSuccessStatusCode)
            {
                var usuarioUri = response.Headers.Location;
                var jsonResult = response.Content.ReadAsStringAsync().Result;
                juros = JsonSerializer.Deserialize<string>(jsonResult);
            }

            return double.Parse(juros);
        }
    }
}
