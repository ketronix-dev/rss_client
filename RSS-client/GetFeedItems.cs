using CodeHollow.FeedReader;

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
                items.Add(item.Title + " - " + item.Link);
            }

            return items;
        }
    }
}