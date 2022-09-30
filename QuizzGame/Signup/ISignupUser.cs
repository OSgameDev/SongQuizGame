
namespace QuizGame.Signup
{
    public interface ISignupUser
    {
        void AddUser(string username, string password);
        bool IsSuccess();
        string ErrorMessage();
    }
}
