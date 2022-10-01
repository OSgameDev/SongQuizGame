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

        private List<Song> _songsList = new List<Song>();

        private Song _currentSong;

        private Random _random = new Random();

        private int _songIndex = 0;
        private int _generatedIndex = 0;
        private int _livesCounter = 2;
        private int _scoreCounter = 0;
        private int _lostCounter = 0;

        private bool _isLoadedFirstSong = false;
        private bool _isWentBack = false;

        public GameForm()
        {
            InitializeComponent();
        }

        private void GameFinished()
        {
            FirstLettersOfSongNameWords.Text = "You have finished the game!";
            FirstLettersOfSongNameWords.ForeColor = Color.Green;
            FirstLettersOfSongNameWords.Location = new Point(150, 190);

            NameOfArtist.Text = "";

            SubmitButton.Visible = false;
            SongGuess.Visible = false;
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
            if(index == _generatedIndex && _isLoadedFirstSong)
            {
                GameFinished();
                return;
            }

            if(!_isWentBack && index >= _songsList.Count)
            {
                index = 0;
                _songIndex = 0;
                _isWentBack = true;
            }

            if (_isWentBack && index > _generatedIndex)
            {
                _generatedIndex -= 1;
            }

            _currentSong = _songsList[index];

            FirstLettersOfSongNameWords.Text = ($"First Letters of each word: {GetFirstLettersOfSongName()}");
            NameOfArtist.Text = ($"Name of artist: {_currentSong.ArtistName}");

            _isLoadedFirstSong = true;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            _songsList = _songsLoader.LoadSongsToList();

            _generatedIndex = _random.Next(0, _songsList.Count - 1);
            _songIndex = _generatedIndex;

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
