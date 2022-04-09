// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public abstract class Product
{
    public abstract void Excute();
}

public class ConcreteProduct1 : Product
{
    public override void Excute()
    {
        Console.WriteLine("ConcreteProduct1.Excute........");
    }
}

public class ConcreteProduct2 : Product
{
    public override void Excute()
    {
        Console.WriteLine("ConcreteProduct2.Excute........");
    }
}

public class DefultProduct : Product
{
    public override void Excute()
    {
        Console.WriteLine("DefultProduct.Excute...");
    }
}


public abstract class Creator
{
    public abstract Product FactoryMethod(int i);
}

public class ConcreteCreator : Creator
{
    public override Product FactoryMethod(int i)
    {
        if (i < 0)
            return new ConcreteProduct1();
        else if (i > 0)
            return new ConcreteProduct2();
        else
            return new DefultProduct();
    }
}