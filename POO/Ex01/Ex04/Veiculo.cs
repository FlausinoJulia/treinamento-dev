namespace Ex04
{
    public abstract class Veiculo
    {
        public abstract string Marca { get; set; }
        public abstract int Ano { get; set; }

        public abstract void Ligar();
        public abstract void Mover();
    }
}
