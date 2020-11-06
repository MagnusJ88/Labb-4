using System;
using System.Linq;
using System.Windows.Forms;
using WordLibrary;

namespace WorldOfWordcraftWinformsApp
{
    public partial class NewList : Form
    {
        public NewList()
        {
            InitializeComponent();
        }
        private void NewList_Load(object sender, EventArgs e)
        {
            dataGridViewWords.ReadOnly = true;
            dataGridViewWords.Visible = false;
            textBoxName.Focus();
        }
        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            if (WordList.GetLists().Contains(textBoxName.Text.ToLower()) || textBoxName.Text.Length == 0)
            {
                addButton.Enabled = false;
                languageTextBox.Enabled = false;
            }
            else
            {
                if (textBoxName.Text.Contains(";"))
                {
                    MessageBox.Show("Invalid character detected!");
                    textBoxName.Clear();
                    addButton.Enabled = false;
                    languageTextBox.Enabled = false;
                }
                else
                {
                    addButton.Enabled = true;
                    languageTextBox.Enabled = true;
                }
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            addButton.Enabled = false;
            dataGridViewWords.ReadOnly = false;
            languageTextBox.ReadOnly = true;
            textBoxName.ReadOnly = true;

            if (languageTextBox.Text.Contains(";"))
            {
                MessageBox.Show("Invalid character detected!\n" +
                    "Please remove all occurences of the semi-colon (\";\") character!");
                addButton.Enabled = true;
                saveButton.Enabled = false;
                languageTextBox.ReadOnly = false;
                languageTextBox.Focus();
            }
            else
            {
                string[] languages = languageTextBox.Text.Split(new[] { Environment.NewLine },
                            StringSplitOptions.RemoveEmptyEntries);

                if (languages.Length > 1)
                {
                    foreach (string word in languages)
                    {
                        dataGridViewWords.Columns.Add(word, word);
                    }
                    dataGridViewWords.Visible = true;
                    saveButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("You must add two or more languages to the textbox on the left " +
                                    "(separated by new lines)");
                    addButton.Enabled = true;
                    saveButton.Enabled = false;
                    languageTextBox.ReadOnly = false;
                    languageTextBox.Focus();
                }
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            dataGridViewWords.AllowUserToAddRows = false;
            dataGridViewWords.ReadOnly = true;

            string[] languages = languageTextBox.Text.Split(new[] { Environment.NewLine },
                                StringSplitOptions.RemoveEmptyEntries);

            WordList saveList = new WordList(textBoxName.Text, languages);

            bool isNotNull = true;
            for (int i = 0; i < dataGridViewWords.Rows.Count; i++)
            {
                string[] translation = new string[dataGridViewWords.Columns.Count];
                for (int j = 0; j < dataGridViewWords.Columns.Count; j++)
                {
                    if (dataGridViewWords.Rows[i].Cells[j].Value != null)
                    {
                        translation[j] = dataGridViewWords.Rows[i].Cells[j].Value.ToString().Replace(";", "-");
                        isNotNull = true;
                    }
                    else
                    {
                        MessageBox.Show("All cells in a row must have a value or the translation can not be saved!");
                        isNotNull = false;
                        break;
                    }
                }
                if (isNotNull)
                {
                    saveList.Add(translation);
                }
            }
            try
            {
                saveList.Save();
                DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Save failed!");
            }
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}