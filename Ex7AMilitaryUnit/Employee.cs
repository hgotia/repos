using System;
using System.Collections.Generic;
using System.Text;
using Enumerations;

namespace Ex7AMilitaryUnit
{
    public class Employee : Person
    {
       public string PersonnelType = "Employee";

       private rank _rank { get; set; }

       public Employee(string fname, string lname, branch branch, rank rank)
       {
           base.FirstName = fname;
           base.LastName = lname;
           base.Branch = branch;
           this._rank = rank;
       }

        public override void Introduce()
        {
           Console.WriteLine($"My name is {_rank} {FirstName} {LastName} from the {Branch}");
        }
    }
}
