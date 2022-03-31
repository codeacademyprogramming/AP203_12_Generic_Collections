using System;
using System.Collections.Generic;
using System.Text;

namespace _31032022
{
    internal class MyList<T,K> 
    {
        T[] _arr = new T[0];

        public T[] Arr { get => _arr; }

        public T this[int index]
        {
            get {
                if (_arr.Length - 1 >= index)
                    return _arr[index];
                else
                {
                    throw new IndexOutOfRangeException("Bele bir index yoxdur!");
                }
            }
            set
            {
                if(_arr.Length - 1 >= index)
                    _arr[index] = value;  
                else
                    throw new IndexOutOfRangeException("Bele bir index yoxdur!");
            }
        }

        public void Add(T val)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = val;    
        }
        public K Test { get; set; }

    }
}
