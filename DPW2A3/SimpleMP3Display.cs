using System;

namespace DPW2A3
{
    public class SimpleMP3Display : IObserver
    {
        public SimpleMP3Display(IObservable player)
        {
            player.AddObserver(this);
        }
        
        public void Update(Song song)
        {
            Console.WriteLine($"Simple display: {song.Artist} - {song.Title}");
        }
    }
}