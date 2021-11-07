using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainTravelCo.Models;
using Microsoft.AspNetCore.Http;


namespace TrainTravelCo.Data
{
    public class DataStore
    {
        private static DataStore _instance = null;
        private static List<Train> TrainList = new();
        private static List<Trip> TripList = new();
        private static List<Booking> BookingList = new();

        
        private DataStore()
        {
        }
        public static DataStore Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataStore();
                    
                }
                return _instance;
            }
        }
        public List<Train> ReturnTrainList() 
        {
            return TrainList;
        }
        public void AddTrainToTrainList(Train train)
        {
            TrainList.Add(train);
        }
        public List<Trip> ReturnTripList()
        {
            return TripList;
        }
        public bool AddTripToTripList(Trip trip) 
        {
            TripList.Add(trip);
            return true;           
        }
        public List<Booking> ReturnBookingList()
        {
            return BookingList;
        }
        public bool AddTripToBookingList(Booking booking)
        {
            BookingList.Add(booking);
            return true;
        }
    }
}
