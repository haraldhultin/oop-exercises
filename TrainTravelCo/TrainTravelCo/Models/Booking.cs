using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainTravelCo.Models
{
    public class Booking
    {
        public Customer BookingCustomer { get; set; }
        public Trip BookingTrip { get; set;}
    }
}
