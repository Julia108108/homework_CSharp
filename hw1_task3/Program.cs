// Задача 6. Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
System.Console.Write ("Введите число и вы увидете является ли оно чётным: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine ("Да");
}
else
{
    Console.WriteLine ("Нет");
}

System.Console.WriteLine(" ");