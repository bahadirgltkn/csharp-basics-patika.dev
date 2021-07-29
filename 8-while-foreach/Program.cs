using System;

namespace _8_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //WHILE
            int  sum = 0, i = 1;
            Console.Write("please enter a number: ");
            int number = int.Parse(Console.ReadLine());
            
            while (i <= number)
            {
                sum += i;
                i++;
            }
            Console.WriteLine("Average of numbers: " + sum / number);

            Console.WriteLine("***** FOREACH *****");
            //FOREACH
            int[] numbers = {1,2,3,4,5,6,7,8,9,10};

            foreach (var num in numbers)
            {
                Console.WriteLine("item: " + num);
            }


        }
    }
}
