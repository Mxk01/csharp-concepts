// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

T2 t = new T2("Bob",45);
Console.WriteLine(t.getName());
Console.WriteLine(t.getAge());
public class T1
{
    protected  string name;
    protected int age;
    public T1(string n, int a)
    {
        name = n;
        age = a;
    }
    ~T1 ()
    {
        Console.WriteLine("Freeing up this boyyyyy!");
    }
    

}

class T3:T1
{
    public T3(string n, int a) : base(n, a)
    {
    }

    public void doSomething()
    {
        Console.WriteLine(name);
    }
}

// this means that class T2 inherits from class T1
class T2 : T1
{
    // inherits from base class
    public T2(string n, int a) : base(n, a)
    {
    }

    public string getName()
    {
        return name;
    }
    public int getAge()
    {
        return age;
    }
}


