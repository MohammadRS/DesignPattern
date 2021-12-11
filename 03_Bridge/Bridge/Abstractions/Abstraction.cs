using _03_Bridge.Bridge.Implementors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Bridge.Bridge.Abstractions
{
    public abstract class Abstraction
    {
        private Implementor implementor;
        public Abstraction()
        {
            implementor = new ConcreteImplementor();
        }
        
        public virtual void Function()
        {
            implementor.Implemetion();
        }
    }

    public class RefindAbstraction : Abstraction
    {

    }
}
