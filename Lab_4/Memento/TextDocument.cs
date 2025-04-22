namespace Memento
{
    public class TextDocument
    {
        public string Content { get; set; } = "";

        public void Print()
        {
            Console.WriteLine($"📄 Document Content: \"{Content}\"");
        }
    }
}
