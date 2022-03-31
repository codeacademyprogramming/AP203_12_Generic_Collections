using System;
using System.Collections.Generic;
using System.Text;

namespace _31032022
{
    internal class MyStringList
    {
        string[] _arr = new string[0];

        public string this[int index]
        {
            get
            {
                return _arr[index]; 
            }
            set
            {
                _arr[index] = value;
            }
        }

        public string[] Arr { get => _arr; }

        public void Add(string str)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = str;
        }
    }
}
