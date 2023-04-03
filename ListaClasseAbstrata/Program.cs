using ListaClasseAbstrata;

Console.WriteLine("Qual forma deseja calcular a área?");
Console.WriteLine("1) Quadrado\n2) Triângulo\n3) Circulo\n");
Console.Write(">");
int formaEscolhida = int.Parse(Console.ReadLine());

switch (formaEscolhida)
{
    case 1://quadrado
        Console.Write("Informe a medida do lado: ");
        double lado = double.Parse(Console.ReadLine());
        var quadrado = new Quadrado(lado);
        Console.WriteLine("A área do Quadrado é: " + quadrado.CalcularArea());
        break;
    case 2://triangulo
        Console.Write("Informe a medida da base: ");
        double basee = double.Parse(Console.ReadLine());
        Console.Write("Informe a medida da altura: ");
        double altura = double.Parse(Console.ReadLine());
        var triangulo = new Triangulo(basee,altura);
        Console.WriteLine("A área do Triângulo é: " + triangulo.CalcularArea());
        break;
    case 3://circulo
        Console.Write("Informe a medida do raio: ");
        double raio = double.Parse(Console.ReadLine());
        var circulo = new Circulo(raio);
        Console.WriteLine("A área do Circulo é: " + circulo.CalcularArea());
        break;
    default:
        break;
}