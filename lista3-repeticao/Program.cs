void ex1() {
    for (int n = 0; n < 11; n++) {
        Console.WriteLine($"5 x {n} = {5 * n}");
    }
}

void ex2() {

    Console.Write("Digite um número inteiro: ");
    int numero = int.Parse(Console.ReadLine());

    Console.WriteLine("");

    for (int n = numero + 1; n < numero + 11; n++) {
        Console.WriteLine(n);
    }

}

void ex3() {
    for (int n = 100; n < 201; n++) {
        if (n % 2 == 0) {
            Console.WriteLine(n);

        }
    }
}

void ex4() {
    Console.WriteLine("- Contar números ímpares em um intervalo -\n");

    Console.Write("Digite o primeiro número: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    int num2 = int.Parse(Console.ReadLine());

    int numerosImpares = 0;

    for (int n = num1; n < num2 + 1; n++) {
        if (n % 2 != 0) {
            numerosImpares++;
        }
    }
    Console.WriteLine($"\nHá {numerosImpares} números impares no intervalo {num1} a {num2}");
}

void ex5() {
    Console.WriteLine("- Soma dos termos em um intervalo -\n");

    Console.Write("Digite o primeiro número: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    int num2 = int.Parse(Console.ReadLine());

    int somaTermos = 0;

    for (int n = num1; n < num2 + 1; n++) {
        somaTermos += n;
    }
    Console.WriteLine($"\nResultado: {somaTermos}");
}

void ex6() {

    string idadeString;
    int idade = 0;
    int somaIdade = 0;

    for (int n = 1; n < 51; n++) {
        Console.Write($"Digite a idade do individuo nº {n}: ");
        idadeString = Console.ReadLine();

        if (idadeString.Length > 0) {
            idade = int.Parse(idadeString);
        } else {
            Console.WriteLine("ERRO! Digite uma idade maior ou igual a zero.");
            n--;
        }

        if (idade > 0) {
            somaIdade += idade;
        } else {
            Console.WriteLine("ERRO! Digite uma idade maior ou igual a zero.");
            n--;
        }
    }

    Console.WriteLine($"\nA média das 50 idades é: {somaIdade / 50}");

}

void ex7() {

    Random randNum = new Random();
    int numeroAleatorio = randNum.Next(100, 110);
    int somaTermos = 0;

    Console.Write("Digite um número: ");
    int num1 = int.Parse(Console.ReadLine());

    while (numeroAleatorio != num1) {
        numeroAleatorio = randNum.Next(100, 110);
        Console.WriteLine($"Número aleatório gerado: {numeroAleatorio}");
        somaTermos += numeroAleatorio;
    }

    Console.WriteLine($"Soma dos números gerados: {somaTermos}");

}

void ex8() {

    int tamanho = 3;

    string[] cidades = new string[tamanho];
    int[] veiculos = new int[tamanho];
    int[] acidentes = new int[tamanho];

    for (int i = 0; i < tamanho; i++) {

        Console.Write($"Digite o nome da cidade {i + 1}: ");
        cidades[i] = Console.ReadLine();

        Console.Write($"Digite o número de veículos de passeio em {cidades[i]} (em 2019): ");
        veiculos[i] = int.Parse(Console.ReadLine());

        Console.Write($"Digite o número de acidentes de trânsito com vítimas em {cidades[i]} (em 2019): ");
        acidentes[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("");
    }

    int maisAcidentes = acidentes.Max();
    int indiceMaisAcidentes = Array.IndexOf(acidentes, maisAcidentes);

    int menosAcidentes = acidentes.Min();
    int indiceMenosAcidentes = Array.IndexOf(acidentes, menosAcidentes);

    Console.WriteLine($"A cidade com a maior quantidade de acidentes de trânsito é: {cidades[indiceMaisAcidentes]}");
    Console.WriteLine($"A cidade com a menor quantidade de acidentes de trânsito é: {cidades[indiceMenosAcidentes]}");
    Console.WriteLine($"A média de veículos das {tamanho} cidades é: {veiculos.Average()}");

    float somaAcidentes = 0;
    float contadorAcidentes = 0;

    for (int i = 0; i < tamanho; i++) {
        if (veiculos[i] < 2000) {
            contadorAcidentes++;
            somaAcidentes += acidentes[i];
        }
    }

    float mediaAcidentes = somaAcidentes / contadorAcidentes;
    Console.WriteLine($"A média de acidentes de transito nas cidades com menos de 2.000 veículos de passeio é: {mediaAcidentes}");
}

void ex9() {
    int opc = 0;

    do {
        Console.Write(@"Menu de Opções
Digite a opção desejada:
1. Somar dois números
2. Raiz quadrada de um número
3. Sair

>");
        opc = int.Parse(Console.ReadLine());

        switch (opc) {
            case 1:
                Console.Write("Digite o num1: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o num2: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Soma: {num1} + {num2} = {num1 + num2}\n");
                break;

            case 2:
                Console.Write("Digite o número: ");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine($"A raiz quadrada do número {numero} é: {Math.Sqrt(numero)}\n");
                break;

            case 3:
                Console.WriteLine("Saindo...");
                break;

            default:
                Console.WriteLine("\nOpção inválida! Digite novamente.\n");
                break;
        }
    } while (opc != 3);
}


ex8();