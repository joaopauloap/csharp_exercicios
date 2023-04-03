using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    public class Ponto
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Ponto()
        {
            X = 0.0;
            Y = 0.0;
        }

        public Ponto(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double CalcularDistancia(Ponto ponto2)
        {
            double dx = ponto2.X - X; 
            double dy = ponto2.Y - Y; 

            return Math.Sqrt(dx * dx + dy * dy); 
        }
    }
}
