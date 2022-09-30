using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QuizGame.Models;
using QuizGame.SongListLoader;

namespace QuizGame.Forms
{
    public partial class GameForm : Form
    {
        private LoadSongsFromLocalFile _songsLoader = new LoadSongsFromLocalFile(); 

        private List<Song> _songs = new List<Song>();

        private Song _currentSong;

        private int _livesCounter = 2;
        private int _songIndex = 0;
        private int _scoreCounter = 0;
        private int _lostCounter = 0;

        public GameForm()
        {
            InitializeComponent();
        }

        private string GetFirstLettersOfSongName()
        {
            var chars = new char[32];

            string[] words = _currentSong.SongName.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                chars[i] = words[i][0];
                chars[i] = Char.ToUpper(chars[i]);
            }

            return new string(chars);
        }

        private void LoadNewSong(int index)
        {
            if (index > _songs.Count) return;

            _currentSong = _songs[index];

            FirstLettersOfSongNameWords.Text = ($"First Letters of each word: {GetFirstLettersOfSongName()}");
            NameOfArtist.Text = ($"Name of artist: {_currentSong.ArtistName}");
        }

        #region (for testing) hide and show
        private void HideAll()
        {
            SongGuess.Visible = false;
            FirstLettersOfSongNameWords.Visible = false;
            NameOfArtist.Visible = false;
            SubmitButton.Visible = false;
        }

        private void ShowAll()
        {
            SongGuess.Visible = true;
            FirstLettersOfSongNameWords.Visible = true;
            NameOfArtist.Visible = true;
            //SubmitButton.Visible = true;
        }
        #endregion

        private void GameForm_Load(object sender, EventArgs e)
        {
            _songs = _songsLoader.LoadSongsToList();

            _currentSong = _songs[_songIndex];

            LoadNewSong(_songIndex);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (SongGuess.Text.ToLower() == _currentSong.SongName.ToLower())
            {
                if (_livesCounter == 2) _scoreCounter += 3;
                else if(_livesCounter == 1) _scoreCounter += 1;

                ScoreLabel.Text = ($"Score :{_scoreCounter}");

                _songIndex += 1;
                LoadNewSong(_songIndex);

                SongGuess.Text = "";
            }
            else
            {
                _livesCounter--;
                LivesLabel.Text = ($"Lives: {_livesCounter}");
                LivesLabel.ForeColor = Color.Red;

                _songIndex += 1;
                LoadNewSong(_songIndex);
                SongGuess.Text = "";
            }
            if (_livesCounter == 0)
            {
                _lostCounter += 1;
                LostLabel.Text = ($"Lost: {_lostCounter}");

                _livesCounter = 2;
                LivesLabel.Text = ($"Lives: {_livesCounter}");
                LivesLabel.ForeColor = Color.Lime;
            }
        }

        private void ScoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void FirstLettersOfSongNameWords_Click(object sender, EventArgs e)
        {

        }
    }
}
