using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add("F");
            arrayList1.Add("H");

            Console.WriteLine("Count: " + arrayList1.Count);
            Console.WriteLine("Capacity: " + arrayList1.Capacity);


            ArrayList arrayList = new ArrayList();

            arrayList.Add(45);
            arrayList.Add("Hikmet");
            arrayList.Add('A');

            arrayList.AddRange(arrayList1);

            arrayList.RemoveAt(1);
            Console.WriteLine("FirstElement: "+arrayList[0]);
            Console.WriteLine("Count: "+arrayList.Count);
            Console.WriteLine("Capacity: "+arrayList.Capacity);


            Console.WriteLine("\n =========== ArrayList elements ===============\n");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //=======================
            //Sorted List
            Console.WriteLine("\n============= Sorted List ====================\n");
            #region SortedList
            SortedList sortedList = new SortedList();

            sortedList.Add("B", "Tofiq");
            sortedList.Add("A", "Hikmet");


            Console.WriteLine("First element: "+sortedList["A"]);

            //foreach (KeyValuePair<string,string> item in sortedList)
            //{
            //}

            #endregion


            #region Queue and Stack
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("Abbass");
            queue.Enqueue('V');

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());


            Stack stack = new Stack();
            stack.Push(4);
            stack.Push('a');
            stack.Push("Abdulla");

            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());


            #endregion

            #region Generic Queue and stack

            Queue<string> genQueue = new Queue<string>();
            genQueue.Enqueue("fdf");

            Stack<int> genStack = new Stack<int>();
            genStack.Push(45);

            #endregion

            #region List

            List<string> names = new List<string>();
            names.Add("Ad1");
            names.Add("Ad2");
            names.Add("Ad3");
            names.Add("Ad4");

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(names[2]);
            names[1] = "fdfd";

            #endregion

            #region Gen. SortedList

            SortedList<string, string> phones = new SortedList<string, string>();
            phones.Add("Hikmet", "4111111");
            phones.Add("Tofiq", "1234343");
            phones.Add("Nermin", "3254344");
            phones.Add("Abbas", "12345");



            Console.WriteLine("Phones");
            foreach (var item in phones)
            {
                Console.WriteLine(item.Key+" - "+item.Value);
            }


            #endregion

            #region Dictionary
            Dictionary<string, string> contacts = new Dictionary<string, string>();

            contacts.Add("Hikmet", "12345");
            contacts.Add("Abbas", "535665");
            Console.WriteLine("\nContacts\n");

            Console.WriteLine(contacts.TryAdd("Hikmet1", "3454354"));



            foreach (var item in contacts)
            {
                Console.WriteLine(item.Key+" - "+item.Value);
            }

            Console.WriteLine("Kimin nomresini axtarirsiniz?");
            string name = Console.ReadLine();

            //while (!contacts.ContainsKey(name))
            //{
            //    Console.WriteLine("Axtardiginiz kontakt melumati tapilmadi, yeniden daxil edin:");
            //    name = Console.ReadLine();
            //}


            string phone;
            while (!contacts.TryGetValue(name,out phone))
            {
                Console.WriteLine("Axtardiginiz kontakt melumati tapilmadi, yeniden daxil edin:");
                name = Console.ReadLine();
            }




            Console.WriteLine(name+": "+phone);

            #endregion
        }
    }
}
