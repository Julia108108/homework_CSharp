Console.Clear();
System.Console.Write("Input first number, please: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input second number, please: ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input third number, please: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if ( a > max) max = a;
if ( b > max) max = b;
if ( c > max) max = c;

Console.WriteLine("max = ");
Console.WriteLine(max);