using System;
using System.Collections;
using System.Collections.Generic;

namespace _17_arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections

            ArrayList list  = new ArrayList();
            list.Add("Ayse");
            list.Add(2);
            list.Add('A');
            list.Add(false);

            // access data in arraylist

            Console.WriteLine(list[1]);
            foreach (var item in list)
                Console.WriteLine(item);
            

            // AddRange

            ArrayList list2 = new ArrayList();

            Console.WriteLine("**Add Range**");
            string[] colors = {"red","yellow","blue"};
            List<int> numbers = new List<int>(){4,2,5,6,12,56,1,93};

            list2.AddRange(numbers);
            //list2.AddRange(colors);

            foreach (var item in list)
                Console.WriteLine(item);
            
            // Sort 
            Console.WriteLine("** SORT ** ");
            list2.Sort();
            foreach (var item in list2)
                Console.WriteLine(item);

            // Binary Search
            // it needs to be sorted before using

            Console.WriteLine("** Binary Search **");
            Console.WriteLine(list2.BinarySearch(56));


            // REVERSE

            Console.WriteLine("** Reverse **");
            list2.Reverse();
            foreach (var item in list2)
                Console.WriteLine(item);

            
            // CLEAR
            Console.WriteLine("** Clear **");
            list2.Clear();
        }
    }
}
