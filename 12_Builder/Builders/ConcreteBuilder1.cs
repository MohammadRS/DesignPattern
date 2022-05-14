using _12_Builder.Classes;

namespace _12_Builder.Builders
{
    public class ConcreteBuilder1 : Builder
    {
        public override void BuildPart1()
        {
            product.Part1 = "Part-1";
        }

        public override void BuildPart2()
        {
            product.Part2 = "part-2";
        }

        public override Product GetResult()
        {
            product.Name = "Product 1";
            Console.WriteLine($"{product.Name} Created");
            return base.GetResult();
        }
    }
}
