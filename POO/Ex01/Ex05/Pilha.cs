using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    public class Pilha<T>
    {
        private List<T> _Items {  get; set; }
        public Pilha()
        {
            _Items = new List<T>();
        }

        public void Push(T item)
        {
             _Items.Add(item);
        }

         public T Pop()
         {
            if (_Items.Count() == 0)
                throw new Exception("A pilha está vazia");

            T item = _Items[_Items.Count - 1];
            _Items.RemoveAt(_Items.Count - 1);
            return item;
         }

        public T Top()
        {
            if (_Items.Count() == 0)
                throw new Exception("A pilha está vazia");

            return _Items[_Items.Count - 1];
        }
    }
}
