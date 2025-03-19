
using Task4Library;

class Program
{
    static void Main()
    {
        // Створення "сімейства" вірусів
        Virus ancestor = new Virus("Alpha", "Corona", 2.5, 10);
        Virus child1 = new Virus("Beta", "Corona", 1.8, 5);
        Virus child2 = new Virus("Gamma", "Corona", 1.6, 3);
        Virus grandchild1 = new Virus("Delta", "Corona", 1.2, 1);

        child1.AddChild(grandchild1);
        ancestor.AddChild(child1);
        ancestor.AddChild(child2);

        Console.WriteLine("Original Family:");
        ancestor.Display();

        // Клонування вірусу
        Virus clonedAncestor = (Virus)ancestor.Clone();
        Console.WriteLine("\nCloned Family:");
        clonedAncestor.Display();
    }
}