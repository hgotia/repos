using System;
using System.Collections.Generic;

#nullable disable

namespace BikeRentals.models
{
    public partial class BikeStatus
    {
        public BikeStatus()
        {
            Bikes = new HashSet<Bike>();
        }

        public string BikeStats { get; set; }

        public virtual ICollection<Bike> Bikes { get; set; }
    }
}
