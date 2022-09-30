using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Encryption
{
    public interface IEncryption
    {
        string Encrypt(string plainText, string passPhrase);
        string Decrypt(string encryptedText, string passPhrase);
    }
}
