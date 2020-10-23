using System;
using System.Windows.Forms;
using WordLibrary;

namespace WordsWinformsApp
{
    public partial class Form1 : Form
    {
        private WordList practiceList;
        private int correctAnswers, wrongAnswers;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string list in WordList.GetLists())
            {
                listBox1.Items.Add(list);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                practiceButton.Enabled = true;
                fromLanguageBox.Clear();
                toLanguageBox.Clear();
            }
        }
        private void practiceButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            practiceButton.Enabled = false;
            practiceList = WordList.LoadList(listBox1.SelectedItem.ToString());
            Practice(practiceList.GetWordToPractice());
            inputBox.Focus();
        }
        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            if (inputBox.Text.Length != 0)
            {
                okButton.Enabled = true;
            }
            else
            {
                okButton.Enabled = false;
            }
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.ToLower() == fromLanguageBox.Text)
            {
                correctAnswers++;
            }
            else
            {
                wrongAnswers++;
            }
            inputBox.Clear();
            inputBox.Focus();
            Practice(practiceList.GetWordToPractice());
        }
        private void Practice(Word word)
        {
            fromLanguageBox.Text = word.Translations[word.FromLanguage];
            toLanguageBox.Text = practiceList.Languages[word.ToLanguage];
        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Load loadForm = new Load();
            loadForm.ShowDialog();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewList newForm = new NewList();
            newForm.ShowDialog();
        }
    }
}
