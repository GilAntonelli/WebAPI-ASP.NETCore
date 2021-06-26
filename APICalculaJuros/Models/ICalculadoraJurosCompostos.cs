using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICalculaJuros.Models
{
    /// <summary>
    /// Interface Calculadora de Juros Compostos    
    /// </summary>
    public interface ICalculadoraJurosCompostos
    {
        public string ObtenhaValorAcrescentandoJurosCompostos(decimal valorInicial, int tempo, double juros);
    }
}
