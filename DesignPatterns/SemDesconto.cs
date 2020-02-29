using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{

    class SemDesconto : IDesconto
    {
        public IDesconto Desconto { get; set; }
        public SemDesconto() {

        }
        public double CalcularDesconto(Orcamento orcamento)
        {
            return 0;
        }

    }

}


