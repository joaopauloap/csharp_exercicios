using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao3
{
    public class Ebook
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Editora { get; set; }
        public string Idioma { get; set; }
        public DateTime Data { get; set; }
        public double Preco { get; set; }

        public void VerificarDisponibilidade()
        {

        }
    }
}
