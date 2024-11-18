namespace Ex01.Services
{
    public class ProcessadorPagamentosService
    {
        public void EfetuarPagamento(IPagamento pagamento, decimal valor)
        {
            if (valor <= 0)
            {
                throw new Exception("Valor inválido para pagamento");
            }
            pagamento.ProcessarPagamento(valor);
            Console.WriteLine(pagamento.ObterDetalhesTransacao());
        }

    }
}
