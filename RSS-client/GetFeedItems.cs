using CodeHollow.FeedReader;
using Pastel;

namespace Feed
{
    public static class FeedItems
    {
        public static List<string> GetList(string url)
        {
            var items = new List<string>{};

            var readerTask = FeedReader.ReadAsync(url);
            readerTask.ConfigureAwait(false);

            foreach (var item in readerTask.Result.Items)
            {
                items.Add(item.Title.Pastel("#116bba") + " - " + item.Link.Pastel("#11ba79"));
            }

            return items;
        }
    }
}