namespace _03_Bridge.Bridge.Implementors
{
    public abstract class Implementor
    {
        public abstract void Implemetion();
    }

    public class ConcreteImplementor : Implementor
    {
        public override void Implemetion()
        {
            Console.WriteLine("run ...Implementors.ConcreteImplementor.Implemetion");
        }
    }
}
