using CodeHollow.FeedReader;
using Pastel;
using System.Net.NetworkInformation;

namespace Feed
{
    public static class FeedItems
    {
        public static List<string> GetList(string url)
        {
            var items = new List<string>{};
            var ping = new Ping();

            var source = new Uri(url);
            
            var isAlive = ping.SendPingAsync(source.Host, 500);
            // Console.WriteLine(isAlive.Result.Status);
            if (isAlive.Result.Status == IPStatus.Success)
            {
                var readerTask = FeedReader.ReadAsync(url);
                readerTask.ConfigureAwait(false);
                
                foreach (var item in readerTask.Result.Items)
                {
                    items.Add(item.Title.Pastel("#116bba") + " - " + item.Link.Pastel("#11ba79"));
                }
                return items;
            }
            else
            {
                items.Add("Ошибка. Нет связи с источником фидов.");  
                return items;
            }

        }
    }
}