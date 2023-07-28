using PRN211_Project.Models;

namespace PRN211_Project
{
    public partial class frmClientAdd : Form
    {
        public static string word;
        public static string action;
        public static int id;
        public frmClientAdd(int tmpId, string v, string? word)
        {
            InitializeComponent();
            action = v;
            id = tmpId;
            if (!string.IsNullOrEmpty(word))
            {
                txtName.Text = word;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ClientAdd_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (var context = new PRN211_ProjectContext())
            {
                List<Models.Type> list = context.Types.ToList();
                cbType.DataSource = list;
                cbType.DisplayMember = "name";
                cbType.ValueMember = "id";
                if (action.Equals("update"))
                {
                    Word w = context.Words.FirstOrDefault(w => w.Id == id);
                    txtName.Text = w.Name;
                    txtMeaning.Text = w.Meaning;
                    cbType.SelectedIndex = cbType.FindStringExact(w.Type.Name);
                }
            }
        }

        private static bool checkWordName(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            foreach (char c in input)
            {
                if (char.IsDigit(c)) return false;
            }
            return true;
        }

        private static bool checkWordMeaning(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            else if (input.Length < 20) return false;
            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string meaning = txtMeaning.Text;
            byte typeId = (byte)cbType.SelectedValue;
            if (!checkWordName(name))
            {
                MessageBox.Show("Word cannot be null or empty and must not contain digit.");
            }
            else
            {
                if (!checkWordMeaning(meaning))
                {
                    MessageBox.Show("Word meaning cannot be null or empty and must be at least 20 characters.");
                }
                else
                {
                    using (var context = new PRN211_ProjectContext())
                    {
                        if (action.Equals("add"))
                        {
                            AddWord(name, typeId, meaning);
                        }
                        else if (action.Equals("update"))
                        {
                            UpdateWord(name, typeId, meaning);
                        }
                    }
                }
            }
        }

        private void AddWord(string name, byte typeId, string meaning)
        {
            using (var context = new PRN211_ProjectContext())
            {
                Word w = context.Words.FirstOrDefault(w => w.TypeId == typeId && w.Name == name && w.Meaning == meaning);
                if (w == null)
                {
                    w = new Word()
                    {
                        Name = name,
                        Meaning = meaning,
                        TypeId = typeId,
                        Username = Session.Username,
                    };
                    context.Words.Add(w);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Add word successfully.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Add word failed.");
                    }
                }
                else
                {
                    MessageBox.Show("Word has already existed.");
                }
            }
        }

        private void UpdateWord(string name, byte typeId, string meaning)
        {
            using (var context = new PRN211_ProjectContext())
            {
                Word w = context.Words.FirstOrDefault(w => w.Id == id);
                if (w != null)
                {
                    w.Name = name;
                    w.Meaning = meaning;
                    w.TypeId = typeId;
                    context.Words.Update(w);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Update word successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Update word failed.");
                    }
                    this.Hide();
                }
            }
        }
    }
}
