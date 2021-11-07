using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainTravelCo.Models
{
    public class Train
    {
        public int TrainID { get; private set; }
        public int RegNumber { get; set; }
        public int maxSeatingCapacity { get; set; }
        private static int _idCounter = 0;
        public Train()
        {
            _idCounter += 1;
            TrainID = _idCounter;
        }
    }
}
