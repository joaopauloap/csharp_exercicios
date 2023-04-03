using ProjetoSeguros;

int opc = 0;
List<Seguro> listaSeguros = new List<Seguro>();

Console.WriteLine("Tipos de seguro para avaliação:");
Console.WriteLine("------------------------------------------------");
Console.WriteLine("1 - Celular\n2 - Residencial\n3 - Automóvel\n4 - Meus Seguros\n5 - Sair\n");

while (opc != 5)
{
    try
    {
        Console.Write("\nEscolha um tipo de seguro para avaliação: ");
        opc = int.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (opc)
        {
            case 1:
                Console.Write("Insira o modelo do aparelho celular: ");
                string modelo = Console.ReadLine();
                Console.Write("Insira a marca do aparelho celular: ");
                string marca = Console.ReadLine();
                Console.Write("Insira o valor do aparelho celular: ");
                double valor = double.Parse(Console.ReadLine());
                Console.WriteLine("\nSeguro de celular adicionado com sucesso!");
                Console.WriteLine();

                SeguroCelular seguroCelular = new SeguroCelular(modelo, marca, valor);
                listaSeguros.Add(seguroCelular);
                break;
            case 2:
                SeguroResidencial seguroResidencial = new SeguroResidencial();
                listaSeguros.Add(seguroResidencial);
                break;
            case 3:
                SeguroAutomovel seguroAutomovel = new SeguroAutomovel();
                listaSeguros.Add(seguroAutomovel);
                break;
            case 4:
                listaSeguros.ForEach(seguro => seguro.ExibirInformacoes());
                break;
            default:
                break;
        }

    }

    catch (System.FormatException)
    {
        Console.WriteLine("Erro: Foi digitado um caractere não numérico. Tente novamente.");
    }

}

Console.WriteLine("\nPrograma Encerrado!");

