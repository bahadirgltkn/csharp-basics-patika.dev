using System;

namespace _19_class
{
    class Program
    {
        static void Main(string[] args)
        {
            // Access Modifiers
            //   *Public    --> The code is accessible for all classes

            //   *Private   -->	The code is only accessible within the same class

            //   *Internal  --> The code is only accessible within its own assembly, but not from another assembly.

            //   *Protected -->	The code is accessible within the same class, or in a class that is inherited from that class.

            Employee emp1 = new Employee();
            emp1.Name = "John";
            emp1.Surname = "Smith";
            emp1.No = 12548548;
            emp1.Department = "Human Resources";
            emp1.EmployeeInfos();
            Console.WriteLine("**************");

            Employee emp2 = new Employee();
            emp2.Name = "Kate";
            emp2.Surname = "Walker";
            emp2.No = 15485136;
            emp2.Department = "Sales";
            emp2.EmployeeInfos();

        }
    }

    class Employee
    {
        public string Name;
        public string Surname;
        public int No;
        public string Department;

        public void EmployeeInfos(){
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Surname: {0}", Surname);
            Console.WriteLine("No: {0}", No);
            Console.WriteLine("Deparment: {0}", Department);
        }
    }
}
