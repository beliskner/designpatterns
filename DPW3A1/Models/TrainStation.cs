using System;

namespace DPW3A1.Models
{
    public class TrainStation
    {
        public string Name { get; set; }
        public string ArrivalTrack { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
        
        public TrainStation(string name, string arrivalTrack, DateTime arrivalTime, DateTime departureTime)
        {
            Name = name;
            ArrivalTrack = arrivalTrack;
            ArrivalTime = arrivalTime;
            DepartureTime = departureTime;
        }
    }
}