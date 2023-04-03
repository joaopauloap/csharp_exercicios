using projetoMouse;

int nDefeitos = 4; //Define a quantidade de defeitos

List<Mouse> GerarLista(List<Mouse> listaMouses, Defeito defeito)
{
    List<Mouse> listaGerada = listaMouses.FindAll(mouse => (mouse.Defeitos != null) && (mouse.Defeitos.Contains(defeito)));
    int qtdElementos = listaGerada.Count;
    Console.Write(qtdElementos == 0 ? "Nenhum" : "");
    listaGerada.ForEach(mouse => Console.Write($"{mouse.Id}, "));
    Console.WriteLine($"\nTotal: {(qtdElementos > 0 ? qtdElementos + " mouses" : 0)}");

    return listaGerada;
}

List<Mouse> listaMouses = new List<Mouse>();
int id = 1, qtdDefeitos, codDefeito, qtdMouses;

Console.WriteLine("Inventário de Mouses");
Console.WriteLine("(Identificador igual a zero encerra o programa)\n");
Console.WriteLine("Defeitos:\n1-Necessita de esfera\n2-Necessita de Limpeza\n3-Troca do Cabo ou Conector\n4-Quebrado ou Inutilizado\n");

while (id != 0)
{
    try
    {
        Console.Write("\nDigite o identificador do mouse: ");
        id = int.Parse(Console.ReadLine());

        if (id == 0)    //Se o id for 0 encerra o loop while
            break;

        if ((id < 0) || ((listaMouses.Find(mouse => mouse.Id == id)) != null))      //Evita IDs negativos e repetidos     
        {
            Console.WriteLine("ERRO! Digite um ID único e válido.");
            continue;
        }

        var mouse = new Mouse();
        mouse.Id = id;

        Console.Write($"Quantos defeitos o mouse {id} tem? : ");
        qtdDefeitos = int.Parse(Console.ReadLine());

        if (qtdDefeitos == 0)  //Se o mouse não tem defeitos, adiciona o objeto mouse na lista e reinicia o loop while
        {
            listaMouses.Add(mouse);
            continue;
        }
        else if (qtdDefeitos > 0 && qtdDefeitos <= nDefeitos)   //verifica se a qtd de defeitos digitada é valida
        {

            List<Defeito> listaDefeitos = new List<Defeito>();

            for (int i = 1; i < qtdDefeitos + 1; i++)
            {
                Console.Write($"Digite o código do defeito {i}: ");
                codDefeito = int.Parse(Console.ReadLine());

                if ((codDefeito <= 0) || (codDefeito > nDefeitos) || (listaDefeitos.Contains((Defeito)codDefeito - 1))) //verifica erros na entrada do codigo de erro
                {
                    Console.WriteLine("ERRO! Digite um código válido.");
                    i--;
                }
                else
                {
                    listaDefeitos.Add((Defeito)codDefeito - 1);
                }
            }
            mouse.Defeitos = listaDefeitos;
            listaMouses.Add(mouse);
        }
        else
        {
            Console.WriteLine($"ERRO! Digite uma quantidade maior ou igual a zero e menor que {nDefeitos}.");
            continue;
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine("ERRO! Digite apenas números válidos.");
        Console.WriteLine(ex.Message);
    }
}

qtdMouses = listaMouses.Count;

if (qtdMouses > 0)
{
    Console.WriteLine("\nRelatório - Completo:\n");

    Console.WriteLine("----Identificação dos mouses sem defeito ----");
    List<Mouse> listaSemDefeito = listaMouses.FindAll(mouse => mouse.Defeitos == null);
    int qtdSemDefeito = listaSemDefeito.Count;
    Console.Write(qtdSemDefeito == 0 ? "Nenhum" : "");
    listaSemDefeito.ForEach(mouse => Console.Write($"{mouse.Id}, "));
    Console.WriteLine($"\nTotal: {(qtdSemDefeito > 0 ? qtdSemDefeito + " mouses" : 0)}");

    Console.WriteLine("----Identificação dos mouses que necessitam de esfera----");
    GerarLista(listaMouses, Defeito.NecessitaEsfera);

    Console.WriteLine("----Identificação dos mouses que necessitam de limpeza----");
    GerarLista(listaMouses, Defeito.NecessitaLimpeza);

    Console.WriteLine("----Identificação dos mouses que necessitam troca de cabo ou conector----");
    GerarLista(listaMouses, Defeito.NecessitaTrocaDeCaboOuConector);

    Console.WriteLine("----Identificação dos mouses que estão quebrados ou inutilizados----");
    GerarLista(listaMouses, Defeito.QuebradoOuInutilizado);

    Console.WriteLine("\n-----------------------------------------------------------------------");
    Console.WriteLine("\nRelatório - Resumo:\n");
    Console.WriteLine($"Quantidade de mouses cadastrados: {qtdMouses}");
    Console.WriteLine($"Porcentagem de mouses sem defeito: {(qtdSemDefeito * 100) / qtdMouses}%");

    int qtdApenasUmDefeito = 0;
    foreach (var mouse in listaMouses)
    {
        if ((mouse.Defeitos != null) && (mouse.Defeitos.Count == 1))
        {
            qtdApenasUmDefeito++;
        }
    }

    Console.WriteLine($"Porcentagem de mouses com apenas um defeito: {(qtdApenasUmDefeito * 100) / qtdMouses}%");
}