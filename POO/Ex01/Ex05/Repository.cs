namespace Ex05
{
    internal class Repository<T> where T : class
    {
        public void Salvar (T item)
        {
            Console.WriteLine($"Salvando {item}...");
        }
    }
}