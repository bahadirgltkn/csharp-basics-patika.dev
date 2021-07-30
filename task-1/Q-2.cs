using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("M: ");
            int m = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for(int i = 0; i < n; i++){
                Console.Write((i+1) + ". number: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("**Numbers**");
            for(int i = 0; i < arr.Length; i++){
                if(arr[i] == m){
                    Console.Write(arr[i]+" ");
                    continue;
                }
                else if(arr[i] % m == 0){
                    Console.Write(arr[i]+" ");
                }
            }
        }
    }
}
