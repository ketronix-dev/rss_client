using System.Xml;

namespace OpmlParser
{
    public static class Parser
    {
        public static string ParseAtrribute(string filePath, string parseAtrribute)
        {
            XmlReader xmlReader = XmlReader.Create(filePath);

            var list = new List<string> {};
            
            while (xmlReader.Read())
            {
                if (xmlReader.NodeType == XmlNodeType.Element)
                {
                    if (xmlReader.HasAttributes)
                    {
                        Console.WriteLine(xmlReader.GetAttribute(parseAtrribute));
                        list.Add(xmlReader.GetAttribute(parseAtrribute));
                    }
                }
            }

            return list[0];
        }
    }
}