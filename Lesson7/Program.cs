// See https://aka.ms/new-console-template for more information
using OperatorOverloading;

Console.WriteLine("Hello, World!");

Operations r1 = new Operations();
Operations r2 = new Operations();
Operations r3 = new Operations();

r1.length = 3;
r2.length = 5;
r3.length = r1.length + r2.length;

Console.WriteLine($" r3 is {r3.length} ");
Console.WriteLine(r1.length == r2.length);
Console.WriteLine(r1.length != r2.length);
Console.WriteLine(r1.length >= r2.length);
Console.WriteLine(r1.length <= r2.length);


namespace OperatorOverloading
{

    public class Operations
    {
        public int length;
        public int height;
        public int breadth;


        //public static TYPE_NAME operator_keyword  operator () { }
        // SYNTAX for operator overloading is the following

        public static Operations operator +(Operations r1, Operations r2)
        {
            Operations r3 = new Operations();
            r3.length = r1.length + r2.length;
            return r3;
        }

        // public static return_type operator_keyword operator (params) 
        public static Operations operator -(Operations r1, Operations r2)
        {
            Operations r3 = new Operations();
            r3.length = r1.length - r2.length;
            return r3;

        }
        public static bool operator ==(Operations r1, Operations r2)
        {
            bool result = false;
            if (r1.length == r2.length)
            {
                result = true;
             }

            return result;


        }

        public static bool operator !=(Operations r1,Operations r2)
        {
            bool different= false;
            if (r1.length != r2.length)
            {
                different = true;
            }
            return different;

        }

        public static bool operator >= (Operations r1,Operations r2)
        {
            bool isGreaterOrEqualTo = false;
            if(r1.length >= r2.length)
            {
                isGreaterOrEqualTo = true;
            }
            else
            {
                isGreaterOrEqualTo = false;
            }
            return isGreaterOrEqualTo;
        }

        public static bool operator <=(Operations r1, Operations r2)
        {
            bool isLessOrEqualTo = false;
            if (r1.length <= r2.length)
            {
                isLessOrEqualTo = true;
            }
            else
            {
                isLessOrEqualTo = false;
            }
            return isLessOrEqualTo;
        }

    }
}