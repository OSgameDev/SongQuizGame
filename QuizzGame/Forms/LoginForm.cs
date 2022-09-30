using System;
using System.Windows.Forms;
using QuizGame.Login;

namespace QuizGame.Forms
{
    public partial class LoginForm : Form
    {
        #region Constructor
        public LoginForm()
        {
            InitializeComponent();
        }
        #endregion

        private ValidateUserLoginFromLocalFile _validateUserLogin = new ValidateUserLoginFromLocalFile();

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(UsernameTextbox.Text == "" || PasswordTextbox.Text == "")
            {
                MessageBox.Show("Fill in both fields!", "Quizz game", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_validateUserLogin.ValidateUser(UsernameTextbox.Text, PasswordTextbox.Text))
            {
                UsernameTextbox.Text = "";
                PasswordTextbox.Text = "";
            }

            else
            {
                MessageBox.Show("Username or password is wrong", "Quizz game", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var gameForm = new GameForm();
            gameForm.ShowDialog();

            this.Dispose();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
