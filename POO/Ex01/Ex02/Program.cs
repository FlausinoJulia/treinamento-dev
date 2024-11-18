using Ex01.Classes;
using Ex02.Classes;
using System.Globalization;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

            Produto notebook = new Produto("Notebook", 3000, 10);
            Comida comida = new Comida("Notebook", 3000, 10);

            Console.WriteLine($"Produto: {notebook.Nome}");
            Console.WriteLine($"Preço: {notebook.Preco:C}");
            Console.WriteLine($"Quantidade em estoque: {notebook.Quantidade}");
            Console.WriteLine($"Valor total em estoque: {notebook.CalcularValorTotalEstoque():C}");

            notebook.AdicionarQuantidadeEstoque(5);
            Console.WriteLine($"Nova quantidade em estoque: {notebook.Quantidade}");

            notebook.RemoverQuantidadeEstoque(3);
            Console.WriteLine($"Quantidade após remoção: {notebook.Quantidade}");

            try
            {
                notebook.RemoverQuantidadeEstoque(20);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro produto[{notebook.Nome}]: {e.Message}");
            }
        }
    }
}
