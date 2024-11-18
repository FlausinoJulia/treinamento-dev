using Ex01.Classes;

namespace Ex02.Classes
{
    public class Comida : Produto
    {
        public Comida(string nome, decimal preco, int quantidade) : base(nome, preco, quantidade)
        {
        }

        public void ExibirPeso()
        {
            Console.WriteLine(Peso);
        }
    }
}
