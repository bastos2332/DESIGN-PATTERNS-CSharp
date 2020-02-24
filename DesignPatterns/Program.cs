using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Strategy.Orcamento orcamento = new Strategy.Orcamento(500);
            Strategy.ISS iSS = new Strategy.ISS();
            Strategy.ICMS iCMS = new Strategy.ICMS();

            Console.WriteLine("O imposto ICMS em cima de um orçamento de 500 reais é de " + new Strategy.CalculadorImpostos().CalcularImpostos(orcamento, iCMS));
            Console.WriteLine("O imposto ISS em cima de um orçamento de 500 reais é de " + new Strategy.CalculadorImpostos().CalcularImpostos(orcamento, iSS));
        }
        
    }
}
