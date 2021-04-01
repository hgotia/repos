using System;
using System.Collections.Generic;
using System.Linq;

namespace VectorDistanceCalculator
{
    class TwoDimensionDistanceCalc
    {
        static void Main(string[] args)
        {
            //set the number of points to generate
            int points = 100;

            //create collection of points
            Point[] pointsCollection = createCollection(points);

            //iterate through the list, calculate the distances between each pair, and return the closest 2 points 
            Console.WriteLine($"{points} 2D points\n");
            calculateManyDistances(points, pointsCollection);
        }

        private static void calculateManyDistances(int points, Point[] pointsCollection)
        {
            double minDistance = double.MaxValue;
            Point minPoint1 = new Point();
            Point minPoint2 = new Point();
            int idx1 = 0;
            int idx2 = 0;

            for (int i = 0; i < points; i++)
            {
                for (int j = i; j < points; j++)             
                {
                    if (i == j)
                    {
                        continue;
                    }

                    double distance = calculateDistance(pointsCollection[i], pointsCollection[j]);
                    
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        minPoint1 = pointsCollection[i];
                        idx1 = i + 1;
                        minPoint2 = pointsCollection[j];
                        idx2 = j + 1;
                    }
                }
            }
            Console.WriteLine($"The shortest distance between 2 points:\nDistance: {minDistance:0.000} \nPoint {idx1}: {minPoint1.x},{minPoint1.y}\nPoint {idx2}: {minPoint2.x},{minPoint2.y}\n");                                                                                                             
        }

        private static double calculateDistance(Point point1, Point point2)
        {
            int radicand = (int)Math.Pow((point1.x - point2.x), 2) +
                           (int)Math.Pow((point1.y - point2.y), 2);

            double distance = Math.Sqrt(radicand);

            return distance;
        }

        private static Point[] createCollection(int points)
        {
            Point[] pointsCollection = new Point[points];
            int count = 0;

            for (int i = 1; i <= points; i++)
            {
                pointsCollection[count] = new Point();
                count++;
            }

            return pointsCollection;
        }
    }

    class Point
    {
        Random rand = new Random();
        private int _x, _y;

        public int x
        {
            get { return _x; }
        }

        public int y
        {
            get { return _y; }
        }

        public Point()
        {
            _x = rand.Next(1, 101);
            _y = rand.Next(1, 101);
        }
    }
}
