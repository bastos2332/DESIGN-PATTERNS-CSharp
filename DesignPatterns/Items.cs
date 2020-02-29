using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{



    class Items
    {
        private string nome;
        private double valor;

        public Items(string nome, double valor)
        {
            this.nome = nome;
            this.valor = valor;
        }

        public string getNome()
        {
            return nome;
        }

        public double getValor()
        {
            return valor;
        }
    }

}

