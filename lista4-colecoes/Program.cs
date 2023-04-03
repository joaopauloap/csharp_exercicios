void ex1()
{
    List<int> listaNumeros = new List<int>();
    List<int> listaMultiplos2 = new List<int>();
    List<int> listaMultiplos3 = new List<int>();

    for (int i = 0; i < 7; i++)
    {
        Console.Write("\nDigite um número inteiro: ");
        listaNumeros.Add(int.Parse(Console.ReadLine()));

        if (listaNumeros[i] % 2 == 0)
        {
            listaMultiplos2.Add(listaNumeros[i]);
        }

        if (listaNumeros[i] % 3 == 0)
        {
            listaMultiplos3.Add(listaNumeros[i]);
        }

    }

    Console.Write("\nNúmeros múltiplos de 2: ");
    foreach (int num in listaMultiplos2)
    {
        Console.Write(num + ", ");
    }

    Console.Write("\nNúmeros múltiplos de 3: ");
    foreach (int num in listaMultiplos3)
    {
        Console.Write(num + ", ");
    }
}

void ex2()
{
    List<int> listaNumeros = new List<int>();

    for (int i = 0; i < 15; i++)
    {
        Console.Write($"\n{i} - Digite um número inteiro: ");
        listaNumeros.Add(int.Parse(Console.ReadLine()));
    }
    Console.WriteLine("");
    for (int i = 0; i < 15; i++)
    {
        if (listaNumeros[i] == 30)
        {
            Console.WriteLine("Número 30 encontrado no indice: " + i);
        }
    }

}

void ex3()
{
    int quantidadeVendedores = 2;

    List<string> listaVendedores = new List<string>();
    List<float> listaVendas = new List<float>();
    List<float> listaComissao = new List<float>();
    List<float> listaComissaoTotal = new List<float>();

    for (int i = 0; i < quantidadeVendedores; i++)
    {
        Console.Write("Digite o nome do vendedor: ");
        listaVendedores.Add(Console.ReadLine());

        Console.Write($"Digite o total em vendas do vendedor {listaVendedores[i]}: R$ ");
        listaVendas.Add(float.Parse(Console.ReadLine()));

        Console.Write($"Digite a comissão do vendedor {listaVendedores[i]} em %: ");
        listaComissao.Add(float.Parse(Console.ReadLine()));

        Console.WriteLine("\n");
    }

    //a) Um relatório com os nomes dos vendedores e os valores a receber referentes á comissão
    Console.WriteLine("\nRelatório: \n");
    for (int i = 0; i < quantidadeVendedores; i++)
    {
        listaComissaoTotal.Add(listaVendas[i] * (listaComissao[i] / 100));
        Console.WriteLine($"{listaVendedores[i]} - Valor a receber da sua comissão de {listaComissao[i]}% = R$ {listaComissaoTotal[i]}");
    }

    //b) O total das vendas de todos os vendedores;
    Console.WriteLine($"\nTotal das vendas: R$ {listaVendas.Sum()}");

    //c) O maior valor a receber e o nome de quem o receberá; 
    float maiorComissao = listaComissaoTotal.Max();
    int indiceMaiorComissao = listaComissaoTotal.IndexOf(maiorComissao);
    string maiorVendedor = listaVendedores[indiceMaiorComissao];
    Console.WriteLine($"Maior valor a receber: R$ {maiorComissao} - {maiorVendedor}");

    //d) O menor valor a receber e o nome de quem o receberá;
    float menorComissao = listaComissaoTotal.Min();
    int indiceMenorComissao = listaComissaoTotal.IndexOf(menorComissao);
    string menorVendedor = listaVendedores[indiceMenorComissao];
    Console.WriteLine($"Menor valor a receber: R$ {menorComissao} - {menorVendedor}");
}

void ex4()
{
    List<float> listaNumeros = new List<float>();
    int contadorNegativos = 0;
    float totalPositivos = 0;

    for (int i = 0; i < 10; i++)
    {
        Console.Write("Digite um número real: ");
        listaNumeros.Add(float.Parse(Console.ReadLine()));
        if (listaNumeros[i] < 0)
        {
            contadorNegativos++;
        }
        else
        {
            totalPositivos += listaNumeros[i];
        }
    }

    Console.WriteLine($"\nQuantidade de números negativos: {contadorNegativos}");
    Console.WriteLine($"Soma de números positivos: {totalPositivos}");

}


void ex5()
{
    List<int> listaNumeros = new List<int>() { 1, 1, 1, 5, 5, 7, 9, 9, 1 };
    List<int> listaRepetidos = new List<int>();
    List<int> listaFrequencia = new List<int>();

    //for (int i = 0; i < 10; i++)
    //{
    //    Console.Write("Digite um número inteiro: ");
    //    listaNumeros.Add(int.Parse(Console.ReadLine()));
    //}

    listaNumeros.Sort();




        //for (int n = i + 1; n < listaNumeros.Count; n++)    //percorre toda a lista
        //{
        //    if (listaNumeros[i] == listaNumeros[n])
        //    {
        //        if (listaRepetidos.Contains(listaNumeros[n]))
        //        {
        //            listaFrequencia[listaRepetidos.IndexOf(listaNumeros[i])]++;
        //        }
        //        else
        //        {
        //            listaRepetidos.Add(listaNumeros[i]);
        //            listaFrequencia.Add(1);
        //        }
        //    }
        //}
    }

    for (int i = 0; i < listaRepetidos.Count; i++)
    {
        Console.WriteLine($"O número {listaRepetidos[i]} repetiu {listaFrequencia[i]} vezes");
    }

}

void ex6()
{
    List<int> listaTodos = new List<int>();
    List<int> listaPares = new List<int>();
    List<int> listaImpares = new List<int>();
    List<int> listaNegativos = new List<int>();
    int numero = 0;

    for (int i = 0; i < 15; i++)
    {
        Console.Write($"\n{i} - Digite um número inteiro: ");
        numero = int.Parse(Console.ReadLine());

        if (numero == 0)
        {
            Console.WriteLine("Erro! Digite um número diferente de zero.");
            i--;
        }
        else
        {
            listaTodos.Add(numero);

            for (int n = 0; n < i; n++) //verifica se há item repetido
            {
                if (numero == listaTodos[n])
                {
                    Console.WriteLine("Erro! Não é permitido números repetidos.");
                    listaTodos.RemoveAt(listaTodos.Count - 1);
                    i--;
                }
                else
                {

                }
            }

        }
    }

    foreach (int item in listaTodos)
    {
        if (item < 0)
        {
            listaNegativos.Add(item);
        }
        else
        {
            if (item % 2 == 0)
            {
                listaPares.Add(item);
            }
            else
            {
                listaImpares.Add(item);
            }
        }
    }

    Console.Write("\nNúmeros pares: ");
    foreach (int item in listaPares)
    {
        Console.Write(item + ", ");
    }

    Console.Write("\nNúmeros ímpares: ");
    foreach (int item in listaImpares)
    {
        Console.Write(item + ", ");
    }

    Console.Write("\nNúmeros negativos: ");
    foreach (int item in listaNegativos)
    {
        Console.Write(item + ", ");
    }

    Console.WriteLine($"\nMaior número: {listaTodos.Max()} e Menor número: {listaTodos.Min()}");
}

ex5();