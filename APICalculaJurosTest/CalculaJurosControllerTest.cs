using APICalculaJuros.Controllers;
using APICalculaJuros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace APICalculaJurosTest
{
    /// <summary>
    /// Classe para teste do controlador da Calculadora de Juros
    /// </summary>
    public class CalculaJurosControllerTest
    {
        CalculaJurosController _CalculadoraJurosController;

        /// <summary>
        /// Construtor padrão da classe
        /// </summary>
        public CalculaJurosControllerTest()
        {
            var calculadoraJurosCompostos = new CalculadoraJurosCompostos();
            var integraAPITaxaJuros = new IntegraAPITaxaJuros();

            this._CalculadoraJurosController = new CalculaJurosController(calculadoraJurosCompostos, integraAPITaxaJuros);
        }

        /// <summary>
        /// Testa o valor final truncado
        /// </summary>
        [Fact]
        public void TesteValorFinalTruncado()
        {
            var okResult = _CalculadoraJurosController.GetCalculoJurosCompostos(100, 5);
            Assert.Equal(okResult.Value, "105,10".ToString());

            okResult = _CalculadoraJurosController.GetCalculoJurosCompostos(500, 10);
            Assert.Equal(okResult.Value, "552,31".ToString());

            okResult = _CalculadoraJurosController.GetCalculoJurosCompostos(50, 8);
            Assert.Equal(okResult.Value, "54,14".ToString());

            okResult = _CalculadoraJurosController.GetCalculoJurosCompostos(880, 12);
            Assert.Equal(okResult.Value, "991,61".ToString());

            okResult = _CalculadoraJurosController.GetCalculoJurosCompostos(10240, 12);
            Assert.Equal(okResult.Value, "11.538,69".ToString());

            okResult = _CalculadoraJurosController.GetCalculoJurosCompostos(164, 36);
            Assert.Equal(okResult.Value, "234,65".ToString());

            okResult = _CalculadoraJurosController.GetCalculoJurosCompostos(57400, 60);
            Assert.Equal(okResult.Value, "104.278,39".ToString());
        }
    }
}
