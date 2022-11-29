namespace PresentationLayer
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SignUp login = new SignUp();
            login.Show();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}