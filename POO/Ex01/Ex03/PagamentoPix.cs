using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    public class PagamentoPix : IPagamento
    {
        public void EstornarPagamento(decimal valor)
        {
            Console.WriteLine($"Pagamento de R${valor:F2} estornado com Pix.");
        }

        public string ObterDetalhesTransacao()
        {
            return "Detalhes da transação PIX";
        }

        public void ProcessarPagamento(decimal valor)
        {
            Console.WriteLine($"Pagamento de R${valor} processado com Pix.");
        }
    }
}
