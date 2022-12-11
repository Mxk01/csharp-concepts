using AbstractClass;
// See https://aka.ms/new-console-template for more information

MethodOverloading.showSomething(3.2f);
MethodOverloading.showSomething(5);

ClassThatInherits x = new ();
Console.WriteLine(x.ShowString("Hello there"));


//Console.WriteLine(AbstractClass.ClassThatInherits.showStri)
public class MethodOverloading
    {
        public static void showSomething(float a) { Console.WriteLine(a); }
        public static void showSomething(int a) { Console.WriteLine(a); }



    }
namespace AbstractClass
{
    public abstract class ParentClass
    {
        // this method can be used by derived classes
        public  abstract  string ShowString(string name);
    }


    public class ClassThatInherits:ParentClass
    {


        public override string ShowString(string name)
        {
            return name;
            
        }

    }
}

