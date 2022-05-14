using _12_Builder.Classes;

namespace _12_Builder.Builders
{
    public class ConcreteBuilder2 : Builder
    {
        public override void BuildPart1()
        {
            product.Part1 = " x part1";
        }

        public override void BuildPart2()
        {
            product.Part2 = "x part2";
        }

        public override Product GetResult()
        {
            product.Name = "Product 2 from builder 2";
            Console.WriteLine($"{product.Name} Created");
            return base.GetResult();
        }
    }
}
