using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    public interface IPagamento
    {
        public void ProcessarPagamento(decimal valor);

        public string ObterDetalhesTransacao();

        public void EstornarPagamento(decimal valor);
    }
}
