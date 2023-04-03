using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    public class Lampada
    {
        public string Cor { get; set; }
        public bool Ligada { get; set; }

        public Lampada()
        {

        }

        public  Lampada(string cor)
        {
            Cor = cor;
            Ligada = true;
        }

        public Lampada(string cor, bool ligada)
        {
            Cor = cor;
            Ligada = ligada;
        }

    }
}
