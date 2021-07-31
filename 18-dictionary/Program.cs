using System;
using System.Collections.Generic;

namespace _18_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Collections.Generic

            Dictionary<int,string> users =  new Dictionary<int, string>();
            users.Add(10,"Rafael Nadal");
            users.Add(14,"Novak Djokobic");
            users.Add(15,"Roger Federer");
            users.Add(16,"Denis Shapovalov");

            // accessing the elements of the Dictionary
            Console.WriteLine("**Accessing of the elements**");
            Console.WriteLine(users[10]);
            foreach (var item in users)
                Console.WriteLine(item);

            // COUNT
            Console.WriteLine("**COUNT**");
            Console.WriteLine(users.Count);                      // 4 

            // ContainsKey
            Console.WriteLine("**ContainsKey**");
            Console.WriteLine(users.ContainsKey(10));           // True
            Console.WriteLine(users.ContainsKey(45));           // False


            // Remove
            Console.WriteLine("**Remove**");
            users.Remove(16);
            foreach (var item in users)
                Console.WriteLine(item);


            // Keys
            Console.WriteLine("**Keys**");
            foreach (var item in users)
                Console.WriteLine(item.Key);


            // Values
            Console.WriteLine("**Keys**");
            foreach (var item in users)
                Console.WriteLine(item.Value);

        }
    }
}
