using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SemDesconto : IDesconto
{
    public IDesconto Desconto { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public double CalcularDesconto(Orcamento orcamento)
    {
        return 0;
    }

    public void SetProximoDesconto(IDesconto desconto)
    {
        
    }
}

