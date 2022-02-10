using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_and_data_structures
{
    //основные операции в связном списке включают добавление, удаление и поиск элемента в списке
    class LinkedList<T> 
        where T : IEquatable<T>
    {
        public Node<T> head;

        public LinkedList()
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

        public void Print()
        {
            if (head == null)
                Console.WriteLine("Linked list is empty");
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
