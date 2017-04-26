using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Utils
{
    public abstract class CalculoOrcamento
    {
        public static double CalcularOrcamento(double distancia, object veiculo)
        {
            var taxaDeslocamento = 6.00;
            var taxaServico = 0.5;
            var valorCombustivel = 3.343;

            var distanciaRota = Math.Round(distancia, 2);
            var mediaConsumoVeiculo = veiculo;


            var custoCombustivel = distanciaRota / Convert.ToInt32(mediaConsumoVeiculo) * valorCombustivel;
            var valorTaxaServico = (custoCombustivel + taxaDeslocamento) * taxaServico;

            return Math.Round(custoCombustivel + taxaDeslocamento + valorTaxaServico, 2);

        }
    }
}
