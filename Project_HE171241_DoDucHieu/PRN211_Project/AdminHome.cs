using Microsoft.EntityFrameworkCore;
using PRN211_Project.Models;
using System.Data;

namespace PRN211_Project
{
    public partial class frmAdminHome : Form
    {
        public frmAdminHome()
        {
            InitializeComponent();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            lblGreeting.Text = $"Welcome {Session.Username}";
            LoadWordList();
        }

        private void LoadWordList()
        {
            using (var context = new PRN211_ProjectContext())
            {
                var wordList = (from w in context.Words
                                where w.Username == null
                                orderby w.Name, w.Type ascending
                                select new
                                {
                                    Id = w.Id,
                                    Name = w.Name,
                                    Type = w.Type.Name,
                                    Meaning = w.Meaning,
                                })
                           .ToList();
                dgWords.DataSource = wordList;
            }
        }

        public static string action;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            action = "add";
            frmAdminAdd adminAdd = new frmAdminAdd();
            adminAdd.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Session.Username = null;
            Session.Password = null;
            frmHome home = new frmHome();
            home.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSelected.Text))
            {
                MessageBox.Show("Please select a word to continue.");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you really want to delete this word?", "Confirm deletion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtSelected.Text);
                    using (var context = new PRN211_ProjectContext())
                    {
                        Word w = context.Words.FirstOrDefault(w => w.Id == id);
                        if (w != null)
                        {
                            List<Synonym> listSyn = context.Synonyms.Where(s => s.FirstId == w.Id || s.SecondId == w.Id).ToList();
                            foreach (Synonym syn in listSyn)
                            {
                                context.Synonyms.Remove(syn);
                                context.SaveChanges();
                            }
                            List<History> listHis = context.Histories.Where(k => k.Id == w.Id).ToList();
                            foreach (History h in listHis)
                            {
                                context.Histories.Remove(h);
                            }
                            context.SaveChanges();
                            context.Database.ExecuteSqlRaw($"delete from user_word where id = {w.Id}");
                            context.SaveChanges();
                            context.Words.Remove(w);
                            if (context.SaveChanges() > 0)
                            {
                                MessageBox.Show("Delete successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Delete failed.");
                            }
                            LoadWordList();
                        }
                        else
                        {
                            MessageBox.Show("ID is not valid.");
                        }
                    }
                }
            }
        }

        public static string tmpId;
        private void dgWords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtSelected.Text = dgWords.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                tmpId = txtSelected.Text;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadWordList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            action = "update";
            if (!string.IsNullOrEmpty(tmpId))
            {
                frmAdminAdd adminUpdate = new frmAdminAdd();
                adminUpdate.Show();
            }
            else
            {
                MessageBox.Show("Please select a word to continue.");
            }
        }
    }
}
