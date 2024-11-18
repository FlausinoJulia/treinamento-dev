using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    public class Carro : Veiculo
    {
        public override string Marca { get; set; }
        public override int Ano { get; set; }
        public override void Ligar()
        {
            Console.WriteLine("O carro está ligado");
        }
        public override void Mover()
        {
            Console.WriteLine("O carro está se movendo.");
        }
    }
}
