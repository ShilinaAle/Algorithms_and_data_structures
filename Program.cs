using System;

namespace Algorithms_and_data_structures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Print();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Print();

            Console.WriteLine($"Remove:");
            list.Remove();
            list.Print();

            Console.WriteLine($"AddAfter(3, 88)");
            list.AddAfter(3, 88);
            list.Print();

            //Edge cases
            list.AddAfter(0, 11);
            list.Print();
            list.AddAfter(-5, 22);
            list.Print();
            list.AddAfter(9, 33);
            list.Print();
            list.AddAfter(90, 44);
            list.Print();

            Console.WriteLine($"index of 2 = {list.IndexOf(2)}");
            Console.WriteLine($"RemoveByIndex(2)");
            list.RemoveByIndex(2);
            list.Print();
            //Edge cases
            list.RemoveByIndex(0);
            list.Print();
            list.RemoveByIndex(9);
            list.Print();
            list.RemoveByIndex(-33);
            list.Print();
            list.RemoveByIndex(33);
            list.Print();

            Console.ReadKey();
        }
    }
}
