using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information
{
    public class Student
    {
        private int ID=98;
        protected string AccountNo = "A110010";
        internal string Name = "Mohaimen";
        protected internal double Balance = 45000;
        private protected double PhoneNo=01521;
        public string UniversityName = "AUST";

        public void DisplayStudent()
        {
            Console.WriteLine("\nStudent Class");
            Console.WriteLine($"ID : {ID}");
            Console.WriteLine($"Account No : {AccountNo}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Balance : {Balance}");
            Console.WriteLine($"Phone No : {PhoneNo}");
            Console.WriteLine($"University : {UniversityName}");
        }
    }


    public class StudentInformationA : Student
    {
        public void DisplayStudentInformationA()
        {
            Console.WriteLine("\nStudent Information A Class");
            //Console.WriteLine($"ID : {ID}");                         ERROR
            Console.WriteLine($"Account No : {AccountNo}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Balance : {Balance}");
            Console.WriteLine($"Phone No : {PhoneNo}");
            Console.WriteLine($"University : {UniversityName}");
        }
    }


    public class StudentInformationB
    {
        public void DisplayStudentInformationB()
        {
            Student s = new Student();

            Console.WriteLine("\nStudent Information B Class");
            //Console.WriteLine($"ID : {s.ID}");                       ERROR
            //Console.WriteLine($"Account No : {s.AccountNo}");        ERROR
            Console.WriteLine($"Name : {s.Name}");
            Console.WriteLine($"Balance : {s.Balance}");
            //Console.WriteLine($"Phone No : {s.PhoneNo}");            ERROR
            Console.WriteLine($"University : {s.UniversityName}");
        }
    }
}
