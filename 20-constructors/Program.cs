using System;

namespace _19_class
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp1 = new Employee("John","Smith", 12548548,"Human Resources");
            emp1.EmployeeInfos();
            Console.WriteLine("\n**************");

            Employee emp2 = new Employee();
            emp2.Name = "Kate";
            emp2.Surname = "Walker";
            emp2.No = 15485136;
            emp2.Department = "Sales";
            emp2.EmployeeInfos();

            Console.WriteLine("\n**************");

            Employee emp3 = new Employee("Ashley","Robertson");
            emp3.EmployeeInfos();

        }
    }

    class Employee
    {
        public string Name;
        public string Surname;
        public int No;
        public string Department;
        
        // CONSTRUCTORS
        // Just like other methods, constructors can be overloaded by using different numbers of parameters.
        public Employee(string name, string surname, int no, string department){
            this.Name = name;
            this.Surname = surname;
            this.No = no;
            this.Department = department;
        }

        public Employee(){}

        public Employee(string name, string surname){
            this.Name = name;
            this.Surname = surname;
        }

        public void EmployeeInfos(){
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Surname: {0}", Surname);
            Console.WriteLine("No: {0}", No);
            Console.WriteLine("Deparment: {0}", Department);
        }
    }
}
