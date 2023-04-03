using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSeguros
{
    public class SeguroCelular : Seguro
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }

        public SeguroCelular()
        {
            Tipo = TipoSeguro.Celular;
            DataContratacao = DateTime.Now;
            Console.Write("Insira o modelo do aparelho celular: ");
            Modelo = Console.ReadLine();
            Console.Write("Insira a marca do aparelho celular: ");
            Marca = Console.ReadLine();
            Console.Write("Insira o valor do aparelho celular: ");
            Valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Seguro de celular adicionado com sucesso!");
            Console.WriteLine();
        }

        public SeguroCelular(string modelo, string marca, double valor)
        {
            Tipo = TipoSeguro.Celular;
            DataContratacao = DateTime.Now;
            Modelo = modelo;
            Marca = marca;
            Valor = valor;
        }

        public override double GetValor()
        {
            return base.GetValor();
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("--- Seguro Celular ---");
            Console.WriteLine($"Data de contratação: {DataContratacao}");
            Console.WriteLine($"Modelo do Celular: {Modelo}");
            Console.WriteLine($"Marca do Celular: {Marca}");
            Console.WriteLine($"Valor do Celular: {Valor.ToString("C")}");
            Console.WriteLine("------------------------------");

        }
    }
}
