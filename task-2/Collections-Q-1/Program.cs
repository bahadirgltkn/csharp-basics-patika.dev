using System;
using System.Collections;

namespace q_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, half = 0, iter = 1, flag = 0;
            int sum1 = 0, sum2 = 0;
            ArrayList primeNumbers = new ArrayList();
            ArrayList notPrimeNumbers = new ArrayList();
            
            while(iter <= 20){

                Console.Write(iter + ". value: ");
                string temp = Console.ReadLine();
                bool isNumeric = int.TryParse(temp, out number);

                half = number / 2;
                
                if(isNumeric){

                    for(int i = 2; i <= half; i++){
                        if(number % i == 0){
                            notPrimeNumbers.Add(number);
                            flag = 1;
                            break;
                        }
                    }

                    if(flag == 0){
                        primeNumbers.Add(number);
                    }
                    iter++;
                    flag = 0;
                }
                else{
                    Console.WriteLine("please enter a numeric value...");
                    continue;
                }
            }

            primeNumbers.Sort();
            notPrimeNumbers.Sort();

            Console.WriteLine("\n***Sorted prime numbers***");
            foreach (var item in primeNumbers){
                Console.Write(item + " ");
                sum1 += (int)item;
            }
               
            Console.WriteLine("\n\n***Sorted not prime numbers***");
            foreach (var item in notPrimeNumbers){
                Console.Write(item + " ");
                sum2 += (int)item;
            }

            Console.WriteLine("\n\n***prime numbers***");
            Console.WriteLine("number of elements: " + primeNumbers.Count);
            Console.WriteLine("average of the array: " + sum1 / primeNumbers.Count);

            Console.WriteLine("\n***not prime numbers***");
            Console.WriteLine("number of elements: " + notPrimeNumbers.Count);
            Console.WriteLine("average of the array: " + sum2 / notPrimeNumbers.Count);
            
        }
    }
}
