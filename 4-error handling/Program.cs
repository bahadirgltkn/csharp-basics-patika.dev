using System;

namespace _4_error_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //ArgumentNullEx
                //int a = int.Parse(null);

                //FormatEx 
                //int a = int.Parse("test");

                //OverfloxEx
                int a = int.Parse("-25412548756");
            }
            catch (ArgumentNullException ex)
            {
               Console.WriteLine("you entered a null value");
               Console.WriteLine(ex);
            }
             catch (FormatException ex)
            {
               Console.WriteLine("data type is not compatible");
               Console.WriteLine(ex);
            }
             catch (OverflowException ex)
            {
               Console.WriteLine("you entered a value that is too large or too small");
               Console.WriteLine(ex);
            }

            finally{
                //The codes in this block will work under all conditions
                Console.WriteLine("transaction completed successfully !!!");
            }
        }
    }
}
