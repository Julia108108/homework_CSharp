// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Напишите количестов строк двумерного массива: ");
int m = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Напишите количестов столбцов двумерного массива: ");
int n = Convert.ToInt32 (Console.ReadLine());
int[,] table = new int[m, n];
FillArrayRandom(table);
PrintArray(table);
Console.WriteLine();
NumberRowMinSumElements(table);

// Функция заполнения массива рандомно числами от 1 до 9
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// Функция вывода двумерного массива 
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Функция нахождения и вывода строки с наименьшей суммой элементов
void NumberRowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    
    for (int i = 0; i < table.GetLength(1); i++)
    {
        minRow = minRow + table[0, i];
    }    
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++) sumRow = sumRow + table[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}    