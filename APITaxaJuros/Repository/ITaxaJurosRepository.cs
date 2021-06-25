using APITaxaJuros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITaxaJuros.Repository
{
    /// <summary>
    /// Interface que representa TaxaJurosRepository
    /// </summary>
    public interface ITaxaJurosRepository
    {
        public TaxaJuros Get();
    }
}
