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
    public class GitHubRepository : IGitHubRepository
    {
        private GitHub _gitHub;

        /// <summary>
        /// Construtor padrão da classe
        /// </summary>
        public GitHubRepository()
        {
            _gitHub = new GitHub();
        }

        /// <summary>
        /// Obtém o GitHub
        /// </summary>
        /// <returns>GitHub</returns>
        public GitHub Get()
        {
            if (_gitHub == null)
                throw new NullReferenceException("GitHub is requirid");

            return _gitHub;
        }
    }
}
