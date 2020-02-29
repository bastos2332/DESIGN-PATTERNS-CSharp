using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class DescontoPorNumeroItens : IDesconto
    {
        public IDesconto Desconto { get; set; }
        public DescontoPorNumeroItens(IDesconto proximoDesconto)
        {
            this.Desconto = proximoDesconto;
        }

        public double CalcularDesconto(Orcamento orcamento)
        {
            if (orcamento.Items.Count > 3)
            {
                return orcamento.Valor * 0.05;
            }
            else
            {
                return this.Desconto.CalcularDesconto(orcamento);
            }
        }

    }


}

