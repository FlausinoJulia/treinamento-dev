using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    public class PagamentoCredito : IPagamento
    {
        public void EstornarPagamento(decimal valor)
        {
            Console.WriteLine($"Pagamento de R${valor:F2} estornado em Crédito.");
        }

        public string ObterDetalhesTransacao()
        {
            return "Detalhes da transação em crédito.";
        }

        public void ProcessarPagamento(decimal valor)
        {
            Console.WriteLine($"Pagamento de R${valor} processado com Crédito.");
        }
    }
}
