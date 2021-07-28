using System;

namespace _3_type_conversion
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("***** IMPLICIT CONVERSION *****");
            // IMPLICIT CONVERSION      char -> int -> long -> float -> double 
            byte a = 5;
            sbyte b = 30;
            short c = 10;
            
            int d = a + b + c;
            Console.WriteLine("d: " + d);
            long h = d;
            Console.WriteLine("h: " + h);
            float i = h;
            Console.WriteLine("i: " + i);

            string e = "bahadir";
            char f  = 'k';
            object g = e + f + d;
            Console.WriteLine("g: " + g);

            Console.WriteLine("***** EXPLICIT CONVERSION *****");
            // EXPLICIT CONVERSION      double -> float -> long -> int -> char
            
            int x = 4;
            byte y = (byte) x;
            Console.WriteLine("y: " + y);

            float w = 10.3f;
            byte v = (byte) w;
            Console.WriteLine("v: " + v);


            // ToString() Method
            Console.WriteLine("***** ToString() Method *****");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: " + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz: " + zz);


            // System.Convert Class
            Console.WriteLine("***** System.Convert *****");
            string str1 = "10", str2 = "20";
            int num1, num2, sum;
            
            num1 = Convert.ToInt32(str1);
            num2 = Convert.ToInt32(str2);
            sum = num1 + num2;
            Console.WriteLine("Sum: " + sum);

            // Parse
            Console.WriteLine("***** Parse Method *****");
            ParseMethod();

        }

        public static void ParseMethod(){

            string str1 = "10";
            string str2 = "10,25";
            int num1;
            double num2;
            double sum;

            num1 = Int32.Parse(str1);
            Console.WriteLine("num1: " + num1);

            num2 = Double.Parse(str2);
            Console.WriteLine("num2: " + num2);
            
        }
    }
}
