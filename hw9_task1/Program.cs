// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Задайте значение N и программа выведет все натуральные числа в промежутке от N до 1.");
int n = Convert.ToInt32 (Console.ReadLine());

WritePositiveIntsDesc(n);

 
 void WritePositiveIntsDesc (int n)
 {
    Console.Write(n + ", ");
    if (n == 1 || n < 0)
    {
        return;
    }
    WritePositiveIntsDesc(n - 1);
 }