using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Veiculo
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public Veiculo()
        {

        }

        public Veiculo(string placa, string marca, string modelo, int ano)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;

            if ((ano >= 1900) && (ano <= 2017))
            {
                Ano = ano;
            }
        }


    }
}
