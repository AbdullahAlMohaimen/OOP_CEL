using Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    public class Program
    {
        static void Main(string[] args)
        {
            double Area,Perimeter;

            Console.WriteLine("Saving Account");
            SavingAccount s1 = new SavingAccount();       //SavingAccount object
            s1.AccNo = "SV00110";
            s1.Name = "Mohaimen";
            s1.Balance = 100000;
            Console.WriteLine(s1.Withdraw(5000));        //call withdraw method
            Console.WriteLine($"After withdraw current balance:  {s1.BalanceCheck()}");
            Console.WriteLine(s1.Deposite(10000));       //call deposite pethod
            Console.WriteLine($"After Deposite current balance:  {s1.BalanceCheck()}");


            Console.WriteLine("\n");
            Console.WriteLine("Crrent Account");
            CurrentAccount c1 = new CurrentAccount();    //currentAccount object
            c1.AccNo = "SV00110";
            c1.Name = "Mohaimen";
            c1.Balance = 95000;
            Console.WriteLine(c1.Withdraw(5000));        //call withdraw method
            Console.WriteLine($"After withdraw current balance:  {c1.BalanceCheck()}");
            Console.WriteLine(c1.Deposite(10000));       //call withdraw method
            Console.WriteLine($"After Deposite current balance:  {c1.BalanceCheck()}");


            Console.WriteLine("\n");
            Console.WriteLine("Area of a Triangle");
            Triangle t = new Triangle(10,8);            //Triangle object
            Area = t.findArea();                        //call findArea method
            Perimeter = t.findperimeter();              //call findPerimeter method
            Console.WriteLine($"Area of Triangle:  {Area}");
            Console.WriteLine($"Perimeter of Triangle:  {Perimeter}");


            Console.WriteLine("\n");
            Console.WriteLine("Area of a Rectangle");
            Rectangle r = new Rectangle(12, 13);        //Rectangle object
            Area = r.findArea();                        //call findArea method
            Perimeter = r.findperimeter();              //call findPerimeter method
            Console.WriteLine($"Area of Rectangle:  {Area}");
            Console.WriteLine($"Perimeter of Rectangle:  {Perimeter}");


            Console.WriteLine("\n");
            Console.WriteLine("Area of a Square");
            Square s = new Square(8);
            Area = s.findArea();                        //call findArea method
            Perimeter = s.findperimeter();              //call findPerimeter method
            Console.WriteLine($"Area of Square:  {Area}");
            Console.WriteLine($"Perimeter of Perimeter:  {Perimeter}");


            Console.WriteLine("\n");
            Console.WriteLine("Area of a Circle");
            Circle c = new Circle(10);
            Area = c.findArea();                        //call findArea method
            Perimeter = c.findperimeter();              //call findPerimeter method
            Console.WriteLine($"Area of Circle:  {Area}");
            Console.WriteLine($"Perimeter of Circle:  {Perimeter}");



            Console.WriteLine("\n");
            Calculate a = new Calculate();
            a.Add(10, 14);
            a.Multiple(9, 6);
            a.Sub(100, 50);

            Console.WriteLine("\n");
            Calculate b = new CalculateA();
            b.Add(11,10);
            b.Multiple(10,9);
            b.Sub(80,60);

            Console.WriteLine("\n");
            CalculateA d = new CalculateA();
            d.Add(1.05f,2.89f);
            d.Add(10, 1.56f);
            d.Add("Mohaimen","Hasan");
            d.Sub(500,190);
            d.Multiple(40,5);


            Console.WriteLine("\n");
            Student a1 = new Student();
            a1.DisplayStudent();


            Console.WriteLine("\n");
            StudentInformationA a2 = new StudentInformationA();
            a2.DisplayStudentInformationA();

            Console.WriteLine("\n");
            StudentInformationB a3 = new StudentInformationB();
            a3.DisplayStudentInformationB();

            Console.WriteLine("\n");
            StudentInformationC a4 = new StudentInformationC();
            a4.DisplayStudentInformationC();

            Console.WriteLine("\n");
            StudentInformationD a5 = new StudentInformationD();
            a5.DisplayStudentInformationD();

            Console.ReadKey();
        }
    }


    public class StudentInformationC : Student
    {
        public void DisplayStudentInformationC()
        {
            Console.WriteLine("\nStudent Information C Class");
            //Console.WriteLine($"ID : {ID}");                         ERROR
            Console.WriteLine($"Account No : {AccountNo}");
            //Console.WriteLine($"Name : {Name}");                     ERROR
            Console.WriteLine($"Balance : {Balance}");
            //Console.WriteLine($"Phone No : {PhoneNo}");              ERROR
        }
    }

    public class StudentInformationD
    {
        public void DisplayStudentInformationD()
        {
            Student j = new Student();

            Console.WriteLine("\nStudent Information D Class");
            //Console.WriteLine($"ID : {j.ID}");                       Error             
            //Console.WriteLine($"Account No : {j.AccountNo}");        ERROR    
            //Console.WriteLine($"Name : {j.Name}");                   ERROR
            //Console.WriteLine($"Balance : {j.Balance}");             ERROR
            //Console.WriteLine($"Phone No : {j.PhoneNo}");            ERROR
            Console.WriteLine($"University : {j.UniversityName}");
        }
    }
}
