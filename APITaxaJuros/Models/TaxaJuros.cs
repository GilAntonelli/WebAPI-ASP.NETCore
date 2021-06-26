using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITaxaJuros.Models
{
    /// <summary>
    /// Classe responsável pela taxa de juros
    /// </summary>
    public class TaxaJuros
    {
        public string Juros { get; private set; }

        /// <summary>
        /// Construtor padrão da classe
        /// </summary>
        public TaxaJuros()
        { 
            this.Juros = "0,01";
        }       
    }
}
