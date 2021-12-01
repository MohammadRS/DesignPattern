namespace _01_Decorator
{
    public abstract class Decorator : Component
    {
        private readonly Component _component;
        public Decorator(Component component)
        {
            _component = component;
        }

        public override void Operation()
        {
            _component.Operation();
        }

    }
}
