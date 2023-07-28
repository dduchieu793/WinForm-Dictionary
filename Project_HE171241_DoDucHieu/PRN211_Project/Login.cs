using PRN211_Project.Models;

namespace PRN211_Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Please fill out all field(s).");
            }
            else
            {
                User user = checkLogin(username, password);
                if (user != null)
                {
                    Session.Username = username;
                    Session.Password = password;
                    if (user.IsAdmin == 1)
                    {
                        frmAdminHome adminHome = new frmAdminHome();
                        adminHome.Show();
                    }
                    else
                    {
                        frmHome home = new frmHome();
                        home.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong username or password.");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            register.Show();
            this.Hide();
        }

        private User checkLogin(string username, string password)
        {
            using (var context = new PRN211_ProjectContext())
            {
                return context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            }
        }
    }
}