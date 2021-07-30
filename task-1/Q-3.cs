using System;
using System.Collections.Generic;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Positive N: ");
            int n = int.Parse(Console.ReadLine());

            List<string> arr = new List<string>();

            for(int i = 0; i < n; i++){
                Console.Write((i+1) + ". word: ");
                string word = Console.ReadLine();
                arr.Add(word);
            }

            arr.Reverse();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
