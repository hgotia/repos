using System;
using System.Collections.Generic;
using System.Text;
using Enumerations;

namespace Ex7AMilitaryUnit
{
    public abstract class Vehicle
    {
        private int _mileage { get; set; }
        public string Model;
        public int Year;
        public bool EngineRunning = false;

        public void setMileage(int mileage)
        {
            _mileage = mileage;
        }

        public void fillGas(int volumeLiters, gas gas)
        {
            Console.WriteLine($"Filling vehicle with {volumeLiters} liters of {gas}");
        }

        public void SetVehicle(string model, int year)
        {
            this.Model = model;
            this.Year = year;
        }

        public virtual void Honk()
        {
            Console.WriteLine("BEEP BEEP!");
        }

        public void StartEngine()
        {
            EngineRunning = true;
        }

        public void VehicleStatus()
        {
            if (EngineRunning == true) Console.WriteLine("Engine is running");
            else Console.WriteLine("Engine is switched off");
        }
    }
}
