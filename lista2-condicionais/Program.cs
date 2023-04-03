void ex1() {
    Console.Write("num1: ");
    string num1Str = Console.ReadLine();
    int num1 = int.Parse(num1Str);

    Console.Write("num2: ");
    string num2Str = Console.ReadLine();
    int num2 = int.Parse(num2Str);

    if (num1 > num2)
        Console.WriteLine(num1);
    else
        Console.WriteLine(num2);
}


void ex2() {
    Console.Write("num1: ");
    string num1Str = Console.ReadLine();
    float num1 = float.Parse(num1Str);

    Console.Write("num2: ");
    string num2Str = Console.ReadLine();
    float num2 = float.Parse(num2Str);

    Console.Write("num3: ");
    string num3Str = Console.ReadLine();
    float num3 = float.Parse(num3Str);

    float[] lista = new float[] { num1, num2, num3 };
    Array.Sort(lista);
    Array.Reverse(lista);

    Array.ForEach(lista, Console.WriteLine);

}


void ex3() {
    Console.Write("num1: ");
    string num1Str = Console.ReadLine();
    int num1 = int.Parse(num1Str);

    Console.Write("num2: ");
    string num2Str = Console.ReadLine();
    int num2 = int.Parse(num2Str);

    Console.Write("num3: ");
    string num3Str = Console.ReadLine();
    int num3 = int.Parse(num3Str);

    if ((num1 == num2) && (num2 == num3)) {
        Console.WriteLine("OS TRÊS NÚMEROS DIGITADOS SÃO IGUAIS");
    } else {
        int[] lista = new int[] { num1, num2, num3 };
        Array.Sort(lista);
        Array.ForEach(lista, Console.WriteLine);

    }

}


void ex4() {
    Console.Write("num1: ");
    string num1Str = Console.ReadLine();
    int num1 = int.Parse(num1Str);

    Console.Write("num2: ");
    string num2Str = Console.ReadLine();
    int num2 = int.Parse(num2Str);

    Console.Write("num3: ");
    string num3Str = Console.ReadLine();
    int num3 = int.Parse(num3Str);

    if ((num1 < num2) && (num1 < num3) && (num2 < num3)) {
        Console.WriteLine("Estão em ordem crescente");
    } else {
        Console.WriteLine("Não estão em ordem crescente");
    }

}


void ex5() {
    Console.Write("num1: ");
    string num1Str = Console.ReadLine();
    int num1 = int.Parse(num1Str);

    if (num1 % 2 == 0) {
        Console.WriteLine($"o número {num1} é par");
    } else {
        Console.WriteLine($"o número {num1} é ímpar");
    }

}


void ex6() {
    Console.Write("num1: ");
    string num1Str = Console.ReadLine();
    int num1 = int.Parse(num1Str);

    if ((num1 % 5 == 0) && (num1 % 10 == 0)) {
        Console.WriteLine($"o número {num1} é multiplo de 5 e 10");
    } else {
        Console.WriteLine($"o número {num1} não é multiplo de 5 e 10");
    }

}


void ex7() {
    Console.Write("num1: ");
    string num1Str = Console.ReadLine();
    float num1 = float.Parse(num1Str);

    Console.Write("num2: ");
    string num2Str = Console.ReadLine();
    float num2 = float.Parse(num2Str);

    if (num1 + num2 <= 10) {
        Console.WriteLine("Número menor ou igual a 10");
    } else {
        Console.WriteLine("Número maior que 10");
    }

}


void ex8() {
    Console.Write("digite o valor do salario bruto: ");
    string salarioString = Console.ReadLine();
    float salario = float.Parse(salarioString);

    Console.Write("digite o valor da prestação: ");
    string prestacaoString = Console.ReadLine();
    float prestacao = float.Parse(prestacaoString);

    if ((salario > 0) && (prestacao > 0)) {
        if (prestacao <= salario * 0.3) {
            Console.WriteLine("Prestação menor que 30% do salário");
            Console.WriteLine("Emprestimo autorizado!");
        } else {
            Console.WriteLine("Prestação maior que 30% do salário");
            Console.WriteLine("Emprestimo não autorizado!");
        }
    }
}


