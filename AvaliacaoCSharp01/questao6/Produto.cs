using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao6
{
    public class Produto
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public double Desconto { get; set; }

        //public Produto(int quantidade, double preco, double desconto)
        //{
        //    Quantidade = quantidade;
        //    Preco = preco;
        //    Desconto = desconto;
        //}


        public double Total()
        {
            return (Quantidade * (Preco - Desconto));
        }
    }
}
