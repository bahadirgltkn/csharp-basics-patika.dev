using System;
using System.Collections.Generic;

namespace _16_generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections.Generic

            List<int> numberList = new List<int>();
            numberList.Add(12);
            numberList.Add(24);
            numberList.Add(45);
            numberList.Add(56);
            numberList.Add(16);
            numberList.Add(75);

            List<string> colorList = new List<string>();
            colorList.Add("red");
            colorList.Add("blue");
            colorList.Add("black");
            colorList.Add("yellow");
            colorList.Add("green");

            // Count
            Console.WriteLine("colorList length: " + colorList.Count);
            Console.WriteLine("numberList length: " + numberList.Count);

            // foreach - List.ForEach
            Console.WriteLine("**numberList**");
            foreach (var item in numberList)
                Console.Write(item + " ");
            Console.WriteLine("");
            
            Console.WriteLine("**colorList**");
            foreach (var item in colorList)
                Console.Write(item + " ");
            Console.WriteLine("");

            Console.WriteLine("**numberList**");
            numberList.ForEach(item => Console.Write(item + " "));
            Console.WriteLine("");

            Console.WriteLine("**colorList**");
            colorList.ForEach(item => Console.Write(item + " "));
            Console.WriteLine("");

            // Remove - RemoveAt
            numberList.Remove(12);
            colorList.Remove("red");

            numberList.RemoveAt(0);
            numberList.ForEach(item => Console.Write(item + " "));
            colorList.RemoveAt(2);
            colorList.ForEach(item => Console.Write(item + " "));
            Console.WriteLine("");


            // Contains 
            if(numberList.Contains(75))
                Console.WriteLine("75 found in list");


            // BinarySearch --> return index
            Console.WriteLine(colorList.BinarySearch("blue"));

            // Array conver to List
            string[] animals = {"cat","dog","bird"};
            List<string> animalsList = new List<string>(animals);
            
            // clear list
            animalsList.Clear();


            // to keep object in list
            List<User> userList = new List<User>();
            User user1 = new User();
            user1.Fisrtname = "John";
            user1.Lastname = "Walter";
            user1.Age = 23;

            User user2 = new User();
            user2.Fisrtname = "James";
            user2.Lastname = "Harley";
            user2.Age = 32;

            userList.Add(user1);    
            userList.Add(user2);   


            List<User> newUserList = new List<User>();
            newUserList.Add(new User(){
                Fisrtname = "Leo",
                Lastname = "Snow",
                Age = 24
            });

            foreach (var item in userList)
            {
                Console.WriteLine("Username: " + item.Fisrtname);
                Console.WriteLine("Lastname: " + item.Lastname);
                Console.WriteLine("Age: " + item.Age);
            }

            newUserList.Clear();

        }
    }

    public class User{
        private string fisrtname;
        private string lastname;
        private int age;

        //Encapsulation

        public string Fisrtname { get => fisrtname; set => fisrtname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public int Age { get => age; set => age = value; }
    }
}
