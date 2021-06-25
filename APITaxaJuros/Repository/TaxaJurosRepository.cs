using APITaxaJuros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITaxaJuros.Repository
{
    /// <summary>
    /// Repositório da taxa de juros
    /// </summary>
    public class TaxaJurosRepository : ITaxaJurosRepository
    {
        private TaxaJuros _taxaJuros;

        /// <summary>
        /// Construtor padrão da classe
        /// </summary>
        public TaxaJurosRepository()
        {
            _taxaJuros = new TaxaJuros();
        }

        /// <summary>
        /// Obtém a taxa de juros
        /// </summary>
        /// <returns>Taxa de Juros</returns>
        public TaxaJuros Get()
        {
            if (_taxaJuros == null)
                throw new NullReferenceException("Taxa de Juros is requirid");

            return _taxaJuros;            
        }
    }
}
