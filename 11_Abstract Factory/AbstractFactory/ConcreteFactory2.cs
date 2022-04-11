using _11_Abstract_Factory.ProductA;
using _11_Abstract_Factory.ProductB;

namespace _11_Abstract_Factory.AbstractFactory
{
    public class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
