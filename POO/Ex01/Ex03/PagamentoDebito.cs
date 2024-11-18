using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    public class PagamentoDebito : IPagamento
    {
        public void EstornarPagamento(decimal valor)
        {
            Console.WriteLine("Pagamento de R${valor:F2}  estornado em Débito");
        }

        public string ObterDetalhesTransacao()
        {
            return "Detalhes da transação em débito.";
        }

        public void ProcessarPagamento(decimal valor)
        {
            Console.WriteLine($"Pagamento de R${valor} processado com Débito.");
        }
    }
}
