using System;
using System.Collections.Generic;
using System.Linq;

namespace ThreeDimensionDistanceCalculator
{
    class ThreeDimensionDistanceCalc
    {
        static void Main(string[] args)
        {
            //set the number of points
            int points = 1000;

            //create the collection
            threeDPoint[] pointsCollection = createCollection(points);

            //iterate through the list, calculate the distances between them, and return the closest 2 points
            calculateManyDistances(points, pointsCollection);
        }

        private static void calculateManyDistances(int points, threeDPoint[] pointsCollection)
        {
            double minDistance = double.MaxValue;
            threeDPoint minPoint1 = new threeDPoint();
            threeDPoint minPoint2 = new threeDPoint();
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
            Console.WriteLine($"The shortest distance between 2 points:\nDistance: {minDistance:0.00000} \nPoint {idx1}: {minPoint1.x},{minPoint1.y},{minPoint1.z}\nPoint {idx2}: {minPoint2.x},{minPoint2.y},{minPoint2.z}\n");
        }

        private static double calculateDistance(threeDPoint point1, threeDPoint point2)
        {
            int radicand = (int)Math.Pow((point1.x - point2.x), 2) +
                           (int)Math.Pow((point1.y - point2.y), 2) +
                           (int)Math.Pow((point1.z - point2.z), 2);

            double distance = Math.Sqrt(radicand);

            return distance;
        }

        private static threeDPoint[] createCollection(int points)
        {
            threeDPoint[] pointsCollection = new threeDPoint[points];
            int count = 0;

            for (int i = 1; i <= points; i++)
            {
                pointsCollection[count] = new threeDPoint();
                count++;
            }

            return pointsCollection;
        }
    }
    class threeDPoint
    {
        Random rand = new Random();
        private int _x, _y, _z;

        public int x
        {
            get { return _x; }
        }

        public int y
        {
            get { return _y; }
        }

        public int z
        {
            get { return _z; }
        }

        public threeDPoint()
        {
            _x = rand.Next(1, 1001);
            _y = rand.Next(1, 1001);
            _z = rand.Next(1, 1001);
        }
    }
}
