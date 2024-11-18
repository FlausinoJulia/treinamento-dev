using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    public class PagamentoDinheiro : IPagamento
    {
        public void EstornarPagamento(decimal valor)
        {
            Console.WriteLine($"Pagamento de R${valor:F2} estornado com Dinheiro.");
        }

        public string ObterDetalhesTransacao()
        {
            return $"Detalhes da transação em Dinheiro.";
        }

        public void ProcessarPagamento(decimal valor)
        {
            Console.WriteLine($"Pagamento de R${valor} processado com Dinheiro.");
        }
    }
}
