using System;
using System.Collections.Generic;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("**Numbers**");
            
            List<int> arr = new List<int>();

            for(int i = 0; i < n; i++){
                Console.Write((i+1) + ".number: ");
                int temp = int.Parse(Console.ReadLine());
                arr.Add(temp);
            }

            Console.WriteLine("**Even numbers**");
            for(int i = 0; i < arr.Count; i++){
                if(arr[i] % 2 == 0)
                    Console.Write(arr[i]+" ");
            }
        }
    }
}
