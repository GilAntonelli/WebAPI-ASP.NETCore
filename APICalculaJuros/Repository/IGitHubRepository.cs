using APITaxaJuros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICalculaJuros.Repository
{
    /// <summary>
    /// Interface que representa as informações do github
    /// </summary>
    public interface IGitHubRepository
    {
        public GitHub Get();
    }
}
