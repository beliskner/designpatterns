using DPW3A1.Models;

namespace DPW3A1.ObserverModels
{
    public interface ITrainDisplay
    {
        TrainStation Station { get; set; }
        void Update(TrainStation station);
    }
}