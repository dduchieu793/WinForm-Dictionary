using Microsoft.EntityFrameworkCore;
using PRN211_Project.Models;

namespace PRN211_Project
{
    public partial class frmWordDetail : Form
    {
        public frmWordDetail(int id, string username)
        {
            InitializeComponent();
            LoadData(id, username);
            if (username == null)
            {
                btnDislike.Hide();
                btnLike.Hide();
                btnUpdate.Hide();
                btnDelete.Hide();
            }
        }

        public static int tmpId;
        public static string tmpUsername;
        private void LoadData(int id, string username)
        {
            tmpId = id;
            tmpUsername = username;
            using (var context = new PRN211_ProjectContext())
            {
                Word w = context.Words.FirstOrDefault(w => w.Id == id);
                if (w != null)
                {
                    lblName.Text = w.Name;
                    Models.Type type = context.Types.FirstOrDefault(t => t.Id == w.TypeId);
                    lblType.Text = type.Name;
                    txtMeaning.Text = w.Meaning;

                    List<long> listIds = context.Synonyms
                        .Where(s => s.FirstId == id)
                        .Select(s => s.SecondId)
                        .ToList();
                    List<Word> listWord = new List<Word>();
                    foreach (var k in listIds)
                    {
                        listWord.Add(context.Words.FirstOrDefault(w => w.Id == k));
                    }
                    dgSynonym.DataSource = listWord;
                    dgSynonym.Columns["Id"].Visible = false;
                }
                if (username != null)
                {
                    History history = context.Histories.FirstOrDefault(h => h.Username.Equals(username) && h.Id == id);
                    if (history != null)
                    {
                        context.Histories.Remove(history);
                        if (context.SaveChanges() < 0)
                        {
                            MessageBox.Show("Error.");
                        }
                    }
                    history = new History()
                    {
                        Username = username,
                        Id = id,
                        Addtime = DateTime.Now,
                    };
                    context.Histories.Add(history);
                    if (context.SaveChanges() < 0)
                    {
                        MessageBox.Show("Error.");
                    }
                    var tmp = (from w1 in context.Words
                               from u in w1.Usernames
                               where w1.Id == tmpId && u.Username == Session.Username
                               select new Word
                               {
                                   Id = w1.Id
                               }).ToList();
                    if (tmp.Count != 0)
                    {
                        btnDislike.Show();
                        btnLike.Hide();
                    }
                    else
                    {
                        btnLike.Show();
                        btnDislike.Hide();
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDislike_Click(object sender, EventArgs e)
        {
            using (var context = new PRN211_ProjectContext())
            {
                if (Session.Username != null)
                {
                    var tmp = (from w in context.Words
                               from u in w.Usernames
                               where w.Id == tmpId && u.Username == Session.Username
                               select new Word
                               {
                                   Id = w.Id
                               }).ToList();
                    if (tmp.Count != 0)
                    {
                        Word w = context.Words.FirstOrDefault(w => w.Id == tmpId);
                        context.Database.ExecuteSqlRaw($"delete from user_word where username = '{Session.Username}' and id = {w.Id}");
                        MessageBox.Show("Remove from collection successfully.");
                        btnLike.Show();
                        btnDislike.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Word is not in collection.");
                    }
                }
                else
                {
                    MessageBox.Show("Please login or register to like/dislike words.");
                }
            }
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            using (var context = new PRN211_ProjectContext())
            {
                if (Session.Username != null)
                {
                    var tmp = (from w in context.Words
                               from u in w.Usernames
                               where w.Id == tmpId
                               select new Word
                               {
                                   Id = w.Id
                               }).ToList();
                    if (tmp.Count == 0)
                    {
                        Word w = context.Words.FirstOrDefault(w => w.Id == tmpId);
                        User u = context.Users.FirstOrDefault(u => u.Username == tmpUsername);

                        //context.Words.Add(w);
                        //context.Words.Attach(w);
                        //context.Users.Add(u);
                        //context.Users.Attach(u);

                        w.Usernames.Add(u);

                        if (context.SaveChanges() > 0)
                        {
                            MessageBox.Show("Add to collection successfully.");
                            btnLike.Hide();
                            btnDislike.Show();
                        }
                        else
                        {
                            MessageBox.Show("Error.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Word has already been in collection.");
                    }
                }
                else
                {
                    MessageBox.Show("Please login or register to like/dislike words.");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new PRN211_ProjectContext())
            {
                Word w = context.Words.FirstOrDefault(w => w.Id == tmpId);
                if (w != null)
                {
                    if (w.Username != null)
                    {
                        frmClientAdd clientAdd = new frmClientAdd(tmpId, "update", "");
                        clientAdd.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("You cannot update this word since it was not added by you.");
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new PRN211_ProjectContext())
            {
                Word w = context.Words.FirstOrDefault(w => w.Id == tmpId);
                if (w != null)
                {
                    if (w.Username != null)
                    {
                        DialogResult dialogResult = MessageBox.Show("Do you really want to delete this word?", "Confirm deletion", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            History h = context.Histories.FirstOrDefault(h => h.Id == tmpId);
                            context.Histories.Remove(h);
                            context.Words.Remove(w);
                            if (context.SaveChanges() > 0)
                            {
                                MessageBox.Show("Delete successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Delete failed.");
                            }
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You cannot delete this word since it was not added by you.");
                    }
                }
            }
        }

        private void dgSynonym_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int id = Convert.ToInt32(dgSynonym.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                frmWordDetail wordDetail = new frmWordDetail(id, Session.Username);
                wordDetail.Show();
                this.Hide();
            }
        }
    }
}
