// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Задайте значение M и N и программа выведет сумму натуральных элементов в промежутке от M до N");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int sum = CallculateSumOfRange(m, n);

Console.WriteLine($"а вот и ваша сумма {sum}");


int CallculateSumOfRange(int m, int n) // возвращает число
{
    if (m < n)
    {
        return m + CallculateSumOfRange(m + 1, n);
    }
    else if (n > m)
    {
        return m + CallculateSumOfRange(m - 1, n);
    }
    else
    {
        return m;
    }
}