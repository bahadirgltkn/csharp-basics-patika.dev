using System;

namespace _6_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            // expression
            switch (month)
            {
                case 1: 
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                default:
                    Console.WriteLine("Wrong data");
                    break;
            }


            switch (month)
            {
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("You are in summer");
                    break;
            }
        }
    }
}
