using System;
using System.Collections.Generic;

namespace AreaPerimeter
{
    interface IGeometry
    {
        void FindArea();
        void FindPerimeter();
    }
    class Square : IGeometry
    {
        private int Side;

        public Square(int side)
        {
            Side = side;
        }
        public void FindArea()
        {
            Console.WriteLine("\n Area of the square : {0}", Side * Side);
        }

        public void FindPerimeter()
        {
            Console.WriteLine("\n Perimeter of the square: {0}", 4 * Side);
        }
    }
    class Rectangle : IGeometry
    {
        private double Length;
        private double Breadth;


        public Rectangle(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }
        public void FindArea()
        {
            Console.WriteLine("\n Area of the rectangle : {0}", Length * Breadth);
        }

        public void FindPerimeter()
        {
            Console.WriteLine("\n Perimeter of the rectangle: {0}", 2.0 * (Length * Breadth));
        }
    }

    class Circle : IGeometry
    {
        const double pi = 3.14;
        private double Radius;
        public Circle(double radius)
        {
            Radius = radius;
        }

        public void FindArea()
        {
            Console.WriteLine("\n Area of the circle : {0}", pi * (Radius * Radius));
        }

        public void FindPerimeter()
        {
            Console.WriteLine("\n Perimeter of the circle: {0}", 2.0 * pi * Radius);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate area and perimeter of circle, square and rectangle(using interface).");

            var Shapes = new List<IGeometry>();
            Shapes.Add(new Square(5));
            Shapes.Add(new Rectangle(10, 5));
            Shapes.Add(new Circle(6));

            foreach (var shape in Shapes)
            {
                shape.FindArea();
                shape.FindPerimeter();
            }
        }
    }
}
