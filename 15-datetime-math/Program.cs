using System;

namespace _15_datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            //DateTime.Now(Month - Year - Hour - Minute - Second)

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(5));
            Console.WriteLine(DateTime.Now.AddMonths(6));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMinutes(15));

            // DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));         // 24
            Console.WriteLine(DateTime.Now.ToString("ddd"));        //Sat
            Console.WriteLine(DateTime.Now.ToString("dddd"));       //Saturday

            Console.WriteLine(DateTime.Now.ToString("MM"));         //07
            Console.WriteLine(DateTime.Now.ToString("MMM"));        //Jul
            Console.WriteLine(DateTime.Now.ToString("MMMM"));       //July

            Console.WriteLine(DateTime.Now.ToString("YY"));         //21    
            Console.WriteLine(DateTime.Now.ToString("YYY"));        //2021


            Console.WriteLine("***MATH****");
            // Math

            Console.WriteLine(Math.Abs(-25));       // |-25| --> 25
            Console.WriteLine(Math.Sin(45));
            Console.WriteLine(Math.Tan(45));
            Console.WriteLine(Math.Cos(45));

            Console.WriteLine(Math.Ceiling(10.3));  // 11
            Console.WriteLine(Math.Round(10.3));    //10
            Console.WriteLine(Math.Floor(10.7));    //10

            Console.WriteLine(Math.Max(4,54));      //54
            Console.WriteLine(Math.Min(4,54));      //4

            Console.WriteLine(Math.Pow(4,3));       // 4 * 4 * 4 = 64
            Console.WriteLine(Math.Sqrt(16));       //4
            Console.WriteLine(Math.Log(9));         
            Console.WriteLine(Math.Log10(10));      


        }
    }
}
