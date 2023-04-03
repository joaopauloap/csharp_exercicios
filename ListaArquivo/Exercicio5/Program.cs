var arquivo = new StreamReader("../../../arquivo.txt");
List<string> listaRegistros = arquivo.ReadToEnd().Split('\n').ToList();
int qtdRegistros = int.Parse(listaRegistros[0]);
listaRegistros.RemoveAt(0);

List<int> listaCampo2 = new List<int>();

for(int i = 0; i < qtdRegistros; i++)
{
    string[] parametros = listaRegistros[i].Split(',');
    listaCampo2.Add(int.Parse(parametros[1]));
}

Console.WriteLine($"Somatória do campo 2: {listaCampo2.Sum()}");

arquivo.Close();