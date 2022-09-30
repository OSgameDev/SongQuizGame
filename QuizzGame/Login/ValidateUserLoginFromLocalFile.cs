using System.Collections.Generic;
using System.IO;
using System.Linq;
using QuizGame.Encryption;
using QuizGame.Classes;

namespace QuizGame.Login
{
    public class ValidateUserLoginFromLocalFile : IValidateUser
    {
        private SymmetrickKeyEncryption _encryption = new SymmetrickKeyEncryption();

        public bool ValidateUser(string username, string password)
        {
            List<string> passLines = File.ReadAllLines(SongQuiz.LoginFilePath).ToList();
            List<User> users = new List<User>();

            foreach (string line in passLines)
            {
                string[] strings = line.Split(',');

                var encryptedUsername = _encryption.Encrypt(username, _encryption.EncryptionKey);
                var encryptedPassword = _encryption.Encrypt(password, _encryption.EncryptionKey);

                if (strings[0] == encryptedUsername && strings[1] == encryptedPassword)
                {
                    return true;
                }
            }

            return false;
        }
    }
    
}
