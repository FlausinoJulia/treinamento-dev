using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    public static class Exercicio02
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double pesoIdeal = (72.7 * altura) - 58;
            Console.WriteLine($"O peso ideal é igual a {pesoIdeal:F2} kg");
        }
    }
}
