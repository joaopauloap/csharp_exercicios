using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao8
{
    public class Aluno
    {
        public Disciplina Disciplina { get; set; }
        public string Nome { get; set; }

        public void AtribuirNotas(List<double> notas)
        {
            Disciplina.Notas = notas;
            Console.WriteLine($"O aluno {Nome} obteve média {Disciplina.ObterMedia()}.");
        }
    }
}
