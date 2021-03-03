using System;
using Enumerations;

namespace Ex7AMilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get POC name
            CreatePointOfContact();

            // Set the mission
            SetMission();

            // Collect team members for the mission
            Employee[] DriveTeam = CreateTeam();

            // Have the team introduce themselves
            TeamIntroduction(DriveTeam);

            //Prepare the vehicles
            PrepareVehicles();
        }

        private static void CreatePointOfContact()
        {
            PointOfContact POC1 = new PointOfContact("Eddie", "Seabrook", branch.Navy, Enumerations.Sites.Camp_Smith);
            POC1.Introduce();
            Console.WriteLine();
        }

        private static void SetMission()
        {
            BloodDrive CampSmith23FEB2021 = new BloodDrive();
            CampSmith23FEB2021.SetBloodDrive(Enumerations.Sites.Camp_Smith, 50);
            CampSmith23FEB2021.EmployeesRequired(6);
            CampSmith23FEB2021.StateObjective();
            Console.WriteLine();
        }

        private static Employee[] CreateTeam()
        {
            return new Employee[6]
            {
            new Employee("Cam", "Maiear", branch.Army, rank.SGT),
            new Employee("Royal", "MacNaoimhin", branch.Army, rank.SPC),
            new Employee("Yona", "Burnham", branch.Army, rank.PFC),
            new Employee("Radha", "Georgiou", branch.Army, rank.SPC),
            new Employee("Paget", "Alvey", branch.Army, rank.SPC),
            new Employee("Kameron", "Boyce", branch.Army, rank.SSG)
            };
        }

        private static void TeamIntroduction(Employee[] DriveTeam)
        {
            foreach (var item in DriveTeam)
            {
                item.Introduce();
            }
        }

        private static void PrepareVehicles()
        {
            Truck BreadTruck = new Truck();
            BreadTruck.setMileage(1000);
            BreadTruck.SetVehicle("Freightliner", 2018);
            BreadTruck.StartEngine();
            BreadTruck.VehicleStatus();

            Van WhiteVan = new Van();
            WhiteVan.setMileage(20000);
            WhiteVan.SetVehicle("Chevrolet", 2019);
            WhiteVan.VehicleStatus();
        }
    }
}
