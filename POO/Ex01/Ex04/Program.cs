namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Imprimir<string>("Thaylor");
            Imprimir<int>(10);

            List<int> list = new List<int>();
        }

        public static void Imprimir<T>(T item)
        {
            Console.WriteLine(item);
        }
    }
}
