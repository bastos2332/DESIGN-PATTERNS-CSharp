using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class CalculadorImpostos
    {
        public double CalcularImpostos(Orcamento orcamento, IImposto imposto)
        {
            return imposto.Calcula(orcamento);
        }
    }

}

