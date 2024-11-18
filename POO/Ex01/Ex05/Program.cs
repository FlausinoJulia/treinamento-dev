using Ex01.Classes;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha<string> nomes = new Pilha<string>();

            nomes.Push("Thaylor");
            nomes.Push("Julia");
            nomes.Push("Vinicius");
            nomes.Push("Malu");

            Console.WriteLine(nomes.Top());

            Carro carro = new("Ford", "Cor");
            Repository<Carro> repositoryCarro = new();
            repositoryCarro.Salvar(carro);

            Produto produto = new("Roupa", 10, 2);
            Repository<Produto> repositoryProduto = new();
            repositoryProduto.Salvar(produto);
        }
    }
}
