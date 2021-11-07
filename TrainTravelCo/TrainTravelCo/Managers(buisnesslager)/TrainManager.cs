using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainTravelCo.Data;
using TrainTravelCo.Models;
using Microsoft.AspNetCore.Mvc;


namespace TrainTravelCo.Managers
{
    public class TrainManager
    {
        public List<Train> GetTrainListViaManager()
        {
            return DataStore.Instance.ReturnTrainList();
        }
        
        public void CreateTrainViaManager(Train train)
        {
            DataStore.Instance.AddTrainToTrainList(train);            
        }
    }
}
