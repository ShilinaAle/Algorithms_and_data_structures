using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_and_data_structures
{
    //основные операции в связном списке включают добавление, удаление и поиск элемента в списке
    //Add, Remove, AddAt, RemoveAt, IndexOf
    class LinkedList<T>
    {
        public Node<T> head;
        int length;

        public LinkedList()
        {
            head = null;
            length = 0;
        }

        public int Length()
        {
            return length;
        }

        public void Add(T data)
        {
            if (head == null)
            {
                head = new Node<T>(data);
                length += 1;
            }
                
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node<T>(data);
                length += 1;
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
                length -= 1;
            }
            Console.WriteLine("asd");
            this.Print();
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
                    Console.Write($"Data = {current.Data} ");
                    //Console.WriteLine($"Ad = {current.Next.Data} ");
                    current = current.Next;
                }
                Console.WriteLine($"Data = {current.Data}");
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
