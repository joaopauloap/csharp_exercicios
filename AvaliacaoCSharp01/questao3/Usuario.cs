using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao3
{
    public class Usuario { 
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }

        public void CadastrarUsuario()
        {

        }

        public string VerificarTipoPessoa()
        {
            return "cnpj";
        }
    }
}
