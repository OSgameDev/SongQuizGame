using System;
using System.Windows.Forms;
using QuizGame.Models;
using QuizGame.Signup;

namespace QuizGame.Forms
{
    public partial class SignupForm : Form
    {
        private SignupUserLocalFile _signUpUser = new SignupUserLocalFile();

        public SignupForm()
        {
            InitializeComponent();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            _signUpUser.AddUser(UsernameTextbox.Text, PasswordTextbox.Text);
            if (_signUpUser.IsSuccess())
            {
                MessageBox.Show("Signed up successfully!", "Quizz game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UsernameTextbox.Text = "";
                PasswordTextbox.Text = "";

                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show($"{_signUpUser.ErrorMessage()}", "Quizz game", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsernameTextbox.Text = "";
                PasswordTextbox.Text = "";
            }
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
