using System.Collections.Generic;
using QuizGame.Models;

namespace QuizGame.SongListLoader
{
    public interface ILoadSongsList
    {
        List<Song> LoadSongsToList();
    }
}
