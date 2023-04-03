using questao5;

var funcionario1 = new Funcionario();

Console.Write("Informe o numero de horas trabalhadas: ");
funcionario1.HorasTrabalhadas = double.Parse(Console.ReadLine());  

Console.Write("Informe o valor da hora de trabalho: ");
funcionario1.ValorHora = double.Parse(Console.ReadLine());

//Console.WriteLine($"Salário R$ {Funcionario1.Salario()}");
funcionario1.MostrarSalario();