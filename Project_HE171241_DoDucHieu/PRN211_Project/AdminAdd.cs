using Microsoft.Data.SqlClient;
using PRN211_Project.Models;
using System.Data;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.Arm;
using PRN211_Project;
using System.Collections.Generic;

namespace PRN211_Project
{
    public partial class frmAdminAdd : Form
    {
        public frmAdminAdd()
        {
            InitializeComponent();
            LoadData();
        }

        DataProvider dp = new DataProvider();
        private void btnAdd_Click(object sender, EventArgs e)
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
                        if (frmAdminHome.action.Equals("add"))
                        {
                            Word w = context.Words.FirstOrDefault(w => w.TypeId == typeId && w.Name == name && w.Meaning == meaning && w.Username == null);
                            if (w == null)
                            {
                                w = new Word()
                                {
                                    Name = name,
                                    Meaning = meaning,
                                    TypeId = typeId,
                                };
                                context.Words.Add(w);
                                if (context.SaveChanges() > 0)
                                {
                                    MessageBox.Show("Add word successfully.");
                                }
                                else
                                {
                                    MessageBox.Show("Add word failed.");
                                }
                                foreach (DataGridViewRow row in dgSynonym.SelectedRows)
                                {
                                    long secondId = Convert.ToInt32(row.Cells[0].FormattedValue.ToString());
                                    if (secondId != null)
                                    {
                                        long firstId = context.Words.FirstOrDefault(w1 => w1.Name.Equals(w.Name) && w1.Meaning.Equals(w.Meaning) && w1.TypeId == w.TypeId && w.Username == null).Id;
                                        Synonym s = context.Synonyms.FirstOrDefault(s => s.FirstId == firstId && s.SecondId == secondId && s.Username == null);
                                        if (s == null)
                                        {
                                            s = new Synonym()
                                            {
                                                FirstId = firstId,
                                                SecondId = secondId,
                                            };
                                            context.Synonyms.Add(s);
                                            context.SaveChanges();
                                        }
                                        s = context.Synonyms.FirstOrDefault(s => s.FirstId == secondId && s.SecondId == firstId && s.Username == null);
                                        if (s == null)
                                        {
                                            s = new Synonym()
                                            {
                                                FirstId = secondId,
                                                SecondId = firstId,
                                            };
                                            context.Synonyms.Add(s);
                                            context.SaveChanges();
                                        }
                                    }
                                }
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Word has already existed.");
                            }
                        }
                        else if (frmAdminHome.action.Equals("update"))
                        {
                            Word w = context.Words.FirstOrDefault(w => w.Id == Convert.ToInt32(frmAdminHome.tmpId));
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
                                foreach (DataGridViewRow row in dgSynonym.SelectedRows)
                                {
                                    long secondId = Convert.ToInt32(row.Cells[0].FormattedValue.ToString());
                                    if (secondId != null)
                                    {
                                        Synonym s = context.Synonyms.FirstOrDefault(s => s.FirstId == w.Id || s.SecondId == w.Id);
                                        context.Synonyms.Remove(s);
                                        context.SaveChanges();
                                        s = context.Synonyms.FirstOrDefault(s => s.FirstId == w.Id && s.SecondId == secondId);
                                        if (s == null)
                                        {
                                            s = new Synonym()
                                            {
                                                FirstId = w.Id,
                                                SecondId = secondId,
                                            };
                                            context.Synonyms.Add(s);
                                            context.SaveChanges();
                                        }
                                        s = context.Synonyms.FirstOrDefault(s => s.FirstId == secondId && s.SecondId == w.Id);
                                        if (s == null)
                                        {
                                            s = new Synonym()
                                            {
                                                FirstId = secondId,
                                                SecondId = w.Id,
                                            };
                                            context.Synonyms.Add(s);
                                            context.SaveChanges();
                                        }
                                    }
                                }
                                this.Hide();
                            }
                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoadData()
        {
            using (var context = new PRN211_ProjectContext())
            {
                List<Models.Type> list = context.Types.ToList();
                cbType.DataSource = list;
                cbType.DisplayMember = "name";
                cbType.ValueMember = "id";
                if (frmAdminHome.action.Equals("add"))
                {
                    var listWord = (from w in context.Words
                                    where w.Username == null
                                    orderby w.Name, w.Type ascending
                                    select new
                                    {
                                        Id = w.Id,
                                        Name = w.Name,
                                        Type = w.Type.Name,
                                        Meaning = w.Meaning,
                                    }).ToList();
                    dgSynonym.DataSource = listWord;

                }
                if (frmAdminHome.action.Equals("update"))
                {
                    Word w = context.Words.FirstOrDefault(w => w.Id == Convert.ToInt32(frmAdminHome.tmpId));
                    txtName.Text = w.Name;
                    txtMeaning.Text = w.Meaning;
                    cbType.SelectedIndex = cbType.FindStringExact(w.Type.Name);

                    List<long> listIds = context.Synonyms
                        .Where(s => s.FirstId == w.Id)
                        .Select(s => s.SecondId)
                        .ToList();
                    List<Word> listWord = context.Words.Where(w => w.Username == null).ToList();
                    dgSynonym.DataSource = listWord;
                    //foreach (DataGridViewRow row in dgSynonym.Rows)
                    //{
                    //    if (row.Index >= 0)
                    //    {
                    //        long k = Convert.ToInt32(row.Cells[0].FormattedValue.ToString());
                    //        foreach (long id in listIds)
                    //        {
                    //            if (k == id)
                    //            {
                    //                row.Cells[row.Index].Selected = true;
                    //                break;
                    //            }
                    //        }
                    //    }
                    //}
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
    }
}
