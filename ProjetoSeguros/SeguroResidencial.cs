using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSeguros
{
    public class SeguroResidencial : Seguro
    {
        public string Cidade { get; set; }
        public double Area { get; set; }

        public SeguroResidencial()
        {
            Tipo = TipoSeguro.Residencial;
            DataContratacao = DateTime.Now;
            Console.Write("Insira a cidade da residência: ");
            Cidade = Console.ReadLine();
            Console.Write("Insira a área em m² da residência: ");
            Area = double.Parse(Console.ReadLine());
            Console.Write("Insira o valor da residência: ");
            Valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Seguro residencial adicionado com sucesso!");
            Console.WriteLine();
        }
        public SeguroResidencial(string cidade, double area, double valor)
        {
            Tipo = TipoSeguro.Residencial;
            DataContratacao = DateTime.Now;
            Cidade = cidade;
            Area = area;
            Valor = valor;
        }
        public override double GetValor()
        {
            return base.GetValor();
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("--- Seguro Residencial ---");
            Console.WriteLine($"Data de contratação: {DataContratacao}");
            Console.WriteLine($"Cidade da residência: {Cidade}");
            Console.WriteLine($"Área da residência: {Area.ToString("N0")} m²");
            Console.WriteLine($"Valor da residência: {Valor.ToString("C")}");
            Console.WriteLine("------------------------------");
        }
    }
}
