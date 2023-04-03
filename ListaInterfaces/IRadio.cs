using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaInterfaces
{
    public interface IRadio:IPlayer
    {
        public void SelecionarEstacao(int prefixo);
    }
}
