namespace _12_Builder.Classes
{
    public class Product
    {
        public string Part1 { get; set; }
        public string Part2 { get; set; }
        public string Name { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Product Name:{this.Name}");
            Console.WriteLine($"Product Part1:{this.Part1}");
            Console.WriteLine($"Product Part2:{this.Part2}");
        }
    }
}
