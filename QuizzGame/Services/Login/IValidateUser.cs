using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Login
{
    public interface IValidateUser
    {
        bool ValidateUser(string username, string password);
    }
}
