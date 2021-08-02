using System;
using System.Collections.Generic;

namespace Project_1
{
    public class Operation
    {

        private int status;
        private int sumOfSearch;

        public Operation()
        {
            status = 0;
        }

        public int Status { get => status; set => status = value; }
        public int SumOfSearch { get => sumOfSearch; set => sumOfSearch = value; }

        public void GetContactList(List<Person> list){
            int sum = 0;

            Console.Write("***Contact List***\n");

            foreach(var item in list){
                Console.WriteLine("Name        : {0}", item.FirstName);
                Console.WriteLine("Surname     : {0}", item.LastName);
                Console.WriteLine("Phone Number: {0}\n", item.TelNo);
                sum += 1;
            }

            Console.WriteLine("Total number of people: " + sum +"\n");
        }

        public void SearchPerson(List<Person> list, string value){
           
            status = 0;
            sumOfSearch = 0;

            foreach (var item in list)
            {   
                if(item.FullName == value || item.TelNo == value){
                    Console.WriteLine("          Search Results           ");
                    Console.WriteLine("***********************************");
                    Console.WriteLine("Name: {0}", item.FirstName);
                    Console.WriteLine("Name: {0}", item.LastName);
                    Console.WriteLine("Name: {0}", item.TelNo);
                    status = 1;
                    sumOfSearch += 1;
                }
            }

            // status controlune bakılacak

        }

        public void UpdatePersonInfos(List<Person> list, string value){
            
            foreach (var item in list)
            {
                if(item.FullName == value || item.TelNo == value){
                    Console.WriteLine("\n********** old information **********");
                    Console.WriteLine("Name         : " +item.FirstName);
                    Console.WriteLine("Surname      : " +item.LastName);
                    Console.WriteLine("Phone Number : " +item.TelNo);

                    Console.WriteLine("\n****** enter new information ******");
                    Console.Write("Name           :");
                    string name = Console.ReadLine();
                    Console.Write("Surname       :");
                    string surname = Console.ReadLine();
                    Console.Write("Phone Number  :");
                    string phone = Console.ReadLine();

                    item.FirstName = name;
                    item.LastName = surname;
                    item.TelNo = phone;

                    Console.WriteLine("Information has been updated...");
                    Console.WriteLine("***********************************\n");
                }
            }
        }

        public void DeletePerson(List<Person> list, string name){
            
            foreach (var item in list)  
            {
               if(item.FullName == name){
                   Console.Write("The person named {0} will be deleted from the list, do you confirm?(y/n)",item.FullName);
                   string result = Console.ReadLine();

                   if(result == "y"){
                       list.Remove(item);
                       Console.WriteLine("Successfully deleted...");
                   }
                   else if(result == "n"){
                       Console.WriteLine("Deletion canceled...");
                   }
               }
               else{
                   Console.WriteLine("The person you are looking for was not found in the your contact list");
                }
            }
        }

    }

}