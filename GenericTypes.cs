// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       int []x  = {1,2,3};
       double  []y =  {1.0,2.0,3.0};
       String []z =  {"1","2","3"};
       
       displayElements(x);
       displayElements(y);
       displayElements(z);
    }
    
    // The issue , we want to make a method which takes in 
    // double ,int and string 
    public static void displayElements<ManyDataTypes>(ManyDataTypes[] array) {
     foreach(ManyDataTypes item in array)
     {
         Console.Write(item + " ");
     }
    
    }
    
}
