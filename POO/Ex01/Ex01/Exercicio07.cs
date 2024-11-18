using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    public static class Exercicio07
    {
        /*
         A série de Fibonacci é formada pela seqüência 1,1,2,3,5,8,13,21,34,55,... Faça um programa capaz de gerar a série até o n−ésimo termo.
         */
        public static void Executar()
        {
            Console.Write("Quantos termos da sequência de Fibonacci você deseja? ");
            int quantidadeDeTermos = Convert.ToInt32(Console.ReadLine()); // validar se foi digitado um número inteiro

            /*
            Console.WriteLine(1);
            Console.WriteLine(1);

            int termoAnterior = 1;
            int termoAnteriorAoAnterior = 1;
            int termoAtual;
            for (int i = 3; i <= quantidadeDeTermos; i++)
            {
                termoAtual = termoAnterior + termoAnteriorAoAnterior;
                Console.WriteLine(termoAtual);

                termoAnteriorAoAnterior = termoAnterior;
                termoAnterior = termoAtual;
            }*/

            BigInteger termoAnterior = 0;
            BigInteger termoAnteriorAoAnterior = 0;
            BigInteger termoAtual = 1;
            for (int i = 1; i <= quantidadeDeTermos; i++)
            {
                Console.WriteLine(termoAtual);
                
                termoAnteriorAoAnterior = termoAnterior;
                termoAnterior = termoAtual;

                termoAtual = termoAnterior + termoAnteriorAoAnterior;
            }

        }

    }
}
