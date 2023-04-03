using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao2
{
    public class Elevador
    {
        public int AndarAtual { get; set; }
        public int TotalAndares { get; set; }
        public int CapacidadePessoas { get; set; }
        public int PessoasNoMomento { get; set; }

        public void Inicializa(int capacidade, int andares)
        {
            TotalAndares = andares;
            CapacidadePessoas = capacidade;
        }

        public void Entra()
        {
            if (PessoasNoMomento <= CapacidadePessoas)
            {
                PessoasNoMomento++;
            }
        }

        public void Sai()
        {
            if (PessoasNoMomento >= 1)
            {
                PessoasNoMomento--;
            }
        }

        public void Sobe()
        {
            if (AndarAtual < TotalAndares)
            {
                AndarAtual++;
            }
        }

        public void Desce()
        {
            if (AndarAtual >= 1)
            {
                AndarAtual--;
            }
        }
    }
}
