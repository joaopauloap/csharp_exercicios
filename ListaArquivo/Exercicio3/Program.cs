var arquivo = new StreamReader("../../../arquivo.txt");
string[] linha = arquivo.ReadToEnd().Split('\n');
List<float> lista = Array.ConvertAll(linha,s => float.Parse(s)).ToList();
Console.WriteLine($"O maior valor é {lista.Max()} e está na linha {lista.IndexOf(lista.Max())+1}");
arquivo.Close();