// Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
System.Console.Write("First figure: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Second figure: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    System.Console.WriteLine ("a");
}

else
{
    System.Console.WriteLine ($"{b}");
}