using System;

namespace _10_array_class_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {23,12,4,86,14,17,87,3};

            Console.WriteLine("*****UNSORTED*****");
            foreach (var item in numbers)
                Console.WriteLine(item);
            

            Console.WriteLine("*****SORTED*****");
            Array.Sort(numbers);
            foreach (var item in numbers)
                Console.WriteLine(item);
            

            //CLEAR  Clear(Array array, int index, int length)
            // arrays = {1,2,3,4,5,6} --> arrays.Clear(arrays,2,2) --> output: 1 2 0 0 5 6
            Console.WriteLine("*****Array Clear*****");
            Array.Clear(numbers,2,2);
            foreach (var item in numbers)
                Console.WriteLine(item);
            

            //Reverse
            Console.WriteLine("*****Array Reverse*****");
            Array.Reverse(numbers);
            foreach (var item in numbers)
                Console.WriteLine(item);
            
            //IndexOf
            Console.WriteLine("*****Array IndexOf*****");
            Console.WriteLine(Array.IndexOf(numbers,86));

            //Resize
            Console.WriteLine("*****Array Resize*****");
            Console.WriteLine("old length: " + numbers.Length);
            Array.Resize<int>(ref numbers, 10);
            Console.WriteLine("new length: " + numbers.Length);
            


        }
    }
}
