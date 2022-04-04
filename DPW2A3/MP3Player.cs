using System;
using System.Collections.Generic;

namespace DPW2A3
{
    public class MP3Player : IObservable
    {
        private List<IObserver> Displays = new List<IObserver>();
        public Song CurrentSong { get; private set; }

        public List<Song> Songs = new()
        {
            new Song("Papillon", "Editors", new TimeSpan(0, 5, 24)),
            new Song("Wish You Were Here", "Pink Floyd", new TimeSpan(0, 5, 39)),
            new Song("Dazed And Confused", "Led Zeppelin", new TimeSpan(0, 6, 26)),
            new Song("Billionaire", "Bruno Mars", new TimeSpan(0, 3, 31))
        };

        public void NextSong()
        {
            var rnd = new Random();
            CurrentSong = Songs[rnd.Next(Songs.Count)];
            foreach (var display in Displays)
            {
                display.Update(CurrentSong);
            }
        }

        public void AddObserver(IObserver observer)
        {
            Displays.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Displays.Remove(observer);
        }
    }
}