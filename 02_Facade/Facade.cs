using _02_Facade.SubSystem1;
using _02_Facade.SubSystem2;
using _02_Facade.SubSystem3;

namespace _02_Facade
{
    public class Facade
    {
        public void DoSumthing()
        {
            Class1 class1 = new Class1();
            Class2 class2 = new Class2();
            Class3 class3 = new Class3();

            class1.Action1();
            class2.Action2();
            class3.Action3();
        }
    }
}
