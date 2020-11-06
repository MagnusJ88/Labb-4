using System;
using System.Windows.Forms;
using WordLibrary;

namespace WorldOfWordcraftWinformsApp
{
    public partial class WorldOfWordcraft : Form
    {
        private WordList practiceList;
        private decimal correctAnswers = 0m, wrongAnswers = 0m;
        private string rightAnswer;
        public WorldOfWordcraft()
        {
            InitializeComponent();
        }
        private void WorldOfWordcraft_Load(object sender, EventArgs e)
        {
            foreach (string list in WordList.GetLists())
            {
                listBoxLists.Items.Add(list);
            }
        }
        private void ListBoxLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxLists.SelectedItem != null)
            {
                practiceButton.Enabled = true;
                inputBox.Enabled = false;
                fromLanguageBox.Clear();
                toLanguageBox.Clear();
                rightWrongLabel.Text = "";
                resultLabel1.Text = "";
                correctAnswers = 0m;
                wrongAnswers = 0m;
            }
        }
        private void PracticeButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            practiceButton.Enabled = false;
            inputBox.Enabled = true;
            inputBox.Focus();

            try
            {
                practiceList = WordList.LoadList(listBoxLists.SelectedItem.ToString());
                Practice(practiceList.GetWordToPractice());
            }
            catch
            {
                IncompleteList();
                practiceButton.Enabled = false;
                inputBox.Enabled = false;
            }
        }
        private void InputBox_TextChanged(object sender, EventArgs e)
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
        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submitButton.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputBox.Text.ToLower() == rightAnswer)
                {
                    correctAnswers++;
                    resultLabel1.Text = "Correct!";
                    resultLabel1.Visible = true;
                }
                else if (rightAnswer != null)
                {
                    wrongAnswers++;
                    resultLabel1.Text = "Wrong!";
                    resultLabel1.Visible = true;
                }
            }
            catch
            {
                IncompleteList();
            }

            inputBox.Clear();
            inputBox.Focus();

            if (correctAnswers > 0 || wrongAnswers > 0)
            {
                rightWrongLabel.Text = $"Correct answers: {correctAnswers}. Wrong answers: {wrongAnswers}." +
                    $" ({Math.Round(correctAnswers / (correctAnswers + wrongAnswers), 1) * 100}% correct)";
                rightWrongLabel.Visible = true;
            }

            try
            {
                Practice(practiceList.GetWordToPractice());
            }
            catch (Exception)
            {
                IncompleteList();
            }
        }
        private void Practice(Word word)
        {
            fromLanguageBox.Text = word.Translations[word.FromLanguage];
            toLanguageBox.Text = practiceList.Languages[word.ToLanguage].ToLower();
            rightAnswer = word.Translations[word.ToLanguage];
        }
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Edit editForm = new Edit())
            {
                editForm.ShowDialog();
            }
        }
        private void NewListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NewList newForm = new NewList())
            {
                if (newForm.ShowDialog() == DialogResult.OK)
                {
                    listBoxLists.Items.Clear();
                    foreach (string list in WordList.GetLists())
                    {
                        listBoxLists.Items.Add(list);
                    }
                }
            }
        }
        private void IncompleteList()
        {
            MessageBox.Show("Error: Incomplete list!\n" +
                                 "Use \"Edit lists\" under \"File\" menu to add words to an existing list\n" +
                                 "or \"New list\" to create a new list!");
        }
    }
}
