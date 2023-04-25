using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMyList
{
    class MyList<T>
    {
        private List<T> items = new List<T>();

        public void Add(T element)
        {
            items.Add(element);
        }

        public T Remove(int index)
        {
            if (index < 0 || index >= items.Count)
            {
                throw new IndexOutOfRangeException("Index Null Exception");
            }

            T element = items[index];
            items.RemoveAt(index);
            return element;
        }

        public bool Contains(T element)
        {
            return items.Contains(element);
        }

        public void Clear()
        {
            items.Clear();
        }

        public void InsertAt(T element, int index)
        {
            if (index < 0 || index > items.Count)
            {
                throw new IndexOutOfRangeException("Index Null Exception");
            }

            items.Insert(index, element);
        }

        public void DeleteAt(int index)
        {
            if (index < 0 || index >= items.Count)
            {
                throw new IndexOutOfRangeException("Index Null Exception");
            }

            items.RemoveAt(index);
        }

        public T Find(int index)
        {
            if (index < 0 || index >= items.Count)
            {
                throw new IndexOutOfRangeException("Index Null Exception");
            }

            return items[index];
        }
    }
}
