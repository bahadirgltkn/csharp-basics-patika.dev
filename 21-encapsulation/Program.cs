using System;

namespace _21_encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // ENCAPSULATION

            Student student1 = new Student();
            student1.Name = "John";
            student1.Surname = "Smith";
            student1.StudentNo = 548;
            student1.ClassNumber = 3;
            student1.StudentInfos();

            student1.IncreaseClass();
            student1.StudentInfos();


            Student student2 = new Student("Alice","Rybak",522,1);
            student2.DecreaseClass();
            student2.DecreaseClass();
            student2.StudentInfos();

        }
    }

    class Student
    {
        private string name;
        private string surname;
        private int studentNo;
        private int classNumber;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int StudentNo { get => studentNo; set => studentNo = value; }
        public int ClassNumber 
        { 
            get => classNumber;
            set 
            {
                if(value < 1){
                    Console.WriteLine("Classnumber can be at least 1");
                    classNumber = 1;
                }
                else{
                    classNumber = value;
                }
            }  
         
        }

        public Student(string name, string surname, int studentNo, int classNumber)
        {
            Name = name;
            Surname = surname;
            StudentNo = studentNo;
            ClassNumber = classNumber;
        }

        // overload
        public Student(){}

        public void StudentInfos(){
            Console.WriteLine("***** STUDENT INFOS *****\n");
            Console.WriteLine("Student Name: {0}", this.Name);
            Console.WriteLine("Student Surname: {0}", this.Surname);
            Console.WriteLine("Student No: {0}", this.StudentNo);
            Console.WriteLine("Student Class: {0}\n", this.ClassNumber);
        }

        public void IncreaseClass(){
            this.ClassNumber += 1;
        }

        public void DecreaseClass(){
            this.ClassNumber -= 1;
        }
    }
}
