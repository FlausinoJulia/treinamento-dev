using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    public static class Exercicio01
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a temperatura em Fahrenheit: ");
            double tempFahrenheit = Convert.ToDouble(Console.ReadLine());

            double tempCelsius = 5 * ((tempFahrenheit - 32) / 9);
            Console.WriteLine($"Temperatura em Celsius: {tempCelsius:F2}");
        }
    }
}
