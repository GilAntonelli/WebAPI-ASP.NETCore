using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace APICalculaJuros.Models
{
    /// <summary>
    /// Classe responsável por efetuar o calculo dos juros compostos
    /// </summary>
    public class CalculadoraJurosCompostos : ICalculadoraJurosCompostos
    {
        /// <summary>
        /// Faz o cálculo dos juros compostos
        /// </summary>
        /// <param name="valorInicial">Valor inicial</param>
        /// <param name="meses">Tempo em meses</param>
        /// <param name="juros">Taxa de juros</param>
        /// <returns>Valor acrecido de juros compostos</returns>
        public string ObtenhaValorAcrescentandoJurosCompostos(decimal valorInicial, int meses, double juros)
        {
            var valorFinal = (double)valorInicial * Math.Pow(1 + juros, (meses));                      
            valorFinal = Math.Truncate(valorFinal * 100) / 100;
            var culturaAtual = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
            culturaAtual.NumberDecimalDigits = 2;
            return valorFinal.ToString("N", culturaAtual);
        }
    }
}
