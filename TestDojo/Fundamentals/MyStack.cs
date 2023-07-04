using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDojo.Fundamentals
{
    public class MyStack<T>
    {
        private readonly List<T> _list = new List<T>();
        
        public int Count => _list.Count;
        public void Push(T item) => _list.Add(item);

        public T Pop()
        {
            if (_list.Count == 0) throw new InvalidOperationException("MyStack is empty!");

            var item = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);
            return item;
        }

        public T Peek()
        {
            if (_list.Count == 0) throw new InvalidOperationException();
            return _list[^1];
        }
    }
}
