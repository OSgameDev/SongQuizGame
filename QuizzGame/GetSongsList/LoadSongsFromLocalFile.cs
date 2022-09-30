using System.Collections.Generic;
using System.IO;
using System.Linq;
using QuizGame.GetSongsList;

namespace QuizGame.Classes
{
    public class LoadSongsFromLocalFile : ILoadSongsList
    {
        public List<Song> LoadSongsToList()
        {
            List<string> lines = File.ReadAllLines(SongQuiz.SongsFilePath).ToList();
            var songsList = new List<Song>();

            foreach (var line in lines)
            {
               string[] strings = line.Split(',');

                Song newSong = new Song(strings[0], strings[1]);

                songsList.Add(newSong);
            }

            return songsList;
        }
    }
}
