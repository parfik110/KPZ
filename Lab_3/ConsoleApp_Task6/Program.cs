using System.Net;
using Flyweight;

namespace ConsoleApp_Task6
{
    public class Program
    {
        static void Main()
        {
            string url = "https://www.gutenberg.org/cache/epub/1513/pg1513.txt";
            string[] lines;

            using (WebClient client = new WebClient())
            {
                Console.WriteLine("Завантаження тексту...");
                string content = client.DownloadString(url);
                lines = content.Split('\n');
            }

            var body = new LightElementNode("body", DisplayType.Block, TagCloseType.Pair);

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].TrimEnd();

                if (string.IsNullOrWhiteSpace(line))
                    continue;

                LightElementNode element;

                if (i == 0)
                    element = LightElementFactory.GetElement("h1");
                else if (line.StartsWith(" "))
                    element = LightElementFactory.GetElement("blockquote");
                else if (line.Length < 20)
                    element = LightElementFactory.GetElement("h2");
                else
                    element = LightElementFactory.GetElement("p");

                element.AddChild(new LightTextNode(line.Trim()));
                body.AddChild(element);
            }

            Console.WriteLine("=== Частина HTML ===");
            Console.WriteLine(string.Join("\n", body.Children.Take(50).Select(e => e.OuterHTML)));

            Console.WriteLine($"\nFlyweight елементів: {LightElementFactory.Count}");
            Console.WriteLine($"Всього вузлів: {CountNodes(body)}");
        }

        static int CountNodes(LightNode node)
        {
            if (node is LightTextNode)
                return 1;

            if (node is LightElementNode elem)
                return 1 + elem.Children.Sum(CountNodes);
            return 0;
        }
    }
}
