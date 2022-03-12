namespace _08_Prototype
{

    public interface IPrototype
    {
        IPrototype Clone();
    }

    public class ConCreatePrototype1 : IPrototype
    {
        public int Property1 { get; set; }  
        public string Property2 { get; set; }

        public ConCreatePrototype1(int property1, string property2)
        {
            Property1 = property1;
            Property2 = property2;  
        }
        public IPrototype Clone()
        {
            return (IPrototype) this.MemberwiseClone();
        }
    }

    public class ConCreatePrototype2 : IPrototype
    {
        public ConCreatePrototype1 ConCreatePrototype1 { get; set; }

        public ConCreatePrototype2(ConCreatePrototype1 conCreatePrototype1)
        {
            ConCreatePrototype1 = conCreatePrototype1;  
        }
        public IPrototype Clone()
        {
            var result = (ConCreatePrototype2) this.MemberwiseClone();
            result.ConCreatePrototype1 = (ConCreatePrototype1)this.ConCreatePrototype1.Clone();
            return (IPrototype) result;
        }
    }
}