using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1
{
    class Program
    {
        static async Task<string> GetHTMLTextAsync(string wikiLink)
        {
            using HttpClient client = new HttpClient();            
            var response = await client.GetAsync(wikiLink);
            string htmlText = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Скачали ответ: {htmlText.Length} символов");
            return htmlText;
        }

        static void GetURLs(string htmlText)
        {
            MatchCollection linksCollection = Regex.Matches(htmlText, @" href=""\/wiki\/(?<name>[\w\d%_\(\)]+|)""");
            foreach (Match link in linksCollection)
            {
                Console.WriteLine($" {HttpUtility.UrlDecode(link.Groups["name"].Value)} : {HttpUtility.UrlDecode(link.Value)}");
            }
        }

        static void Main()
        {
            var wikiLink = "https://ru.wikipedia.org/wiki/%D0%97%D0%B0%D0%B3%D0%BB%D0%B0%D0%B2%D0%BD%D0%B0%D1%8F_%D1%81%D1%82%D1%80%D0%B0%D0%BD%D0%B8%D1%86%D0%B0";
            string htmlText = GetHTMLTextAsync(wikiLink).Result;
            GetURLs(htmlText);
        }
    }
}
