using System.Globalization;

T1 t = new S1("Everyone"); 

Console.WriteLine(t.Greeting());
t = new S2("Kim",DateTime.Now);
Console.WriteLine(t.Greeting());

public abstract class T1
{
    protected string Name;
    public abstract string Greeting();

}
public abstract class T2 : T1
{
    protected DateTime Birth;
    public abstract string GetBirth();    

}
public  class S1 : T1
{
    public S1(string name)
    {
        Name = name;
    }
    public override string Greeting()
    {
        return "Hello " + Name;
    }
}
public class S2 : T2
{
    public S2(string name,DateTime birth)
    {
        Name = name;
        Birth = birth;

    }
    public override string GetBirth()
    {       
        return Birth.ToString("D", new CultureInfo("es-AR"));
    }
    public override string Greeting()
    {
        return "Hello " + Name +  "\nYour birth was: " + GetBirth() + "\nEnjoy the journey!";
    }
}


