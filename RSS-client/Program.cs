using Feed;
using OpmlParser;
using System.Xml;
using Pastel;

namespace RSS_client
{
    class Program
    {
        static void Main(string[] args)
        {
            var urls = Parser.ParseAtrribute(args[0],"xmlUrl");

            foreach (var url in urls)
            {
                Console.WriteLine($"Источник: {url}".Pastel("#11bab7"));
                Console.WriteLine("-----------------------------------------------------------".Pastel("#11ba57"));
                foreach (var post in FeedItems.GetList(url))
                {
                    Console.WriteLine(post);
                }
                Console.WriteLine("-----------------------------------------------------------".Pastel("#11ba57"));
            }
        }
    }
}