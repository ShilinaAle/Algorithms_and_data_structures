using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_and_data_structures
{
    class Collection<T> 
    {
        List<T> list = new List<T>();

        public void PrintList()
        {
            foreach (var i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        public static void StartCollections()
        {
            Console.WriteLine("----------List----------"); 
            Console.WriteLine();
            Collection<int> collectionList = new Collection<int>();
            collectionList.list = new List<int>() { 1, 2, 3 };
            collectionList.PrintList();
            collectionList.list.Add(4);
            Console.WriteLine("list.Add(4), list[3]: ");
            Console.WriteLine(collectionList.list[3]);
            Console.WriteLine("change list[3]: ");
            collectionList.list[3] = 88;
            collectionList.PrintList();
            Console.WriteLine("list.Count: ");
            Console.WriteLine(collectionList.list.Count);
            Console.WriteLine("InsertRange 1 ");
            collectionList.list.InsertRange(1, new int[] { 5, 5, 5});
            collectionList.PrintList();
            Console.WriteLine($"Search 2: {collectionList.list.BinarySearch(2)}");
            Console.WriteLine("RemoveAll 5");
            collectionList.list.RemoveAll(i => i == 5);
            collectionList.PrintList();
            collectionList.list.Contains(2);
            var newList = collectionList.list.GetRange(1, 2);
            foreach (var i in newList)
                Console.Write($"{i} ");
            Console.WriteLine();
            int[] arr = new int[4];
            collectionList.list.CopyTo(0, arr, 1, 3);
            foreach (var i in arr)
                Console.Write($"{i} ");
            Console.WriteLine();

            Console.WriteLine();
        }
    }
}
