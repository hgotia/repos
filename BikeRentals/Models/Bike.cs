using System;
using System.Collections.Generic;

#nullable disable

namespace BikeRentals.models
{
    public partial class Bike
    {
        public int BikeId { get; set; }
        public string BikeStatus { get; set; }
        public string BikeSize { get; set; }

        public virtual BikeSize BikeSizeNavigation { get; set; }
        public virtual BikeStatus BikeStatusNavigation { get; set; }
    }
}
