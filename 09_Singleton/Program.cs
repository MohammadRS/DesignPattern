
var obj1 = Singleton.GetInstance();
var obj2 = Singleton.GetInstance();
Console.WriteLine(obj1 == obj2);
Console.ReadLine();

public class Singleton
{
    private static readonly Singleton UnicInstance = new Singleton();

    private Singleton()
    {

    }

    public static Singleton GetInstance() => UnicInstance;
}