// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

Console.WriteLine("Hello, World!");
Console.ReadLine();



object a = 100;
dynamic b = "hello";


Console.WriteLine(b.GetType());
Console.WriteLine(a.GetType());


P1 test = new P1();
test.FirstMethod();


P1.LogContentAndType(b);

String myString = "";
myString.Concat("Abc");
P1.LogContentAndType(myString);
class P1
{
    public  void FirstMethod()
    {
        Console.WriteLine("Something");
        Console.WriteLine("Size of int is {0} bytes and size of float is {1} bytes", sizeof(int),sizeof(float));
    }
    public static void LogContentAndType(dynamic myVar)
    {
        Console.WriteLine($"{myVar} {myVar.GetType()}");
        
    }
}

 