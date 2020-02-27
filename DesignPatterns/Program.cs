using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        /* STRATEGY */
        Orcamento orcamento = new Orcamento(500);
        ISS iSS = new ISS();
        ICMS iCMS = new ICMS();
        Console.WriteLine("=======================STRATEGY=========================");
        Console.WriteLine("O imposto ICMS em cima de um orçamento de 500 reais é de " + new CalculadorImpostos().CalcularImpostos(orcamento, iCMS));
        Console.WriteLine("O imposto ISS em cima de um orçamento de 500 reais é de " + new CalculadorImpostos().CalcularImpostos(orcamento, iSS));

        /* CHAIN OF RESPONSABILITY */
        CalculadorDesconto calculador = new CalculadorDesconto();
        Orcamento orcamento2 = new Orcamento(500.0);

        orcamento2.AdicionaItens(new Items("CANETA", 250.0));
        orcamento2.AdicionaItens(new Items("LAPIS", 250.0));
        orcamento2.AdicionaItens(new Items("LAPIS", 250.0));
        orcamento2.AdicionaItens(new Items("LAPIS", 250.0));

        double desconto = calculador.Calcular(orcamento2);
        Console.WriteLine("==========================CHAIN OF RESPONSABILITY=========================");
        Console.WriteLine("O desconto para este orçamento foi de: " + desconto);


        Console.ReadKey();
    }

}

