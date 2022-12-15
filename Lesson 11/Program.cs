using Exceptions;
using System.Reflection.Emit;
  
ExceptionLearning showException = new ExceptionLearning();
Console.WriteLine(showException);
User u1 = new User("ASADSADSDDSASDA");
Console.WriteLine(u1);
namespace Exceptions
{

    public interface IException
    {
        public void ShowException(int a, int b, int x);

    }
    public class ExceptionLearning : IException
    {

     
        private int a;
        private int b;
        private int x;

        public ExceptionLearning()
        {
            a = 3;
            b = 0;
            x = 0;
           ShowException(a,b,x);

        }
        public void ShowException(int a,int b,int x)
        {
            try
            {
                x = a / b;

            }
            catch (DivideByZeroException e)
            {
                // shows the error message
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine(x);
            }
        }

    }

    // user defined exceptions 

    public class NameTooLongException : Exception
    {
        // inherits from Exception class its constructor
        public NameTooLongException(string message) : base(message)
        {

        }
    }
    public class User
    {
        public User(string name) {
           
            if(name.Length > 10) {
                throw  (new NameTooLongException("Your username shouldn't be more than 10 characters"));
            }
            try
            {
                 name = "SAKAOAKOPSAK";
            }
            catch (NameTooLongException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine(name);
            }

         }
    }


}



