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

                try
                {
                    string pageContent = await getStringTask;

                    Task<List<String>> getResultLines = FindWordsInPage(words, pageContent);

                    List<string> resultsForPage = await getResultLines;

                    AddResultToCollection(resultsForPage, resultView);
                }

                catch (Exception e)
                {
                    resultView.Items.Add("Problem z połączeniem");
                    break;
                }
            }
        }

        public async Task<List<String>> FindWordsInPage(List<string> words, String pageContent)
        {
            List<string> results = new List<string>(); 

            foreach (string word in words)
            {
                int count = await CountWordForPage(word, pageContent);
                results.Add(word + ": " + count);
            }

            return results;
        }

        
        private async Task<int> CountWordForPage(String word, String page)
        {
            int count = Regex.Matches(page, word).Count;
            return count;
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
