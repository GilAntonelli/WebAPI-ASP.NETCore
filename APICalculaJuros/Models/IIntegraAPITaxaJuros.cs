using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICalculaJuros.Models
{
    /// <summary>
    /// Interface responsável pela integração com a API taxaJuros
    /// </summary>
    public interface IIntegraAPITaxaJuros
    {
        public double ObtenhaTaxaJuros();
    }
}
