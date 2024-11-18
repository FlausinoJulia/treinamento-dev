using Ex01.Services;
using Ex01;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPagamento pagamentoCredito = new PagamentoCredito();
            IPagamento pagamentoDebito = new PagamentoDebito();

            ProcessadorPagamentosService processadorPagamentosService = new ProcessadorPagamentosService();

            processadorPagamentosService.EfetuarPagamento(pagamentoCredito, 50);
            processadorPagamentosService.EfetuarPagamento(pagamentoDebito, 30);

            List<int> numeros = new List<int>();
            IList<int> numeross = new List<int>();
        }
    }
}
