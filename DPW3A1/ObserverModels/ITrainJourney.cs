using System.Collections.Generic;
using DPW3A1.Models;

namespace DPW3A1.ObserverModels
{
    public interface ITrainJourney
    {
        TrainStation CurrentStation { get; }
        List<TrainStation> Stations { get; }
        void AddObserver(ITrainDisplay trainDisplay);
        void RemoveObserver(ITrainDisplay trainDisplay);
        void ChangeStation();
    }
}