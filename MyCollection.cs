using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_and_data_structures
{
    class MyCollection
    {
        static List<int> list = new List<int>();
        static LinkedList<string> link = new LinkedList<string>();
        static Queue<int> queue = new Queue<int>(10);
        static Stack<string> stack = new Stack<string>();
        static Dictionary<string, int> dict = new Dictionary<string, int>()
        {
            {"first", 1 },
            {"second", 2 },
            {"third", 3 },
        };

        public static void PrintList()
        {
            foreach (var i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        public static void PrintLink()
        {
            foreach (var i in link)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        public static void PrintQueue()
        {
            IEnumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Write($"{(int)enumerator.Current} ");
            }
            Console.WriteLine();
        }

        public static void PrintStack()
        {
            foreach (var i in stack)
                Console.WriteLine($"{i} ");
            Console.WriteLine();
        }

        public static void PrintDict()
        {
            foreach (var i in dict)
            {
                Console.WriteLine($"{i.Key} = {i.Value}");
            }
            Console.WriteLine();
        }

        public static void StartCollectionsList()
        {
            Console.WriteLine("----------MyCollection.List----------");
            Console.WriteLine();
            list = new List<int>() { 1, 2, 3 };
            PrintList();
            list.Add(4);
            Console.WriteLine("list.Add(4), list[3]: ");
            Console.WriteLine(list[3]);
            Console.WriteLine("change list[3]: ");
            list[3] = 88;
            PrintList();
            Console.WriteLine("list.Count: ");
            Console.WriteLine(list.Count);
            Console.WriteLine("InsertRange 1 ");
            list.InsertRange(1, new int[] { 5, 5, 5 });
            PrintList();
            Console.WriteLine($"Search 2: {list.BinarySearch(2)}");
            Console.WriteLine("RemoveAll 5");
            list.RemoveAll(i => i == 5);
            PrintList();
            list.Contains(2);
            var newList = list.GetRange(1, 2);
            foreach (var i in newList)
                Console.Write($"{i} ");
            Console.WriteLine();
            int[] arr = new int[4];
            list.CopyTo(0, arr, 1, 3);
            foreach (var i in arr)
                Console.Write($"{i} ");
            Console.WriteLine();

        }
        public static void StartCollectionsLinkedList()
        {
            Console.WriteLine("----------MyCollection.LinkedList----------");
            Console.WriteLine();
            link = new LinkedList<string>(new[] { "one", "two", "three" });
            PrintLink();
            Console.WriteLine($"Value of two: {link.First.Next.Value}, " +
                $"prev: {link.First.Next.Previous.Value}, " +
                $"next: {link.First.Next.Next.Value}");
            link.AddFirst("first");
            link.AddLast("last");
            Console.WriteLine("AddFirst and AddLast");
            PrintLink();
            Console.WriteLine("Add in the link");
            link.AddAfter(link.First.Next.Next, "middle");
            PrintLink();
            Console.WriteLine();
        }

        public static void StartCollectionsQueue()
        {
            Console.WriteLine("----------MyCollection.Queue----------");
            Console.WriteLine();
            queue = new Queue<int>(list);
            PrintQueue();
            Console.WriteLine("Add in the end");
            queue.Enqueue(777);
            PrintQueue();
            Console.WriteLine($"queue.Dequeue(): {queue.Dequeue()}");
            PrintQueue();
            Console.WriteLine($"Peek: {queue.Peek()}");
            PrintQueue();
        }

        public static void StartCollectionsStack()
        {
            Console.WriteLine("----------MyCollection.Stack----------");
            Console.WriteLine();
            stack.Push("first");
            stack.Push("second");
            PrintStack();
            Console.WriteLine(stack.Peek());
            Console.WriteLine($"count of elements: {stack.Count}");
            stack.Pop();
            Console.WriteLine($"second in stack after Pop()? - {stack.Contains("second")}");
            var exist = stack.TryPop(out string result);
            Console.WriteLine(result);
        }

        public static void StartCollectionsDictionary()
        {
            Console.WriteLine("----------MyCollection.Dictionary----------");
            Console.WriteLine();
            PrintDict();
            Console.WriteLine(dict["second"]);
            var f = new KeyValuePair<string, int>("four", 4);
            dict.Add(f.Key, f.Value);
            dict["new"] = 777;
            PrintDict();
            Console.WriteLine(dict.ContainsKey("w"));
            dict.Remove("w");
            dict.Remove("w", out int value);
            Console.WriteLine(value);
            dict.Remove("new", out int value2);
            Console.WriteLine($".Remove(new) with out {value2}");
        }
    }
}
