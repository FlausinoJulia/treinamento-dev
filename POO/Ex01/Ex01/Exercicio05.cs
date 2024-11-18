using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    public static class Exercicio05
    {
        private static List<char> respostas = new List<char>();

        public static void Executar ()
        {
            Console.WriteLine("Você está sendo investigado. Responda as perguntas a seguir digitando S para sim ou N para não.");

            ArmazenaReposta("Telefonou para a vítima? (S ou N) ");
            ArmazenaReposta("Esteve no local do crime? (S ou N) ");
            ArmazenaReposta("Mora perto da vítima? (S ou N) ");
            ArmazenaReposta("Devia para a vítima? (S ou N) ");
            ArmazenaReposta("Já trabalhou com a vítima? (S ou N) ");

            int respostasPositivas = 0;
            foreach (char resposta in respostas) 
            {
                if (resposta == 'S') respostasPositivas++;
            }

            if (respostasPositivas == 0) Console.WriteLine("Você é inocente!");
            else if (respostasPositivas == 5) Console.WriteLine("Você é o assassino!");
            else if (respostasPositivas == 2) Console.WriteLine("Você é suspeito!");
            else Console.WriteLine("Você é cúmplice!");
        }

        public static void ExecutarSolucaoThaylor()
        {
            int respostasPositivas = 0;

            string[] perguntas = {
                "Telefonou para a vítima? ",
                "Esteve no local do crime? ",
                "Mora perto da vítima? ",
                "Devia para a vítima? ",
                "Já trabalhou com a vítima? "
            };

            foreach (var pergunta in perguntas)
            {
                Console.WriteLine(pergunta + "(s ou n)");
                char resposta = char.ToLower(Console.ReadKey().KeyChar);

                if (resposta == 's')
                {
                    respostasPositivas++;
                }
            }

            string classificacao;

            if (respostasPositivas == 0) classificacao = "inocente";
            else if (respostasPositivas == 5) classificacao = "assassino";
            else if (respostasPositivas == 2) classificacao = "suspeito!";
            else classificacao = "cúmplice!";

            Console.WriteLine($"Você é {classificacao}!");
        }

        public static void ArmazenaReposta(string pergunta)
        {
            string resposta = "";
            do
            {
                Console.Write(pergunta);
                resposta = Console.ReadLine();

            } while (resposta != "S" && resposta != "N");
            respostas.Add(Convert.ToChar(resposta));
        }
    }
}
