//Escreva um programa para cadastrar um Cliente. Instancie o objeto do tipo Cliente e preencha as
//propriedades deste objeto com dados vindos do usuário e depois evoque o método ExibirNomeFormatado
//da classe Cliente

using ExPolimorfismo;

Console.Write("Informe o nome do cliente: ");
string nomeCliente = Console.ReadLine();

Console.Write("Informe o título do cliente: ");
string tituloCliente = Console.ReadLine();

var cliente1 = new Cliente(tituloCliente,nomeCliente);

cliente1.ExibirNomeFormatado();