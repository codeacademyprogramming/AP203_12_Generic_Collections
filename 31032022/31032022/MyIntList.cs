using System;
using System.Collections.Generic;
using System.Text;

namespace _31032022
{
    internal class MyIntList
    {
        int[] _arr = new int[0];

        public int[] Arr { get => _arr; }
        public void Add(int val)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = val;
        }
    }
}
