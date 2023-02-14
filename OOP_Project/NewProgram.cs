using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    //Calculate class
    public class Calculate
    {
        //Addition method using virtual keyword
        public virtual void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine($"sum of {a} and {b} is {c}");
        }

        //subtraction method using virtual keyword
        public void Sub(int x, int y)
        {
            int z = x - y;
            Console.WriteLine($"Subtract of {x} and {y} is {z}");
        }

        //multiplication method
        public void Multiple(int s, int t)
        {
            int u = s * t;
            Console.WriteLine($"Multiply of {s} and {t} is {u}");
        }
    }

    //CalculateA (child class)
    public class CalculateA : Calculate
    {
        //method override and overloading


        public void Add(int a,float f)
        {
            float c = a + f;
            Console.WriteLine($"Sum of {a} and {f} is {c}");
            Console.WriteLine($"Calculate");
        }

        
        public void Add(int a, int b, int c)
        {
            int d = a + b + c;
            Console.WriteLine($"Sum of {a} , {b} and {c} is {d}");
        }

        public void Add(float x,float y)
        {
            float z = x + y;
            Console.WriteLine($"sum of {x} and {y} is {z}");
        }

        public void Add(string a,string b)
        {
            Console.WriteLine($"{a} and {b}");
        }
    }
}
