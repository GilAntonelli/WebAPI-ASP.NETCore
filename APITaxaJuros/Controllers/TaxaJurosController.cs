using APITaxaJuros.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITaxaJuros.Controllers
{
    /// <summary>
    /// Controller responsável pelos dados da taxa de juros
    /// </summary>
    [Route("api/[controller]")]
    public class TaxaJurosController : Controller
    {
        private readonly ITaxaJurosRepository _taxaJurosRepository;

        /// <summary>
        /// Construtor padrão da classe
        /// </summary>
        /// <param name="taxaJurosRepository"></param>
        public TaxaJurosController(ITaxaJurosRepository taxaJurosRepository)
        {
            this._taxaJurosRepository = taxaJurosRepository;
        }
        
        /// <summary>
        /// Obtém a taxa de juros
        /// </summary>
        /// <returns>Taxa de juros</returns>
        [HttpGet]
        public ActionResult<string> getTaxaJuros()
        {
            return _taxaJurosRepository.Get().Juros;
        }
    }
}
