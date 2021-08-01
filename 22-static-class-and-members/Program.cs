using System;

namespace _22_static_class_and_members
{
    class Program
    {
        static void Main(string[] args)
        {
            // No need to create objects to access static properties
            // we can access through class

            Console.WriteLine("Number of employees: {0}", Employee.NumberOfEmployee);
            
            Employee emp1 = new Employee("John","Smith","HR");
            Console.WriteLine("Number of employees: {0}", Employee.NumberOfEmployee);
            Employee emp2 = new Employee("Leo","Carew","HR");
            Employee emp4 = new Employee("Maria","Rilke","HR");
            Console.WriteLine("Number of employees: {0}", Employee.NumberOfEmployee);

            Console.WriteLine("Result of Add: {0} ", Operations.Add(100,300));
            Console.WriteLine("Result of Sub: {0} ", Operations.Sub(600,300));
        }
    }

    class Employee
    {
        private static int numberOfEmployee;
        private string Name;
        private string Surname;
        private string Department;

        public static int NumberOfEmployee { get => numberOfEmployee; }

        public Employee(string name, string surname, string department)
        {
            Name = name;
            Surname = surname;
            Department = department;
            numberOfEmployee ++;
        }

        static Employee(){
            numberOfEmployee = 0;
        }
    }

    static class Operations
    {
        public static long Add(int a, int b){
            return a + b;
        }
        public static long Sub(int a, int b){
            return a - b;
        }
    }
}
