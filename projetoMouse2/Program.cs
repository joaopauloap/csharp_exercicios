int nDefeitos = 4; //Define a quantidade de defeitos

Dictionary<int, List<int>> listaMouses = new Dictionary<int, List<int>>();
int id = 1, qtdDefeitos, codDefeito, totalMouses;

Console.WriteLine("Inventário de Mouses");
Console.WriteLine("(Identificador igual a zero encerra o programa)\n");
Console.WriteLine("Defeitos:\n1-Necessita de esfera\n2-Necessita de Limpeza\n3-Troca do Cabo ou Conector\n4-Quebrado ou Inutilizado\n");

while (id != 0)
{
    try
    {
        Console.Write("\nDigite o identificador do mouse: ");
        id = int.Parse(Console.ReadLine());

        if (id == 0)    //Se o id for 0 encerra o programa
            break;
        if ((id < 0) || (listaMouses.Keys.Contains(id)))       //Evita IDs negativos e repetidos
        {
            Console.WriteLine("ERRO! Digite um ID único e válido.");
            continue;
        }

        Console.Write($"Quantos defeitos o mouse {id} tem? : ");
        qtdDefeitos = int.Parse(Console.ReadLine());

        if (qtdDefeitos == 0)
        {
            listaMouses.Add(id, new List<int> { 0 });
            continue;
        }
        else if (qtdDefeitos > 0 && qtdDefeitos <= nDefeitos)
        {

            List<int> defeitos = new List<int>();

            for (int i = 1; i < qtdDefeitos + 1; i++)
            {
                Console.Write($"Digite o código do defeito {i}: ");
                codDefeito = int.Parse(Console.ReadLine());

                if ((codDefeito <= 0) || (codDefeito > nDefeitos) || (defeitos.Contains(codDefeito))) //verifica erros na entrada do codigo de erro
                {
                    Console.WriteLine("ERRO! Digite um código válido.");
                    i--;
                }
                else
                {
                    defeitos.Add(codDefeito);
                }
            }

            listaMouses.Add(id, defeitos);
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

totalMouses = listaMouses.Count;

if (totalMouses > 0)
{
    List<int> semDefeitos = new List<int>();
    List<int> esfera = new List<int>();
    List<int> limpeza = new List<int>();
    List<int> cabo = new List<int>();
    List<int> quebrados = new List<int>();

    foreach (var mouse in listaMouses.Keys)
    {
        foreach (var defeito in listaMouses[mouse])
        {
            switch (defeito)
            {
                case 0: //sem defeitos
                    semDefeitos.Add(mouse);
                    break;
                case 1: //precisa esfera
                    esfera.Add(mouse);
                    break;
                case 2: //precisa limpeza
                    limpeza.Add(mouse);
                    break;
                case 3: //precisa cabo
                    cabo.Add(mouse);
                    break;
                case 4: //quebrados
                    quebrados.Add(mouse);
                    break;
            }
        }
    }

    semDefeitos.Sort();
    esfera.Sort();
    limpeza.Sort();
    cabo.Sort();
    quebrados.Sort();

    Console.WriteLine('\n');
    Console.WriteLine("----Identificação dos mouses sem defeito ----");
    Console.Write(semDefeitos.Count == 0 ? "Nenhum" : "");
    semDefeitos.ForEach(e => Console.Write($"{e}, "));
    Console.WriteLine($"\nTotal: {(semDefeitos.Count > 0 ? semDefeitos.Count + " mouses" : 0)}");

    Console.WriteLine("----Identificação dos mouses que necessitam de esfera----");
    Console.Write(esfera.Count == 0 ? "Nenhum" : "");
    esfera.ForEach(e => Console.Write($"{e}, "));
    Console.WriteLine($"\nTotal: {(esfera.Count > 0 ? esfera.Count + " mouses" : 0)}");

    Console.WriteLine("----Identificação dos mouses que necessitam de limpeza----");
    Console.Write(limpeza.Count == 0 ? "Nenhum" : "");
    limpeza.ForEach(e => Console.Write($"{e}, "));
    Console.WriteLine($"\nTotal: {(limpeza.Count > 0 ? limpeza.Count + " mouses" : 0)}");

    Console.WriteLine("----Identificação dos mouses que necessitam troca de cabo ou conector----");
    Console.Write(cabo.Count == 0 ? "Nenhum" : "");
    cabo.ForEach(e => Console.Write($"{e}, "));
    Console.WriteLine($"\nTotal: {(cabo.Count > 0 ? cabo.Count + " mouses" : 0)}");

    Console.WriteLine("----Identificação dos mouses que estão quebrados ou inutilizados----");
    Console.Write(quebrados.Count == 0 ? "Nenhum" : "");
    quebrados.ForEach(e => Console.Write($"{e}, "));
    Console.WriteLine($"\nTotal: {(quebrados.Count > 0 ? quebrados.Count + " mouses" : 0)}");
}
