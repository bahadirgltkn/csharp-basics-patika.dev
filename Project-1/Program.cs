using System;
using System.Collections.Generic;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            List<Person> listContact = new List<Person>();


            Person per1 = new Person("John","Smith","5111111111");
            listContact.Add(per1);
            Person per2 = new Person("Kate","Snow","5222222222");
            listContact.Add(per2);
            Person per3 = new Person("Dan","Brown","5333333333");
            listContact.Add(per3);
            Person per4 = new Person("Maria","Rilke","5444444444");
            listContact.Add(per4);
            Person per5 = new Person("John","Locke","5555555555");
            listContact.Add(per5);


            int status = 1;

            while(status == 1){
                Console.WriteLine("\n***************************************");
                Console.WriteLine("Please select the action you want to do");
                Console.WriteLine("***************************************");
                Console.WriteLine("(1) Registering a New Number\n" + 
                                  "(2) Deleting an existing number\n" + 
                                  "(3) Updating an existing number\n" + 
                                  "(4) List contacts\n" + 
                                  "(5) Search in my contacts\n" +
                                  "(6) To exit !");
                Console.Write("Your choice: ");

                string temp = Console.ReadLine();
                bool isExist = int.TryParse(temp,out int choice);

                if(!isExist){
                    Console.WriteLine("A number that does not exist !!!");
                    continue;
                }

                switch(choice){

                    case 1:
                        Console.Write("Name             : ");
                        string name = Console.ReadLine();
                        Console.Write("Surname          : ");
                        string surname = Console.ReadLine();
                        Console.Write("Phone Number : ");
                        string phoneNumber = Console.ReadLine();

                        Person per = new Person(name,surname,phoneNumber);
                        listContact.Add(per);
                        break;


                    case 2:
                        Console.WriteLine("Enter the full name of the person you want to delete");
                        Console.WriteLine("Fullname    : ");
                        string tempName = Console.ReadLine();
                        
                        operation.DeletePerson(listContact, tempName);

                        break;
                    

                    case 3:
                        Console.WriteLine("Enter the full name or phone number of the person you want to update");
                        Console.Write("Enter: ");
                        string value = Console.ReadLine();
                        operation.UpdatePersonInfos(listContact, value);

                        break;
                    

                    case 4:
                        operation.GetContactList(listContact);
                        break;
                    

                    case 5:
                        Console.WriteLine("\n*************************");
                        Console.WriteLine("(1) With phone number ");
                        Console.WriteLine("(2) With name and surname");
                        Console.WriteLine("*************************");
                        Console.Write("Choice:  ");
                        

                        
                        int result = int.Parse(Console.ReadLine());

                        if(result == 1){
                            Console.Write("\nEnter the phone number you want to search    : ");
                            string number = Console.ReadLine();
                            operation.SearchPerson(listContact, number);
                        }
                        else{
                            Console.Write("\nEnter the fullname you want to search    : ");
                            string fullName = Console.ReadLine();
                            operation.SearchPerson(listContact, fullName);
                            
                        }

                        if(operation.Status == 0){
                            Console.WriteLine("No data matching the values ​​you entered could be found...");
                        }

                        break;
                    

                    case 6:
                        Console.WriteLine("Your logout has been successfully completed...");
                        status = 0;
                        break;
                }
            
            }
          


            
        }
    }
}
