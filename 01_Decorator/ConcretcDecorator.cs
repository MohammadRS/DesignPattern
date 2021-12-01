namespace _01_Decorator
{
    public class ConcretcDecorator : Decorator
    {
        public ConcretcDecorator(Component component) : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            New1();
            New2();
        }

        public void New1()
        {
            Console.WriteLine("New1");
        }
        public void New2()
        {
            Console.WriteLine("New2");
        }
    }
}
