using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordLibrary;

namespace WordsWinformsApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Load loadForm = new Load();
            loadForm.TopLevel = true;
            loadForm.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewList newForm = new NewList();
            newForm.TopLevel = true;
            newForm.Show();
        }
    }
}
