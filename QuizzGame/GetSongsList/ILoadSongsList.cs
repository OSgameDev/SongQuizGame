using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizGame.Classes;

namespace QuizGame.GetSongsList
{
    public interface ILoadSongsList
    {
        List<Song> LoadSongsToList();
    }
}
