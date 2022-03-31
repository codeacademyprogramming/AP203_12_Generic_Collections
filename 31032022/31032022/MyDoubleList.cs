using System;
using System.Collections.Generic;
using System.Text;

namespace _31032022
{
    internal class MyDoubleList
    {
        double[] _arr = new double[0];

        public double[] Arr { get => _arr; }
        public void Add(double val)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = val;
        }
    }
}
