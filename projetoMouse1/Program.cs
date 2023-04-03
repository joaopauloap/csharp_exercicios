Dictionary<int, int> listaMouses = new Dictionary<int, int>();
int id = 1, defeito, totalMouses, esfera = 0, limpeza = 0, cabo = 0, quebrado = 0;

Console.WriteLine("Checagem do inventário de Mouses");
Console.WriteLine("(Digite 0 para sair do programa)\n");
Console.WriteLine("Defeitos:\n1-Necessita de esfera\n2-Necessita de Limpeza\n3-Troca do Cabo ou Conector\n4-Quebrado ou Inutilizado\n");


while (id != 0)
{
    try
    {
        Console.Write("\nDigite o nº de identificação do mouse: ");
        id = int.Parse(Console.ReadLine());

        if (id == 0)
            break;
        if ((id < 0) || (listaMouses.Keys.Contains(id)))
        {
            Console.WriteLine("ERRO! Digite um ID único e válido.");
            continue;
        }

        Console.Write("Digite o nº do defeito: ");
        defeito = int.Parse(Console.ReadLine());
        if ((defeito <= 0) || (defeito > 4))
        {
            Console.WriteLine("ERRO! Digite um código válido.");
            continue;
        }
        listaMouses.Add(id, defeito);
    }
    catch (Exception ex)
    {
        Console.WriteLine("ERRO! Digite apenas números.");
    }
}

totalMouses = listaMouses.Count;

if (totalMouses > 0)
{
    foreach (var par in listaMouses)
    {
        switch (par.Value)
        {
            case 1:
                esfera++;
                break;
            case 2:
                limpeza++;
                break;
            case 3:
                cabo++;
                break;
            case 4:
                quebrado++;
                break;
        }
    }

    Console.WriteLine($"\nQuantidade de mouses: {totalMouses}\n");
    Console.WriteLine("Situação:                        Quantidade      Percentual");
    Console.WriteLine($"1-Necessita de esfera                {esfera}              {esfera * 100 / totalMouses}%");
    Console.WriteLine($"2-Necessita de limpeza               {limpeza}              {limpeza * 100 / totalMouses}%");
    Console.WriteLine($"3-Necessita troca do cabo/conector   {cabo}              {cabo * 100 / totalMouses}%");
    Console.WriteLine($"4-Quebrado ou inutilizado            {quebrado}              {quebrado * 100 / totalMouses}%");

}
