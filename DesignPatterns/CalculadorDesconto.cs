using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CalculadorDesconto
{
    public double Calcular(Orcamento orcamento)
    {
        IDesconto descontoItem = new DescontoPorNumeroItens();
        IDesconto descontoValor = new DescontoPorValorOrcamento();
        IDesconto SemDesconto = new SemDesconto();

        descontoItem.SetProximoDesconto(descontoValor);
        descontoValor.SetProximoDesconto(SemDesconto);

        return descontoItem.CalcularDesconto(orcamento);

    }
}

