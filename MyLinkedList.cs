using System;
using System.Collections.Generic;
using System.Collections;

namespace Algorithms_and_data_structures
{
    //основные операции в связном списке включают добавление, удаление и поиск элемента в списке
    class MyLinkedList<T> : IEnumerable<T>
        where T : IEquatable<T>
    {
        public Node<T>? head;

        public MyLinkedList()
        {
            head = null;
        }


        public void Add(T data)
        {
            if (head == null)
            {
                head = new Node<T>(data);
            }
                
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node<T>(data);
            }
        }

        public void AddAfter(int index, T val)
        {
            var element = new Node<T>(val);
            Node<T> cur = head;
            if (index < 0)
            {
                element.Next = head;
                head = element;
                return;
            }
            int ind = 0;
            while (cur.Next != null)
            {
                if (index == ind)
                {
                    element.Next = cur.Next;
                    cur.Next = element;
                    return;
                }
                cur = cur.Next;
                ind += 1;
            }
            cur.Next = element;
        }

        public void Remove()
        {
            if (head == null)
            {
                Console.WriteLine($"Linked list is empty");
                return;
            }
            else
            {
                Node<T> current = head;
                Node<T> prev = null;
                while (current.Next != null)
                {
                    prev = current;
                    current = current.Next;
                }
                prev.Next = null;
            }
        }

        public void Remove(T data)
        {
            if (head == null)
            {
                Console.WriteLine($"Linked list is empty");
                return;
            }
            else if (head.Data.Equals(data))
            {
                head = head.Next;                
            }
            else 
            { 
                Node<T> current = head;
                Node<T> prev = null;
                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        prev.Next = current.Next;
                    }
                    prev = current;
                    current = current.Next;
                }
            }
        }

        public void RemoveByIndex(int index)
        {

            if (index == 0)
            {
                head = head.Next;
                return;
            }

            Node<T> cur = head;
            Node<T> prev = null;
            int ind = -1;
            while (cur != null)
            {
                if (index == ind + 1)
                {
                    prev.Next = cur.Next;
                    return;
                }
                prev = cur;
                cur = cur.Next;
                ind += 1;
            }
            Console.WriteLine($"Index {index} out of range");
        }

        public int IndexOf(T item)
        {
            Node<T> cur = head;
            var ind = 0;
            while (cur != null)
            {
                if (cur.Data.Equals(item))
                    return ind;
                cur = cur.Next;
                ind += 1;
            }
            return -1;
        }

        public void Print()
        {
            if (head == null)
                Console.WriteLine("My Linked list is empty");
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    Console.Write($"{current.Data} ");
                    current = current.Next;
                }
                Console.WriteLine($"{current.Data} ");
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public static void StartMyLinkedList()
        {
            Console.WriteLine("----------LinkedList----------");
            Console.WriteLine();
            MyLinkedList<int> list = new MyLinkedList<int>();
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

            Console.WriteLine($"AddAfter(3, 88) (0, 11) (-5, 22) (9, 33) (90, 44)");
            list.AddAfter(3, 88);
            list.Print();

            list.AddAfter(0, 11);
            list.Print();
            list.AddAfter(-5, 22);
            list.Print();
            list.AddAfter(9, 33);
            list.Print();
            list.AddAfter(90, 44);
            list.Print();

            Console.WriteLine($"Remove()");
            list.Remove();
            list.Print();

            Console.WriteLine($"Remove 22, 8, 11");
            list.Remove(22);
            list.Print();
            list.Remove(8);
            list.Print();
            list.Remove(11);
            list.Print();

            Console.WriteLine($"RemoveByIndex 2 0 9 -33 33");
            list.RemoveByIndex(2);
            list.Print();

            list.RemoveByIndex(0);
            list.Print();
            list.RemoveByIndex(9);
            list.Print();
            list.RemoveByIndex(-33);
            list.Print();
            list.RemoveByIndex(33);
            list.Print();

            Console.WriteLine($"index of 2 = {list.IndexOf(2)}");
            Console.WriteLine();
        }
    }
    class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }
}
