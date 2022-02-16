using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Algorithms_and_data_structures
{
    class MyObservableCollection
    {
        static ObservableCollection<char> letters = new ObservableCollection<char>() { 'a', 'b', 'c' };

        static void Print()
        {
            foreach (var l in letters)
                Console.Write($"{l} ");
            Console.WriteLine();
        }

        static void Changes(object? sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Console.WriteLine($"Notify!!! Add {e.NewItems[0]}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine($"Notify!!! Remove {e.OldItems[0]}");
                    break;
                case NotifyCollectionChangedAction.Move:
                    Console.WriteLine($"Notify!!! Move {e.NewItems[0]}");
                    break;
                default:
                    Console.WriteLine("Notify!!! Unknown command");
                    break;

            }
        }
        
        public static void StartObservableCollection()
        {
            letters.CollectionChanged += Changes;
            letters.Add('d');
            Console.WriteLine(letters.Contains('a'));
            Console.WriteLine(letters.IndexOf('f'));
            Print();
            letters.Remove('b');
            letters.Remove('a');
            letters.Insert(0, 'o');
            letters.Move(0, letters.Count - 1);
            Print();
        }
    }
}
