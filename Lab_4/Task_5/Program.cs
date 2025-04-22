using Memento;
namespace Task_5
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("\n--- Мементо ---");

            var document = new TextDocument();
            var editor = new TextEditor(document);

            editor.TypeText("Hello");
            editor.ShowDocument();

            editor.TypeText(", world!");
            editor.ShowDocument();

            Console.WriteLine("↩️ Undoing last change...");
            editor.Undo();
            editor.ShowDocument();

            Console.WriteLine("↩️ Undoing again...");
            editor.Undo();
            editor.ShowDocument();
        }
    }
}
