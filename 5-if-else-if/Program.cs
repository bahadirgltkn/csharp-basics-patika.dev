using System;

namespace _5_if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;


            if(time >= 6 && time < 11)
                Console.WriteLine("Good Morning");
            if(time <= 18)
                Console.WriteLine("have a good day");
            else    
                Console.WriteLine("Good night");

            // Ternary Operator
            // variable = (condition) ? expressionTrue :  expressionFalse;
            //string result = time <= 18 ? "have a good day" : "good night";
            string result = time >=6 && time < 11 ? "good morning" : time <= 18 ? "hava a good day" : "good night";
            Console.WriteLine(result);
        }
    }
}
