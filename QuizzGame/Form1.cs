using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using QuizGame.Forms;

namespace QuizGame
{
    public partial class SongQuiz : Form
    {
        public static string LoginFilePath = "LoginData.QuizGame";
        public static string SongsFilePath = "SongsList.QuizGame";

        public SongQuiz()
        {
            InitializeComponent();
        }


        #region Make form movable without border
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void ProjectInit()
        {
            CheckForIllegalCrossThreadCalls = false;

            if (!File.Exists(SongsFilePath))
            {
                StreamWriter streamWriter = File.CreateText(SongsFilePath);

                streamWriter.Flush();
                streamWriter.Dispose();
            }

            if (!File.Exists(LoginFilePath))
            {
                StreamWriter streamWriter = File.CreateText(LoginFilePath);

                streamWriter.Flush();
                streamWriter.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProjectInit();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.ShowDialog();
        }

        #region Winforms undeletable(it can be but causes errors and long time to fix "by removing events") generated rubbish
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
