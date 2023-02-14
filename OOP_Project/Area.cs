using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    //abstract class AREA
    public abstract class Area
    {
        public double length;
        public double width;
        public double height;
        public double radius;
        public const float pi = 3.1416f;

        public abstract double findArea();
        public abstract double findperimeter();
    }

    //find the area and perimeter of a triangle
    public class Triangle : Area
    {
        //constructor
        public Triangle(double l, double h)
        {
            base.length = l;
            base.height = h;
        }

        //override findArea method
        public override double findArea()
        {
            double area = 0.5 * length * height;
            return area;
        }

        //override findPerimeter method
        public override double findperimeter()
        {
            double perimeter = length + height + Math.Sqrt((length*length)+(height*height));
            return perimeter;
        }
    }



    //find the area and perimeter of a rectangle
    public class Rectangle : Area
    {
        //constructor
        public Rectangle(double l, double w)
        {
            base.length = l;
            base.width = w;
        }

        //override findArea method
        public override double findArea()
        {
            double area = length * width;
            return area;
        }

        //override findPerimeter method
        public override double findperimeter()
        {
            double perimeter = 2*(length+width);
            return perimeter;
        }
    }



    //find the area and perimeter of a square
    public class Square : Area
    {
        //constructor
        public Square(double l)
        {
            base.length = l;
        }

        //override findArea method
        public override double findArea()
        {
            double area = length * length;
            return area;
        }

        //override findPerimeter method
        public override double findperimeter()
        {
            double perimeter = 4*length;
            return perimeter;
        }
    }



    //find the area and perimeter of a Circle
    public class Circle : Area
    {
        //constructor
        public Circle(double r)
        {
            base.radius = r;
        }

        //override findArea method
        public override double findArea()
        {
            double area = pi*radius * radius;
            return area;
        }

        //override findPerimeter method
        public override double findperimeter()
        {
            double perimeter = 2 * pi * radius;
            return perimeter;
        }
    }

}
