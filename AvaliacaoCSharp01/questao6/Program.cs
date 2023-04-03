using questao6;

List<Produto> listaProdutos = new List<Produto>();

Console.WriteLine("Cadastro de produtos\n");
Console.Write("Quantidade de produtos a serem cadastrados: ");
int quantidadeProdutos = int.Parse(Console.ReadLine());

for (int i = 1; i < quantidadeProdutos + 1; i++)
{
    var novoProduto = new Produto();

    Console.Write($"\nUnidades do produto {i}: ");
    novoProduto.Quantidade = int.Parse(Console.ReadLine());

    Console.Write($"Preço do produto {i}: ");
    novoProduto.Preco = double.Parse(Console.ReadLine());

    Console.Write($"Desconto unitário para o produto {i}: ");
    novoProduto.Desconto = double.Parse(Console.ReadLine());

    //var novoProduto = new Produto(quantidade,preco,desconto);

    listaProdutos.Add(novoProduto);
}

double totalVenda=0;

foreach (var objProduto in listaProdutos)
{
    totalVenda += objProduto.Total();
}

Console.WriteLine($"\nO total da venda foi: R$ {totalVenda.ToString("C")}");