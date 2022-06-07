using CodeHollow.FeedReader;

namespace RSS_client
{
    class Program
    {
        static void Main()
        { 
            string hlp = "Please enter feed url or exit to stop the program:";
            Console.WriteLine(hlp);

            while (true)
            {
                var url = Console.ReadLine();
                if (url.Equals("exit", StringComparison.InvariantCultureIgnoreCase))
                    break;

                var urlsTask = FeedReader.GetFeedUrlsFromUrlAsync(url);
                var urls = urlsTask.Result;

                string feedUrl;

                feedUrl = url;

                var readerTask = FeedReader.ReadAsync(feedUrl);
                readerTask.ConfigureAwait(false);

                foreach (var item in readerTask.Result.Items)
                {
                    Console.WriteLine(item.Title + " - " + item.Link);
                }
            }
        }
    }
}