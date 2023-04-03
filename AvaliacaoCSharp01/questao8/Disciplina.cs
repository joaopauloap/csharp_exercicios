using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao8
{
    public class Disciplina
    {
        public List<double> Notas { get; set; }

        public double ObterMedia()
        {
            return (Notas.Sum()/Notas.Count());
        }
    }
}
