using System;

namespace _11_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //<Access Specifier> <Return Type> <Method Name>(Parameter List)

            int result = addTwoNumbers(24,53);
            Console.WriteLine(result);

            Methods item = new Methods();
            item.printScreen(Convert.ToString(result));

            int a = 10;
            int b = 20;
            Console.WriteLine(a + " + " + b + " = " + addTwoNumbers(a,b));
            Console.WriteLine("***With call by reference***");
            Console.WriteLine(a + " + " + b + " = " + item.addTwoNumbers2(ref a,ref b));
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
        }

        public static int addTwoNumbers(int number1, int number2){
            // call by value number1 = a
            //call by value number2 = b
            return number1 + number2;
        }
    }

    class Methods{
        public void printScreen(string data){
            Console.WriteLine("***with printScreen Class***");
            Console.WriteLine(data);
        }

        public int addTwoNumbers2(ref int number1, ref int number2){
            number1++;
            number2++;
            return number1 + number2;
        }

    }
}
