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
        private WordSearcher wordSearcher;

        public Form1()
        {
            InitializeComponent();

            initCollections();

            wordSearcher = new WordSearcher(ResultCollectionView);
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
            if (!String.IsNullOrEmpty(NewPageValue.Text))
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
            wordSearcher.FindWordsForPages(wordColl, pageColl);
        }

        private void initCollections()
        {
            initWordCollection();  
            initPageCollection();
        }

        private void initWordCollection()
        {
            wordColl.Add("panel");
            wordColl.Add("sieci");
            wordColl.Add("wejbxabjsf");
            wordColl.Add("losowa");

            WordCollectionView.Items.Add("panel");
            WordCollectionView.Items.Add("sieci");
            WordCollectionView.Items.Add("wejbxabjsf");
            WordCollectionView.Items.Add("losowa");

        }

        private void initPageCollection()
        {
            pageColl.Add("http://eduinf.waw.pl/inf/utils/010_2010/0213.php");
            pageColl.Add("https://sekurak.pl/");
            pageColl.Add("https://sekurak.pl/");


            PageCollectionView.Items.Add("http://eduinf.waw.pl/inf/utils/010_2010/0213.php");
            PageCollectionView.Items.Add("https://sekurak.pl/");
            PageCollectionView.Items.Add("https://sekurak.pl/");

        }
    }
}
