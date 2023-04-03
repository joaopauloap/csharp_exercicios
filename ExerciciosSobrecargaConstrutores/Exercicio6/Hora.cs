using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    public class Horas
    {
        public int Hora { get; set; }
        public int Minuto { get; set; }
        public int Segundo { get; set; }

        public Horas(int hora, int minuto, int segundo)
        {
            Hora = hora;
            Minuto = minuto;
            Segundo = segundo;
        }

        public void ObterHora()
        {
            Console.WriteLine($"{Hora.ToString()}:{Minuto.ToString()}:{Segundo.ToString()}");
        }

    }
}
