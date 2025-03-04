namespace WelcomeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = textBox2.Text;

            if (userName == "admin" && password == "admin")
            {
                label4.Text = "Successfully logged in!";
            }
            else
            {
                label4.Text = "Username or password is incorrect!";
            }
        }
    }
}
