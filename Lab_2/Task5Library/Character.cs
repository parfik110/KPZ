namespace Task5Library
{
    public class Character
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string BodyType { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Outfit { get; set; }
        public List<string> Inventory { get; set; } = new List<string>();
        public List<string> Actions { get; set; } = new List<string>();

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\nHeight: {Height}\nBody Type: {BodyType}\nHair Color: {HairColor}\nEye Color: {EyeColor}\nOutfit: {Outfit}");
            Console.WriteLine("Inventory: " + string.Join(", ", Inventory));
            Console.WriteLine("Actions: " + string.Join(", ", Actions));
            Console.WriteLine();
        }
    }
}