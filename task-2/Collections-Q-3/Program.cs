using System;
using System.Collections;

namespace Collections_Q_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList charList = new ArrayList();

            Console.Write("please enter a sentence: ");
            string sentence = Console.ReadLine();

            for(int i = 0; i < sentence.Length; i++){
                if(sentence[i] =='a' || sentence[i]=='e' || sentence[i]=='i' || sentence[i]=='o' || sentence[i]=='u' || sentence[i]=='A' || 
                    sentence[i]=='E' || sentence[i]=='I' || sentence[i]=='O' || sentence[i]=='U')
                {
                    charList.Add(sentence[i]);
                }
            }

            Console.WriteLine("\n***unsorted***");
            foreach (var item in charList)
            {
                Console.Write(item + " ");
            }

            charList.Sort();
            Console.WriteLine("\n***sorted***");
            foreach (var item in charList)
            {
                Console.Write(item + " ");
            }
        }
    }
}
