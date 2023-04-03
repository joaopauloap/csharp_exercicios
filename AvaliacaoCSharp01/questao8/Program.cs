using questao8;

var aluno1 = new Aluno();
aluno1.Nome = "João Paulo";
aluno1.Disciplina = new Disciplina();

List<double> notas = new List<double>();
for (int i = 1; i < 4; i++)
{
    Console.Write($"Informe a nota {i} do aluno {aluno1.Nome}: ");
    notas.Add(double.Parse(Console.ReadLine()));
}

aluno1.AtribuirNotas(notas);
