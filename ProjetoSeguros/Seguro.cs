using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSeguros
{
    public abstract class Seguro
    {
        public double Valor { get; set; }
        public TipoSeguro Tipo { get; set; }
        public DateTime DataContratacao { get; set; }
        public Seguro()
        {

        }

        public virtual double GetValor()
        {
            return Valor;
        }

        public abstract void ExibirInformacoes();

    }
}
