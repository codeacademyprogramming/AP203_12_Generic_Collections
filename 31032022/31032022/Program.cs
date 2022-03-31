using System;

namespace _31032022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Hikmet","Tofiq","Abdulla"};

            NameList nameList = new NameList();
            nameList.Add("Hikmet");
            nameList.Add("Tofiq");
            nameList.Add("abdulla");
            nameList.Add("Zulfiye");

            foreach (var item in nameList.Names)
            {
                Console.WriteLine(item);
            }

            //MyStringList stringList = new MyStringList();
            MyList<string,int> stringList = new MyList<string,int>();
            stringList.Add("str1");
            stringList.Add("str2");
            stringList.Add("str3");
            stringList.Add("str4");

            Console.WriteLine("string list\n");
            foreach (var item in stringList.Arr)
            {
                Console.WriteLine(item);
            }
            stringList.Test = 45;


            //MyIntList intList = new MyIntList();
            MyList<int,char> intList = new MyList<int,char>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(13);
            intList.Add(15);

            intList.Test = '5';

            intList[1] = 45;
            Console.WriteLine("item: "+intList[3]);

            Console.WriteLine("\nint list\n");
            foreach (var item in intList.Arr)
            {
                Console.WriteLine(item);
            }


            MyStringList myStringList = new MyStringList();

            myStringList.Add("Str1");
            myStringList.Add("Str2");
            myStringList.Add("Str3");
            myStringList.Add("Str4");


            Console.WriteLine("\n My string list \n");
            foreach (var item in myStringList.Arr)
            {
                Console.WriteLine(item);
            }


        }
    }
}
