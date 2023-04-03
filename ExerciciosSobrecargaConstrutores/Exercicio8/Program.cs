/*
 * Crie uma classe chamada Ponto, que armazene as coordenadas (x,y) de um ponto num plano. A coordenada
default(padrão) para qualquer ponto deve ser (0.0 , 0.0).
a) Além do construtor sem parâmetro, esta classe deve conter um construtor que receba como
parâmetros os valores de x e y.
b) Crie um método para calcular a distância de 2 pontos (x1,y1) e (x2,y2). Este método receberá
como parâmetro um objeto da classe Ponto e retornará a distância entre os pontos.
c) Crie uma classe de Teste e calcule a distância de 2 pontos e exiba o resultado na tela.
d) Use o construtor sem parâmetro para instanciar o primeiro ponto e o construtor com parâmetros
para instanciar o segundo ponto.

Nota: Para calcular a distância de 2 pontos utilize a fórmula:
dx = x2 - x1; dy = y2 - y1; distancia = Math.Sqrt(dx*dx + dy*dy);
*/

using Exercicio8;

var ponto1 = new Ponto();
ponto1.X = -2;
ponto1.Y = 4;
var ponto2 = new Ponto(2, 2);

Console.WriteLine(ponto1.CalcularDistancia(ponto2));
