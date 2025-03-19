namespace Task4Library
{
    public class Virus : ICloneable
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public List<Virus> Children { get; set; }

        public Virus(string name, string species, double weight, int age)
        {
            Name = name;
            Species = species;
            Weight = weight;
            Age = age;
            Children = new List<Virus>();
        }

        public void AddChild(Virus child)
        {
            Children.Add(child);
        }

        public object Clone()
        {
            Virus clone = new Virus(Name, Species, Weight, Age);
            foreach (var child in Children)
            {
                clone.AddChild((Virus)child.Clone());
            }
            return clone;
        }

        public void Display(int level = 0)
        {
            Console.WriteLine(new string('-', level * 2) + $"> {Name}, {Species}, {Weight}g, {Age} days old");
            foreach (var child in Children)
            {
                child.Display(level + 1);
            }
        }
    }
}