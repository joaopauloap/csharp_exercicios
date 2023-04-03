/*
 * Crie uma classe chamada Lampada
1. Crie as propriedades Cor do tipo String e Ligada do tipo boolean
2. Crie um construtor sem parâmetro.
3. Crie um construtor que receba 2 parâmetros: a cor e o estado da lâmpada (true ou false) e atribua
as respectivas propriedades.
4. Crie um construtor que receba apenas um parâmetro: a cor da lâmpada. Neste caso, atribua a cor a
respectiva propriedade e por padrão, atribua a propriedade Ligada o valor true.
5. No arquivo Program.cs, instancie 3 lâmpadas.
a. A primeira deverá ser instanciada através do construtor sem parâmetro
b. A segunda, através do construtor com um parâmetro
c. A terceira, através do construtor com dois parâmetros
6. Imprima as cores e o estados das lâmpadas instanciadas
*/
using Exercicio7;

var lampada1 = new Lampada();
lampada1.Cor = "Branca";
lampada1.Ligada = false;

var lampada2 = new Lampada("Amarela");
var lampada3 = new Lampada("Azul", true);

Console.WriteLine($"Lampada1\n   Cor: {lampada1.Cor}");
Console.WriteLine($"   Ligada: {lampada1.Ligada}");

Console.WriteLine($"\nLampada2\n   Cor: {lampada2.Cor}");
Console.WriteLine($"   Ligada: {lampada2.Ligada}");

Console.WriteLine($"\nLampada3\n   Cor: {lampada3.Cor}");
Console.WriteLine($"   Ligada: {lampada3.Ligada}");