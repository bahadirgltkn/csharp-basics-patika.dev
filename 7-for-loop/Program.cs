using System;

namespace _7_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("please enter a number: ");
            // int length = int.Parse(Console.ReadLine());

            // for (int i = 0; i < length; i++)
            // {
            //     Console.WriteLine("length: " + i);
            // }


            // 1 -- 1000 sum of odd numbers and even numbers

            int sumOdd = 0, sumEven = 0;
            for(int i = 1; i <= 1000; i++){
                if(i % 2 == 0)
                    sumEven += i;
                else
                    sumOdd += i;
            }

            Console.WriteLine("sum of odd numbers: " + sumOdd);
            Console.WriteLine("sum of even numbers: " + sumEven);


            // break(exit loop), continue(next cycle)
            for (int i = 1; i < 10; i++)
            {
                if(i == 4)
                    break;
                Console.WriteLine("i: " + i);           // output: 1 2 3 
            }

            for (int i = 1; i < 10; i++)
            {
                if(i == 4)
                    continue;
                Console.WriteLine("i: " + i);           // output: 1 2 3 5 6 7 8 9 
            }

            // infinite loop  for(;;;);
        }
    }
}


