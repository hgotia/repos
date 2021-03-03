using System;
using System.Collections.Generic;
using System.Text;
using Enumerations;

namespace Ex7AMilitaryUnit
{
    public class PointOfContact : Person
    {
        public Sites Site { get; set; }

        public string PersonnelType = "Point of contact";

        public PointOfContact(string fname, string lname, branch branch, Sites loc)
        {
            base.FirstName = fname;
            base.LastName = lname;
            base.Branch = branch;
            this.Site = loc;
        }

        public override void Introduce()
        {
            Console.WriteLine($"My name is {FirstName} {LastName}. I will be your Point of contact for {Site}");
        }
    }
}
