using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WordLibrary;

namespace WorldOfWordcraftWinformsApp
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }
        private void Load_Load(object sender, EventArgs e)
        {
            foreach (string list in WordList.GetLists())
            {
                listBox.Items.Add(list);
            }
        }
        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakeFormReadOnly();

            if (listBox.SelectedItem != null)
            {
                editButton.Enabled = true;
                WordList loadedList = WordList.LoadList(listBox.SelectedItem.ToString());
                dataGridViewWords.Columns.Clear();
                foreach (var language in loadedList.Languages)
                {
                    dataGridViewWords.Columns.Add(language, language);
                }
                Action<string[]> action = new Action<string[]>(ShowTranslations);
                loadedList.List(0, action);
            }
        }
        private void ShowTranslations(string[] translations)
        {
            dataGridViewWords.Rows.Add(translations);
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            saveButton.Enabled = true;
            dataGridViewWords.AllowUserToAddRows = true;
            dataGridViewWords.AllowUserToDeleteRows = true;
            dataGridViewWords.ReadOnly = false;
            editButton.Enabled = false;
            label2.Visible = true;
            label3.Visible = true;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            MakeFormReadOnly();

            string[] languages = new string[dataGridViewWords.Columns.Count];
            for (int i = 0; i < dataGridViewWords.Columns.Count; i++)
            {
                languages[i] = dataGridViewWords.Columns[i].HeaderText;
            }

            bool isNotNull = true;
            List<string[]> translationsList = new List<string[]>();
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
                        MessageBox.Show("All cells in a row must have a value or the row will not " +
                            "be added to the list!");
                        isNotNull = false;
                        break;
                    }
                }
                if (isNotNull)
                {
                    translationsList.Add(translation);
                }
            }

            WordList saveList = new WordList(listBox.SelectedItem.ToString(), languages);
            foreach (var translation in translationsList)
            {
                saveList.Add(translation);
            }

            try
            {
                saveList.Save();
            }
            catch
            {
                MessageBox.Show("Save failed");
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewWords.SelectedRows.Count != 0)
            {
                try
                {
                    foreach (DataGridViewRow row in dataGridViewWords.SelectedRows)
                    {
                        dataGridViewWords.Rows.Remove(row);
                    }
                }
                catch
                {
                    MessageBox.Show("Why would you try to delete a row with nothing in it?");
                }
            }
            else
            {
                MessageBox.Show("User must select an entire row by clicking the blank column (far left), " +
                    "otherwise deletion will not occur!");
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void MakeFormReadOnly()
        {
            dataGridViewWords.ReadOnly = true;
            dataGridViewWords.AllowUserToAddRows = false;
            dataGridViewWords.AllowUserToDeleteRows = false;
            editButton.Enabled = true;
            saveButton.Enabled = false;
            deleteButton.Enabled = false;
            label2.Visible = false;
            label3.Visible = false;
        }
        private void DataGridViewWords_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewWords.SelectedRows.Count > 0 && !editButton.Enabled)
            {
                deleteButton.Enabled = true;
            }
            else
            {
                deleteButton.Enabled = false;
            }
        }
        private void DataGridViewWords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteButton.Enabled = false;
        }
    }
}