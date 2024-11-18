using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{

    // Faça um programa que imprima na tela apenas os números ímpares entre 1 e 50.
    public static class Exercicio06
    {
        public static void Executar ()
        {
            Console.WriteLine("Números ímpares entre 1 e 50:");
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }
        }
    }
}
