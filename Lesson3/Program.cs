// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// making a string from an array of characters
char[] v = { 'A', 'B', 'C' };
string x = new string(v);
Console.WriteLine(x);




double[] myMoney  = {3.3,4.1,5.2,6.4};
int[] test = { 1, 3, 4, 5, 6, 8, 9 };
myMoney[0] = 0.3;
myMoney[1] = 2;

string a = "bbb";
string b = "ccc";
string c = String.Join(a,b);
Console.WriteLine("{0}",c);
Console.WriteLine(c);
c = c.Substring(3);
Console.WriteLine(c);
Console.WriteLine(c.Contains('A'));


Console.WriteLine(String.Compare(a,b)==0);

int[] n = new int[10];

for(int i = 0; i < n.Length; i++)
{
   
        n[i] = i + 2;
    
    Console.WriteLine(i*2);
}

foreach(int i in myMoney)
{
    Console.WriteLine(i);
}