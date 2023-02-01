// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine ("Сколько нечётных чисел будет в вашем массиве?: --> ");
int amount = Convert.ToInt32(Console.ReadLine());

int[] array = new int [amount];
Random rnd = new Random();

for (int i = 0; i < amount; i++)
{
    array[i] = rnd.Next(-99, 100); 
    Console.Write (array[i] + " ");
}

int sum = array [1];

for (i = 3; i < amount; i+=2)
{
    sum = sum + array[i];
}

Console.Write($"Сумма элементов, стоящих на нечетных позициях в массиве: {sum}");