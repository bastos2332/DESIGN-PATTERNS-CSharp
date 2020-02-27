using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DescontoPorValorOrcamento : IDesconto
{
    public IDesconto Desconto { get; set; }

    public double CalcularDesconto(Orcamento orcamento)
    {
       if (orcamento.Valor > 500)
        {
            return orcamento.Valor * 0.01;
        }else
        {
            return this.Desconto.CalcularDesconto(orcamento);
        }
    }

    public void SetProximoDesconto(IDesconto desconto)
    {
        this.Desconto = desconto;
    }
}

