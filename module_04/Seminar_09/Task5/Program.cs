using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Web;

namespace Task5
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

        static void Main(string[] args)
        {
            string url = "https://ru.wikipedia.org/wiki/%D0%A8%D0%B0%D1%85%D0%BC%D0%B0%D1%82%D0%BD%D0%B0%D1%8F_%D0%B4%D0%BE%D1%81%D0%BA%D0%B0";
            string htmlText = GetHTMLTextAsync(url).Result;
            Regex r = new Regex(@"<img.*?src=("".*?"").*?>");            
            foreach (Match i in r.Matches(htmlText))
                Console.WriteLine(HttpUtility.UrlDecode(i.Groups[1].Value));
        }
    }
}
