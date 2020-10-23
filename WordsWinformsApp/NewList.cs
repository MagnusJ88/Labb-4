using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WordLibrary;

namespace WordsWinformsApp
{
    public partial class NewList : Form
    {
        public NewList()
        {
            InitializeComponent();
        }

        private void NewList_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.ReadOnly = false;
            addButton.Enabled = false;
            if (languageTextBox.Text.Length != 0)
            {
                foreach (string word in languageTextBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
                {
                    dataGridView1.Columns.Add(word, word);
                }
                dataGridView1.Visible = true;
            }
            else
            {
                MessageBox.Show("You must add languages to the textbox on the left (separated by new lines)");
            }
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (WordList.GetLists().Contains(textBoxName.Text.ToLower()) || textBoxName.Text.Length == 0)
            {
                saveButton.Enabled = false;
                addButton.Enabled = false;
                languageTextBox.Enabled = false;
            }
            else
            {
                saveButton.Enabled = true;
                addButton.Enabled = true;
                languageTextBox.Enabled = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            string[] languages = languageTextBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            WordList saveList = new WordList(textBoxName.Text, languages);
            List<string[]> translationList = new List<string[]>();
            bool isNotNull = true;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string[] translation = new string[dataGridView1.Columns.Count];
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        translation[j] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        isNotNull = true;
                    }
                    else
                    {
                        MessageBox.Show("All cells in a row must have a value or you can not save changes!");
                        isNotNull = false;
                        break;
                    }
                }
                if (isNotNull)
                {
                    translationList.Add(translation);
                }
            }
            foreach (var translation in translationList)
            {
                saveList.Add(translation);
            }

            //TODO are you sure you wish to save?-knapp!
            saveList.Save();
            this.Close();
        }
    }
}
