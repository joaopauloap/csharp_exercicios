var arquivoLeitura = new StreamReader("../../../arquivoLeitura.txt");
string[] linhas = arquivoLeitura.ReadToEnd().Split('\n');
arquivoLeitura.Close();

var arquivoEscrita = new StreamWriter("../../../arquivoEscrita.txt");

foreach(string linha in linhas)
{
    string[] parametros = linha.Split(',');

    int parametro1 = int.Parse(parametros[0]);
    int parametro2 = int.Parse(parametros[1]);
    
    int somaParametros = parametro1 + parametro2;
    
    arquivoEscrita.WriteLine($"{parametro1},{parametro2},{somaParametros}");
}


arquivoEscrita.Close();