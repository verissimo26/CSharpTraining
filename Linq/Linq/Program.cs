using Linq.entities;

static void Print <T> (string message, IEnumerable<T>collection)
{
    Console.WriteLine (message);
    foreach (T obj in collection)
    {
        Console.WriteLine(obj);
    }
}   


Category c1 = new Category() { ID = 1, Name = "Tools ", Tier = 2 };
Category c2 = new Category() { ID = 2, Name = "Computers ", Tier = 1 };
Category c3 = new Category() { ID = 3, Name = "Eletronics ", Tier = 3 };

List<Produtct> produtcts = new List<Produtct>()

{
    new Produtct () {Id = 1, Name ="Computer", Price = 1200, Category = c2},
    new Produtct () {Id = 1, Name ="Chave", Price = 800, Category = c1},
    new Produtct () {Id = 1, Name ="Notebook", Price = 2900, Category = c2},
    new Produtct () {Id = 1, Name ="Pincel", Price = 70, Category = c1},
    new Produtct () {Id = 1, Name ="Chaveiro", Price = 300, Category = c1},
    new Produtct () {Id = 1, Name ="Mouse", Price = 110, Category = c2},
    new Produtct () {Id = 1, Name ="Caneta", Price = 110, Category = c1},
    new Produtct () {Id = 1, Name ="Azul", Price = 110, Category = c3},
    new Produtct () {Id = 1, Name ="Tapete", Price = 80, Category = c2},
    new Produtct () {Id = 1, Name ="Rato", Price = 600, Category = c1},
    new Produtct () {Id = 1, Name ="Impressora", Price = 2500, Category = c2},
    new Produtct () {Id = 1, Name ="Mouse2", Price = 20, Category = c1},
    new Produtct () {Id = 1, Name ="CS", Price = 100, Category = c1},
    new Produtct () {Id = 1, Name ="teclado", Price = 50, Category = c3},
    new Produtct () {Id = 1, Name ="SoundBar", Price = 90, Category = c1},
};

Console.WriteLine("TIER 1 PRICE < 900");

var r1 = produtcts.Where(p => p.Category.Tier == 1 && p.Price < 2000);
Print("Produtos menor que 900", r1);

var r2 = produtcts.Where(p => p.Category.Name == "Tools").Select (p => p.Name);
Print("Names Tols", r2);
