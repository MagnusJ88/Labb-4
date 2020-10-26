using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WordLibrary;

namespace WordsWinformsApp
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
                listBox1.Items.Add(list);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakeFormReadOnly();

            if (listBox1.SelectedItem != null)
            {
                editButton.Enabled = true;
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
            MakeFormReadOnly();

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
            deleteButton.Enabled = true;
            label2.Visible = true;
            label3.Visible = true;
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.Remove(row);
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
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void MakeFormReadOnly()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            editButton.Enabled = true;
            saveButton.Enabled = false;
            deleteButton.Enabled = false;
            label2.Visible = false;
            label3.Visible = false;
        }
    }
}
