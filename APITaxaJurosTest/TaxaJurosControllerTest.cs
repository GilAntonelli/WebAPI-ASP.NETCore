using APITaxaJuros.Controllers;
using APITaxaJuros.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace APITaxaJurosTest
{
    /// <summary>
    /// Classe responsável pelos testes do controller
    /// </summary>
    public class TaxaJurosControllerTest
    {
        TaxaJurosController _taxaJurosController;
        ITaxaJurosRepository _taxaJurosRepository;

        /// <summary>
        /// Construtor padrão da classe
        /// </summary>
        public TaxaJurosControllerTest()
        {
            _taxaJurosRepository = new TaxaJurosRepository();
            _taxaJurosController = new TaxaJurosController(_taxaJurosRepository); 
        }

        /// <summary>
        /// Teste para verificar o tipo do retorno da controller
        /// </summary>
        [Fact]
        public void TesteRetornoController()
        {            
            var okResult = _taxaJurosController.getTaxaJuros();            
            Assert.IsType<ActionResult<string>>(okResult);
        }

        /// <summary>
        /// Teste para verificar o valor da taxa de juros
        /// </summary>
        [Fact]
        public void TesteValorTaxaDeJuros()
        {            
            var okResult = _taxaJurosController.getTaxaJuros();
            Assert.Equal(okResult.Value, "0,01".ToString());
        }
    }
}
