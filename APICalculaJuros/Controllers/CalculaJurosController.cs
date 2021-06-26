using APICalculaJuros.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace APICalculaJuros.Controllers
{
    /// <summary>
    /// Controlador da calculadora de juros
    /// </summary>
    [Route("api/[controller]")]
    public class CalculaJurosController : Controller
    {
        private ICalculadoraJurosCompostos _calculadoraJurosCompostos;
        private IIntegraAPITaxaJuros _integraAPITaxaJuros;

        /// <summary>
        /// Construtor padrão da classe
        /// </summary>
        /// <param name="calculadoraJurosCompostos">Calculadora de juros compostos</param>
        /// <param name="integraAPITaxaJuros">Integra API taxaJuros</param>
        public CalculaJurosController(ICalculadoraJurosCompostos calculadoraJurosCompostos, IIntegraAPITaxaJuros integraAPITaxaJuros)
        {
            this._calculadoraJurosCompostos = calculadoraJurosCompostos;
            this._integraAPITaxaJuros = integraAPITaxaJuros;
        }

        /// <summary>
        /// Obtém o cálculo dos juros compostos
        /// </summary>
        /// <param name="valorInicial">Valor inicial</param>
        /// <param name="meses">Meses</param>
        /// <returns>Valor inicial acrescido de juros compostos</returns>
        [HttpGet]
        public ActionResult<string> GetCalculoJurosCompostos(decimal valorInicial, int meses)
        {
            var taxaJuros = _integraAPITaxaJuros.ObtenhaTaxaJuros();
            return _calculadoraJurosCompostos.ObtenhaValorAcrescentandoJurosCompostos(valorInicial, meses, taxaJuros);
        }
    } 
}
