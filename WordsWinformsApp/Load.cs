using System;
using System.Windows.Forms;
using WordLibrary;

namespace WordsWinformsApp
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void Load_Load(object sender, EventArgs e)
        {
            string[] availableLists = WordList.GetLists();
            foreach (string list in availableLists)
            {
                listBox1.Items.Add(list);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string listName = listBox1.SelectedItem.ToString();
                WordList loadedList = WordList.LoadList(listName);
                dataGridView1.Columns.Clear();
                foreach (var language in loadedList.Languages)
                {
                    dataGridView1.Columns.Add(language, language);
                }
                Action<string[]> action = new Action<string[]>(showTranslations);
                loadedList.List(0, action);
            }
        }
        private void showTranslations(String[] translations)
        {
            dataGridView1.Rows.Add(translations);
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            
            
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            saveButton.Enabled = true;
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
            dataGridView1.ReadOnly = false;
        }
        private void Save(WordList wordList)
        {
            wordList.Save();
        }
    }
}
