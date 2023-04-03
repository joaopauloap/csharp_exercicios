Console.Write("Informe a quantidade de linhas: ");
int linhas=int.Parse(Console.ReadLine());

Console.Write("Informe a quantidade de colunas: ");
int colunas = int.Parse(Console.ReadLine());

var arquivo = new StreamWriter("../../../arquivo.txt");
Random randNum = new Random();

for (int i = 0; i < linhas; i++)
{
    for(int j = 0; j < colunas; j++)
    {
        int numeroAleatorio = randNum.Next(0, 1000);
        arquivo.Write(numeroAleatorio.ToString()+'\t');

    }
    arquivo.WriteLine();
}

arquivo.Close();