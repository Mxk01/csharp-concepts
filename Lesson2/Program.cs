// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

int i = 2;
const float a = 2;
// type casting 
float x = (float) i;
Console.WriteLine(x.GetType() == a.GetType());

Console.WriteLine("Write your name here!");
string userInput = Console.ReadLine();
Console.WriteLine("Hello " + userInput);

C1.Test();

class C1
{

    public static int? number = 7;
    // static fields
    private static string Name { get; set; } = "Bob";
    // coallescing null operator - checks if number is null ,if it is then x will be 2
    int x = number ?? 2;
    public static void Test ()
    {
        Console.WriteLine($"Hello there {Name}, your mark is {number}");
    }
}



