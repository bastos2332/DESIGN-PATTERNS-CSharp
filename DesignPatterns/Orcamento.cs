using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Orcamento
{
    public double Valor { get; private set; }
    public List<Items> Items { get; set; }


    public Orcamento(double valor)
    {
        this.Valor = valor;
        this.Items = new List<Items>();
    }

    public void AdicionaItens(Items item)
    {
        this.Items.Add(item);
    }
}




