using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DescontoPorNumeroItens : IDesconto
{
    public IDesconto Desconto { get; set; }

    public double CalcularDesconto(Orcamento orcamento)
    {
        if(orcamento.Items.Count > 3)
        {
            return orcamento.Valor * 0.05;
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

