using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainTravelCo.Data;
using TrainTravelCo.Models;

namespace TrainTravelCo.Managers
{
    public class TripManager
    {
        public List<Trip> GetTripsViaManager()
        {
            return DataStore.Instance.ReturnTripList();
        }

        public bool CreateTripViaManager(Trip tripFromUser)
        {

            foreach (var train in DataStore.Instance.ReturnTrainList())
            {
                if (train.TrainID == tripFromUser.TripTrainID)
                {
                    return DataStore.Instance.AddTripToTripList(tripFromUser);
                }

            }

            Trip trip = new Trip()
            {
                TripDepartsFrom
            }
            return false;
        }


    }
}
