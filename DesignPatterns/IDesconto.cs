using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IDesconto
{
    IDesconto Desconto { get; set; }
    double CalcularDesconto(Orcamento orcamento);
    void SetProximoDesconto(IDesconto desconto);
}

