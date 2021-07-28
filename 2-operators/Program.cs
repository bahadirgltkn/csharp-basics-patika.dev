using System;

namespace _2_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment Operators
            int x = 3;
            int y = 3;
            y += 2;         // y = y + 2 

            // Logical Operators ( ||, &&, !)
            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                Console.WriteLine("Perfect");
            if(isSuccess || isCompleted)
                Console.WriteLine("Great");
            if(isSuccess && !isCompleted)
                Console.WriteLine("Fine");


            // Comparison Operators   (<, >, <=, >=, ==, !=)
            int a = 3, b = 4;
            bool result = a < b;

            Console.WriteLine(result);
            result = a > b;
            Console.WriteLine(result);
            result = a >= b ;
            Console.WriteLine(result);
            result = a <= b;
            Console.WriteLine(result);
            result = a == b;
            Console.WriteLine(result);
            result = a != b;
            Console.WriteLine(result);

            // Arithmetic Operators ( /, +, -, *, %)
            int number1 = 10, number2 = 5;

            int result2 = number1 / number2;
            Console.WriteLine(result2);
            result2 = number1 * number2;
            Console.WriteLine(result2);
            result2 = number1 + number2;
            Console.WriteLine(result2);
            result2 = number1 - number2;
            Console.WriteLine(result2);

        }
    }
}
