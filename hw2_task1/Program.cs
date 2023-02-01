// Задача 10. Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Write("Введите 3-х значное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if ((a < 100) || (a > 999))
{
    System.Console.WriteLine ("Ошибка, введите 3-х значное число");
}

else
{
    int b = (a % 100) / 10;
    System.Console.WriteLine(b);
}

