using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    public static class Exercicio08
    {
        public static void Executar()
        {
            Console.Write("De qual número você deseja realiza a tabuada? (Informe um número inteiro de 1 a 10) ");
            int numeroDesejado = Convert.ToInt32(Console.ReadLine()); // fazer validações para que seja digitado um número inteiro de 1 a 10

            Console.WriteLine($"Tabuada do {numeroDesejado}:"); 

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numeroDesejado} x {i} = {numeroDesejado * i}");
            }
        }
    }
}
