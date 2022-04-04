using System;

namespace DPW2A3
{
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public TimeSpan Duration { get; set; }
    
        public Song(string title, string artist, TimeSpan duration)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
        }
    }
}