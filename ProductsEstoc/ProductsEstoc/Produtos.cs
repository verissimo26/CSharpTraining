
namespace ProductsEstoc
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quatidade;

        public double ValorTotalEstoque()
        {
            return Preco * Quatidade;
        }

       public void AddProduto (int quantidade)
        {
            Quatidade = Quatidade + quantidade;
        }

        public void RemoverProduto (int quantidade)
        {
            Quatidade -= quantidade;
        }
        public override string ToString()
        {
            return "Produto: " + Nome 
                + " Preço $: " + Preco.ToString("F2") 
                + " Quantidade: " + Quatidade
                + " Valor em estoque: " + ValorTotalEstoque();
        }

    }
}
