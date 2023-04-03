using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao3
{
    public class Carrinho
    {
        public Usuario Usuario { get; set; }
        public List<Ebook> ListaCarrinho { get; set; }

        public void AdicionarAoCarrinho()
        {

        }

        public void FinalizarCompra()
        {
            if (Usuario.VerificarTipoPessoa() == "cnpj")
            {
                //...
            }
        }
    }
}
