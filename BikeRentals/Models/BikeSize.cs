using System;
using System.Collections.Generic;

#nullable disable

namespace BikeRentals.models
{
    public partial class BikeSize
    {
        public BikeSize()
        {
            Bikes = new HashSet<Bike>();
        }

        public string BikeSize1 { get; set; }

        public virtual ICollection<Bike> Bikes { get; set; }
    }
}
