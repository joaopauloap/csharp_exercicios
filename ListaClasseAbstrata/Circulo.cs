using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaClasseAbstrata
{
    public class Circulo : FormaPlana
    {
        public override int x { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        
        private const double PI = 3.1415;
        private double Raio { get; set; }

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public override double CalcularArea()
        {
            return PI*Raio*Raio;
        }
    }
}
