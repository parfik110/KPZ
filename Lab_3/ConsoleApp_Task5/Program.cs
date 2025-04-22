using Composite;

namespace ConsoleApp_Task5
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ul = new LightElementNode("ul", DisplayType.Block, TagCloseType.Pair);
            ul.AddClass("menu");

            var li1 = new LightElementNode("li", DisplayType.Block, TagCloseType.Pair);
            li1.AddChild(new LightTextNode("Item 1"));

            var li2 = new LightElementNode("li", DisplayType.Block, TagCloseType.Pair);
            li2.AddChild(new LightTextNode("Item 2"));

            ul.AddChild(li1);
            ul.AddChild(li2);

            li1.SubscribeEvent("click", () => Console.WriteLine("Clicked on Item 1"));
            li2.SubscribeEvent("mouseover", () => Console.WriteLine("Hovered over Item 2"));

            Console.WriteLine("=== LightHTML output ===");
            Console.WriteLine(ul.OuterHTML);

            Console.WriteLine("\n=== Event simulation ===");
            li1.TriggerEvent("click");
            li2.TriggerEvent("mouseover");
        }
    }
}
