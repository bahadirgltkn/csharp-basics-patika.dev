using System;

namespace _24_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            // enumeration
            Console.WriteLine(Days.Monday);
            Console.WriteLine((int)Days.Sunday);


            // enums increase code readability
            int temparature = 32;
            if(temparature <= (int)Weather.Normal)
                Console.WriteLine("Wait");
            else if(temparature >= (int)Weather.Hot)
                Console.WriteLine("a hot day");
            
        }
    }

    enum Days
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday=23,
        Saturday,
        Sunday
    }

    enum Weather
    {
        Cold = 5,
        Normal = 20,
        Hot = 25,
        VeryHot =30
    }
}