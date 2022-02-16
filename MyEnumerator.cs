using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_and_data_structures
{
    class SomeObject 
    {
        public int[] Data;
        public SomeObject(int[] data)
        {
            Data = data;
        }
    }

    class AnotherObject
    {
        SomeObject someObject = new SomeObject(new int[] { 9, 8, 7 });
        public IEnumerator GetEnumerator() => someObject.Data.GetEnumerator(); //просто вызываем перечислитель массива
    }
    class Enumer : IEnumerable, IEnumerator //хотим определить свою логику перечисления
    {
        SomeObject arr;
        int index = -1;

        public Enumer()
        {
            arr = new SomeObject(new int[] { 1, 2, 3 });
        }

        //public IEnumerator GetEnumerator() => arr.Data.GetEnumerator(); //аналогично AnotherObject с дефолтным перебором
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (index < arr.Data.Length - 1)
            {
                index += 1;
                Console.WriteLine("особая логика MoveNext");
                return true;
            }
            Reset();
            Console.WriteLine("особая логика MoveNext - конец коллекции");
            return false;
        }

        public object Current {
            get
            {
                Console.WriteLine("особая логика Current");
                return arr.Data[index];
            }
        }

        public void Reset() => index = -1;
    }
    class MyEnumerator
    {
        public static void MyMain()
        {
            Console.WriteLine("Print int[] Data from SomeObject directly:");
            SomeObject someObject = new SomeObject(new[] { 4, 5, 6 });
            IEnumerator enumerator = someObject.Data.GetEnumerator();
            //foreach (var i in someObject) - не будет работать, т.к. в классе SomeObject нет метода GetEnumerator()
            //    Console.Write($"{i} ");
            while (enumerator.MoveNext())
                Console.Write(enumerator.Current + " ");
            Console.WriteLine();

            Console.WriteLine("Print someObject from anotherObject: IEnumerable:");
            AnotherObject anotherObject = new AnotherObject();
            foreach (var i in anotherObject) //будет работать, потому что в классе AnotherObject есть метод GetEnumerator()
                Console.Write($"{i} ");
            Console.WriteLine();

            Console.WriteLine("Print Enumer : IEnumerable, IEnumerator");
            Enumer array = new Enumer();
            foreach (var i in array)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
    }
}
