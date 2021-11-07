using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainTravelCo.Models
{
    public class Trip
    {
        public int TripId { get; private set; }
        public string TripDepartsFrom { get; set; }
        public string  TripDestination { get; set; }
        public string  TripDepartureTime { get; set; }
        
        public List<Booking> Bookings { get; set; }

        private static int TripIdCounter = 0;


        public Trip()
        {
            TripId = TripIdCounter++;
            Bookings = new List<Booking>();
        }
    }
}
