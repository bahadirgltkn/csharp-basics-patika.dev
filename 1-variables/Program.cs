using System;

namespace _1_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //STRING 
            String str1 = " ";
            String str2 = null;
            String str3 = "new string";
            String str4 = string.Empty;
            str4 = "Updated";
            String name = "walter";
            String surname = "white";
            String fullName = name + " " + surname;

            //INTEGER - LONG
            Int16 i16 = 5;      //2 byte
            int i = 5;          //4 byte
            Int32 i32 = 5;      //4 byte
            Int64 i64 = 5;      //8 byte

            uint ui = 5;        //4 byte
            long l = 5;         //8 byte
            ulong ul = 5;       //8 byte  ul_value > 0

            int integer1 = 5;
            int integer2 = 10;
            int integer3 = integer1 * integer2;

            //BYTE  1byte --> 0..255
            byte b1 = 5; 


            //SBYTE 1byte --> -128...127
            sbyte b2 = 5;


            //SHORT 2byte
            short s = 5;


            //UNSIGNEDSHORT 2byte --> us_value > 0
            ushort us = 5;

        
            //TO REAL NUMBER
            float f = 5;        //4 byte
            double d = 5;       //8 byte
            decimal de = 5;      //16 byte

            //CHAR
            char ch = '2';      //2 byte

            //BOOLEAN
            bool bool1 = true;
            bool bool2 = false;
            bool bool3 = 10 < 2;    //FALSE

            //DATETIME
            DateTime dt = DateTime.Now; 

            //TYPE CONVERSION
            String str20 = "20";
            int int20 = 20;
            String newString = str20 + int20.ToString();    // 2020

            int int21 = int20 + Convert.ToInt32(str20);     // 40

            int int22 = int20 + int.Parse(str20);           // 40   
            
            String dt2 = DateTime.Now.ToString("dd.MM.yyyy");  
            String dt3 = DateTime.Now.ToString("dd/MM/yyyy");       // MM --> month
            String dt4 = DateTime.Now.ToString("HH:mm");            // mm --> minute
            
            Console.WriteLine(dt4);
        }
    }
}
