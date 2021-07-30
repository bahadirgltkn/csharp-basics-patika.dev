using System;

namespace _12_method_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // out parameters
            string number = "999";

            bool result = int.TryParse(number, out int outNumber);
            if(result){
                Console.WriteLine("successful");
                Console.WriteLine(outNumber);
            }
            else{
                Console.WriteLine("not successful");
            }

            Methods item = new Methods();
            item.add(4,5, out int sumResult);
            Console.WriteLine(sumResult);           // 9

            //Overloading
            int value = 999;
            item.printScreen(Convert.ToString(value));
            item.printScreen("Bahadır","Gültekin");

        }
    }

    class Methods{
        public void add(int a, int b, out int sum){
            sum = a + b;
        }

        public void printScreen(string data){
            Console.WriteLine(data);
        }

        //overload
        public void printScreen(int data){
            Console.WriteLine(data);
        }
        
        public void printScreen(string data1, string data2){
            Console.WriteLine(data1 +" "+ data2);
        }
    }
}
