using _11_Abstract_Factory.ProductA;
using _11_Abstract_Factory.ProductB;

namespace _11_Abstract_Factory.AbstractFactory
{
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
