using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyszukiwarka_Słów
{
    class WordSearcher
    {
        ListBox resultView;

        public WordSearcher(ListBox resultView)
        {
            this.resultView = resultView;
        }

        public async Task FindWordsForPages(List<string> words, List<string> pageUrls)
        {
            foreach (string pageUrl in pageUrls)
            {
                await Task.Run(() => LoadContentPageAndFindWordsForPage(words, pageUrl));   
            }
        }

        public async Task LoadContentPageAndFindWordsForPage(List<string> words, string pageUrl)
        {
            HttpClient httpClient = new HttpClient();
            Task<string> getStringTask = httpClient.GetStringAsync(pageUrl);

            resultView.Items.Add(pageUrl);

            try
            {
                string pageContent = await getStringTask;

                Task<List<String>> getResultLines = FindWordsInPage(words, pageContent);

                List<string> resultsForPage = await getResultLines;

                AddResultToCollection(resultsForPage);
            }

            catch (Exception e)
            {
                resultView.Items.Add("Problem z połączeniem");
            }
        }

        public async Task<List<String>> FindWordsInPage(List<string> words, String pageContent)
        {
            List<string> results = new List<string>(); 

            foreach (string word in words)
            {
                int count = Regex.Matches(pageContent, word).Count;
                results.Add(word + ": " + count);
            }

            return results;
        }

        private void AddResultToCollection(List<string> results)
        {
            foreach (string result in results)
            {
                resultView.Items.Add(result);
            }

            resultView.Items.Add("");
        }
    }
}
