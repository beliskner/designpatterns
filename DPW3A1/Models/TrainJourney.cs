using System;
using System.Collections.Generic;
using System.Linq;
using DPW3A1.Models;
using DPW3A1.ObserverModels;

namespace DPW3A1
{
    public class TrainJourney : ITrainJourney
    {
        public List<ITrainDisplay> Observers { get; set; }
        public TrainStation CurrentStation { get; set; }
        public List<TrainStation> Stations { get; set; }
        
        public TrainJourney()
        {
            Observers = new List<ITrainDisplay>();
            Stations = new List<TrainStation>
            {
                new ("Anna Paulowna", "1b", DateTime.Now.AddMinutes(5), DateTime.Now.AddMinutes(35)),
                new ("Hoorn", "9¾", DateTime.Now.AddMinutes(10), DateTime.Now.AddMinutes(40)),
                new ("Purmerend", "3a", DateTime.Now.AddMinutes(2), DateTime.Now.AddMinutes(10))
            };
            CurrentStation = Stations[0];
        }

        public void AddObserver(ITrainDisplay trainDisplay)
        {
            Observers.Add(trainDisplay);
        }

        public void RemoveObserver(ITrainDisplay trainDisplay)
        {
            Observers.Remove(trainDisplay);
        }

        public void ChangeStation()
        {
            CurrentStation = Stations.SkipWhile(x => x != CurrentStation).Skip(1).DefaultIfEmpty(Stations[0]).FirstOrDefault();
            foreach (var observer in Observers)
            {
                observer.Update(CurrentStation);
            }
        }
    }
}