using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaClasseAbstrata
{
    public class Quadrado : FormaPlana
    {
        private double Lado { get; set; }
        public override int x { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Quadrado(double lado)
        {
            Lado = lado;
        }

        public override double CalcularArea()
        {
            return Lado * Lado;
        }
    }
}
