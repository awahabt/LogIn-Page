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
            if(userName.Text=="Moin" && userPassword.Text == "Moin")
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
    }
}