void ex9() {

    Console.Write(@"Passagens Aéreas

1 - Norte (Ida: R$ 280,00 | Ida e Volta: R$ 400,00)
2 - Nordeste (Ida: R$ 380,00 | Ida e Volta: R$ 628,00)
3 - Centro-Oeste(Ida: R$ 620,00 | Ida e Volta: R$ 1100,00)

-> Escolha o nº da região: ");

    string regiaoString = Console.ReadLine();
    int regiao = int.Parse(regiaoString);

    Console.WriteLine("\n1 - Somente Ida?\n2 - Ida e volta?\n");
    Console.Write("-> Quantidade de passagens: ");
    string idaevoltaString = Console.ReadLine();
    int idaevolta = int.Parse(idaevoltaString);

    Console.WriteLine("\nResumo:\n");

    switch (regiao) {
        case 1: //norte
            if (idaevolta == 1) {   //ida
                Console.WriteLine("Você escolheu a região: NORTE");
                Console.WriteLine("Quantidade de passagens: 1 (Apenas ida)");
                Console.WriteLine(" Total: R$ 280,00");
            } else if (idaevolta == 2) {    //ida e volta
                Console.WriteLine("Você escolheu a região: NORTE");
                Console.WriteLine("Quantidade de passagens: 2 (Ida e volta)");
                Console.WriteLine(" Total: R$ 400,00");
            } else {    //erro
                Console.WriteLine("Erro! Digite um número válido para as passagens!");
            }
            break;

        case 2: //Nordeste
            if (idaevolta == 1) {   //ida
                Console.WriteLine("Você escolheu a região: NORDESTE");
                Console.WriteLine("Quantidade de passagens: 1 (Apenas ida)");
                Console.WriteLine(" Total: R$ 380,00");
            } else if (idaevolta == 2) {    //ida e volta
                Console.WriteLine("Você escolheu a região: NORDESTE");
                Console.WriteLine("Quantidade de passagens: 2 (Ida e volta)");
                Console.WriteLine(" Total: R$ 628,00");
            } else {    //erro
                Console.WriteLine("Erro! Digite um número válido para as passagens!");
            }
            break;

        case 3: //Centro-Oeste
            if (idaevolta == 1) {   //ida
                Console.WriteLine("Você escolheu a região: CENTRO-OESTE");
                Console.WriteLine("Quantidade de passagens: 1 (Apenas ida)");
                Console.WriteLine(" Total: R$ 620,00");
            } else if (idaevolta == 2) {    //ida e volta
                Console.WriteLine("Você escolheu a região: CENTRO-OESTE");
                Console.WriteLine("Quantidade de passagens: 2 (Ida e volta)");
                Console.WriteLine(" Total: R$ 1100,00");
            } else {    //erro
                Console.WriteLine("Erro! Digite um número válido para as passagens!");
            }
            break;

        default:
            Console.WriteLine("Erro! Digite um número válido para a região (1 a 3).");
            break;

    }
}


void ex10() {
    Console.Write("Digite o número da conta bancária: ");
    string contaBancariaString = Console.ReadLine();

    if (contaBancariaString.Length == 3) {
        int etapa1 = int.Parse(contaBancariaString) + int.Parse(contaBancariaString.Reverse().ToArray());
        
        string etapa1Vetor = etapa1.ToString();
        int etapa2 = 0;

        for (int n = 0; n < 3; n++) {
            etapa2 += int.Parse(etapa1Vetor[n].ToString()) * (n + 1);
        }
        
        string etapa3 = etapa2.ToString();
        char digitoVerificador = etapa3[etapa3.Length - 1];
        Console.WriteLine($"O digito verificador da conta {contaBancariaString} é: {digitoVerificador}");

    } else {
        Console.WriteLine("Erro! Digite uma conta bancária válida (3 digitos).");
    }

}


void ex11() {
    //Considerando as variáveis numero_1 = 15 e numero_2 = 6:
    //a)A variável resultado terá conteudo igual ao número inteiro 20
    //b)Após os 2 textos solicitando a entrada de um número, será exibida a mensagem "Resultado maior que zero e menor ou igual a 20"
    
    //c)

    int numero_1, numero_2, resultado;

    Console.Write("Digite um número inteiro: ");
    string numero1string = Console.ReadLine();
    numero_1 = int.Parse(numero1string);

    Console.Write("Digite um número inteiro: ");
    string numero2string = Console.ReadLine();
    numero_2 = int.Parse(numero2string);

    resultado = ((numero_1 % 2) * 3) + (13 - 2 + numero_2);
    
    if (resultado <= 0) {
        Console.WriteLine("Resultado menor ou igual a zero");
    }else if ((resultado > 0) && (resultado <= 20)) {
        Console.WriteLine("Resultado maior que zero e menor ou igual a 20");
    } else {
        Console.WriteLine("Resultado maior que 20");
    }
}


ex11();