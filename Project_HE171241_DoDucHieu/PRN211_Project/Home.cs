using PRN211_Project.Models;

namespace PRN211_Project
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            //Session.Username = "admin";
            //Session.Password = "he171241";
            if (Session.Username != null)
            {
                btnLogin.Hide();
                btnLogout.Show();
                lblIntro.Text = $"Welcome, {Session.Username}";
                btnCollection.Enabled = true;
                btnAdd.Enabled = true;
                btnHistory.Enabled = true;
                lblNote.Hide();
            }
            else
            {
                btnLogin.Show();
                btnLogout.Hide();
                btnCollection.Enabled = false;
                btnAdd.Enabled = false;
                btnHistory.Enabled = false;
                lblNote.Show();
            }
        }

        private void btnCollection_Click(object sender, EventArgs e)
        {
            using (var context = new PRN211_ProjectContext())
            {
                var collection = (from u in context.Users
                                  from w in u.Ids
                                  join c in context.Words on w.Id equals c.Id
                                  where u.Username == Session.Username
                                  orderby c.Name, c.Type.Name
                                  select new
                                  {
                                      Id = c.Id,
                                      Name = c.Name,
                                      Type = c.Type.Name,
                                      Meaning = c.Meaning,

                                  }).ToList();
                dgWords.DataSource = collection;
                dgWords.Columns["Id"].Visible = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Username = null;
            Session.Password = null;
            frmHome home = new frmHome();
            home.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (var context = new PRN211_ProjectContext())
            {
                var wordList = (from w in context.Words
                                where w.Name.StartsWith(txtSearch.Text) && (w.Username == null || w.Username == Session.Username)
                                orderby w.Name, w.Type.Name
                                select new
                                {
                                    Id = w.Id,
                                    Name = w.Name,
                                    Type = w.Type.Name,
                                    Meaning = w.Meaning,
                                })
                           .ToList();
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    if (Session.Username != null)
                    {
                        dgWords.DataSource = wordList;
                        dgWords.Columns["Id"].Visible = false;
                    }
                    else
                    {
                        dgWords.DataSource = wordList;
                        dgWords.Columns["Id"].Visible = false;
                    }
                }
                else
                {
                    dgWords.DataSource = null;
                    dgWords.Rows.Clear();
                }
            }
        }

        private void dgWords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int id = Convert.ToInt32(dgWords.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                frmWordDetail wordDetail = new frmWordDetail(id, Session.Username);
                wordDetail.Show();
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            using (var context = new PRN211_ProjectContext())
            {
                var historyList = (from h in context.Histories
                                   where h.Username == Session.Username
                                   from w in context.Words
                                   where w.Id == h.Id
                                   orderby h.Addtime.ToString() descending
                                   select new
                                   {
                                       Id = h.Id,
                                       Name = w.Name,
                                       Type = w.Type.Name,
                                       Meaning = w.Meaning
                                   })
                           .ToList();
                dgWords.DataSource = historyList;
                dgWords.Columns["Id"].Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmClientAdd clientAdd = new frmClientAdd(0, "add", "");
            clientAdd.Show();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            using (var context = new PRN211_ProjectContext())
            {
                var wordList = (from w in context.Words
                                where w.Name.StartsWith(txtSearch.Text) && (w.Username == null || w.Username == Session.Username)
                                orderby w.Name, w.Type.Name
                                select new
                                {
                                    Id = w.Id,
                                    Name = w.Name,
                                    Type = w.Type.Name,
                                    Meaning = w.Meaning,
                                })
                           .ToList();
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    if (Session.Username != null)
                    {
                        if (wordList.Count == 0)
                        {

                            DialogResult dialogResult = MessageBox.Show("Word is not in dictionary. Do you want to add?", "Add or not", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                frmClientAdd clientAdd = new frmClientAdd(0, "add", txtSearch.Text);
                                clientAdd.Show();
                            }
                        }
                        else
                        {
                            dgWords.DataSource = wordList;
                            dgWords.Columns["Id"].Visible = false;
                        }
                    }
                    else
                    {
                        dgWords.DataSource = wordList;
                        dgWords.Columns["Id"].Visible = false;
                    }
                }
                else
                {
                    dgWords.DataSource = null;
                    dgWords.Rows.Clear();
                }
            }
        }
    }
}
