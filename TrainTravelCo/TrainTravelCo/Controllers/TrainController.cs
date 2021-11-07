using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainTravelCo.Data;
using TrainTravelCo.Managers;
using TrainTravelCo.Models;

namespace TrainTravelCo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TrainController : ControllerBase
    {
        private TrainManager _instanceTrainManager;
        public TrainController()
        {
            _instanceTrainManager = new();
        }
        [HttpGet]
        public List<Train> GetTrainList()
        {
            return _instanceTrainManager.GetTrainListViaManager();
        }
        [HttpPost]
        public IActionResult CreateTrain(Train train)
        {
            _instanceTrainManager.CreateTrainViaManager(train);
            return Content("Train created and added to list.");
        }

    }
}
