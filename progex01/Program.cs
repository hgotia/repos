using System;

namespace progex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPart 1, circumference and area of a circle.");

            try
            {
                string strradius = GetValue();

                //// Implementation of radius here
                int intradius = int.Parse(strradius);
                double circumference = checked(2 * Math.PI * intradius);

                Console.WriteLine($"The circumference is {circumference}");

                double area = checked(Math.PI * Math.Pow(intradius, 2));
                Console.WriteLine($"The area is {area}");

                //// Implementation of hemisphere here
                Console.WriteLine("\nPart 2, volume of a hemisphere.");

                double volume = checked((Math.PI * Math.Pow(intradius, 3) * 4 / 3) / 2);
                Console.WriteLine($"The volume is {volume}");

                //// Implementation triangle here
                Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");

                Console.Write("Enter an integer for side a: ");
                int intA = int.Parse(GetValue());
                Console.Write("Enter an integer for side b: ");
                int intB = int.Parse(GetValue());
                Console.Write("Enter an integer for side c: ");
                int intC = int.Parse(GetValue());

                double halfCirc = checked((double)(intA + intB + intC) / 2);
                double triangleArea = checked(Math.Sqrt(halfCirc * (halfCirc - intA) * (halfCirc - intA) * (halfCirc - intA)));
                Console.WriteLine($"The area of the triangle is {triangleArea}");

                //// Implementation of quadratic formula here
                Console.WriteLine("\nPart 4, solving a quadratic equation.");

                Console.WriteLine("Given the algorithm: ax^2 + bx + c = 0, provide the values for a, b, and c below: ");
                Console.Write("Enter an integer for a: ");
                int coEffA = int.Parse(GetValue());
                Console.Write("Enter an integer for b: ");
                int coEffB = int.Parse(GetValue());
                Console.Write("Enter an integer for c: ");
                int coEffC = int.Parse(GetValue());

                //double rootOne = (double)((-1 * coEffB) + (Math.Sqrt(Math.Pow(coEffB,2)-4*coEffA*coEffC))/2*coEffA);
                //Console.WriteLine(rootOne);

                double denominator = checked((double)2 * coEffA);
                double leftSide = checked((double)-coEffB / denominator);
                double rightSide = checked((double)Math.Pow(coEffB, 2) - (4 * coEffA * coEffC));

                // My way of dealing with the sqrt of a negative number is to not calculate it at all and just represent it as is.

                Console.WriteLine($"\nUsing the Quadratic Formula where a={coEffA}, b={coEffB}, and c={coEffC},");
                Console.WriteLine($"The positive solution is {leftSide} + (\u221A({rightSide})) / {denominator}");
                Console.WriteLine($"The negative solution is {leftSide} - (\u221A({rightSide})) / {denominator}");

            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            finally
            {
                Console.WriteLine("\nThis program has finally terminated.");
            }
        }

        private static string GetValue()
        {
            string number = Console.ReadLine();

            while (int.Parse(number) < 1)
            {
                Console.WriteLine("\nEnter only integers greater than 0.");
                GetValue();
            }
            return number;
        }
    }
}
