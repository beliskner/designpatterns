using System;

namespace DPW2A3
{
    public class FancyMP3Display : IObserver
    {
        public FancyMP3Display(IObservable player)
        {
            player.AddObserver(this);
        }
        
        public void Update(Song song)
        {
            Console.WriteLine($"Fancy display: {song.Title} by {song.Artist} {song.Duration}");
        }
    }
}