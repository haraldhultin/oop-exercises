using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainTravelCo.Models;
using TrainTravelCo.Managers;
using TrainTravelCo.Data;

namespace TrainTravelCo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TripController : ControllerBase
    {
        private TripManager _instanceOfTripManager; 
        public TripController()
        {
            _instanceOfTripManager = new TripManager();
        }
        [HttpGet]
        public List<Trip> GetTrips()
        {
            return DataStore.Instance.ReturnTripList();
        }
        [HttpPost]
        public IActionResult CreateTrip(Trip tripFromUser)
        {
            if(_instanceOfTripManager.CreateTripViaManager(tripFromUser))
            {
            return Ok("Success!");
            }
            return NotFound("Could not book");
        }

    }
}
