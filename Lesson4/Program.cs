// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");
Books book = new Books();




book.Id = 1;
book.Name = "Harry Potter";

Person p;
p.name = "Robert";
p.age = 33;


TestClass t = new TestClass("Some text");
t.setTest("Baaasdqw");
Console.WriteLine(t.getTest());


Console.WriteLine($" {book.Id.ToString()}.{book.Name}");
Console.WriteLine($" I am {p.age.ToString()} years old. My name is   {p.name}");



 
Books.getBookDetails(3, "Lord of rings", "some description abcdefgh");

string Naruto = Enum.GetName(typeof(Anime),Anime.Naruto);
Console.WriteLine($"{Naruto} is number {(int)Anime.Naruto + 1} in the enum ");
enum Anime { Naruto, Bleach, MHA, OnePiece };


struct Books
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; } 

    public static void getBookDetails(int Id,string Name,string Description)
    {
        Console.WriteLine($"${Id.ToString()}, {Name}, {Description}");
    }
}

struct Person
{
    public string name;
    public int age;

}



class TestClass
{
    public static string test;

    public TestClass(string someParam)
    {
        test = someParam;
    }
    ~TestClass()
    {
        Console.WriteLine("Freeing up some resources bro!");
    }
    public void setTest(string aParameter)
    {
        test = aParameter;
    }
    public string getTest()
    {
        return test;
    }


}