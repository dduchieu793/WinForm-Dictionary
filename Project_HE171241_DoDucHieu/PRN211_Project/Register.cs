using PRN211_Project.Models;

namespace PRN211_Project
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string repassword = txtRepassword.Text;
            if (username.Equals("") || password.Equals("") || repassword.Equals(""))
            {
                MessageBox.Show("Please fill out all required field(s).");
            }
            else
            {
                if (checkDuplicate(username))
                {
                    MessageBox.Show("Username has already existed.");
                }
                else
                {
                    if (!checkPassword(password))
                    {
                        MessageBox.Show("Password must be at least 8 characters including letters and digits.");
                    }
                    else
                    {
                        if (!repassword.Equals(password))
                        {
                            MessageBox.Show("Re-password must equal password.");
                        }
                        else
                        {
                            RegisterToDatabase(username, password);
                        }
                    }
                }
            }
        }

        private void RegisterToDatabase(string username, string password)
        {
            using (var context = new PRN211_ProjectContext())
            {
                User user = new User()
                {
                    Username = username,
                    Password = password,
                };

                context.Users.Add(user);
                if (context.SaveChanges() > 0)
                {
                    Session.Username = username;
                    Session.Password = password;
                    frmHome home = new frmHome();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Register error.");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Hide();
        }

        private bool checkDuplicate(string username)
        {
            using (var context = new PRN211_ProjectContext())
            {
                User user = context.Users.FirstOrDefault(x => x.Username == username);
                if (user != null)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool checkPassword(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            if (!isIncludedDigit(password) || !isIncludedLetter(password))
            {
                return false;
            }
            return true;
        }

        private static bool isIncludedDigit(string s)
        {
            foreach (char c in s)
            {
                if (Char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }


        private static bool isIncludedLetter(string s)
        {
            foreach (char c in s)
            {
                if (Char.IsLetter(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
