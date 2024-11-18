using System.Globalization;
using Ex01.Classes;
using Ex01.Services;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

            Produto notebook = new Produto("Notebook", 3000, 10);


            Console.WriteLine($"Produto: {notebook.Nome}");
            Console.WriteLine($"Preço: {notebook.Preco:C}");
            Console.WriteLine($"Quantidade em estoque: {notebook.Quantidade}");
            Console.WriteLine($"Valor total eme stoque: {notebook.CalcularValorTotalEstoque():C}");

            notebook.AdicionarQuantidadeEstoque(5);
            Console.WriteLine($"Quantidade em estoque: {notebook.Quantidade}");

            notebook.RemoverQuantidadeEstoque(3);
            Console.WriteLine($"Quantidade em estoque: {notebook.Quantidade}");

            try
            {
                notebook.RemoverQuantidadeEstoque(20);
            }
            catch(Exception e)
            {
                Console.WriteLine($"Erro produto [{notebook.Nome}]: {e.Message}");
            }
            */


            /*EX03*/
            IPagamento pagamentoCredito = new PagamentoCredito();
            IPagamento pagamentoDebito = new PagamentoDebito();

            ProcessadorPagamentosService processadorPagamentosService = new ProcessadorPagamentosService();
        }
    }
}
