using System;
using System.Collections.Generic;
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
            foreach (string list in WordList.GetLists())
            {
                listBox1.Items.Add(list);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
            saveButton.Enabled = false;
            if (listBox1.SelectedItem != null)
            {
                WordList loadedList = WordList.LoadList(listBox1.SelectedItem.ToString());
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
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            editButton.Enabled = true;
            saveButton.Enabled = false;
            string[] languages = new string[dataGridView1.Columns.Count];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                languages[i] = dataGridView1.Columns[i].HeaderText;
            }
            bool isNotNull = true;
            List<string[]> translationsList = new List<string[]>();
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
                        MessageBox.Show("All cells in a row must have a value or the row will not be added to the list!");
                        isNotNull = false;
                        break;
                    }
                }
                if (isNotNull)
                {
                    translationsList.Add(translation);
                }
            }
            WordList saveList = new WordList(listBox1.SelectedItem.ToString(), languages);
            foreach (var translation in translationsList)
            {
                saveList.Add(translation);
            }
            //are you sure you wish to save-knapp!
            saveList.Save();
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            saveButton.Enabled = true;
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
            dataGridView1.ReadOnly = false;
            editButton.Enabled = false;
        }
    }
}
