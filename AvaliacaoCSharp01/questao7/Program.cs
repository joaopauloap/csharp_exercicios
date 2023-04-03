using questao7;

var conta1 = new ContaCorrente();
conta1.Titular = "João Paulo";

conta1.ExibirSaldo();

Console.WriteLine("\nDepositando Salário...");
conta1.Depositar(1850.00);
conta1.ExibirSaldo();
Console.WriteLine("\nDepositado com sucesso!\n");
Console.WriteLine("\nSacando R$ 350,00 ...");
conta1.Sacar(350.00);
Console.WriteLine("Sacado com sucesso!\n");

conta1.ExibirSaldo();