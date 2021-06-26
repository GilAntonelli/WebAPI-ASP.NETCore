using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITaxaJuros.Models
{
    /// <summary>
    /// Classe que representa informações do GitHub
    /// </summary>
    public class GitHub
    {
        public string Url { get; private set; }

        /// <summary>
        /// Construtor padrão da classe
        /// </summary>
        public GitHub()
        {
            this.Url = "https://github.com/GilAntonelli/WebAPI-ASP.NETCore";
        }        
    }
}
