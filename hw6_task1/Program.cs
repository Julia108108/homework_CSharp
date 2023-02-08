// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2

int[] arr = new int[8];
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-100,100);
}

foreach (var item in arr)
{
    System.Console.Write(item + " ");
}

bool f (int x)
{
    return (x > 0);
}

System.Console.WriteLine("\n" + arr.Count(f));

