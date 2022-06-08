using Feed;
using OpmlParser;
using System.Xml;

namespace RSS_client
{
    class Program
    {
        static void Main(string[] args)
        {
            var urls = Parser.ParseAtrribute("/home/fast/Загрузки/News.opml","xmlUrl");
            Console.WriteLine(urls);
            Console.WriteLine(FeedItems.GetList(urls));
        }
    }
}