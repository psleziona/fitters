namespace Fitters
{
    public delegate void CloseWelcomeScreen();
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(new CloseWelcomeScreen(CloseWindow));
            loginForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void CloseWindow()
        {
            this.Dispose();
        }
    }
}