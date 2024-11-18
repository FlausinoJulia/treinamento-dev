namespace Ex04
{
    public class Caixa<T>
    {
        private T _Item;

        public void Adicionar(T item)
        {
            _Item = item;
        }

        public T Obter()
        {
            return _Item;
        }
    }   
}
