using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Shape
    {
        public abstract double CalculateArea();

        public void DisplayResult()
        {
            Console.WriteLine("The area is: {0}", CalculateArea());
        }
    }

    class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return width * height;
        }
    }

    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
    class Class2
    {
        public static void Main(string[] args)
        {
            int choice;
            double width, height, radius;

            // Create a menu
            Console.WriteLine("1. Calculate the area of a rectangle");
            Console.WriteLine("2. Calculate the area of a circle");
            Console.WriteLine("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            // Get the required inputs
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the width: ");
                    width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the height: ");
                    height = Convert.ToDouble(Console.ReadLine());
                    Rectangle rectangle = new Rectangle(width, height);
                    rectangle.DisplayResult();
                    break;
                case 2:
                    Console.WriteLine("Enter the radius: ");
                    radius = Convert.ToDouble(Console.ReadLine());
                    Circle circle = new Circle(radius);
                    circle.DisplayResult();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

           // return 0;
        }
    }

}
