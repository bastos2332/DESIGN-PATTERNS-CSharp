using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class DescontoVendaCasada : IDesconto
        
    {
        public IDesconto Desconto { get;set; }

        public DescontoVendaCasada(IDesconto proximoDesconto)
        {
            this.Desconto = proximoDesconto;
        }

        public double CalcularDesconto(Orcamento orcamento)
        {
            bool isPossuiCaneta = false;
            bool isPossuiLapis = false;
            foreach (Items item in orcamento.Items)
            {
                if (item.getNome() == "CANETA")
                {
                    isPossuiCaneta = true;
                }else if(item.getNome() == "LAPIS") {
                    isPossuiLapis = true;
                }
            }
            if(isPossuiCaneta & isPossuiLapis)
            {
                return orcamento.Valor * 0.5;
            }else
            {
                return this.Desconto.CalcularDesconto(orcamento);
            }

        }
    }
}
