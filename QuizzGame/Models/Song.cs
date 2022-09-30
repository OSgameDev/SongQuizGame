using System;

namespace QuizGame.Models
{
    public class Song
    {
        public string SongName = "";
        public string ArtistName = "";

        public Song(string songName, string artistName)
        {
            SongName = songName;
            ArtistName = artistName;
        }
    }
}
