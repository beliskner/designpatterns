using System.ComponentModel;
using System.Windows;
using DPW3A1.Models;
using DPW3A1.ObserverModels;

namespace DPW3A1
{
    public partial class TrainDisplay : Window, ITrainDisplay, INotifyPropertyChanged
    {
        private ITrainJourney _journey;

        public event PropertyChangedEventHandler? PropertyChanged;

        public TrainStation Station { get; set; }
        public TrainDisplay(ITrainJourney journey, TrainStation startStation)
        {
            _journey = journey;
            _journey.AddObserver(this);
            Station = startStation;
            InitializeComponent();
        }

        public void Update(TrainStation station)
        {
            Station = station;
            lblStationName.Content = Station.Name;
            lblStationTrack.Content = Station.ArrivalTrack;
        }
    }
}