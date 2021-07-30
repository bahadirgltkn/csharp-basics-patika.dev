using System;

namespace _14_string_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Lorem ipsum dolor sit amet.";
            string str2 = "Lorem ipsum";

            //LENGTH 
            Console.WriteLine("length: " + str1.Length);

            // ToUpper, ToLower
            Console.WriteLine(str1.ToLower());
            Console.WriteLine(str1.ToUpper());

            //Concat
            Console.WriteLine(String.Concat(str1," New string."));

            //Compare, CompareTo
            string str3 = "hi";
            string str4 = "world";
            Console.WriteLine(str1.CompareTo(str2));    // 0 1 -1
            Console.WriteLine(String.Compare(str1,str2,true));
            Console.WriteLine(String.Compare(str1,str2,false));
            Console.WriteLine(str3.CompareTo(str4));   // hi - world

            //Contains
            Console.WriteLine(str1.Contains(str2));
            Console.WriteLine(str1.EndsWith("t"));              //Lorem ipsum dolor sit amet.
            Console.WriteLine(str1.StartsWith("Lorem"));        //Lorem ipsum dolor sit amet.

            //IndexOf - LastIndexOf
            Console.WriteLine(str1.IndexOf("ip"));          //first index
            Console.WriteLine(str1.IndexOf("sass"));        // -1
            Console.WriteLine(str1.LastIndexOf("i"));       //last index

            //Insert
            Console.WriteLine(str1.Insert(0,"New string "));

            //PadLeft, PadRight (Padding)
            Console.WriteLine(str1 + str2.PadLeft(30));
            Console.WriteLine(str1 + str2.PadLeft(30,'*')); 
            //Star is added to the left to contain thirty characters
            

            //Remove
            Console.WriteLine(str1.Remove(10));         
            // It starts deleting from the eleventh index
            Console.WriteLine(str1.Remove(3,4));        
            // 4-5-6-7.index 

            //Replace
            Console.WriteLine(str1.Replace("Lorem","new lorem"));

            //Split
            Console.WriteLine(str1.Split(' ')[1]);   
            // kept in the array
            // 0-Lorem
            //1-ipsum
            //2-dolor...

            //Substring
            Console.WriteLine(str1.Substring(4));
            Console.WriteLine(str1.Substring(4,6));
        }
    }
}
