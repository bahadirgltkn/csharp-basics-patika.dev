using System;

namespace Project_1
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private string telNo;
        private string fullName;


        public Person(string firstName, string lastName, string telNo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.TelNo = telNo;
            this.FullName = firstName + " " + lastName;
        }


        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string TelNo { get => telNo; set => telNo = value; }
        public string FullName { get => fullName; set => fullName = value; }
    }
}