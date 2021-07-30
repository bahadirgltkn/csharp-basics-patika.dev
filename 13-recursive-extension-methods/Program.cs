using System;

namespace _13_recursive_extension_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //recursive function
            int result = 1;
            for(int i = 1; i < 5; i++)
                result *= 3;
            Console.WriteLine(result);

            Operations item = new Operations();
            Console.WriteLine("**recursive**");
            Console.WriteLine(item.expo(3,4));


            //Extension Methods
            string str1 = "Bahadır Gültekin";
            bool result2 = str1.checkSpaces();
            Console.WriteLine(result2);
            if(result2)
                Console.WriteLine(str1.removeWhiteSpaces());
            
            Console.WriteLine(str1.makeUpperCase());
            Console.WriteLine(str1.makeLowerCase());
            
            int[] array2 = {5,23,4,3,7,5,9};
            array2.sortArray();
            array2.printArray();
            
            int number10 = 10;
            Console.WriteLine(number10.isEvenNumber());

            Console.WriteLine(str1.getFirstCharacter());


        }
    }

    public class Operations{

        public int expo(int number1, int number2){

            if(number2 < 2)
                return number1;

            return expo(number1, number2 - 1) * number1;
        }
    }

    public static class Extension{
        // ıt must be static class to use extension methods

        public static bool checkSpaces(this string param){
            return param.Contains(" ");
        }

        public static string removeWhiteSpaces(this string param){

            string[] array = param.Split(" ");
            return string.Join("", array);
        }

        public static string makeUpperCase(this string param){
            
            return param.ToUpper();
        }

        public static string makeLowerCase(this string param){
            
            return param.ToLower();
        }

        public static int[] sortArray(this int[] arr){
            Array.Sort(arr);
            return arr;
        }

        public static void printArray(this int[] arr){
            foreach (var item in arr)
                Console.WriteLine(item);
        }

        public static bool isEvenNumber(this int number){
            return number % 2 == 0;
        }

        public static string getFirstCharacter(this string param){
            return param.Substring(0,1);
        }
    }
}
