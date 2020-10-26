using System;
using System.Windows.Forms;
using WordLibrary;

namespace WordsWinformsApp
{
    public partial class Form1 : Form
    {
        private WordList practiceList;
        private decimal correctAnswers = 0m, wrongAnswers = 0m;
        private string rightAnswer;
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
                rightWrongLabel.Text = "";
                correctAnswers = 0m;
                wrongAnswers = 0m;
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
                submitButton.Enabled = true;
            }
            else
            {
                submitButton.Enabled = false;
            }
        }
        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submitButton.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.ToLower() == rightAnswer)
            {
                correctAnswers++;
                resultLabel1.Text = "Correct!";
            }
            else
            {
                wrongAnswers++;
                resultLabel1.Text = "Wrong!";
            }
            inputBox.Clear();
            inputBox.Focus();
            rightWrongLabel.Text = $"Correct answers: {correctAnswers}. Wrong answers: {wrongAnswers}." +
                $" ({Math.Round(correctAnswers / (correctAnswers + wrongAnswers), 1) * 100}% correct)";
            Practice(practiceList.GetWordToPractice());
        }
        private void Practice(Word word)
        {
            fromLanguageBox.Text = word.Translations[word.FromLanguage];
            toLanguageBox.Text = practiceList.Languages[word.ToLanguage].ToLower();
            rightAnswer = word.Translations[word.ToLanguage];
        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit loadForm = new Edit();
            loadForm.ShowDialog();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NewList newForm = new NewList())
            {
                if (newForm.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Clear();
                    foreach (string list in WordList.GetLists())
                    {
                        listBox1.Items.Add(list);
                    }
                }
            }
        }
    }
}
