var arquivo = new StreamWriter("../../../arquivo.txt");

for (int c = 65; c <= 90; c++)
{
        arquivo.WriteLine((char)c);   
}

arquivo.Close();