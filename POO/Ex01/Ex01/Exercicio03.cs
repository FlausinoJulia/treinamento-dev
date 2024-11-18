using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    public static class Exercicio03
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            string resposta = "";
            do 
            {
                Console.Write("Calcular peso ideal para homem ou mulher? (digite H ou M): ");
                resposta = Console.ReadLine();

                if (resposta != "M" && resposta != "H")
                {
                    Console.WriteLine("Digite apenas H ou M!");
                }
            } while (resposta != "M" && resposta != "H");

            char sexo = Convert.ToChar(resposta);

            double pesoIdeal;
            if (sexo == 'M')
            {
                pesoIdeal = (62.1 * altura) - 44.7;
            }
            else
            {
                pesoIdeal = (72.7 * altura) - 58;
            }

            Console.WriteLine($"O peso ideal calculado para essa pessoa é de {pesoIdeal:F2}");
        }
    }
}
