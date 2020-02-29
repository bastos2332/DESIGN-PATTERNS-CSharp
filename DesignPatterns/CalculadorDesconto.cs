using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class CalculadorDesconto
    {
        public double Calcular(Orcamento orcamento)
        {
            IDesconto SemDesconto = new SemDesconto();
            IDesconto descontoItem = new DescontoPorNumeroItens(SemDesconto);
            IDesconto descontoValor = new DescontoPorValorOrcamento(descontoItem);
            IDesconto descontoVendaCasada = new DescontoVendaCasada(descontoValor);
            return descontoVendaCasada.CalcularDesconto(orcamento);
        }
    }
}


