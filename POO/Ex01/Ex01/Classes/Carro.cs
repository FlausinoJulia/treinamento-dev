namespace Ex01.Classes
{
    public class Carro
    {
        private string _Marca;
        private string _Cor;

        public Carro(string cor, string marca)
        {
            _Cor = cor;
            _Marca = marca;
            QuantidadeGasolina = 50;
        }

        public string Marca
        {
            get { return _Marca; }
            set { _Marca = value;  }
        }

        public string Cor
        {
            get { return _Cor; }
            set { _Cor = value; }
        }

        public int QuantidadeGasolina { get; private set;  }

        public void Acelerar()
        {
            if (QuantidadeGasolina == 0)
                Console.WriteLine("Não é possível acelerar. Carro sem gasolina!");
            else
            {
                Console.WriteLine("Vrummmmmmmmm");
                QuantidadeGasolina = QuantidadeGasolina - 1;
            }
        }

        private void Abastecer()
        {
            QuantidadeGasolina = 50;
        }

        private void ConsultarGasolina()
        {
            Console.WriteLine($"Gasolina atual: {QuantidadeGasolina}L");
        }
    }
}
