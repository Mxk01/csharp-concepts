#define PI 





// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
#if (PI)
Console.WriteLine("PI is defined");
#elif (PI && !VCC) 
Console.WriteLine("VCC isn't defined but PI is");
#else
Console.WriteLine("PI isn't defined");
#endif
