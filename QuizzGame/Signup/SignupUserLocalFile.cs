using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using QuizGame.Encryption;
using QuizGame.Signup;

namespace QuizGame.Classes
{
    public class SignupUserLocalFile : ISignupUser
    {
        private bool _success = false;
        private string _errorMessage = "";

        private SymmetrickKeyEncryption _encryption = new SymmetrickKeyEncryption();

        public void AddUser(string username, string password)
        {
            if (username == "" || password == "")
            {
                MessageBox.Show("Fill in both fields!", "Quizz game", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _success = false;
                return;
            }

            List<string> lines = File.ReadAllLines(SongQuiz.LoginFilePath).ToList();

            var user = new User(username, password);

            var encryptedUsername = _encryption.Encrypt(user.Username, _encryption.EncryptionKey);

            foreach (var line in lines)
            {
                if (line.Contains(encryptedUsername))
                {
                    _success = false;
                    _errorMessage = "User already exists!";
                    return;
                }
            }

            var encryptedPassword = _encryption.Encrypt(user.Password, _encryption.EncryptionKey);

            lines.Add($"{encryptedUsername},{encryptedPassword}");

            File.WriteAllLines(SongQuiz.LoginFilePath, lines);

            _success = true;
            _errorMessage = "";
        }

        public bool IsSuccess()
        {
            return _success;
        }

        public string ErrorMessage()
        {
            return _errorMessage;
        }
    }
}
