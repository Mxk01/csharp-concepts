// here we're using a nested namespace
using  N1.N2;
using N3;
Test t1 = new Test();
Console.WriteLine("Type in your name");
string test = Console.ReadLine();
t1.ShowSomething("Hello "+test);
A a1 = new A();
a1.ShowSomething("Testing ... ");

namespace N1
{


    namespace N2
    {

        public interface ITest
        {
            public void ShowSomething(string message);
        }
        public class Test:ITest
        {

            public void ShowSomething(string message)
            {
                Console.WriteLine(message);
            }
        }
    }
}

namespace N3
{
     class A
    {
        public void ShowSomething(string message)
        {
            Console.WriteLine(message); 
        }
    }
}