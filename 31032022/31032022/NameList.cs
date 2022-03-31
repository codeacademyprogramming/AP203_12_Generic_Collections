using System;
using System.Collections.Generic;
using System.Text;

namespace _31032022
{
    internal class NameList
    {
        string[] _names = new string[0];

        public string[] Names { get => _names; }

        public void Add(string str)
        {
            if(!string.IsNullOrWhiteSpace(str) && str.Length>2 && char.IsUpper(str[0]))
            {
                Array.Resize(ref _names, _names.Length + 1);
                _names[_names.Length - 1] = str;
            }
        }


    }
}
