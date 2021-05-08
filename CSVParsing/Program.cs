using System;
using System.Collections.Generic;
using System.IO;

namespace CSVParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading CSV with embedded commas:");
            getCSV();
        }
        private static List<string> getCSV()
        {
            StreamReader sb = new StreamReader("C:/Users/TIM ASUS/Desktop/pres-test.csv");
            List<string> list = new List<string>();

            while (!sb.EndOfStream)
            {
                var line = sb.ReadLine();
                string[] separators = new string[] { "\n", "\",", ",\"", "\"" };
                var values = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                Console.WriteLine($"\nCurrent input is {line}");
                Console.WriteLine($"This line has {values.Length} fields\n");

                foreach (var item in values)
                {
                    list.Add(item);
                    Console.WriteLine(item);
                }
            }

            return list;
        }
    }
}
