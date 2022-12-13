// See https://aka.ms/new-console-template for more information
using InterfacesTesting;

TestClass tc = new TestClass();
Console.WriteLine("The sum of the numbers is  {0}",tc.Sum(3,2));
tc.Bark("Pochita says woof");
namespace InterfacesTesting
{
    // interfaces have method signatures
    public interface ITesting
    {
        // method signatures
        public void DoSomething();
        public int Sum(int a,int b);

        public void Bark(string a);
    }

    public class TestClass:ITesting
    {

        public void  DoSomething()
        {
            Console.WriteLine("Hello there");
        }

        public int Sum(int a,int b)
        {
            return a + b;
        }
        public void Bark(string a)
        {
            Console.WriteLine(a);
        }
    }

    

}