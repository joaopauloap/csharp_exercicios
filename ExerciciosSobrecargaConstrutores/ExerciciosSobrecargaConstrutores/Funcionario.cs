using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSobrecargaConstrutores
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public long Matricula { get; set; }
        public Profissao Profissao { get; set; }
        public double Salario { get; set; }

        public Funcionario()
        {

        }
        public Funcionario(long matricula)
        {

        }

        public Funcionario(long matricula, string nome)
        {

        }
        public Funcionario(long matricula, string nome, Profissao profissao)
        {

        }

        public void ExibirDadosFuncionario()
        {

        }
    }
}
