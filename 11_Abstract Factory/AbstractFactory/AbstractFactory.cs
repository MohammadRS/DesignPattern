using _11_Abstract_Factory.ProductA;
using _11_Abstract_Factory.ProductB;

namespace _11_Abstract_Factory.AbstractFactory
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }
}
