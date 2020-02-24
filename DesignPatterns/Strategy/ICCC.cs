using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class ICCC : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            double resultado;
            if(orcamento.Valor < 1000)
            {
                resultado = orcamento.Valor * 0.05;
            }else if (orcamento.Valor >= 1000 & orcamento.Valor <= 3000 ) {
                resultado = orcamento.Valor * 0.07;
            } else
            {
                resultado = (orcamento.Valor * 0.08) - 30;
            }
            return resultado;
        }
    }
}
