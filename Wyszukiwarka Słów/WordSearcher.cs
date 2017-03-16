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
        public async void FindWordsForPages(List<string> words, List<string> pageUrls, ListBox resultView)
        {
            foreach (string pageUrl in pageUrls)
            {
                HttpClient httpClient = new HttpClient();
                Task<string> getStringTask = httpClient.GetStringAsync(pageUrl);

                resultView.Items.Add(pageUrl);

                string pageContent = await getStringTask;

                List<string> resultsForPage =  FindWordsInPage(words, pageContent).Result;

                AddResultToCollection(resultsForPage, resultView);

            }
        }

        public async Task<List<String>>  FindWordsInPage(List<string> words, String pageContent)
        {
            List<string> results = new List<string>(); 
            foreach (string word in words)
            {
                int count = Regex.Matches(pageContent, word).Count;
                results.Add(word + ": " + count);
            }

            return results;
        }

        private void AddResultToCollection(List<string> results, ListBox resultView)
        {
            foreach (string result in results)
            {
                resultView.Items.Add(result);
            }

            resultView.Items.Add("");
        }
    }
}
