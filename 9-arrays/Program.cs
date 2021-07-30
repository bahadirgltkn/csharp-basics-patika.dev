using System;

namespace _9_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = new string[5];
            string[] animals = {"cat","dog","bird","monkey"};

            int[] numbers;
            numbers = new int[5];

            colors[0] = "red";
            numbers[3] = 20;

            Console.WriteLine(colors[0]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(animals[2]);

            Console.Write("enter the length of the array: ");
            int len = int.Parse(Console.ReadLine());
            int[] numbers2 = new int[len];

            for (int i = 0; i < len; i++)
            {
                Console.Write("{0}. number: ", i+1);
                numbers2[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            foreach (var item in numbers2)
                sum += item;

            Console.WriteLine("Average: " + sum / len);

        }
    }
}
