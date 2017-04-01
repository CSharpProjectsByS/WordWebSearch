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
            List<Task> tasks = new List<Task>();

            foreach (string pageUrl in pageUrls)
            {
                Task findWords = LoadContentPageAndFindWordsForPage(words, pageUrl);
                tasks.Add(findWords);  
            }

            foreach (Task task in tasks)
            {
                await task;
            }

        }

        public async Task doTask(Task task)
        {
            await task;
        }

        public async Task LoadContentPageAndFindWordsForPage(List<string> words, string pageUrl)
        {
            Console.WriteLine("Jestem w LoadContentPageAndFindWordsForPage");
            HttpClient httpClient = new HttpClient();
            Task<string> getStringTask = httpClient.GetStringAsync(pageUrl);
            Console.WriteLine("Załadowano stronę");

            Console.WriteLine("Dodano stronę do widoku");

            try
            {
                string pageContent = await getStringTask;

                Task<List<String>> getResultLines = FindWordsInPage(words, pageContent, pageUrl);

                List<string> resultsForPage = await getResultLines;

                AddResultToCollection(resultsForPage);
            }

            catch (Exception e)
            {
                resultView.Items.Add("Problem z połączeniem");
            }
        }

        public Task<List<String>> FindWordsInPage(List<string> words, String pageContent, string pageUrl)
        {
            Console.WriteLine("Jestem w FindWordsInPage");

            return  Task.Run<List<String>>(() =>
            {
                List<string> results = new List<string>();

                results.Add(pageUrl);

                foreach (string word in words)
                {
                    int count = Regex.Matches(pageContent, word).Count;
                    results.Add(word + ": " + count);
                }

                return results;
            });
            
        }

        private void AddResultToCollection(List<string> results)
        {
            Console.WriteLine("AddResultToCollection");
            foreach (string result in results)
            {
                resultView.Items.Add(result);
            }

            resultView.Items.Add("");
        }
    }
}
