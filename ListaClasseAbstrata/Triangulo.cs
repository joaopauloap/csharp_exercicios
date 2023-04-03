using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaClasseAbstrata
{
    public class Triangulo : FormaPlana
    {
        private double Base { get; set; }
        private double Altura { get; set; }
        public override int x { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Triangulo(double basee, double altura)
        {
            Base = basee;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return (Base*Altura)/2;
        }
    }
}
