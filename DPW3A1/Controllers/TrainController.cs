using DPW3A1.ObserverModels;

namespace DPW3A1.Controllers
{
    public class TrainController : ITrainController
    {
        
        private readonly ITrainJourney _trainJourney;

        public TrainController()
        {
            _trainJourney = new TrainJourney();
        }

        public void NextStation()
        {
            _trainJourney.ChangeStation();
        }

        public void NewDisplay()
        {
            var display = new TrainDisplay(_trainJourney, _trainJourney.CurrentStation);
            display.Show();
        }
    }
}