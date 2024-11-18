using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.Classes
{
    public class Eletronico : Produto
    {
        public Eletronico(string nome, decimal preco, int quantidade) : base(nome, preco, quantidade)
        {

        }

        public void ExibirPeso()
        {
            Console.WriteLine(Peso);
        }
    }
}
