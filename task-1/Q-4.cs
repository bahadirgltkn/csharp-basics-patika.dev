using System;

namespace q_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("sentence: ");
            string sentence = Console.ReadLine();

            int charCount = sentence.Replace(" ","").Length;
            Console.WriteLine("Character number: " + charCount);

            int i = 0, wordCount = 1;
            while(i <= sentence.Length - 1){
                if(sentence[i] == ' ' || sentence[i] == '\n' || sentence[i] == '\t'){
                    wordCount++;
                }
                i++;
            }
            Console.WriteLine("Total number of words: " + wordCount);


        }
    }
}
