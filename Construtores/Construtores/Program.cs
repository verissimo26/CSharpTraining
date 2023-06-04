using ProductsEstoc;


Produto p = new Produto();

Console.WriteLine("Digite os dados do produto");
Console.WriteLine("nome: ");
p.Nome = Console.ReadLine();

Console.WriteLine("Preço");
p.Preco = double.Parse(Console.ReadLine());

Console.WriteLine("Quantidade");
p.Quatidade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados Informados" + p);


Console.WriteLine("Adicionar produtos");
int qtd = int.Parse(Console.ReadLine());
p.AddProduto(qtd);
Console.WriteLine("Dados Atualizados " + p);

Console.WriteLine("Remover Produtos");
int remover = int.Parse(Console.ReadLine());
p.RemoverProduto(qtd);
Console.WriteLine("Dados Atualizados com remocao " + p);

