using System;
using System.Collections;

namespace Collections_Q_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, iter = 1;
            ArrayList arr = new ArrayList();

            while(iter <= 20){
                Console.Write(iter + ". value: ");
                string temp = Console.ReadLine();
                bool isNumeric = int.TryParse(temp, out number);

                if(isNumeric){
                    arr.Add(number);
                    iter++;
                }
                else{
                    Console.WriteLine("please enter a numeric value...");
                    continue;
                }
            }

            arr.Sort();
            int sum1 = 0, sum2= 0;

            for(int i = 0; i < 3; i++){
                int num = Convert.ToInt16(arr[i]);
                sum1 += num;
            }
            
            arr.Reverse();
            arr.RemoveRange(3,17);

            foreach (var item in arr)
            {
                sum2 += (int)item;
            }

            Console.WriteLine("the sum of the three largest numbers: " + sum2);
            Console.WriteLine("the average of the three largest numbers: " + (double)sum2 / 3);
            Console.WriteLine("the sum of the three smallest numbers: " + sum1);
            Console.WriteLine("the average of the three smallest numbers: " + (double)sum1 / 3);
            Console.WriteLine("sum of averages: " + (  (  (double)sum2 / 3) +  ((double)sum1 / 3) )  );

        }
    }
}
