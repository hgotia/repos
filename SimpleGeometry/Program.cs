using System;

namespace SimpleGeometry
{
    class Program
    {
        static void Main(string[] args)
        {
            double area;
            double radius;

            radius = GetRadius();
            area = areaCircle(radius);

            Console.WriteLine($"The area of your circle with radius {radius} is {area:0.0#}");
        }

        private static double GetRadius()
        {
            Console.WriteLine("Give a radius: ");
            return double.Parse(Console.ReadLine());
        }

        private static double areaCircle(double radius)
        {
            return Math.PI * (Math.Pow(radius, 2));
        }
    }
}
