using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    public class MyList<T> where T : IComparable
    {

        private int _capacity;
        private int _top;
        private T[] _array;
        public MyList(int capacity = 4)
        {
            _capacity = capacity;
            _array = new T[capacity];
            _top = -1;
        }

        public int Size { get => _top + 1; }
        public int Capacity { get => _capacity; }

        public void Add(T value)
        {
            if (Size < _capacity)
            {
                _array[++_top] = value;
            }
            else
            {
                T[] temp = new T[_capacity * 2];
                for (int i = 0; i < _capacity; i++)
                {
                    temp[i] = _array[i];
                }
                temp[++_top] = value;
                _capacity *= 2;
                _array = temp;

            }
        }

        public T Get(int index)
        {
            if (index < 0 || index > _top)
            {
                throw new IndexOutOfRangeException();
            }
            return _array[index];
        }
        public void Set(int index, T value)
        {
            if (index < 0 || index > _top)
            {
                throw new IndexOutOfRangeException();
            }
            _array[index] = value;
        }

        public T this[int index]
        {
            get => Get(index);
            set => Set(index, value);
        }



        public bool Remove(T item)
        {
            int index = Index(item);
            if (index == -1) return false;
            for (int i = index; i < _top; i++)
            {
                Swap(ref _array[i], ref _array[i + 1]);
            }
            _top--;
            Console.WriteLine($"Removed {item}");
            return true;
        }
        private void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        public int Index(T item)
        {
            for (int i = 0; i < Size; i++)
            {
                if (_array[i].CompareTo(item) == 0)
                {
                    return i;
                }

            }
            return -1;
        }



        public MyList<T> Fliter(Predicate<T> where)
        {
            MyList<T> result = new MyList<T>();
            for (int i = 0; i < Size; i++)
            {
                if (where(_array[i]))
                {
                    result.Add(_array[i]);
                }
            }
            return result;
        }
    }
}
