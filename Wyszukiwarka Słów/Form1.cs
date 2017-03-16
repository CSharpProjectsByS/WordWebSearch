using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyszukiwarka_Słów
{
    public partial class Form1 : Form
    {

        private List<string> pageColl = new List<string>();
        private List<string> wordColl = new List<string>();
        private WordSearcher wordSearcher = new WordSearcher();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddWordButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(NewWordValue.Text))
            {
                wordColl.Add(NewWordValue.Text);
                WordCollectionView.Items.Add(NewWordValue.Text);
            }
            else
            {
                MessageBox.Show("Niepoprawna wartość słowa");
            }          
        }

        private void AddPageButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(NewWordValue.Text))
            {
                pageColl.Add(NewPageValue.Text);
                PageCollectionView.Items.Add(NewPageValue.Text);
            }
            else
            {
                MessageBox.Show("Niepoprawna wartość słowa");
            }
        }

        private void ClearWordsButton_Click(object sender, EventArgs e)
        {
            wordColl = null;
            wordColl = new List<string>();
            WordCollectionView.Items.Clear();
        }

        private void ClearPagesButton_Click(object sender, EventArgs e)
        {
            pageColl = null;
            pageColl = new List<string>();
            PageCollectionView.Items.Clear();
        }

        private void ClearResultButton_Click(object sender, EventArgs e)
        {
            ResultCollectionView.Items.Clear();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            wordSearcher.FindWordsForPages(wordColl, pageColl, ResultCollectionView);
        }
    }
}
