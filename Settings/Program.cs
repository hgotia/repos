using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Settings
{
    class Program
    {
        static void ReadSingleValueFromAppsettings()
        {
            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(path: "mysetting.json", optional: true, reloadOnChange: true);
            IConfiguration configuration = configBuilder.Build();

            string x = configuration.GetValue<string>("Mssa:Lunch");

            Console.WriteLine(x);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("settings.Program.Main()");
            ReadSingleValueFromAppsettings();
        }
    }
}
