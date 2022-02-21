namespace _07_Adapter
{
    public class ClassAdapter
    {
        public interface ITarget
        {
            void Operation();
        }


        public class Adaptee
        {
            public void SpecificOperation()
            {
                Console.WriteLine("Adaptee.SpecificOperation()");
            }
        }


        public class Adapter : Adaptee, ITarget
        {
            public void Operation()
            {
                SpecificOperation();
            }
        }
    }
}
