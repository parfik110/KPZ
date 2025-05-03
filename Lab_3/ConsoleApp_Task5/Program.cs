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



            Console.WriteLine("\n=== State Pattern Demo ===\n");
            var section = new LightElementNode("section", DisplayType.Block, TagCloseType.Pair);
            section.AddChild(new LightTextNode("This is content"));

            section.SetState(new HiddenState());
            Console.WriteLine(section.OuterHTML);  // display: none

            section.SetState(new VisibleState());
            Console.WriteLine(section.OuterHTML);  // display: block



            Console.WriteLine("\n=== Template Method (Lifecycle) Demo ===\n");

            var header = new LightElementNode("header", DisplayType.Block, TagCloseType.Pair);
            header.SetLifecycleHooks(new DefaultLifecycleHooks());

            header.AddChild(new LightTextNode("Welcome to the site!"));
            Console.WriteLine(header.OuterHTML);
            header.Remove();

        }
    }
}
