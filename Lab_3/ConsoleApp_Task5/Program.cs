using Composite;

namespace ConsoleApp_Task5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== LightHTML output ===");

            var ul = new LightElementNode("ul", DisplayType.Block, TagCloseType.Pair);
            ul.AddClass("menu");

            var li1 = new LightElementNode("li", DisplayType.Block, TagCloseType.Pair);
            li1.AddChild(new LightTextNode("Item 1"));

            var li2 = new LightElementNode("li", DisplayType.Block, TagCloseType.Pair);
            li2.AddChild(new LightTextNode("Item 2"));

            ul.AddChild(li1);
            ul.AddChild(li2);

            Console.WriteLine(ul.OuterHTML);

            Console.WriteLine("=== Image output with Strategy ===");

            var fileImg = new LightImageNode("images/local-photo.jpg", new FileSystemImageLoadingStrategy());
            var netImg = new LightImageNode("http://example.com/photo.jpg", new NetworkImageLoadingStrategy());

            Console.WriteLine(fileImg.OuterHTML);
            Console.WriteLine(netImg.OuterHTML);


            Console.WriteLine("\n=== Tree traversal with Iterator ===\n");
            var iterator = new DepthFirstIterator(ul);
            while (iterator.HasNext())
            {
                var node = iterator.Next();
                Console.WriteLine(node.OuterHTML);
            }


            Console.WriteLine("\n=== Command Pattern Demo ===\n");
            var cmdManager = new CommandManager();

            var div = new LightElementNode("div", DisplayType.Block, TagCloseType.Pair);

            cmdManager.ExecuteCommand(new AddClassCommand(div, "red"));
            cmdManager.ExecuteCommand(new AddClassCommand(div, "bold"));
            Console.WriteLine(div.OuterHTML);  // <div class="red bold"></div>

            cmdManager.Undo(); // remove bold
            Console.WriteLine(div.OuterHTML);  // <div class="red"></div>

            cmdManager.Redo(); // add bold again
            Console.WriteLine(div.OuterHTML);  // <div class="red bold"></div>


        }
    }
}
