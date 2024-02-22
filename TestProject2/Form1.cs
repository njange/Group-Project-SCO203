namespace SCO203
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        internal static void Login_Click(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void Login_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;
            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}