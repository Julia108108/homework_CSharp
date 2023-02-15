// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Задайте значение M и N и программа выведет значение функции Аккермана");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int sum = AckermanFnc(m, n);

Console.WriteLine($"а вот и ваша сумма {sum}");


int AckermanFnc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AckermanFnc(m - 1, 1);
    }
    else
    {
        return AckermanFnc(m - 1, AckermanFnc(m, n - 1));
    }
}