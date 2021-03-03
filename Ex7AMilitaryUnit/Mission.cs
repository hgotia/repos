using System;
using System.Collections.Generic;
using System.Text;

namespace Ex7AMilitaryUnit
{
    public class Mission
    {
        public int Distance { get; set; }
        public int NumEmployeesRequired { get; set; }
        public string Objective { get; set; }

        public virtual void SetObjective(string objectiveDescription)
        {
            Objective = objectiveDescription;
        }

        public void EmployeesRequired(int numberOfEmployees)
        {
            NumEmployeesRequired = numberOfEmployees;
            Console.WriteLine($"We are going to need {numberOfEmployees} for this mission");
        }
    }
}
