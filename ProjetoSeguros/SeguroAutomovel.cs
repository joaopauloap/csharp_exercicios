using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSeguros
{
    public class SeguroAutomovel : Seguro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int Quilometragem { get; set; }

        public SeguroAutomovel()
        {
            Tipo = TipoSeguro.Automovel;
            DataContratacao = DateTime.Now;
            Console.Write("Insira a marca do automóvel: ");
            Marca = Console.ReadLine();
            Console.Write("Insira o modelo do automóvel: ");
            Modelo = Console.ReadLine();
            Console.Write("Insira o ano do automóvel: ");
            Ano = int.Parse(Console.ReadLine());
            Console.Write("Insira a quilometragem do automóvel: ");
            Quilometragem = int.Parse(Console.ReadLine());
            Console.Write("Insira o valor do automóvel: ");
            Valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Seguro automotivo adicionado com sucesso!");
            Console.WriteLine();
        }

        public SeguroAutomovel(string marca, string modelo, int ano, int quilometragem, double valor)
        {
            Tipo = TipoSeguro.Automovel;
            DataContratacao = DateTime.Now;
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Quilometragem = quilometragem;
            Valor = valor;
        }
        public override double GetValor()
        {
            return base.GetValor();
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("--- Seguro Automóvel ---");
            Console.WriteLine($"Data de contratação: {DataContratacao}");
            Console.WriteLine($"Marca do automovel: {Marca}");
            Console.WriteLine($"Modelo do automóvel: {Modelo}");
            Console.WriteLine($"Ano do automóvel: {Ano}");
            Console.WriteLine($"Quilometragem do automóvel: {Quilometragem.ToString("N0")} Km");
            Console.WriteLine($"Valor do automóvel: {Valor.ToString("C")}");
            Console.WriteLine("------------------------------");

        }
    }
}
