using APICalculaJuros.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICalculaJuros.Controllers
{
    /// <summary>
    /// Controlador para retornar a url do projeto do github
    /// </summary>
    [Route("api/[controller]")]
    public class showmethecodeController : Controller
    {
        private IGitHubRepository _gitHubRepository;

        /// <summary>
        /// Construtor padrão da classe
        /// </summary>
        /// <param name="gitHubRepository"></param>
        public showmethecodeController(IGitHubRepository gitHubRepository)
        {
            this._gitHubRepository = gitHubRepository;
        }

        /// <summary>
        /// Obtém a url do projeto no github
        /// </summary>
        /// <returns>Url do projeto no github</returns>
        [HttpGet]
        public ActionResult<string> GetUrlCode()
        {
            return this._gitHubRepository.Get().Url;
        }
    }
}
