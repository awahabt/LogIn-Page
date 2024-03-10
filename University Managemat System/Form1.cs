namespace University_Managemat_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            userPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userName.Text == "Wahab" && userPassword.Text == "123")
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter correct User ID");
            }
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
