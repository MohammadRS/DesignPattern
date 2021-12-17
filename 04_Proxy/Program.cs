ISubject subject = new Proxy();
subject.DoAction();

Console.WriteLine();

public interface ISubject
{
    void DoAction();
}

public class RealSubject : ISubject
{
    public void DoAction()
    {
        Console.WriteLine("RealSubject.DoAction() is Run....");
    }
}

public class Proxy : ISubject
{
    private RealSubject _realSubject;
    public void DoAction()
    {
        GetRealSubject().DoAction();
    }

    protected RealSubject GetRealSubject()
    {
        if(_realSubject == null)
        {
            _realSubject = new RealSubject();
        }
        return _realSubject;
    }
}


