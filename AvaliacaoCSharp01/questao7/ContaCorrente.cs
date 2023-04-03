using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao7
{
    public class ContaCorrente
    {
        public String Titular { get; set; }
        public int AgenciaContaCorrente { get; set; }
        public String NumeroContaCorrente { get; set; }
        public double Saldo { get; set; }

        public double Depositar(double valor)
        {
            Saldo += valor;
            return Saldo;
        }

        public double Sacar(double valor)
        {
            Saldo -= valor;
            return Saldo;
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Olá {Titular}, o seu saldo é R$ {Saldo}");
        }
    }
}
