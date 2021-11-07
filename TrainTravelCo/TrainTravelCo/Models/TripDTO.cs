using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrainTravelCo.Models
{
    public class TripDTO
    {

        [Required]
        public string TripDepartsFrom { get; set; }
        [Required]
        public string TripDestination { get; set; }
        [Required]
        public string TripDepartureTime { get; set; }
        [Required]
        public int TripTrainID { get; set; }


    }
}
