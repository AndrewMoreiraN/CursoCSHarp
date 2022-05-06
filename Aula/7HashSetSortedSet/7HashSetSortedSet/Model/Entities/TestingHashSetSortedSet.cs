using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entities
{
    internal class TestingHashSetSortedSet
    {
        public void Main()
        {
            List<int> list = new List<int>() { 0, 4, 5, 4, 62, 2, 2, 44, 3, 7, 1, 10 };

            HashSet<string> set = new HashSet<string>();
            SortedSet<int> a = new SortedSet<int>() { 0, 4, 5, 4, 3, 7, 1, 10 };
            SortedSet<int> b = new SortedSet<int>() { 0, 2, 3, 4, 7, 8, 9, 10 };

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine("Contains Notebook " + set.Contains("Notebook"));
            Console.WriteLine("Contains Cellphone " + set.Contains("Cellphone"));

            //Union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);

            //Intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);

            //Difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);

            PrintCollection<int>(list);
            list.Sort();
            PrintCollection<int>(list);

            SortedSet<int> ss = new SortedSet<int>(list);
            PrintCollection<int>(ss);

            Console.WriteLine();
            PrintCollection<string>(set);
            PrintCollection<int>(a);
            PrintCollection<int>(b);
            PrintCollection<int>(c);
            PrintCollection<int>(d);
            PrintCollection<int>(e);

            static void PrintCollection<T>(IEnumerable<T> collection)
            {
                foreach (T obj in collection)
                {
                    Console.Write(obj + " ");
                }
                Console.WriteLine();
            }
        }
    }
}