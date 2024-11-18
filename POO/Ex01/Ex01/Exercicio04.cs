namespace Ex01
{
    public static class Exercicio04
    {
        public static void Executar ()
        {
            Console.Write("Digite a primeira nota: ");
            double notaUm = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nDigite a segunda nota: ");
            double notaDois = Convert.ToDouble(Console.ReadLine());

            double media = (notaUm + notaDois) / 2;

            char resultado = ' ';
            if (media >= 9.0 && media <= 10.0)
            {
                resultado = 'A';
            }
            else if (media >= 7.5 && media < 9.0)
            {
                resultado = 'B';
            }
            else if (media >= 6.0 && media < 7.5)
            {
                resultado = 'C';
            }
            else if (media >= 4.0 && media < 6.0)
            {
                resultado = 'D';
            }
            else if (media >= 0.0 && media < 4)
            {
                resultado = 'E';
            }

            Console.WriteLine($"A Média de Aproveitamento Conceito desse aluno é: {resultado}");
        }
    }
}
